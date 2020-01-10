/*
Copyright (C) 2018-2019 de4dot@gmail.com

Permission is hereby granted, free of charge, to any person obtaining
a copy of this software and associated documentation files (the
"Software"), to deal in the Software without restriction, including
without limitation the rights to use, copy, modify, merge, publish,
distribute, sublicense, and/or sell copies of the Software, and to
permit persons to whom the Software is furnished to do so, subject to
the following conditions:

The above copyright notice and this permission notice shall be
included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

// ⚠️This file was generated by GENERATOR!🦹‍♂️

#nullable enable

#if !NO_ENCODER
namespace Iced.Intel {
#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
	public static partial class AssemblerRegisters {
		public static readonly AssemblerRegister al = Register.AL;
		public static readonly AssemblerRegister cl = Register.CL;
		public static readonly AssemblerRegister dl = Register.DL;
		public static readonly AssemblerRegister bl = Register.BL;
		public static readonly AssemblerRegister ah = Register.AH;
		public static readonly AssemblerRegister ch = Register.CH;
		public static readonly AssemblerRegister dh = Register.DH;
		public static readonly AssemblerRegister bh = Register.BH;
		public static readonly AssemblerRegister spl = Register.SPL;
		public static readonly AssemblerRegister bpl = Register.BPL;
		public static readonly AssemblerRegister sil = Register.SIL;
		public static readonly AssemblerRegister dil = Register.DIL;
		public static readonly AssemblerRegister r8l = Register.R8L;
		public static readonly AssemblerRegister r9l = Register.R9L;
		public static readonly AssemblerRegister r10l = Register.R10L;
		public static readonly AssemblerRegister r11l = Register.R11L;
		public static readonly AssemblerRegister r12l = Register.R12L;
		public static readonly AssemblerRegister r13l = Register.R13L;
		public static readonly AssemblerRegister r14l = Register.R14L;
		public static readonly AssemblerRegister r15l = Register.R15L;
		public static readonly AssemblerRegister ax = Register.AX;
		public static readonly AssemblerRegister cx = Register.CX;
		public static readonly AssemblerRegister dx = Register.DX;
		public static readonly AssemblerRegister bx = Register.BX;
		public static readonly AssemblerRegister sp = Register.SP;
		public static readonly AssemblerRegister bp = Register.BP;
		public static readonly AssemblerRegister si = Register.SI;
		public static readonly AssemblerRegister di = Register.DI;
		public static readonly AssemblerRegister r8w = Register.R8W;
		public static readonly AssemblerRegister r9w = Register.R9W;
		public static readonly AssemblerRegister r10w = Register.R10W;
		public static readonly AssemblerRegister r11w = Register.R11W;
		public static readonly AssemblerRegister r12w = Register.R12W;
		public static readonly AssemblerRegister r13w = Register.R13W;
		public static readonly AssemblerRegister r14w = Register.R14W;
		public static readonly AssemblerRegister r15w = Register.R15W;
		public static readonly AssemblerRegister eax = Register.EAX;
		public static readonly AssemblerRegister ecx = Register.ECX;
		public static readonly AssemblerRegister edx = Register.EDX;
		public static readonly AssemblerRegister ebx = Register.EBX;
		public static readonly AssemblerRegister esp = Register.ESP;
		public static readonly AssemblerRegister ebp = Register.EBP;
		public static readonly AssemblerRegister esi = Register.ESI;
		public static readonly AssemblerRegister edi = Register.EDI;
		public static readonly AssemblerRegister r8d = Register.R8D;
		public static readonly AssemblerRegister r9d = Register.R9D;
		public static readonly AssemblerRegister r10d = Register.R10D;
		public static readonly AssemblerRegister r11d = Register.R11D;
		public static readonly AssemblerRegister r12d = Register.R12D;
		public static readonly AssemblerRegister r13d = Register.R13D;
		public static readonly AssemblerRegister r14d = Register.R14D;
		public static readonly AssemblerRegister r15d = Register.R15D;
		public static readonly AssemblerRegister rax = Register.RAX;
		public static readonly AssemblerRegister rcx = Register.RCX;
		public static readonly AssemblerRegister rdx = Register.RDX;
		public static readonly AssemblerRegister rbx = Register.RBX;
		public static readonly AssemblerRegister rsp = Register.RSP;
		public static readonly AssemblerRegister rbp = Register.RBP;
		public static readonly AssemblerRegister rsi = Register.RSI;
		public static readonly AssemblerRegister rdi = Register.RDI;
		public static readonly AssemblerRegister r8 = Register.R8;
		public static readonly AssemblerRegister r9 = Register.R9;
		public static readonly AssemblerRegister r10 = Register.R10;
		public static readonly AssemblerRegister r11 = Register.R11;
		public static readonly AssemblerRegister r12 = Register.R12;
		public static readonly AssemblerRegister r13 = Register.R13;
		public static readonly AssemblerRegister r14 = Register.R14;
		public static readonly AssemblerRegister r15 = Register.R15;
		public static readonly AssemblerRegister eip = Register.EIP;
		public static readonly AssemblerRegister rip = Register.RIP;
		public static readonly AssemblerRegister es = Register.ES;
		public static readonly AssemblerRegister cs = Register.CS;
		public static readonly AssemblerRegister ss = Register.SS;
		public static readonly AssemblerRegister ds = Register.DS;
		public static readonly AssemblerRegister fs = Register.FS;
		public static readonly AssemblerRegister gs = Register.GS;
		public static readonly AssemblerRegister xmm0 = Register.XMM0;
		public static readonly AssemblerRegister xmm1 = Register.XMM1;
		public static readonly AssemblerRegister xmm2 = Register.XMM2;
		public static readonly AssemblerRegister xmm3 = Register.XMM3;
		public static readonly AssemblerRegister xmm4 = Register.XMM4;
		public static readonly AssemblerRegister xmm5 = Register.XMM5;
		public static readonly AssemblerRegister xmm6 = Register.XMM6;
		public static readonly AssemblerRegister xmm7 = Register.XMM7;
		public static readonly AssemblerRegister xmm8 = Register.XMM8;
		public static readonly AssemblerRegister xmm9 = Register.XMM9;
		public static readonly AssemblerRegister xmm10 = Register.XMM10;
		public static readonly AssemblerRegister xmm11 = Register.XMM11;
		public static readonly AssemblerRegister xmm12 = Register.XMM12;
		public static readonly AssemblerRegister xmm13 = Register.XMM13;
		public static readonly AssemblerRegister xmm14 = Register.XMM14;
		public static readonly AssemblerRegister xmm15 = Register.XMM15;
		public static readonly AssemblerRegister xmm16 = Register.XMM16;
		public static readonly AssemblerRegister xmm17 = Register.XMM17;
		public static readonly AssemblerRegister xmm18 = Register.XMM18;
		public static readonly AssemblerRegister xmm19 = Register.XMM19;
		public static readonly AssemblerRegister xmm20 = Register.XMM20;
		public static readonly AssemblerRegister xmm21 = Register.XMM21;
		public static readonly AssemblerRegister xmm22 = Register.XMM22;
		public static readonly AssemblerRegister xmm23 = Register.XMM23;
		public static readonly AssemblerRegister xmm24 = Register.XMM24;
		public static readonly AssemblerRegister xmm25 = Register.XMM25;
		public static readonly AssemblerRegister xmm26 = Register.XMM26;
		public static readonly AssemblerRegister xmm27 = Register.XMM27;
		public static readonly AssemblerRegister xmm28 = Register.XMM28;
		public static readonly AssemblerRegister xmm29 = Register.XMM29;
		public static readonly AssemblerRegister xmm30 = Register.XMM30;
		public static readonly AssemblerRegister xmm31 = Register.XMM31;
		public static readonly AssemblerRegister ymm0 = Register.YMM0;
		public static readonly AssemblerRegister ymm1 = Register.YMM1;
		public static readonly AssemblerRegister ymm2 = Register.YMM2;
		public static readonly AssemblerRegister ymm3 = Register.YMM3;
		public static readonly AssemblerRegister ymm4 = Register.YMM4;
		public static readonly AssemblerRegister ymm5 = Register.YMM5;
		public static readonly AssemblerRegister ymm6 = Register.YMM6;
		public static readonly AssemblerRegister ymm7 = Register.YMM7;
		public static readonly AssemblerRegister ymm8 = Register.YMM8;
		public static readonly AssemblerRegister ymm9 = Register.YMM9;
		public static readonly AssemblerRegister ymm10 = Register.YMM10;
		public static readonly AssemblerRegister ymm11 = Register.YMM11;
		public static readonly AssemblerRegister ymm12 = Register.YMM12;
		public static readonly AssemblerRegister ymm13 = Register.YMM13;
		public static readonly AssemblerRegister ymm14 = Register.YMM14;
		public static readonly AssemblerRegister ymm15 = Register.YMM15;
		public static readonly AssemblerRegister ymm16 = Register.YMM16;
		public static readonly AssemblerRegister ymm17 = Register.YMM17;
		public static readonly AssemblerRegister ymm18 = Register.YMM18;
		public static readonly AssemblerRegister ymm19 = Register.YMM19;
		public static readonly AssemblerRegister ymm20 = Register.YMM20;
		public static readonly AssemblerRegister ymm21 = Register.YMM21;
		public static readonly AssemblerRegister ymm22 = Register.YMM22;
		public static readonly AssemblerRegister ymm23 = Register.YMM23;
		public static readonly AssemblerRegister ymm24 = Register.YMM24;
		public static readonly AssemblerRegister ymm25 = Register.YMM25;
		public static readonly AssemblerRegister ymm26 = Register.YMM26;
		public static readonly AssemblerRegister ymm27 = Register.YMM27;
		public static readonly AssemblerRegister ymm28 = Register.YMM28;
		public static readonly AssemblerRegister ymm29 = Register.YMM29;
		public static readonly AssemblerRegister ymm30 = Register.YMM30;
		public static readonly AssemblerRegister ymm31 = Register.YMM31;
		public static readonly AssemblerRegister zmm0 = Register.ZMM0;
		public static readonly AssemblerRegister zmm1 = Register.ZMM1;
		public static readonly AssemblerRegister zmm2 = Register.ZMM2;
		public static readonly AssemblerRegister zmm3 = Register.ZMM3;
		public static readonly AssemblerRegister zmm4 = Register.ZMM4;
		public static readonly AssemblerRegister zmm5 = Register.ZMM5;
		public static readonly AssemblerRegister zmm6 = Register.ZMM6;
		public static readonly AssemblerRegister zmm7 = Register.ZMM7;
		public static readonly AssemblerRegister zmm8 = Register.ZMM8;
		public static readonly AssemblerRegister zmm9 = Register.ZMM9;
		public static readonly AssemblerRegister zmm10 = Register.ZMM10;
		public static readonly AssemblerRegister zmm11 = Register.ZMM11;
		public static readonly AssemblerRegister zmm12 = Register.ZMM12;
		public static readonly AssemblerRegister zmm13 = Register.ZMM13;
		public static readonly AssemblerRegister zmm14 = Register.ZMM14;
		public static readonly AssemblerRegister zmm15 = Register.ZMM15;
		public static readonly AssemblerRegister zmm16 = Register.ZMM16;
		public static readonly AssemblerRegister zmm17 = Register.ZMM17;
		public static readonly AssemblerRegister zmm18 = Register.ZMM18;
		public static readonly AssemblerRegister zmm19 = Register.ZMM19;
		public static readonly AssemblerRegister zmm20 = Register.ZMM20;
		public static readonly AssemblerRegister zmm21 = Register.ZMM21;
		public static readonly AssemblerRegister zmm22 = Register.ZMM22;
		public static readonly AssemblerRegister zmm23 = Register.ZMM23;
		public static readonly AssemblerRegister zmm24 = Register.ZMM24;
		public static readonly AssemblerRegister zmm25 = Register.ZMM25;
		public static readonly AssemblerRegister zmm26 = Register.ZMM26;
		public static readonly AssemblerRegister zmm27 = Register.ZMM27;
		public static readonly AssemblerRegister zmm28 = Register.ZMM28;
		public static readonly AssemblerRegister zmm29 = Register.ZMM29;
		public static readonly AssemblerRegister zmm30 = Register.ZMM30;
		public static readonly AssemblerRegister zmm31 = Register.ZMM31;
		public static readonly AssemblerRegister k0 = Register.K0;
		public static readonly AssemblerRegister k1 = Register.K1;
		public static readonly AssemblerRegister k2 = Register.K2;
		public static readonly AssemblerRegister k3 = Register.K3;
		public static readonly AssemblerRegister k4 = Register.K4;
		public static readonly AssemblerRegister k5 = Register.K5;
		public static readonly AssemblerRegister k6 = Register.K6;
		public static readonly AssemblerRegister k7 = Register.K7;
		public static readonly AssemblerRegister bnd0 = Register.BND0;
		public static readonly AssemblerRegister bnd1 = Register.BND1;
		public static readonly AssemblerRegister bnd2 = Register.BND2;
		public static readonly AssemblerRegister bnd3 = Register.BND3;
		public static readonly AssemblerRegister cr0 = Register.CR0;
		public static readonly AssemblerRegister cr1 = Register.CR1;
		public static readonly AssemblerRegister cr2 = Register.CR2;
		public static readonly AssemblerRegister cr3 = Register.CR3;
		public static readonly AssemblerRegister cr4 = Register.CR4;
		public static readonly AssemblerRegister cr5 = Register.CR5;
		public static readonly AssemblerRegister cr6 = Register.CR6;
		public static readonly AssemblerRegister cr7 = Register.CR7;
		public static readonly AssemblerRegister cr8 = Register.CR8;
		public static readonly AssemblerRegister cr9 = Register.CR9;
		public static readonly AssemblerRegister cr10 = Register.CR10;
		public static readonly AssemblerRegister cr11 = Register.CR11;
		public static readonly AssemblerRegister cr12 = Register.CR12;
		public static readonly AssemblerRegister cr13 = Register.CR13;
		public static readonly AssemblerRegister cr14 = Register.CR14;
		public static readonly AssemblerRegister cr15 = Register.CR15;
		public static readonly AssemblerRegister dr0 = Register.DR0;
		public static readonly AssemblerRegister dr1 = Register.DR1;
		public static readonly AssemblerRegister dr2 = Register.DR2;
		public static readonly AssemblerRegister dr3 = Register.DR3;
		public static readonly AssemblerRegister dr4 = Register.DR4;
		public static readonly AssemblerRegister dr5 = Register.DR5;
		public static readonly AssemblerRegister dr6 = Register.DR6;
		public static readonly AssemblerRegister dr7 = Register.DR7;
		public static readonly AssemblerRegister dr8 = Register.DR8;
		public static readonly AssemblerRegister dr9 = Register.DR9;
		public static readonly AssemblerRegister dr10 = Register.DR10;
		public static readonly AssemblerRegister dr11 = Register.DR11;
		public static readonly AssemblerRegister dr12 = Register.DR12;
		public static readonly AssemblerRegister dr13 = Register.DR13;
		public static readonly AssemblerRegister dr14 = Register.DR14;
		public static readonly AssemblerRegister dr15 = Register.DR15;
		public static readonly AssemblerRegister st0 = Register.ST0;
		public static readonly AssemblerRegister st1 = Register.ST1;
		public static readonly AssemblerRegister st2 = Register.ST2;
		public static readonly AssemblerRegister st3 = Register.ST3;
		public static readonly AssemblerRegister st4 = Register.ST4;
		public static readonly AssemblerRegister st5 = Register.ST5;
		public static readonly AssemblerRegister st6 = Register.ST6;
		public static readonly AssemblerRegister st7 = Register.ST7;
		public static readonly AssemblerRegister mm0 = Register.MM0;
		public static readonly AssemblerRegister mm1 = Register.MM1;
		public static readonly AssemblerRegister mm2 = Register.MM2;
		public static readonly AssemblerRegister mm3 = Register.MM3;
		public static readonly AssemblerRegister mm4 = Register.MM4;
		public static readonly AssemblerRegister mm5 = Register.MM5;
		public static readonly AssemblerRegister mm6 = Register.MM6;
		public static readonly AssemblerRegister mm7 = Register.MM7;
		public static readonly AssemblerRegister tr0 = Register.TR0;
		public static readonly AssemblerRegister tr1 = Register.TR1;
		public static readonly AssemblerRegister tr2 = Register.TR2;
		public static readonly AssemblerRegister tr3 = Register.TR3;
		public static readonly AssemblerRegister tr4 = Register.TR4;
		public static readonly AssemblerRegister tr5 = Register.TR5;
		public static readonly AssemblerRegister tr6 = Register.TR6;
		public static readonly AssemblerRegister tr7 = Register.TR7;
	}
}
#endif
