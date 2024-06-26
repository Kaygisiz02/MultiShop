﻿namespace MultiShop.Data
{
    public class Category: BaseEntity,IOrdered,IImage
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? Image { get; set; }
        public required string CategoryName { get; set; }
        public int? Order { get; set; }
    }  
}
