// SPDX-License-Identifier: MIT
// Copyright wtfsck@protonmail.com
// Copyright iced contributors

use pyo3::exceptions::{PyTypeError, PyValueError};
use pyo3::prelude::*;
use pyo3::types::{PyByteArray, PyBytes};

/// Gets a ref to the bytes or an error. It assumes the input data is not modified
/// if it's mutable (eg. if it's a `bytearray`)
pub(crate) unsafe fn get_temporary_byte_array_ref(data: &PyAny) -> PyResult<&[u8]> {
	if let Ok(bytes) = <PyBytes as PyTryFrom>::try_from(data) {
		Ok(bytes.as_bytes())
	} else if let Ok(bytearray) = <PyByteArray as PyTryFrom>::try_from(data) {
		Ok(bytearray.as_bytes())
	} else {
		//TODO: support memoryview (also update docs and Decoder ctor and the message below)
		Err(PyTypeError::new_err("Expected one of these types: bytes, bytearray"))
	}
}

#[inline(never)]
pub(crate) fn to_value_error(error: iced_x86::IcedError) -> PyErr {
	PyValueError::new_err(format!("{}", error))
}
