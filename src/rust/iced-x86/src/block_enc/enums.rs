// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

use core::fmt;

// GENERATOR-BEGIN: RelocKind
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// Relocation kind
#[derive(Copy, Clone, Eq, PartialEq, Ord, PartialOrd, Hash)]
#[cfg_attr(not(feature = "exhaustive_enums"), non_exhaustive)]
pub enum RelocKind {
	/// 64-bit offset. Only used if it's 64-bit code.
	Offset64 = 0,
}
#[rustfmt::skip]
static GEN_DEBUG_RELOC_KIND: [&str; 1] = [
	"Offset64",
];
impl fmt::Debug for RelocKind {
	#[inline]
	fn fmt(&self, f: &mut fmt::Formatter<'_>) -> fmt::Result {
		write!(f, "{}", GEN_DEBUG_RELOC_KIND[*self as usize])?;
		Ok(())
	}
}
impl Default for RelocKind {
	#[must_use]
	#[inline]
	fn default() -> Self {
		RelocKind::Offset64
	}
}
// GENERATOR-END: RelocKind

// GENERATOR-BEGIN: BlockEncoderOptions
// ⚠️This was generated by GENERATOR!🦹‍♂️
/// [`BlockEncoder`] options
///
/// [`BlockEncoder`]: struct.BlockEncoder.html
#[allow(missing_copy_implementations)]
#[allow(missing_debug_implementations)]
pub struct BlockEncoderOptions;
impl BlockEncoderOptions {
	/// No option is set
	pub const NONE: u32 = 0x0000_0000;
	/// By default, branches get updated if the target is too far away, eg. `Jcc SHORT` -> `Jcc NEAR` or if 64-bit mode, `Jcc + JMP [RIP+mem]`. If this option is enabled, no branches are fixed.
	pub const DONT_FIX_BRANCHES: u32 = 0x0000_0001;
	/// The [`BlockEncoder`] should return [`RelocInfo`]s
	///
	/// [`BlockEncoder`]: struct.BlockEncoder.html
	/// [`RelocInfo`]: struct.RelocInfo.html
	pub const RETURN_RELOC_INFOS: u32 = 0x0000_0002;
	/// The [`BlockEncoder`] should return new instruction offsets
	///
	/// [`BlockEncoder`]: struct.BlockEncoder.html
	pub const RETURN_NEW_INSTRUCTION_OFFSETS: u32 = 0x0000_0004;
	/// The [`BlockEncoder`] should return [`ConstantOffsets`]
	///
	/// [`BlockEncoder`]: struct.BlockEncoder.html
	/// [`ConstantOffsets`]: struct.ConstantOffsets.html
	pub const RETURN_CONSTANT_OFFSETS: u32 = 0x0000_0008;
}
// GENERATOR-END: BlockEncoderOptions
