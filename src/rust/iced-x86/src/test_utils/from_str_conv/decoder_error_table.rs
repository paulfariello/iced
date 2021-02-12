// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

use super::super::super::DecoderError;
use std::collections::HashMap;

lazy_static! {
	pub(super) static ref TO_DECODER_ERROR_HASH: HashMap<&'static str, DecoderError> = {
		// GENERATOR-BEGIN: DecoderErrorHash
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		let mut h = HashMap::with_capacity(3);
		let _ = h.insert("None", DecoderError::None);
		let _ = h.insert("InvalidInstruction", DecoderError::InvalidInstruction);
		let _ = h.insert("NoMoreBytes", DecoderError::NoMoreBytes);
		// GENERATOR-END: DecoderErrorHash
		h
	};
}
