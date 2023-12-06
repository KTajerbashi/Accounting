﻿using Domain.Library.Entities.RPT;
using Infrastructure.Library.BaseService;
using Infrastructure.Library.Models.DTOs.RPT;
using Infrastructure.Library.Models.Views.RPT;

namespace Infrastructure.Library.Repositories.RPT
{
    public abstract class CartReportRepository : GenericRepository<CartReport, CartReportDTO, CartReportView>, IGenericQueries
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
