﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Aborted11
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            foo();
        }
        public void foo()
        {
            foo();
        }
    }
}
