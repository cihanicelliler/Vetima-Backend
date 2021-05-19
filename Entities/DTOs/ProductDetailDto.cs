using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class ProductDetailDto
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductName_EN { get; set; }
        public string CategoryName { get; set; }
        public string CategoryName_EN { get; set; }
        public string DescriptionProduct { get; set; }
        public string DescriptionProduct2 { get; set; }
        public string DescriptionProduct_EN { get; set; }
        public string DescriptionProduct2_EN { get; set; }
        public string ImagePath_1 { get; set; }
        public string ImagePath_2 { get; set; }
        public string ImagePath_3 { get; set; }
        public string ImagePath_4 { get; set; }
        public string ImagePath_5 { get; set; }
        public string ImagePath_6 { get; set; }
        public string ImagePath_7 { get; set; }
        public string ImagePath_8 { get; set; }
        public string ImagePath_9 { get; set; }
        public string ImagePath_10 { get; set; }
    }
}
