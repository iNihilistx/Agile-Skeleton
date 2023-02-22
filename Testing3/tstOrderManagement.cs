using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderManagement
    {
        [TestMethod]
        public void TestMethod1()
        {
           
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            Assert.IsNotNull(order);
        }

        
    }
}
