// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

namespace Generator.Enums.Encoder {
	[Enum("LKind")]
	enum LKind {
		None,
		[Comment(".128, .256, .512")]
		L128,
		[Comment(".L0, .L1")]
		L0,
		[Comment(".LZ")]
		LZ,
	}
}
