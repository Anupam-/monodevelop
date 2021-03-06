﻿//
// UserInterfaceTest.cs
//
// Author:
//       Michael Hutchinson <m.j.hutchinson@gmail.com>
//
// Copyright (c) 2014 Xamarin Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using NUnit.Framework;
using MonoDevelop.Components.AutoTest;

namespace UserInterfaceTests
{
	[TestFixture]
	public abstract class UITestBase
	{
		public AutoTestClientSession Session {
			get { return TestService.Session; }
		}

		public string MonoDevelopBinPath { get; set; }

		public UITestBase () {}

		public UITestBase (string mdBinPath)
		{
			MonoDevelopBinPath = mdBinPath;
		}

		[SetUp]
		public virtual void SetUp ()
		{
			Util.ClearTmpDir ();

			TestService.StartSession (MonoDevelopBinPath);
		}

		[TearDown]
		public virtual void Teardown ()
		{
			TestService.EndSession ();
		}
	}
}
