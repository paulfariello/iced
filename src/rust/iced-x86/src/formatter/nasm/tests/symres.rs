// SPDX-License-Identifier: MIT
// Copyright (C) 2018-present iced project and contributors

use crate::formatter::nasm::tests::fmt_factory::create_resolver;
use crate::formatter::tests::sym_res::symbol_resolver_test;

#[test]
fn symres() {
	symbol_resolver_test("Nasm", "SymbolResolverTests", |symbol_resolver| create_resolver(symbol_resolver));
}
