using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class ProductImages : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
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
        public DateTime Date { get; set; }
    }
}
