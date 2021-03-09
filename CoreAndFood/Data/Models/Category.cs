using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName{ get; set; }
        public string CategoryDescription{ get; set; }

        public List<Food> Foods { get; set; }
    }
}
