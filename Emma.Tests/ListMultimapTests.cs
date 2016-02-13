using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Emma.impl;
using Emma.abs;

namespace Emma.Tests
{
    [TestClass]
    public class MultimapTests
    {
        [TestMethod]
        public void TestListMultimap()
        {
            var listmap = new ListMultimap<int, string>();
            listmap.Put(1, "hello");
            listmap.Put(1, "bonjour");
            listmap.Put(2, "goodbye");

            var records = listmap.Get(1);
            Assert.IsTrue(records.Count == 2);
            Assert.IsTrue(records.Contains("hello") && records.Contains("bonjour"));

            Assert.IsTrue(listmap.ContainsKey(1));
            Assert.IsFalse(listmap.ContainsKey(5));

            listmap.Remove(1);
            Assert.IsTrue(listmap.Count == 1);
            
        }
    }
}
