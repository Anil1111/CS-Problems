﻿using Advanced.Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS.Problems.Tests.DynamicProgramming
{
    [TestClass]
    public class StringInterleaving_Tests
    {
        [TestMethod]
        public void StringInterleaving_Smoke_Test()
        {
            Assert.IsTrue(StringInterleaving.IsInterleaved("aabcc", "dbbca", "aadbbcbcac"));
            Assert.IsTrue(StringInterleaving.IsInterleaved( "XY", "WZ", "WZXY"));

            Assert.IsFalse(StringInterleaving.IsInterleaved("ccbaa", "dbbca", "aadbbcbcac"));
            Assert.IsFalse(StringInterleaving.IsInterleaved("YZ", "WZ", "WZXY"));
        }
    }
}
