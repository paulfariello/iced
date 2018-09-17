﻿/*
    Copyright (C) 2018 de4dot@gmail.com

    This file is part of Iced.

    Iced is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    Iced is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Iced.  If not, see <https://www.gnu.org/licenses/>.
*/

#if !NO_MASM_FORMATTER && !NO_FORMATTER
using System.Collections.Generic;
using Xunit;

namespace Iced.UnitTests.Intel.FormatterTests.Masm {
	public sealed class MasmFormatterTest64_ForceMemSize_000 : FormatterTest {
		[Theory]
		[MemberData(nameof(Format_Data))]
		void Format(int index, InstructionInfo info, string formattedString) => FormatBase(index, info, formattedString, MasmFormatterFactory.Create_ForceMemSize());
		public static IEnumerable<object[]> Format_Data => GetFormatData(infos, formattedStrings);

		static readonly InstructionInfo[] infos = InstructionInfos64_000.AllInfos;
		static readonly string[] formattedStrings = new string[InstructionInfos64_000.AllInfos_Length] {
			"add dh,cl",
			"add byte ptr [rax],bh",
			"add si,cx",
			"add word ptr [rax],bx",
			"add esi,ecx",
			"add dword ptr [rax],ebx",
			"add rsi,rcx",
			"add qword ptr [rax],rbx",
			"add cl,dh",
			"add bh,byte ptr [rax]",
			"add cx,si",
			"add bx,word ptr [rax]",
			"add ecx,esi",
			"add ebx,dword ptr [rax]",
			"add rcx,rsi",
			"add rbx,qword ptr [rax]",
			"add al,-5Bh",
			"add ax,5AA5h",
			"add eax,12345AA5h",
			"add rax,-7DCBA55Bh",
			"or dh,cl",
			"or byte ptr [rax],bh",
			"or si,cx",
			"or word ptr [rax],bx",
			"or esi,ecx",
			"or dword ptr [rax],ebx",
			"or rsi,rcx",
			"or qword ptr [rax],rbx",
			"or cl,dh",
			"or bh,byte ptr [rax]",
			"or cx,si",
			"or bx,word ptr [rax]",
			"or ecx,esi",
			"or ebx,dword ptr [rax]",
			"or rcx,rsi",
			"or rbx,qword ptr [rax]",
			"or al,-5Bh",
			"or ax,5AA5h",
			"or eax,12345AA5h",
			"or rax,-7DCBA55Bh",
			"adc dh,cl",
			"adc byte ptr [rax],bh",
			"adc si,cx",
			"adc word ptr [rax],bx",
			"adc esi,ecx",
			"adc dword ptr [rax],ebx",
			"adc rsi,rcx",
			"adc qword ptr [rax],rbx",
			"adc cl,dh",
			"adc bh,byte ptr [rax]",
			"adc cx,si",
			"adc bx,word ptr [rax]",
			"adc ecx,esi",
			"adc ebx,dword ptr [rax]",
			"adc rcx,rsi",
			"adc rbx,qword ptr [rax]",
			"adc al,-5Bh",
			"adc ax,5AA5h",
			"adc eax,12345AA5h",
			"adc rax,-7DCBA55Bh",
			"sbb dh,cl",
			"sbb byte ptr [rax],bh",
			"sbb si,cx",
			"sbb word ptr [rax],bx",
			"sbb esi,ecx",
			"sbb dword ptr [rax],ebx",
			"sbb rsi,rcx",
			"sbb qword ptr [rax],rbx",
			"sbb cl,dh",
			"sbb bh,byte ptr [rax]",
			"sbb cx,si",
			"sbb bx,word ptr [rax]",
			"sbb ecx,esi",
			"sbb ebx,dword ptr [rax]",
			"sbb rcx,rsi",
			"sbb rbx,qword ptr [rax]",
			"sbb al,-5Bh",
			"sbb ax,5AA5h",
			"sbb eax,12345AA5h",
			"sbb rax,-7DCBA55Bh",
			"and dh,cl",
			"and byte ptr [rax],bh",
			"and si,cx",
			"and word ptr [rax],bx",
			"and esi,ecx",
			"and dword ptr [rax],ebx",
			"and rsi,rcx",
			"and qword ptr [rax],rbx",
			"and cl,dh",
			"and bh,byte ptr [rax]",
			"and cx,si",
			"and bx,word ptr [rax]",
			"and ecx,esi",
			"and ebx,dword ptr [rax]",
			"and rcx,rsi",
			"and rbx,qword ptr [rax]",
			"and al,-5Bh",
			"and ax,5AA5h",
			"and eax,12345AA5h",
			"and rax,-7DCBA55Bh",
			"sub dh,cl",
			"sub byte ptr [rax],bh",
			"sub si,cx",
			"sub word ptr [rax],bx",
			"sub esi,ecx",
			"sub dword ptr [rax],ebx",
			"sub rsi,rcx",
			"sub qword ptr [rax],rbx",
			"sub cl,dh",
			"sub bh,byte ptr [rax]",
			"sub cx,si",
			"sub bx,word ptr [rax]",
			"sub ecx,esi",
			"sub ebx,dword ptr [rax]",
			"sub rcx,rsi",
			"sub rbx,qword ptr [rax]",
			"sub al,-5Bh",
			"sub ax,5AA5h",
			"sub eax,12345AA5h",
			"sub rax,-7DCBA55Bh",
			"xor dh,cl",
			"xor byte ptr [rax],bh",
			"xor si,cx",
			"xor word ptr [rax],bx",
			"xor esi,ecx",
			"xor dword ptr [rax],ebx",
			"xor rsi,rcx",
			"xor qword ptr [rax],rbx",
			"xor cl,dh",
			"xor bh,byte ptr [rax]",
			"xor cx,si",
			"xor bx,word ptr [rax]",
			"xor ecx,esi",
			"xor ebx,dword ptr [rax]",
			"xor rcx,rsi",
			"xor rbx,qword ptr [rax]",
			"xor al,-5Bh",
			"xor ax,5AA5h",
			"xor eax,12345AA5h",
			"xor rax,-7DCBA55Bh",
			"cmp dh,cl",
			"cmp byte ptr [rax],bh",
			"cmp si,cx",
			"cmp word ptr [rax],bx",
			"cmp esi,ecx",
			"cmp dword ptr [rax],ebx",
			"cmp rsi,rcx",
			"cmp qword ptr [rax],rbx",
			"cmp cl,dh",
			"cmp bh,byte ptr [rax]",
			"cmp cx,si",
			"cmp bx,word ptr [rax]",
			"cmp ecx,esi",
			"cmp ebx,dword ptr [rax]",
			"cmp rcx,rsi",
			"cmp rbx,qword ptr [rax]",
			"cmp al,-5Bh",
			"cmp ax,5AA5h",
			"cmp eax,12345AA5h",
			"cmp rax,-7DCBA55Bh",
			"push ax",
			"push r8w",
			"push rax",
			"push r8",
			"push cx",
			"push r9w",
			"push rcx",
			"push r9",
			"push dx",
			"push r10w",
			"push rdx",
			"push r10",
			"push bx",
			"push r11w",
			"push rbx",
			"push r11",
			"push sp",
			"push r12w",
			"push rsp",
			"push r12",
			"push bp",
			"push r13w",
			"push rbp",
			"push r13",
			"push si",
			"push r14w",
			"push rsi",
			"push r14",
			"push di",
			"push r15w",
			"push rdi",
			"push r15",
			"pop ax",
			"pop r8w",
			"pop rax",
			"pop r8",
			"pop cx",
			"pop r9w",
			"pop rcx",
			"pop r9",
			"pop dx",
			"pop r10w",
			"pop rdx",
			"pop r10",
			"pop bx",
			"pop r11w",
			"pop rbx",
			"pop r11",
			"pop sp",
			"pop r12w",
			"pop rsp",
			"pop r12",
			"pop bp",
			"pop r13w",
			"pop rbp",
			"pop r13",
			"pop si",
			"pop r14w",
			"pop rsi",
			"pop r14",
			"pop di",
			"pop r15w",
			"pop rdi",
			"pop r15",
			"movsxd cx,si",
			"movsxd bx,word ptr [rax]",
			"movsxd ecx,esi",
			"movsxd ebx,dword ptr [rax]",
			"movsxd rcx,esi",
			"movsxd rbx,dword ptr [rax]",
			"pushw -5AA6h",
			"push -7BED5AA6h",
			"imul cx,si,5AA5h",
			"imul bx,word ptr [rax],-5AA6h",
			"imul ecx,esi,3412A55Ah",
			"imul ebx,dword ptr [rax],3412A55Ah",
			"imul rcx,rsi,-7BED5AA6h",
			"imul rbx,qword ptr [rax],-7BED5AA6h",
			"pushw -5Bh",
			"push -5Bh",
			"imul cx,si,-5Bh",
			"imul bx,word ptr [rax],-5Bh",
			"imul ecx,esi,-5Bh",
			"imul ebx,dword ptr [rax],-5Bh",
			"imul rcx,rsi,-5Bh",
			"imul rbx,qword ptr [rax],-5Bh",
			"ins byte ptr [edi],dx",
			"insb",
			"ins word ptr [edi],dx",
			"insw",
			"ins dword ptr [edi],dx",
			"insd",
			"outs dx,byte ptr [esi]",
			"outsb",
			"outs dx,word ptr [esi]",
			"outsw",
			"outs dx,dword ptr [esi]",
			"outsd",
			"jo short 800000000000004Ch",
			"jno short 800000000000004Ch",
			"jb short 800000000000004Ch",
			"jae short 800000000000004Ch",
			"je short 800000000000004Ch",
			"jne short 800000000000004Ch",
			"jbe short 800000000000004Ch",
			"ja short 800000000000004Ch",
			"js short 800000000000004Ch",
			"jns short 800000000000004Ch",
			"jp short 800000000000004Ch",
			"jnp short 800000000000004Ch",
			"jl short 800000000000004Ch",
			"jge short 800000000000004Ch",
			"jle short 800000000000004Ch",
			"jg short 800000000000004Ch",
			"add cl,5Ah",
			"add byte ptr [rax],5Ah",
			"or dl,-5Bh",
			"or byte ptr [rax],-5Bh",
			"adc bl,5Ah",
			"adc byte ptr [rax],5Ah",
			"sbb ah,-5Bh",
			"sbb byte ptr [rax],-5Bh",
			"and ch,5Ah",
			"and byte ptr [rax],5Ah",
			"sub dh,-5Bh",
			"sub byte ptr [rax],-5Bh",
			"xor bh,5Ah",
			"xor byte ptr [rax],5Ah",
			"cmp al,-5Bh",
			"cmp byte ptr [rax],-5Bh",
			"add cx,-5AA6h",
			"add word ptr [rax],-5AA6h",
			"add ecx,3412A55Ah",
			"add dword ptr [rax],3412A55Ah",
			"add rcx,-7BED5AA6h",
			"add qword ptr [rax],-7BED5AA6h",
			"or dx,5AA5h",
			"or word ptr [rax],5AA5h",
			"or edx,-5476A55Bh",
			"or dword ptr [rax],-5476A55Bh",
			"or rdx,-7BED5AA6h",
			"or qword ptr [rax],-7BED5AA6h",
			"adc bx,-5AA6h",
			"adc word ptr [rax],-5AA6h",
			"adc ebx,3412A55Ah",
			"adc dword ptr [rax],3412A55Ah",
			"adc rbx,-7BED5AA6h",
			"adc qword ptr [rax],-7BED5AA6h",
			"sbb sp,5AA5h",
			"sbb word ptr [rax],5AA5h",
			"sbb esp,-5476A55Bh",
			"sbb dword ptr [rax],-5476A55Bh",
			"sbb rsp,-7BED5AA6h",
			"sbb qword ptr [rax],-7BED5AA6h",
			"and bp,-5AA6h",
			"and word ptr [rax],-5AA6h",
			"and ebp,3412A55Ah",
			"and dword ptr [rax],3412A55Ah",
			"and rbp,-7BED5AA6h",
			"and qword ptr [rax],-7BED5AA6h",
			"sub si,5AA5h",
			"sub word ptr [rax],5AA5h",
			"sub esi,-5476A55Bh",
			"sub dword ptr [rax],-5476A55Bh",
			"sub rsi,-7BED5AA6h",
			"sub qword ptr [rax],-7BED5AA6h",
			"xor di,-5AA6h",
			"xor word ptr [rax],-5AA6h",
			"xor edi,3412A55Ah",
			"xor dword ptr [rax],3412A55Ah",
			"xor rdi,-7BED5AA6h",
			"xor qword ptr [rax],-7BED5AA6h",
			"cmp ax,5AA5h",
			"cmp word ptr [rax],5AA5h",
			"cmp eax,-5476A55Bh",
			"cmp dword ptr [rax],-5476A55Bh",
			"cmp r8,-7BED5AA6h",
			"cmp qword ptr [rax],-7BED5AA6h",
			"add cx,-5Bh",
			"add word ptr [rax],-5Bh",
			"add ecx,-5Bh",
			"add dword ptr [rax],-5Bh",
			"add rcx,-5Bh",
			"add qword ptr [rax],-5Bh",
			"or dx,-5Bh",
			"or word ptr [rax],-5Bh",
			"or edx,-5Bh",
			"or dword ptr [rax],-5Bh",
			"or rdx,-5Bh",
			"or qword ptr [rax],-5Bh",
			"adc bx,-5Bh",
			"adc word ptr [rax],-5Bh",
			"adc ebx,-5Bh",
			"adc dword ptr [rax],-5Bh",
			"adc rbx,-5Bh",
			"adc qword ptr [rax],-5Bh",
			"sbb sp,-5Bh",
			"sbb word ptr [rax],-5Bh",
			"sbb esp,-5Bh",
			"sbb dword ptr [rax],-5Bh",
			"sbb rsp,-5Bh",
			"sbb qword ptr [rax],-5Bh",
			"and bp,-5Bh",
			"and word ptr [rax],-5Bh",
			"and ebp,-5Bh",
			"and dword ptr [rax],-5Bh",
			"and rbp,-5Bh",
			"and qword ptr [rax],-5Bh",
			"sub si,-5Bh",
			"sub word ptr [rax],-5Bh",
			"sub esi,-5Bh",
			"sub dword ptr [rax],-5Bh",
			"sub rsi,-5Bh",
			"sub qword ptr [rax],-5Bh",
			"xor di,-5Bh",
			"xor word ptr [rax],-5Bh",
			"xor edi,-5Bh",
			"xor dword ptr [rax],-5Bh",
			"xor rdi,-5Bh",
			"xor qword ptr [rax],-5Bh",
			"cmp ax,-5Bh",
			"cmp word ptr [rax],-5Bh",
			"cmp eax,-5Bh",
			"cmp dword ptr [rax],-5Bh",
			"cmp r8,-5Bh",
			"cmp qword ptr [rax],-5Bh",
			"test cl,dh",
			"test bh,byte ptr [rax]",
			"test cx,si",
			"test bx,word ptr [rax]",
			"test ecx,esi",
			"test ebx,dword ptr [rax]",
			"test rcx,rsi",
			"test rbx,qword ptr [rax]",
			"xchg cl,dh",
			"xchg bh,byte ptr [rax]",
			"xchg cx,si",
			"xchg bx,word ptr [rax]",
			"xchg ecx,esi",
			"xchg ebx,dword ptr [rax]",
			"xchg rcx,rsi",
			"xchg rbx,qword ptr [rax]",
			"mov dh,cl",
			"mov byte ptr [rax],bh",
			"mov si,cx",
			"mov word ptr [rax],bx",
			"mov esi,ecx",
			"mov dword ptr [rax],ebx",
			"mov rsi,rcx",
			"mov qword ptr [rax],rbx",
			"mov cl,dh",
			"mov bh,byte ptr [rax]",
			"mov cx,si",
			"mov bx,word ptr [rax]",
			"mov ecx,esi",
			"mov ebx,dword ptr [rax]",
			"mov rcx,rsi",
			"mov rbx,qword ptr [rax]",
			"mov si,cs",
			"mov word ptr [rax],ds",
			"mov esi,cs",
			"mov word ptr [rax],ds",
			"mov rsi,cs",
			"mov word ptr [rax],ds",
			"lea bx,[rax]",
			"lea ebx,[rax]",
			"lea rbx,[rax]",
			"mov fs,si",
			"mov ds,word ptr [rax]",
			"mov fs,esi",
			"mov ds,word ptr [rax]",
			"mov fs,rsi",
			"mov ds,word ptr [rax]",
			"pop si",
			"pop word ptr [rax]",
			"pop rsi",
			"pop qword ptr [rax]",
			"xchg ax,ax",
			"xchg r8w,ax",
			"nop",
			"xchg r8d,eax",
			"xchg rax,rax",
			"xchg r8,rax",
			"xchg cx,ax",
			"xchg r9w,ax",
			"xchg ecx,eax",
			"xchg r9d,eax",
			"xchg rcx,rax",
			"xchg r9,rax",
			"xchg dx,ax",
			"xchg r10w,ax",
			"xchg edx,eax",
			"xchg r10d,eax",
			"xchg rdx,rax",
			"xchg r10,rax",
			"xchg bx,ax",
			"xchg r11w,ax",
			"xchg ebx,eax",
			"xchg r11d,eax",
			"xchg rbx,rax",
			"xchg r11,rax",
			"xchg sp,ax",
			"xchg r12w,ax",
			"xchg esp,eax",
			"xchg r12d,eax",
			"xchg rsp,rax",
			"xchg r12,rax",
			"xchg bp,ax",
			"xchg r13w,ax",
			"xchg ebp,eax",
			"xchg r13d,eax",
			"xchg rbp,rax",
			"xchg r13,rax",
			"xchg si,ax",
			"xchg r14w,ax",
			"xchg esi,eax",
			"xchg r14d,eax",
			"xchg rsi,rax",
			"xchg r14,rax",
			"xchg di,ax",
			"xchg r15w,ax",
			"xchg edi,eax",
			"xchg r15d,eax",
			"xchg rdi,rax",
			"xchg r15,rax",
			"pause",
			"cbw",
			"cwde",
			"cdqe",
			"cwd",
			"cdq",
			"cqo",
			"wait",
			"pushf",
			"pushfq",
			"popf",
			"popfq",
			"sahf",
			"lahf",
			"mov al,byte ptr [0F0DEBC9A78563412h]",
			"mov al,byte ptr [78563412h]",
			"mov ax,word ptr [0F0DEBC9A78563412h]",
			"mov ax,word ptr [78563412h]",
			"mov eax,dword ptr [0F0DEBC9A78563412h]",
			"mov eax,dword ptr [78563412h]",
			"mov rax,qword ptr [0F0DEBC9A78563412h]",
			"mov rax,qword ptr [78563412h]",
			"mov byte ptr [0F0DEBC9A78563412h],al",
			"mov byte ptr [78563412h],al",
			"mov word ptr [0F0DEBC9A78563412h],ax",
			"mov word ptr [78563412h],ax",
			"mov dword ptr [0F0DEBC9A78563412h],eax",
			"mov dword ptr [78563412h],eax",
			"mov qword ptr [0F0DEBC9A78563412h],rax",
			"mov qword ptr [78563412h],rax",
			"movs byte ptr [edi],byte ptr [esi]",
			"movsb",
			"movs word ptr [edi],word ptr [esi]",
			"movsw",
			"movs dword ptr [edi],dword ptr [esi]",
			"movsd",
			"movs qword ptr [edi],qword ptr [esi]",
			"movsq",
			"cmps byte ptr [esi],byte ptr [edi]",
			"cmpsb",
			"cmps word ptr [esi],word ptr [edi]",
			"cmpsw",
			"cmps dword ptr [esi],dword ptr [edi]",
			"cmpsd",
			"cmps qword ptr [esi],qword ptr [edi]",
			"cmpsq",
			"test al,-5Bh",
			"test ax,5AA5h",
			"test eax,12345AA5h",
			"test rax,-7DCBA55Bh",
			"stos byte ptr [edi]",
			"stosb",
			"stos word ptr [edi]",
			"stosw",
			"stos dword ptr [edi]",
			"stosd",
			"stos qword ptr [edi]",
			"stosq",
			"lods byte ptr [esi]",
			"lodsb",
			"lods word ptr [esi]",
			"lodsw",
			"lods dword ptr [esi]",
			"lodsd",
			"lods qword ptr [esi]",
			"lodsq",
			"scas byte ptr [edi]",
			"scasb",
			"scas word ptr [edi]",
			"scasw",
			"scas dword ptr [edi]",
			"scasd",
			"scas qword ptr [edi]",
			"scasq",
			"mov al,5Ah",
			"mov r8b,5Ah",
			"mov cl,-5Bh",
			"mov r9b,-5Bh",
			"mov dl,5Ah",
			"mov r10b,5Ah",
			"mov bl,-5Bh",
			"mov r11b,-5Bh",
			"mov ah,5Ah",
			"mov spl,5Ah",
			"mov r12b,5Ah",
			"mov ch,-5Bh",
			"mov bpl,-5Bh",
			"mov r13b,-5Bh",
			"mov dh,5Ah",
			"mov sil,5Ah",
			"mov r14b,5Ah",
			"mov bh,-5Bh",
			"mov dil,-5Bh",
			"mov r15b,-5Bh",
			"mov ax,-5AA6h",
			"mov r8w,-5AA6h",
			"mov eax,3412A55Ah",
			"mov r8d,3412A55Ah",
			"mov rax,3412A55A37261504h",
			"mov r8,3412A55A37261504h",
			"mov cx,5AA5h",
			"mov r9w,5AA5h",
			"mov ecx,78565AA5h",
			"mov r9d,78565AA5h",
			"mov rcx,78565AA537261504h",
			"mov r9,78565AA537261504h",
			"mov dx,-5AA6h",
			"mov r10w,-5AA6h",
			"mov edx,3412A55Ah",
			"mov r10d,3412A55Ah",
			"mov rdx,3412A55A37261504h",
			"mov r10,3412A55A37261504h",
			"mov bx,5AA5h",
			"mov r11w,5AA5h",
			"mov ebx,78565AA5h",
			"mov r11d,78565AA5h",
			"mov rbx,78565AA537261504h",
			"mov r11,78565AA537261504h",
			"mov sp,-5AA6h",
			"mov r12w,-5AA6h",
			"mov esp,3412A55Ah",
			"mov r12d,3412A55Ah",
			"mov rsp,3412A55A37261504h",
			"mov r12,3412A55A37261504h",
			"mov bp,5AA5h",
			"mov r13w,5AA5h",
			"mov ebp,78565AA5h",
			"mov r13d,78565AA5h",
			"mov rbp,78565AA537261504h",
			"mov r13,78565AA537261504h",
			"mov si,-5AA6h",
			"mov r14w,-5AA6h",
			"mov esi,3412A55Ah",
			"mov r14d,3412A55Ah",
			"mov rsi,3412A55A37261504h",
			"mov r14,3412A55A37261504h",
			"mov di,5AA5h",
			"mov r15w,5AA5h",
			"mov edi,78565AA5h",
			"mov r15d,78565AA5h",
			"mov rdi,78565AA537261504h",
			"mov r15,78565AA537261504h",
			"rol cl,5Ah",
			"rol byte ptr [rax],5Ah",
			"ror dl,-5Bh",
			"ror byte ptr [rax],-5Bh",
			"rcl bl,5Ah",
			"rcl byte ptr [rax],5Ah",
			"rcr ah,-5Bh",
			"rcr byte ptr [rax],-5Bh",
			"shl ch,5Ah",
			"shl byte ptr [rax],5Ah",
			"shr dh,-5Bh",
			"shr byte ptr [rax],-5Bh",
			"sar al,-5Bh",
			"sar byte ptr [rax],-5Bh",
			"rol cx,5Ah",
			"rol word ptr [rax],5Ah",
			"rol ecx,5Ah",
			"rol dword ptr [rax],5Ah",
			"rol rcx,5Ah",
			"rol qword ptr [rax],5Ah",
			"ror dx,-5Bh",
			"ror word ptr [rax],-5Bh",
			"ror edx,-5Bh",
			"ror dword ptr [rax],-5Bh",
			"ror rdx,-5Bh",
			"ror qword ptr [rax],-5Bh",
			"rcl bx,5Ah",
			"rcl word ptr [rax],5Ah",
			"rcl ebx,5Ah",
			"rcl dword ptr [rax],5Ah",
			"rcl rbx,5Ah",
			"rcl qword ptr [rax],5Ah",
			"rcr sp,-5Bh",
			"rcr word ptr [rax],-5Bh",
			"rcr esp,-5Bh",
			"rcr dword ptr [rax],-5Bh",
			"rcr rsp,-5Bh",
			"rcr qword ptr [rax],-5Bh",
			"shl bp,5Ah",
			"shl word ptr [rax],5Ah",
			"shl ebp,5Ah",
			"shl dword ptr [rax],5Ah",
			"shl rbp,5Ah",
			"shl qword ptr [rax],5Ah",
			"shr si,-5Bh",
			"shr word ptr [rax],-5Bh",
			"shr esi,-5Bh",
			"shr dword ptr [rax],-5Bh",
			"shr rsi,-5Bh",
			"shr qword ptr [rax],-5Bh",
			"sar ax,-5Bh",
			"sar word ptr [rax],-5Bh",
			"sar eax,-5Bh",
			"sar dword ptr [rax],-5Bh",
			"sar r8,-5Bh",
			"sar qword ptr [rax],-5Bh",
			"ret -5AA6h",
			"ret",
			"mov cl,5Ah",
			"mov byte ptr [rax],5Ah",
			"xabort 5Ah",
			"mov cx,-5AA6h",
			"mov word ptr [rax],-5AA6h",
			"mov ecx,3412A55Ah",
			"mov dword ptr [rax],3412A55Ah",
			"mov rcx,-7BED5AA6h",
			"mov qword ptr [rax],-7BED5AA6h",
			"xbegin 7FFFFFFFFFFFA54Fh",
			"xbegin 800000003412A550h",
			"xbegin 800000003412A551h",
			"enterw -5AA6h,-5Ah",
			"enter -5AA6h,-5Ah",
			"leavew",
			"leave",
			"retfw -5AA6h",
			"retf -5AA6h",
			"retfq -5AA6h",
			"retfw",
			"retf",
			"retfq",
			"int 3",
			"int 5Ah",
			"iret",
			"iretd",
			"iretq",
			"rol cl,1",
			"rol byte ptr [rax],1",
			"ror dl,1",
			"ror byte ptr [rax],1",
			"rcl bl,1",
			"rcl byte ptr [rax],1",
			"rcr ah,1",
			"rcr byte ptr [rax],1",
			"shl ch,1",
			"shl byte ptr [rax],1",
			"shr dh,1",
			"shr byte ptr [rax],1",
			"sar al,1",
			"sar byte ptr [rax],1",
			"rol cx,1",
			"rol word ptr [rax],1",
			"rol ecx,1",
			"rol dword ptr [rax],1",
			"rol rcx,1",
			"rol qword ptr [rax],1",
			"ror dx,1",
			"ror word ptr [rax],1",
			"ror edx,1",
			"ror dword ptr [rax],1",
			"ror rdx,1",
			"ror qword ptr [rax],1",
			"rcl bx,1",
			"rcl word ptr [rax],1",
			"rcl ebx,1",
			"rcl dword ptr [rax],1",
			"rcl rbx,1",
			"rcl qword ptr [rax],1",
			"rcr sp,1",
			"rcr word ptr [rax],1",
			"rcr esp,1",
			"rcr dword ptr [rax],1",
			"rcr rsp,1",
			"rcr qword ptr [rax],1",
			"shl bp,1",
			"shl word ptr [rax],1",
			"shl ebp,1",
			"shl dword ptr [rax],1",
			"shl rbp,1",
			"shl qword ptr [rax],1",
			"shr si,1",
			"shr word ptr [rax],1",
			"shr esi,1",
			"shr dword ptr [rax],1",
			"shr rsi,1",
			"shr qword ptr [rax],1",
			"sar ax,1",
			"sar word ptr [rax],1",
			"sar eax,1",
			"sar dword ptr [rax],1",
			"sar r8,1",
			"sar qword ptr [rax],1",
			"rol cl,cl",
			"rol byte ptr [rax],cl",
			"ror dl,cl",
			"ror byte ptr [rax],cl",
			"rcl bl,cl",
			"rcl byte ptr [rax],cl",
			"rcr ah,cl",
			"rcr byte ptr [rax],cl",
			"shl ch,cl",
			"shl byte ptr [rax],cl",
			"shr dh,cl",
			"shr byte ptr [rax],cl",
			"sar al,cl",
			"sar byte ptr [rax],cl",
			"rol cx,cl",
			"rol word ptr [rax],cl",
			"rol ecx,cl",
			"rol dword ptr [rax],cl",
			"rol rcx,cl",
			"rol qword ptr [rax],cl",
			"ror dx,cl",
			"ror word ptr [rax],cl",
			"ror edx,cl",
			"ror dword ptr [rax],cl",
			"ror rdx,cl",
			"ror qword ptr [rax],cl",
			"rcl bx,cl",
			"rcl word ptr [rax],cl",
			"rcl ebx,cl",
			"rcl dword ptr [rax],cl",
			"rcl rbx,cl",
			"rcl qword ptr [rax],cl",
			"rcr sp,cl",
			"rcr word ptr [rax],cl",
			"rcr esp,cl",
			"rcr dword ptr [rax],cl",
			"rcr rsp,cl",
			"rcr qword ptr [rax],cl",
			"shl bp,cl",
			"shl word ptr [rax],cl",
			"shl ebp,cl",
			"shl dword ptr [rax],cl",
			"shl rbp,cl",
			"shl qword ptr [rax],cl",
			"shr si,cl",
			"shr word ptr [rax],cl",
			"shr esi,cl",
			"shr dword ptr [rax],cl",
			"shr rsi,cl",
			"shr qword ptr [rax],cl",
			"sar ax,cl",
			"sar word ptr [rax],cl",
			"sar eax,cl",
			"sar dword ptr [rax],cl",
			"sar r8,cl",
			"sar qword ptr [rax],cl",
			"xlatb",
			"fadd dword ptr [rax]",
			"fmul dword ptr [rax]",
			"fcom dword ptr [rax]",
			"fcomp dword ptr [rax]",
			"fsub dword ptr [rax]",
			"fsubr dword ptr [rax]",
			"fdiv dword ptr [rax]",
			"fdivr dword ptr [rax]",
			"fadd st,st(3)",
			"fmul st,st(3)",
			"fcom st(3)",
			"fcomp st(3)",
			"fsub st,st(3)",
			"fsubr st,st(3)",
			"fdiv st,st(3)",
			"fdivr st,st(3)",
			"fld dword ptr [rax]",
			"fst dword ptr [rax]",
			"fstp dword ptr [rax]",
			"fldenv fpuenv14 ptr [rax]",
			"fldenv [rax]",
			"fldcw word ptr [rax]",
			"fnstenv fpuenv14 ptr [rax]",
			"fnstenv [rax]",
			"fnstcw word ptr [rax]",
			"fld st(3)",
			"fxch st(3)",
			"fnop",
			"fchs",
			"fabs",
			"ftst",
			"fxam",
			"fld1",
			"fldl2t",
			"fldl2e",
			"fldpi",
			"fldlg2",
			"fldln2",
			"fldz",
			"f2xm1",
			"fyl2x",
			"fptan",
			"fpatan",
			"fxtract",
			"fprem1",
			"fdecstp",
			"fincstp",
			"fprem",
			"fyl2xp1",
			"fsqrt",
			"fsincos",
			"frndint",
			"fscale",
			"fsin",
			"fcos",
			"fiadd dword ptr [rax]",
			"fimul dword ptr [rax]",
			"ficom dword ptr [rax]",
			"ficomp dword ptr [rax]",
			"fisub dword ptr [rax]",
			"fisubr dword ptr [rax]",
			"fidiv dword ptr [rax]",
			"fidivr dword ptr [rax]",
			"fcmovb st,st(3)",
			"fcmove st,st(3)",
			"fcmovbe st,st(3)",
			"fcmovu st,st(3)",
			"fucompp",
			"fild dword ptr [rax]",
			"fisttp dword ptr [rax]",
			"fist dword ptr [rax]",
			"fistp dword ptr [rax]",
			"fld tbyte ptr [rax]",
			"fstp tbyte ptr [rax]",
			"fcmovnb st,st(3)",
			"fcmovne st,st(3)",
			"fcmovnbe st,st(3)",
			"fcmovnu st,st(3)",
			"fnclex",
			"fninit",
			"fucomi st,st(3)",
			"fcomi st,st(3)",
			"fadd qword ptr [rax]",
			"fmul qword ptr [rax]",
			"fcom qword ptr [rax]",
			"fcomp qword ptr [rax]",
			"fsub qword ptr [rax]",
			"fsubr qword ptr [rax]",
			"fdiv qword ptr [rax]",
			"fdivr qword ptr [rax]",
			"fadd st(3),st",
			"fmul st(3),st",
			"fsubr st(3),st",
			"fsub st(3),st",
			"fdivr st(3),st",
			"fdiv st(3),st",
			"fld qword ptr [rax]",
			"fisttp qword ptr [rax]",
			"fst qword ptr [rax]",
			"fstp qword ptr [rax]",
			"frstor fpustate94 ptr [rax]",
			"frstor [rax]",
			"fnsave fpustate94 ptr [rax]",
			"fnsave [rax]",
			"fnstsw word ptr [rax]",
			"ffree st(3)",
			"fst st(3)",
			"fstp st(3)",
			"fucom st(3)",
			"fucomp st(3)",
			"fiadd word ptr [rax]",
			"fimul word ptr [rax]",
			"ficom word ptr [rax]",
			"ficomp word ptr [rax]",
			"fisub word ptr [rax]",
			"fisubr word ptr [rax]",
			"fidiv word ptr [rax]",
			"fidivr word ptr [rax]",
			"faddp st(3),st",
			"fmulp st(3),st",
			"fcompp",
			"fsubrp st(3),st",
			"fsubp st(3),st",
			"fdivrp st(3),st",
			"fdivp st(3),st",
			"fild word ptr [rax]",
			"fisttp word ptr [rax]",
			"fist word ptr [rax]",
			"fistp word ptr [rax]",
			"fbld tbyte ptr [rax]",
			"fild qword ptr [rax]",
			"fbstp tbyte ptr [rax]",
			"fistp qword ptr [rax]",
			"fnstsw ax",
			"fucomip st,st(3)",
			"fcomip st,st(3)",
			"loopned 800000000000004Dh",
			"loopne 800000000000004Ch",
			"looped 800000000000004Dh",
			"loope 800000000000004Ch",
			"loopd 800000000000004Dh",
			"loop 800000000000004Ch",
			"jecxz 800000000000004Dh",
			"jrcxz 800000000000004Ch",
			"in al,5Ah",
			"in ax,5Ah",
			"in eax,5Ah",
			"out 5Ah,al",
			"out 5Ah,ax",
			"out 5Ah,eax",
			"call 7FFFFFFFA55A3407h",
			"jmp near ptr 7FFFFFFFA55A3407h",
			"jmp short 800000000000004Ch",
			"in al,dx",
			"in ax,dx",
			"in eax,dx",
			"out dx,al",
			"out dx,ax",
			"out dx,eax",
			"int1",
			"hlt",
			"cmc",
			"test cl,5Ah",
			"test byte ptr [rax],5Ah",
			"not cl",
			"not byte ptr [rax]",
			"neg dh",
			"neg byte ptr [rax]",
			"mul ch",
			"mul byte ptr [rax]",
			"imul dh",
			"imul byte ptr [rax]",
			"div bh",
			"div byte ptr [rax]",
			"idiv al",
		};
	}
}
#endif
