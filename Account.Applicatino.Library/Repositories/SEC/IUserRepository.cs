﻿using Account.Application.Library.BaseService;
using Account.Application.Library.Models.DTOs.SEC;
using Account.Application.Library.Models.Views.SEC;
using Account.Domain.Library.Entities.SEC;

namespace Account.Application.Library.Repositories.SEC
{
    public interface IUserRepository : IGenericRepository<User, UserDTO, UserView>, IBaseQueries
    {

    }
}
