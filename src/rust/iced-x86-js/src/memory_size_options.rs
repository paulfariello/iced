// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

use wasm_bindgen::prelude::*;

// GENERATOR-BEGIN: Enum
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Memory size options used by the formatters
#[wasm_bindgen]
#[derive(Copy, Clone)]
pub enum MemorySizeOptions {
	/// Show memory size if the assembler requires it, else don't show anything
	Default = 0,
	/// Always show the memory size, even if the assembler doesn't need it
	Always = 1,
	/// Show memory size if a human can't figure out the size of the operand
	Minimal = 2,
	/// Never show memory size
	Never = 3,
}
// GENERATOR-END: Enum

#[allow(dead_code)]
pub(crate) fn memory_size_options_to_iced(value: MemorySizeOptions) -> iced_x86_rust::MemorySizeOptions {
	// Safe, the enums are exactly identical
	unsafe { std::mem::transmute(value as u8) }
}

#[allow(dead_code)]
pub(crate) fn iced_to_memory_size_options(value: iced_x86_rust::MemorySizeOptions) -> MemorySizeOptions {
	// Safe, the enums are exactly identical
	unsafe { std::mem::transmute(value as u8) }
}
