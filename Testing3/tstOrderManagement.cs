using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing3
{
    [TestClass]
    public class tstOrderManagement
    {
      
        [TestMethod]
        public void InstanceOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            Assert.IsNotNull(order);
        }

        [TestMethod]
        public void OrderIdPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            int testData = 1;
            order.OrderId = 1;
            Assert.AreEqual(order.OrderId, testData);
        }

        [TestMethod]
        public void ProductIdPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            string testData = 1.ToString();
            order.ProductId = 1.ToString();
            Assert.AreEqual(order.ProductId, testData);
        }


        [TestMethod]
        public void CustomerIdPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            string testData = 1.ToString();
            order.CustomerId = 1.ToString();
            Assert.AreEqual(order.CustomerId, testData);
        }

        [TestMethod]
        public void ProductQuantityPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            int testData = 14;
            order.ProductQuantity = 14;
            Assert.AreEqual(order.ProductQuantity, testData);
        }

        [TestMethod]
        public void StatusPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            string testData = "In progress";
            order.Status = testData;
            Assert.AreEqual(order.Status, testData);
        }

        [TestMethod]
        public void OrderDatePropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            DateTime testData = DateTime.Now.Date;
            order.OrderDate = testData;
            Assert.AreEqual(order.OrderDate, testData);
        }

        [TestMethod]
        public void IsCanceledPropertyOK()
        {
            clsOrderManagement order = new clsOrderManagement();
            bool testData = true;
            order.IsCanceled = true;
            Assert.AreEqual(order.IsCanceled, testData);
        }
    }
}
