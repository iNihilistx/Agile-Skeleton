﻿using System;

namespace Testing1
{
    public class clsStock
    {
        public DateTime DateAdded { get; internal set; }
        public bool Available { get; internal set; }
        public int StockAmount { get; internal set; }
        public decimal Price { get; internal set; }
        public string ProductName { get; internal set; }
        public string ProductDescription { get; internal set; }
    }
}