﻿using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.BUS;
using Account.Application.Library.Models.Views.BUS;
using Account.Domain.Library.Entities.BUS;

namespace Account.Application.Library.Repositories.BUS
{
    public interface ICartRepository : IGenericRepository<Cart, CartDTO, CartView>, IBaseQueries
    {

    }
}
