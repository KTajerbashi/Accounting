﻿using Domain.Library.Entities.LOG;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.LOG;
using Infrastructure.Library.Models.Views.LOG;

namespace Infrastructure.Library.Repositories.LOG
{
    public abstract class CartLogRepository : GenericRepository<CartLog, CartLogDTO, CartLogView>, IGenericQueries
    {
        public string GetCount()
        {
            throw new NotImplementedException();
        }

        public string Search(string value)
        {
            throw new NotImplementedException();
        }

        public string ShowAll(string paging)
        {
            throw new NotImplementedException();
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }
    }
}
