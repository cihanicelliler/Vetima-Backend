using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public string DescriptionProduct { get; set; }
        public string DescriptionProduct2 { get; set; }
        public string ImagePath { get; set; }
    }
}
