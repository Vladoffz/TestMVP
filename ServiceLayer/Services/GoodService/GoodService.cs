using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.Models.Good;

namespace ServiceLayer.Services.GoodService
{
    public class GoodService : IGoodService, IGoodRepository
    {
        private IGoodService _goodService;
        private IGoodRepository _goodRepository;

        public GoodService(IGoodService goodService, IGoodRepository goodRepository)
        {
            _goodService = goodService;
            _goodRepository = goodRepository;
        }

        public void ValidateModel(GoodModel goodModel)
        {
            throw new NotImplementedException();
        }

        public void Add(GoodModel goodModel)
        {
            throw new NotImplementedException();
        }

        public void Update(GoodModel goodModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(GoodModel goodModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<GoodModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public GoodModel Get(int GoodID)
        {
            throw new NotImplementedException();
        }
    }
}
