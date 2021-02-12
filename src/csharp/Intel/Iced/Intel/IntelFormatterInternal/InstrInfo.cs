// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

#if INTEL
using System;
using System.Diagnostics;
using Iced.Intel.FormatterInternal;

namespace Iced.Intel.IntelFormatterInternal {
	// GENERATOR-BEGIN: InstrOpKind
	// ⚠️This was generated by GENERATOR!🦹‍♂️
	enum InstrOpKind : byte {
		Register,
		NearBranch16,
		NearBranch32,
		NearBranch64,
		FarBranch16,
		FarBranch32,
		Immediate8,
		Immediate8_2nd,
		Immediate16,
		Immediate32,
		Immediate64,
		Immediate8to16,
		Immediate8to32,
		Immediate8to64,
		Immediate32to64,
		MemorySegSI,
		MemorySegESI,
		MemorySegRSI,
		MemorySegDI,
		MemorySegEDI,
		MemorySegRDI,
		MemoryESDI,
		MemoryESEDI,
		MemoryESRDI,
		Memory64,
		Memory,
		DeclareByte,
		DeclareWord,
		DeclareDword,
		DeclareQword,
	}
	// GENERATOR-END: InstrOpKind

	struct InstrOpInfo {
		internal const int TEST_RegisterBits = IcedConstants.RegisterBits;

		public FormatterString Mnemonic;
		public InstrOpInfoFlags Flags;
		public byte OpCount;
		public InstrOpKind Op0Kind;
		public InstrOpKind Op1Kind;
		public InstrOpKind Op2Kind;
		public InstrOpKind Op3Kind;
		public InstrOpKind Op4Kind;
		public byte Op0Register;
		public byte Op1Register;
		public byte Op2Register;
		public byte Op3Register;
		public byte Op4Register;
		public sbyte Op0Index;
		public sbyte Op1Index;
		public sbyte Op2Index;
		public sbyte Op3Index;
		public sbyte Op4Index;

		public readonly int GetOpRegister(int operand) =>
			operand switch {
				0 => Op0Register,
				1 => Op1Register,
				2 => Op2Register,
				3 => Op3Register,
				4 => Op4Register,
				_ => throw new ArgumentOutOfRangeException(nameof(operand)),
			};

		public readonly InstrOpKind GetOpKind(int operand) {
			switch (operand) {
			case 0: return Op0Kind;
			case 1: return Op1Kind;
			case 2: return Op2Kind;
			case 3: return Op3Kind;
			case 4: return Op4Kind;
			default:
				Debug.Assert(Op0Kind == InstrOpKind.DeclareByte || Op0Kind == InstrOpKind.DeclareWord || Op0Kind == InstrOpKind.DeclareDword || Op0Kind == InstrOpKind.DeclareQword);
				return Op0Kind;
			}
		}

		public readonly int GetInstructionIndex(int operand) {
			int instructionOperand;
			switch (operand) {
			case 0: instructionOperand = Op0Index; break;
			case 1: instructionOperand = Op1Index; break;
			case 2: instructionOperand = Op2Index; break;
			case 3: instructionOperand = Op3Index; break;
			case 4: instructionOperand = Op4Index; break;
			default:
				Debug.Assert(Op0Kind == InstrOpKind.DeclareByte || Op0Kind == InstrOpKind.DeclareWord || Op0Kind == InstrOpKind.DeclareDword || Op0Kind == InstrOpKind.DeclareQword);
				instructionOperand = -1;
				break;
			}
			return instructionOperand < 0 ? -1 : instructionOperand;
		}

#if INSTR_INFO
		public readonly bool TryGetOpAccess(int operand, out OpAccess access) {
			int instructionOperand;
			switch (operand) {
			case 0: instructionOperand = Op0Index; break;
			case 1: instructionOperand = Op1Index; break;
			case 2: instructionOperand = Op2Index; break;
			case 3: instructionOperand = Op3Index; break;
			case 4: instructionOperand = Op4Index; break;
			default:
				Debug.Assert(Op0Kind == InstrOpKind.DeclareByte || Op0Kind == InstrOpKind.DeclareWord || Op0Kind == InstrOpKind.DeclareDword || Op0Kind == InstrOpKind.DeclareQword);
				instructionOperand = Op0Index;
				break;
			}
			if (instructionOperand < InstrInfo.OpAccess_INVALID) {
				access = (OpAccess)(-instructionOperand - 2);
				return true;
			}
			access = OpAccess.None;
			return false;
		}
#endif

		public readonly int GetOperandIndex(int instructionOperand) {
			int index;
			if (instructionOperand == Op0Index)
				index = 0;
			else if (instructionOperand == Op1Index)
				index = 1;
			else if (instructionOperand == Op2Index)
				index = 2;
			else if (instructionOperand == Op3Index)
				index = 3;
			else if (instructionOperand == Op4Index)
				index = 4;
			else
				index = -1;
			return index < OpCount ? index : -1;
		}

		public InstrOpInfo(FormatterString mnemonic, in Instruction instruction, InstrOpInfoFlags flags) {
			Static.Assert(IcedConstants.MaxOpCount == 5 ? 0 : -1);
			Mnemonic = mnemonic;
			Flags = flags;
			Op0Kind = (InstrOpKind)instruction.Op0Kind;
			Op1Kind = (InstrOpKind)instruction.Op1Kind;
			Op2Kind = (InstrOpKind)instruction.Op2Kind;
			Op3Kind = (InstrOpKind)instruction.Op3Kind;
			Op4Kind = (InstrOpKind)instruction.Op4Kind;
			Static.Assert(TEST_RegisterBits == 8 ? 0 : -1);
			Op0Register = (byte)instruction.Op0Register;
			Static.Assert(TEST_RegisterBits == 8 ? 0 : -1);
			Op1Register = (byte)instruction.Op1Register;
			Static.Assert(TEST_RegisterBits == 8 ? 0 : -1);
			Op2Register = (byte)instruction.Op2Register;
			Static.Assert(TEST_RegisterBits == 8 ? 0 : -1);
			Op3Register = (byte)instruction.Op3Register;
			Static.Assert(TEST_RegisterBits == 8 ? 0 : -1);
			Op4Register = (byte)instruction.Op4Register;
			int opCount = instruction.OpCount;
			OpCount = (byte)opCount;
			switch (opCount) {
			case 0:
				Op0Index = InstrInfo.OpAccess_INVALID;
				Op1Index = InstrInfo.OpAccess_INVALID;
				Op2Index = InstrInfo.OpAccess_INVALID;
				Op3Index = InstrInfo.OpAccess_INVALID;
				Op4Index = InstrInfo.OpAccess_INVALID;
				break;

			case 1:
				Op0Index = 0;
				Op1Index = InstrInfo.OpAccess_INVALID;
				Op2Index = InstrInfo.OpAccess_INVALID;
				Op3Index = InstrInfo.OpAccess_INVALID;
				Op4Index = InstrInfo.OpAccess_INVALID;
				break;

			case 2:
				Op0Index = 0;
				Op1Index = 1;
				Op2Index = InstrInfo.OpAccess_INVALID;
				Op3Index = InstrInfo.OpAccess_INVALID;
				Op4Index = InstrInfo.OpAccess_INVALID;
				break;

			case 3:
				Op0Index = 0;
				Op1Index = 1;
				Op2Index = 2;
				Op3Index = InstrInfo.OpAccess_INVALID;
				Op4Index = InstrInfo.OpAccess_INVALID;
				break;

			case 4:
				Op0Index = 0;
				Op1Index = 1;
				Op2Index = 2;
				Op3Index = 3;
				Op4Index = InstrInfo.OpAccess_INVALID;
				break;

			case 5:
				Op0Index = 0;
				Op1Index = 1;
				Op2Index = 2;
				Op3Index = 3;
				Op4Index = 4;
				break;

			default:
				throw new InvalidOperationException();
			}
		}
	}

	abstract class InstrInfo {
		public const int OpAccess_INVALID = -1;
#if INSTR_INFO
		public const int OpAccess_None = -(int)(OpAccess.None + 2);
		public const int OpAccess_Read = -(int)(OpAccess.Read + 2);
		public const int OpAccess_CondRead = -(int)(OpAccess.CondRead + 2);
		public const int OpAccess_Write = -(int)(OpAccess.Write + 2);
		public const int OpAccess_CondWrite = -(int)(OpAccess.CondWrite + 2);
		public const int OpAccess_ReadWrite = -(int)(OpAccess.ReadWrite + 2);
		public const int OpAccess_ReadCondWrite = -(int)(OpAccess.ReadCondWrite + 2);
		public const int OpAccess_NoMemAccess = -(int)(OpAccess.NoMemAccess + 2);
#else
		public const int OpAccess_None = OpAccess_INVALID;
		public const int OpAccess_Read = OpAccess_INVALID;
		public const int OpAccess_CondRead = OpAccess_INVALID;
		public const int OpAccess_Write = OpAccess_INVALID;
		public const int OpAccess_CondWrite = OpAccess_INVALID;
		public const int OpAccess_ReadWrite = OpAccess_INVALID;
		public const int OpAccess_ReadCondWrite = OpAccess_INVALID;
		public const int OpAccess_NoMemAccess = OpAccess_INVALID;
#endif

		public abstract void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info);

		protected static int GetBitness(CodeSize codeSize) =>
			codeSize switch {
				CodeSize.Code16 => 16,
				CodeSize.Code32 => 32,
				CodeSize.Code64 => 64,
				_ => 0,
			};
	}

	sealed class SimpleInstrInfo : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flags;

		public SimpleInstrInfo(string mnemonic) : this(mnemonic, InstrOpInfoFlags.None) { }

		public SimpleInstrInfo(string mnemonic, InstrOpInfoFlags flags) {
			this.mnemonic = new FormatterString(mnemonic);
			this.flags = flags;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) =>
			info = new InstrOpInfo(mnemonic, instruction, flags);
	}

	sealed class SimpleInstrInfo_cc : InstrInfo {
		readonly int ccIndex;
		readonly FormatterString[] mnemonics;

		public SimpleInstrInfo_cc(int ccIndex, string[] mnemonics) {
			this.ccIndex = ccIndex;
			this.mnemonics = FormatterString.Create(mnemonics);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			const InstrOpInfoFlags flags = InstrOpInfoFlags.None;
			var mnemonic = MnemonicCC.GetMnemonicCC(options, ccIndex, mnemonics);
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_memsize : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_memsize(int bitness, string mnemonic) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			int instrBitness = GetBitness(instruction.CodeSize);
			var flags = instrBitness == 0 || (instrBitness & bitness) != 0 ? InstrOpInfoFlags.MemSize_Nothing : InstrOpInfoFlags.ShowNoMemSize_ForceSize | InstrOpInfoFlags.ShowMinMemSize_ForceSize;
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_StringIg1 : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_StringIg1(string mnemonic) => this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = default;
			info.Mnemonic = mnemonic;
			info.OpCount = 1;
			info.Op0Kind = (InstrOpKind)instruction.Op0Kind;
		}
	}

	sealed class SimpleInstrInfo_StringIg0 : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_StringIg0(string mnemonic) => this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = default;
			info.Mnemonic = mnemonic;
			info.OpCount = 1;
			info.Op0Kind = (InstrOpKind)instruction.Op1Kind;
			info.Op0Index = info.Op1Index;
		}
	}

	sealed class SimpleInstrInfo_nop : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;
		readonly Register register;

		public SimpleInstrInfo_nop(int bitness, string mnemonic, Register register) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
			this.register = register;
		}

		static readonly FormatterString str_xchg = new FormatterString("xchg");

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			int instrBitness = GetBitness(instruction.CodeSize);
			if (instrBitness == 0 || (instrBitness & bitness) != 0)
				info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			else {
				info = default;
				info.Mnemonic = str_xchg;
				info.OpCount = 2;
				info.Op0Kind = InstrOpKind.Register;
				info.Op1Kind = InstrOpKind.Register;
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)register;
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op1Register = (byte)register;
				info.Op0Index = OpAccess_None;
				info.Op1Index = OpAccess_None;
			}
		}
	}

	sealed class SimpleInstrInfo_ST1 : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flags;
		readonly int op0Access;

		public SimpleInstrInfo_ST1(string mnemonic, InstrOpInfoFlags flags) : this(mnemonic, flags, false) { }

		public SimpleInstrInfo_ST1(string mnemonic, InstrOpInfoFlags flags, bool isLoad) {
			this.mnemonic = new FormatterString(mnemonic);
			this.flags = flags;
			op0Access = isLoad ? OpAccess_Write : OpAccess_ReadWrite;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, flags);
			Debug.Assert(instruction.OpCount == 1);
			info.OpCount = 2;
			info.Op1Kind = info.Op0Kind;
			info.Op1Register = info.Op0Register;
			info.Op0Kind = InstrOpKind.Register;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op0Register = (byte)Registers.Register_ST;
			info.Op1Index = info.Op0Index;
			info.Op0Index = (sbyte)op0Access;
		}
	}

	sealed class SimpleInstrInfo_ST2 : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flags;

		public SimpleInstrInfo_ST2(string mnemonic, InstrOpInfoFlags flags) {
			this.mnemonic = new FormatterString(mnemonic);
			this.flags = flags;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, flags);
			Debug.Assert(instruction.OpCount == 1);
			info.OpCount = 2;
			info.Op1Kind = InstrOpKind.Register;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op1Register = (byte)Registers.Register_ST;
			info.Op1Index = OpAccess_Read;
		}
	}

	sealed class SimpleInstrInfo_maskmovq : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_maskmovq(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			Debug.Assert(instruction.OpCount == 3);

			var opKind = instruction.Op0Kind;
			var shortFormOpKind = instruction.CodeSize switch {
				CodeSize.Unknown => opKind,
				CodeSize.Code16 => OpKind.MemorySegDI,
				CodeSize.Code32 => OpKind.MemorySegEDI,
				CodeSize.Code64 => OpKind.MemorySegRDI,
				_ => throw new InvalidOperationException(),
			};
			var flags = InstrOpInfoFlags.IgnoreSegmentPrefix;
			if (opKind != shortFormOpKind) {
				if (opKind == OpKind.MemorySegDI)
					flags |= InstrOpInfoFlags.AddrSize16;
				else if (opKind == OpKind.MemorySegEDI)
					flags |= InstrOpInfoFlags.AddrSize32;
				else if (opKind == OpKind.MemorySegRDI)
					flags |= InstrOpInfoFlags.AddrSize64;
			}
			info = default;
			info.Flags = flags;
			info.Mnemonic = mnemonic;
			info.OpCount = 2;
			info.Op0Kind = (InstrOpKind)instruction.Op1Kind;
			info.Op0Index = 1;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op0Register = (byte)instruction.Op1Register;
			info.Op1Kind = (InstrOpKind)instruction.Op2Kind;
			info.Op1Index = 2;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op1Register = (byte)instruction.Op2Register;
			var segReg = instruction.SegmentPrefix;
			if (segReg != Register.None && FormatterUtils.ShowSegmentPrefix(Register.DS, instruction, options)) {
				info.OpCount = 3;
				info.Op2Kind = InstrOpKind.Register;
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op2Register = (byte)segReg;
				info.Op2Index = OpAccess_Read;
			}
		}
	}

	sealed class SimpleInstrInfo_os : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flags;

		public SimpleInstrInfo_os(int bitness, string mnemonic) : this(bitness, mnemonic, InstrOpInfoFlags.None) { }

		public SimpleInstrInfo_os(int bitness, string mnemonic, InstrOpInfoFlags flags) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
			this.flags = flags;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = this.flags;
			int instrBitness = GetBitness(instruction.CodeSize);
			if (instrBitness != 0 && instrBitness != bitness) {
				if (bitness == 16)
					flags |= InstrOpInfoFlags.OpSize16;
				else if (bitness == 32) {
					if (instrBitness != 64)
						flags |= InstrOpInfoFlags.OpSize32;
				}
				else
					flags |= InstrOpInfoFlags.OpSize64;
			}
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_os_bnd : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_os_bnd(int bitness, string mnemonic) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = InstrOpInfoFlags.None;
			if (instruction.HasRepnePrefix)
				flags |= InstrOpInfoFlags.BndPrefix;
			int instrBitness = GetBitness(instruction.CodeSize);
			if (instrBitness != 0 && instrBitness != bitness) {
				if (bitness == 16)
					flags |= InstrOpInfoFlags.OpSize16;
				else if (bitness == 32)
					flags |= InstrOpInfoFlags.OpSize32;
				else
					flags |= InstrOpInfoFlags.OpSize64;
			}
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_as : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_as(int bitness, string mnemonic) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = InstrOpInfoFlags.None;
			int instrBitness = GetBitness(instruction.CodeSize);
			if (instrBitness != 0 && instrBitness != bitness) {
				if (bitness == 16)
					flags |= InstrOpInfoFlags.AddrSize16;
				else if (bitness == 32)
					flags |= InstrOpInfoFlags.AddrSize32;
				else
					flags |= InstrOpInfoFlags.AddrSize64;
			}
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_os_jcc : InstrInfo {
		readonly int bitness;
		readonly int ccIndex;
		readonly FormatterString[] mnemonics;
		readonly InstrOpInfoFlags flags;

		public SimpleInstrInfo_os_jcc(int bitness, int ccIndex, string[] mnemonics) : this(bitness, ccIndex, mnemonics, InstrOpInfoFlags.None) { }

		public SimpleInstrInfo_os_jcc(int bitness, int ccIndex, string[] mnemonics, InstrOpInfoFlags flags) {
			this.bitness = bitness;
			this.ccIndex = ccIndex;
			this.mnemonics = FormatterString.Create(mnemonics);
			this.flags = flags;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = this.flags;
			int instrBitness = GetBitness(instruction.CodeSize);
			if (instrBitness != 0 && instrBitness != bitness) {
				if (bitness == 16)
					flags |= InstrOpInfoFlags.OpSize16;
				else if (bitness == 32)
					flags |= InstrOpInfoFlags.OpSize32;
				else
					flags |= InstrOpInfoFlags.OpSize64;
			}
			var prefixSeg = instruction.SegmentPrefix;
			if (prefixSeg == Register.CS)
				flags |= InstrOpInfoFlags.IgnoreSegmentPrefix | InstrOpInfoFlags.JccNotTaken;
			else if (prefixSeg == Register.DS)
				flags |= InstrOpInfoFlags.IgnoreSegmentPrefix | InstrOpInfoFlags.JccTaken;
			if (instruction.HasRepnePrefix)
				flags |= InstrOpInfoFlags.BndPrefix;
			var mnemonic = MnemonicCC.GetMnemonicCC(options, ccIndex, mnemonics);
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_os_loop : InstrInfo {
		readonly int bitness;
		readonly int ccIndex;
		readonly Register register;
		readonly FormatterString[] mnemonics;

		public SimpleInstrInfo_os_loop(int bitness, int ccIndex, Register register, string[] mnemonics) {
			this.bitness = bitness;
			this.ccIndex = ccIndex;
			this.register = register;
			this.mnemonics = FormatterString.Create(mnemonics);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = InstrOpInfoFlags.None;
			int instrBitness = GetBitness(instruction.CodeSize);
			var expectedReg = instrBitness switch {
				0 => register,
				16 => Register.CX,
				32 => Register.ECX,
				64 => Register.RCX,
				_ => throw new InvalidOperationException(),
			};
			if (instrBitness != 0 && instrBitness != bitness) {
				if (bitness == 16)
					flags |= InstrOpInfoFlags.OpSize16;
				else if (bitness == 32)
					flags |= InstrOpInfoFlags.OpSize32;
				else
					flags |= InstrOpInfoFlags.OpSize64;
			}
			if (expectedReg != register) {
				if (register == Register.CX)
					flags |= InstrOpInfoFlags.AddrSize16;
				else if (register == Register.ECX)
					flags |= InstrOpInfoFlags.AddrSize32;
				else
					flags |= InstrOpInfoFlags.AddrSize64;
			}
			var mnemonic = ccIndex == -1 ? mnemonics[0] : MnemonicCC.GetMnemonicCC(options, ccIndex, mnemonics);
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_movabs : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_movabs(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = InstrOpInfoFlags.None;
			int instrBitness = GetBitness(instruction.CodeSize);
			var memSize = instruction.MemoryDisplSize switch {
				2 => 16,
				4 => 32,
				_ => 64,
			};
			if (instrBitness == 0)
				instrBitness = memSize;
			if (instrBitness != memSize) {
				if (memSize == 16)
					flags |= InstrOpInfoFlags.AddrSize16;
				else if (memSize == 32)
					flags |= InstrOpInfoFlags.AddrSize32;
				else
					flags |= InstrOpInfoFlags.AddrSize64;
			}
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_opmask_op : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_opmask_op(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			Debug.Assert(instruction.OpCount <= 2);
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			var kreg = instruction.OpMask;
			if (kreg != Register.None) {
				info.OpCount++;
				info.Op2Kind = info.Op1Kind;
				info.Op2Register = info.Op1Register;
				info.Op2Index = 1;
				info.Op1Kind = InstrOpKind.Register;
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op1Register = (byte)kreg;
				info.Op1Index = OpAccess_Read;
				info.Flags |= InstrOpInfoFlags.IgnoreOpMask;
			}
		}
	}

	sealed class SimpleInstrInfo_bnd : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flags;

		public SimpleInstrInfo_bnd(string mnemonic, InstrOpInfoFlags flags) {
			this.mnemonic = new FormatterString(mnemonic);
			this.flags = flags;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var flags = this.flags;
			if (instruction.HasRepnePrefix)
				flags |= InstrOpInfoFlags.BndPrefix;
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}

	sealed class SimpleInstrInfo_ST_STi : InstrInfo {
		readonly FormatterString mnemonic;
		readonly bool pseudoOp;

		public SimpleInstrInfo_ST_STi(string mnemonic, bool pseudoOp) {
			this.mnemonic = new FormatterString(mnemonic);
			this.pseudoOp = pseudoOp;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			const InstrOpInfoFlags flags = 0;
			if (pseudoOp && options.UsePseudoOps && (instruction.Op0Register == Register.ST1 || instruction.Op1Register == Register.ST1)) {
				info = default;
				info.Mnemonic = mnemonic;
			}
			else {
				info = new InstrOpInfo(mnemonic, instruction, flags);
				Debug.Assert(info.Op0Register == (int)Register.ST0);
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)Registers.Register_ST;
			}
		}
	}

	sealed class SimpleInstrInfo_STi_ST : InstrInfo {
		readonly FormatterString mnemonic;
		readonly bool pseudoOp;

		public SimpleInstrInfo_STi_ST(string mnemonic, bool pseudoOp) {
			this.mnemonic = new FormatterString(mnemonic);
			this.pseudoOp = pseudoOp;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			const InstrOpInfoFlags flags = 0;
			if (pseudoOp && options.UsePseudoOps && (instruction.Op0Register == Register.ST1 || instruction.Op1Register == Register.ST1)) {
				info = default;
				info.Mnemonic = mnemonic;
			}
			else {
				info = new InstrOpInfo(mnemonic, instruction, flags);
				Debug.Assert(info.Op1Register == (int)Register.ST0);
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op1Register = (byte)Registers.Register_ST;
			}
		}
	}

	sealed class SimpleInstrInfo_pops : InstrInfo {
		readonly FormatterString mnemonic;
		readonly FormatterString[] pseudo_ops;

		public SimpleInstrInfo_pops(string mnemonic, FormatterString[] pseudo_ops) {
			this.mnemonic = new FormatterString(mnemonic);
			this.pseudo_ops = pseudo_ops;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			int imm = instruction.Immediate8;
			if (options.UsePseudoOps && (uint)imm < (uint)pseudo_ops.Length) {
				info.Mnemonic = pseudo_ops[imm];
				RemoveLastOp(ref info);
			}
		}

		internal static void RemoveLastOp(ref InstrOpInfo info) {
			switch (info.OpCount) {
			case 4:
				info.Op3Index = OpAccess_INVALID;
				break;
			case 3:
				info.Op2Index = OpAccess_INVALID;
				break;
			default:
				throw new InvalidOperationException();
			}
			info.OpCount--;
		}
	}

	sealed class SimpleInstrInfo_pclmulqdq : InstrInfo {
		readonly FormatterString mnemonic;
		readonly FormatterString[] pseudo_ops;

		public SimpleInstrInfo_pclmulqdq(string mnemonic, FormatterString[] pseudo_ops) {
			this.mnemonic = new FormatterString(mnemonic);
			this.pseudo_ops = pseudo_ops;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			if (options.UsePseudoOps) {
				int index;
				int imm = instruction.Immediate8;
				if (imm == 0)
					index = 0;
				else if (imm == 1)
					index = 1;
				else if (imm == 0x10)
					index = 2;
				else if (imm == 0x11)
					index = 3;
				else
					index = -1;
				if (index >= 0) {
					info.Mnemonic = pseudo_ops[index];
					SimpleInstrInfo_pops.RemoveLastOp(ref info);
				}
			}
		}
	}

	sealed class SimpleInstrInfo_imul : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_imul(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			Debug.Assert(info.OpCount == 3);
			if (options.UsePseudoOps && info.Op0Kind == InstrOpKind.Register && info.Op1Kind == InstrOpKind.Register && info.Op0Register == info.Op1Register) {
				info.OpCount--;
				info.Op0Index = OpAccess_ReadWrite;
				info.Op1Kind = info.Op2Kind;
				info.Op1Index = 2;
				info.Op2Index = OpAccess_INVALID;
			}
		}
	}

	sealed class SimpleInstrInfo_Reg16 : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_Reg16(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			const InstrOpInfoFlags flags = InstrOpInfoFlags.None;
			info = new InstrOpInfo(mnemonic, instruction, flags);
			if (Register.EAX <= (Register)info.Op0Register && (Register)info.Op0Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)((((Register)info.Op0Register - Register.EAX) & 0xF) + Register.AX);
			}
			if (Register.EAX <= (Register)info.Op1Register && (Register)info.Op1Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op1Register = (byte)((((Register)info.Op1Register - Register.EAX) & 0xF) + Register.AX);
			}
			if (Register.EAX <= (Register)info.Op2Register && (Register)info.Op2Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op2Register = (byte)((((Register)info.Op2Register - Register.EAX) & 0xF) + Register.AX);
			}
		}
	}

	sealed class SimpleInstrInfo_Reg32 : InstrInfo {
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_Reg32(string mnemonic) =>
			this.mnemonic = new FormatterString(mnemonic);

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			const InstrOpInfoFlags flags = InstrOpInfoFlags.None;
			info = new InstrOpInfo(mnemonic, instruction, flags);
			if (Register.RAX <= (Register)info.Op0Register && (Register)info.Op0Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)((Register)info.Op0Register - Register.RAX + Register.EAX);
			}
			if (Register.RAX <= (Register)info.Op1Register && (Register)info.Op1Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op1Register = (byte)((Register)info.Op1Register - Register.RAX + Register.EAX);
			}
			if (Register.RAX <= (Register)info.Op2Register && (Register)info.Op2Register <= Register.R15) {
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op2Register = (byte)((Register)info.Op2Register - Register.RAX + Register.EAX);
			}
		}
	}

	sealed class SimpleInstrInfo_reg : InstrInfo {
		readonly FormatterString mnemonic;
		readonly Register register;

		public SimpleInstrInfo_reg(string mnemonic, Register register) {
			this.mnemonic = new FormatterString(mnemonic);
			this.register = register;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.None);
			Debug.Assert(instruction.OpCount == 0);
			info.OpCount = 1;
			info.Op0Kind = InstrOpKind.Register;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op0Register = (byte)register;
			if (instruction.Code == Code.Skinit)
				info.Op0Index = OpAccess_ReadWrite;
			else
				info.Op0Index = OpAccess_Read;
		}
	}

	sealed class SimpleInstrInfo_invlpga : InstrInfo {
		readonly int bitness;
		readonly FormatterString mnemonic;

		public SimpleInstrInfo_invlpga(int bitness, string mnemonic) {
			this.bitness = bitness;
			this.mnemonic = new FormatterString(mnemonic);
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = default;
			info.Mnemonic = mnemonic;
			info.OpCount = 2;
			info.Op0Kind = InstrOpKind.Register;
			info.Op1Kind = InstrOpKind.Register;
			Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
			info.Op1Register = (byte)Register.ECX;
			info.Op0Index = OpAccess_Read;
			info.Op1Index = OpAccess_Read;

			switch (bitness) {
			case 16:
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)Register.AX;
				break;

			case 32:
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)Register.EAX;
				break;

			case 64:
				Static.Assert(InstrOpInfo.TEST_RegisterBits == 8 ? 0 : -1);
				info.Op0Register = (byte)Register.RAX;
				break;

			default:
				throw new InvalidOperationException();
			}
		}
	}

	sealed class SimpleInstrInfo_DeclareData : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpKind opKind;

		public SimpleInstrInfo_DeclareData(Code code, string mnemonic) {
			this.mnemonic = new FormatterString(mnemonic);
			opKind = code switch {
				Code.DeclareByte => InstrOpKind.DeclareByte,
				Code.DeclareWord => InstrOpKind.DeclareWord,
				Code.DeclareDword => InstrOpKind.DeclareDword,
				Code.DeclareQword => InstrOpKind.DeclareQword,
				_ => throw new InvalidOperationException(),
			};
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			info = new InstrOpInfo(mnemonic, instruction, InstrOpInfoFlags.MnemonicIsDirective);
			info.OpCount = (byte)instruction.DeclareDataCount;
			info.Op0Kind = opKind;
			info.Op1Kind = opKind;
			info.Op2Kind = opKind;
			info.Op3Kind = opKind;
			info.Op4Kind = opKind;
			info.Op0Index = OpAccess_Read;
			info.Op1Index = OpAccess_Read;
			info.Op2Index = OpAccess_Read;
			info.Op3Index = OpAccess_Read;
			info.Op4Index = OpAccess_Read;
		}
	}

	sealed class SimpleInstrInfo_bcst : InstrInfo {
		readonly FormatterString mnemonic;
		readonly InstrOpInfoFlags flagsNoBroadcast;

		public SimpleInstrInfo_bcst(string mnemonic, InstrOpInfoFlags flagsNoBroadcast) {
			this.mnemonic = new FormatterString(mnemonic);
			this.flagsNoBroadcast = flagsNoBroadcast;
		}

		public override void GetOpInfo(FormatterOptions options, in Instruction instruction, out InstrOpInfo info) {
			var memInfo = MemorySizes.AllMemorySizes[(int)instruction.MemorySize];
			var flags = memInfo.bcstTo.Length != 0 ? InstrOpInfoFlags.None : flagsNoBroadcast;
			info = new InstrOpInfo(mnemonic, instruction, flags);
		}
	}
}
#endif
