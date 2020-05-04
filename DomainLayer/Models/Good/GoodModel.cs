using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Good
{
    public class GoodModel
    {
        public int GoodID { get; set; }
        public string GoodType { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

    }
}
