﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models.Good
{
    interface IGoodModel
    { 
        string GoodType { get; set; }
       int Weight { get; set; }
       int Height { get; set; }
       int Width { get; set; }

    }
}
