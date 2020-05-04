using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Good;

namespace ServiceLayer.Services.GoodService
{
    public interface IGoodRepository
    {
        void Add(GoodModel goodModel);
        void Update(GoodModel goodModel);
        void Delete(GoodModel goodModel);
        IEnumerable<GoodModel> GetAll();
        GoodModel Get(int GoodID);
    }
}
