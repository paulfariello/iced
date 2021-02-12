# SPDX-License-Identifier: MIT
# Copyright wtfsck@protonmail.com
# Copyright iced contributors

# ⚠️This file was generated by GENERATOR!🦹‍♂️

# pylint: disable=invalid-name
# pylint: disable=line-too-long
# pylint: disable=too-many-lines

"""
Mnemonic condition code selector (eg. ``JAE`` / ``JNB`` / ``JNC``)
"""

from typing import List

AE: int = 0
"""
``JAE``, ``CMOVAE``, ``SETAE``
"""
NB: int = 1
"""
``JNB``, ``CMOVNB``, ``SETNB``
"""
NC: int = 2
"""
``JNC``, ``CMOVNC``, ``SETNC``
"""

__all__: List[str] = []
