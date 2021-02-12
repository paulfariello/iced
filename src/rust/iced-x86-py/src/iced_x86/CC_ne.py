# SPDX-License-Identifier: MIT
# Copyright wtfsck@protonmail.com
# Copyright iced contributors

# ⚠️This file was generated by GENERATOR!🦹‍♂️

# pylint: disable=invalid-name
# pylint: disable=line-too-long
# pylint: disable=too-many-lines

"""
Mnemonic condition code selector (eg. ``JNE`` / ``JNZ``)
"""

from typing import List

NE: int = 0
"""
``JNE``, ``CMOVNE``, ``SETNE``, ``LOOPNE``, ``REPNE``
"""
NZ: int = 1
"""
``JNZ``, ``CMOVNZ``, ``SETNZ``, ``LOOPNZ``, ``REPNZ``
"""

__all__: List[str] = []
