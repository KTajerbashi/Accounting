﻿using Account.Domain.Library.Entities.BUS;
using Account.Application.Library.ApplicationContext.DatabaseContext;
using Account.Application.Library.BaseService;
using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Application.Library.Patterns;

namespace Account.Application.Library.Repositories.BUS
{
    public abstract class CustomerRepository : GenericRepository<Customer, CustomerDTO, CustomerView>, IBaseQueries
    {
        protected CustomerRepository(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        protected CustomerRepository(ContextDbApplication context)
          : base(context)
        {
        }
        public string GetCount()
        {
            return (@"
SELECT  COUNT(*)
FROM    BUS.Customers
WHERE   IsDeleted = 0
");
        }

        public string Search(string value)
        {
            return ("");
        }

        public string ShowAll(string paging)
        {
            return (@"
SELECT       
    ID AS آیدی, 
    FullName AS [نام کامل], 
    FORMAT(CreateDate,'yyyy-mm-dd','fa') AS [تاریخ ثبت], 
    UpdateDate AS [آخرین ویرایش],   
    CASE IsActive WHEN 1 THEN N'فعال' ELSE N'غیر فعال' END AS وضعیت,
    Picture AS نصویر
FROM            BUS.Customers
WHERE IsDeleted = 0
");
        }

        public string ShowFromTo(string from, string to)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<KeyValue<long>> TitleValue()
        {
            return Context.Customers.Where(x => !x.IsDeleted).Select(x => new KeyValue<long>
            {
                Key = x.FullName,
                Value = x.ID
            }).OrderByDescending(x => x.Key);
        }
    }
}
