// SPDX-License-Identifier: MIT
// Copyright (C) 2018-present iced project and contributors

use crate::data_reader::DataReader;
use crate::formatter::fast::enums::*;
use crate::formatter::fast::fmt_data::FORMATTER_TBL_DATA;
use crate::formatter::fast::FmtTableData;
use crate::formatter::strings_tbl::get_strings_table_ref;
use crate::iced_constants::IcedConstants;
use alloc::boxed::Box;
use alloc::string::String;
use alloc::vec::Vec;
use lazy_static::lazy_static;

lazy_static! {
	pub(super) static ref FMT_DATA: FmtTableData = read();
}

fn read() -> FmtTableData {
	let mut mnemonics: Vec<&'static str> = Vec::with_capacity(IcedConstants::CODE_ENUM_COUNT);
	let mut flags: Vec<u8> = Vec::with_capacity(IcedConstants::CODE_ENUM_COUNT);
	let mut reader = DataReader::new(FORMATTER_TBL_DATA);
	let strings = get_strings_table_ref();
	let mut prev_index = -1isize;
	let mut prev_flags = FastFmtFlags::NONE as usize;
	for _ in 0..IcedConstants::CODE_ENUM_COUNT {
		let f = reader.read_u8();
		let current_index;
		if (f & (FastFmtFlags::SAME_AS_PREV as usize)) != 0 {
			current_index = reader.index() as isize;
			reader.set_index(prev_index as usize);
		} else {
			current_index = -1;
			prev_index = reader.index() as isize;
		}
		let mnemonic: &'static str = if (prev_flags & FastFmtFlags::HAS_VPREFIX as usize) == (f & FastFmtFlags::HAS_VPREFIX as usize)
			&& (f & (FastFmtFlags::SAME_AS_PREV as usize)) != 0
		{
			mnemonics[mnemonics.len() - 1]
		} else if (f & (FastFmtFlags::HAS_VPREFIX as usize)) != 0 {
			let s = strings[reader.read_compressed_u32() as usize];
			let mut res = String::with_capacity(s.len() + 1);
			res.push('v');
			res.push_str(s);
			let res = Box::into_raw(Box::new(res));
			unsafe { (*res).as_str() }
		} else {
			strings[reader.read_compressed_u32() as usize]
		};

		flags.push(f as u8);
		mnemonics.push(mnemonic);
		prev_flags = f;

		if current_index >= 0 {
			reader.set_index(current_index as usize);
		}
	}
	debug_assert!(!reader.can_read());

	FmtTableData { mnemonics, flags }
}
