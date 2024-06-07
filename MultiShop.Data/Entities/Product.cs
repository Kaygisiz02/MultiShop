﻿namespace MultiShop.Data
{
    public class Product: BaseEntity
    {
        public int ProductID { get; set; }
        public required string ProductName { get; set; }
        public int CategoryID { get; set; }
        public decimal? Price { get; set; }
        public  decimal DistcountedPrice { get; set; }
        public int? StockQuantity { get; set; }
        public int? Order { get; set; }
        public string? Image { get; set; }
        public string? Description { get; set; }
    }  
}