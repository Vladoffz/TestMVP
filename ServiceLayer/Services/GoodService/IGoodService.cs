using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Good;

namespace ServiceLayer.Services.GoodService
{
    public interface IGoodService
    {
        void ValidateModel(GoodModel goodModel);
    }
}
