using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Data
{
    public class Category:BaseEntity,IOrder
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string? Image { get; set; }
        public required string CategoryName { get; set; }
        public int? Order { get; set; }
    }  
}
