using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.ISNotNull(aStock);
        }
    }
}
