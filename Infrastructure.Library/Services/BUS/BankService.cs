﻿using Dapper;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.Models.DTOs.BUS;
using Account.Infrastructure.Library.Patterns;
using Account.Infrastructure.Library.Repositories.BUS;

namespace Account.Infrastructure.Library.Services.BUS
{
    public class BankService : BankRepository
    {

        public BankService(IUnitOfWork<ContextDbApplication> unitOfWork) : base(unitOfWork)
        {
        }
        public (List<BankDTO>, List<CartDTO>) GetData()
        {
            try
            {
                var banks = new List<BankDTO>();
                var carts = new List<CartDTO>();
                var bankData = base.DapperServices.Query<BankDTO>("SELECT * FROM BUS.Banks",new
                {

                });
                var CartData = base.DapperServices.Query<CartDTO>("SELECT * FROM BUS.Carts",new
                {

                });
                banks.AddRange(bankData);
                carts.AddRange(CartData);
                return (banks, carts);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BankDTO GetBankByName(string name)
        {
            var result  = base.DapperServices.QueryFirstOrDefault<BankDTO>(@"
SELECT *
FROM BUS.Banks BN
WHERE BN.IsDeleted = 0
AND BN.IsActive = 1
AND BN.BankName LIKE @Name
", new
            {
                Name = name,
            });
            //base.Search(name);
            return result;
        }
       
    }
}
