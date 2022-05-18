using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int CategoryId { get; set; }
        public bool IsTopDeal { get; set; }
        public string ImageUrl { get; set; }
        public bool InStock { get; set; }
        public Category Category { get; set; }
    }
}
