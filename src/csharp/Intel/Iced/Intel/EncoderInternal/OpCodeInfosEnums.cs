// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

#if ENCODER && OPCODE_INFO
using System;

namespace Iced.Intel.EncoderInternal {
	// GENERATOR-BEGIN: OpCodeInfoFlags1
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	[Flags]
	enum OpCodeInfoFlags1 : uint {
		None = 0x00000000,
		Cpl0Only = 0x00000001,
		Cpl3Only = 0x00000002,
		InputOutput = 0x00000004,
		Nop = 0x00000008,
		ReservedNop = 0x00000010,
		SerializingIntel = 0x00000020,
		SerializingAmd = 0x00000040,
		MayRequireCpl0 = 0x00000080,
		CetTracked = 0x00000100,
		NonTemporal = 0x00000200,
		FpuNoWait = 0x00000400,
		IgnoresModBits = 0x00000800,
		No66 = 0x00001000,
		NFx = 0x00002000,
		RequiresUniqueRegNums = 0x00004000,
		Privileged = 0x00008000,
		SaveRestore = 0x00010000,
		StackInstruction = 0x00020000,
		IgnoresSegment = 0x00040000,
		OpMaskReadWrite = 0x00080000,
		ModRegRmString = 0x00100000,
		DecOptionValueMask = 0x0000000F,
		DecOptionValueShift = 0x00000015,
	}
	// GENERATOR-END: OpCodeInfoFlags1

	// GENERATOR-BEGIN: OpCodeInfoFlags2
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	[Flags]
	enum OpCodeInfoFlags2 : uint {
		None = 0x00000000,
		RealMode = 0x00000001,
		ProtectedMode = 0x00000002,
		Virtual8086Mode = 0x00000004,
		CompatibilityMode = 0x00000008,
		UseOutsideSmm = 0x00000010,
		UseInSmm = 0x00000020,
		UseOutsideEnclaveSgx = 0x00000040,
		UseInEnclaveSgx1 = 0x00000080,
		UseInEnclaveSgx2 = 0x00000100,
		UseOutsideVmxOp = 0x00000200,
		UseInVmxRootOp = 0x00000400,
		UseInVmxNonRootOp = 0x00000800,
		UseOutsideSeam = 0x00001000,
		UseInSeam = 0x00002000,
		TdxNonRootGenUd = 0x00004000,
		TdxNonRootGenVe = 0x00008000,
		TdxNonRootMayGenEx = 0x00010000,
		IntelVmExit = 0x00020000,
		IntelMayVmExit = 0x00040000,
		IntelSmmVmExit = 0x00080000,
		AmdVmExit = 0x00100000,
		AmdMayVmExit = 0x00200000,
		TsxAbort = 0x00400000,
		TsxImplAbort = 0x00800000,
		TsxMayAbort = 0x01000000,
		IntelDecoder16or32 = 0x02000000,
		IntelDecoder64 = 0x04000000,
		AmdDecoder16or32 = 0x08000000,
		AmdDecoder64 = 0x10000000,
		InstrStrFmtOptionMask = 0x00000007,
		InstrStrFmtOptionShift = 0x0000001D,
	}
	// GENERATOR-END: OpCodeInfoFlags2

	// GENERATOR-BEGIN: InstrStrFmtOption
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	enum InstrStrFmtOption {
		None,
		OpMaskIsK1_or_NoGprSuffix,
		IncVecIndex,
		NoVecIndex,
		SwapVecIndex12,
		SkipOp0,
	}
	// GENERATOR-END: InstrStrFmtOption
}
#endif
