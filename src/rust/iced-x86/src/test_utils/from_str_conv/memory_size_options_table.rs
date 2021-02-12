// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

use super::super::super::MemorySizeOptions;
use std::collections::HashMap;

lazy_static! {
	pub(super) static ref TO_MEMORY_SIZE_OPTIONS_HASH: HashMap<&'static str, MemorySizeOptions> = {
		// GENERATOR-BEGIN: MemorySizeOptionsHash
		// ⚠️This was generated by GENERATOR!🦹‍♂️
		let mut h = HashMap::with_capacity(4);
		let _ = h.insert("Default", MemorySizeOptions::Default);
		let _ = h.insert("Always", MemorySizeOptions::Always);
		let _ = h.insert("Minimal", MemorySizeOptions::Minimal);
		let _ = h.insert("Never", MemorySizeOptions::Never);
		// GENERATOR-END: MemorySizeOptionsHash
		h
	};
}
