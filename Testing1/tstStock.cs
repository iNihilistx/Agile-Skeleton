using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Testing1
{
    [TestClass]
    public class tstStock
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsStock aStock = new clsStock();
            Assert.IsNotNull(aStock);
        }
        [TestMethod]
        public void StockDescriptionPropertyOK()
        {
            clsStock astock = new clsStock();
            string TestData = "A smaller than usual ring";
            astock.ProductDescription = TestData;
            Assert.AreEqual(astock.ProductDescription, TestData);
        }
        [TestMethod]
        public void StockUploadedPropertyOK()
        {
            clsStock astock = new clsStock();
            // line below stops the date updating
            DateTime TestData = DateTime.Now.Date;
            astock.DateAdded = TestData;
            Assert.AreEqual(astock.DateAdded, TestData);
        }
        [TestMethod]
        public void AvailabilityyPropertyOk()
        {
            clsStock astock = new clsStock();
            Boolean TestData = true;
            astock.Available = true;
            Assert.AreEqual(astock.Available, TestData);
        }
        [TestMethod]
        public void StockAmountPropertyOK()
        {
            clsStock astock = new clsStock();
            Int32 TestData = 1;
            astock.StockAmount = TestData;
            Assert.AreEqual(astock.StockAmount, TestData);
        }
        [TestMethod]
        public void PricePropertyOK()
        {
            clsStock astock = new clsStock();
            decimal TestData = 1;
            astock.Price = TestData;
            Assert.AreEqual(astock.Price, TestData);
        }
        [TestMethod]
        public void ProductNamePropertyOK()
        {
            clsStock astock = new clsStock();
            string TestData = "Diamond Ring";
            astock.ProductName = TestData;
            Assert.AreEqual(astock.ProductName, TestData);
        }
    }
}
