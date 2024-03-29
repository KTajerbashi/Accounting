﻿using Account.Application.Library.Models.Controls;
using Account.Application.Library.Models.DTOs.SEC;
using Account.Application.Library.Models.Views.SEC;
using Account.Domain.Library.Entities.SEC;
using Account.Infrastructure.Library.ApplicationContext.DatabaseContext;
using Account.Infrastructure.Library.BaseService;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Account.Application.Library.Repositories.SEC
{
    public class RoleRepository : GenericRepository<Role, RoleDTO, RoleView>, IRoleRepository
    {
        public RoleRepository(ContextDbApplication context, IMapper mapper) : base(context, mapper)
        {
        }

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

        public IEnumerable<KeyValue<byte>> TitleValue()
        {
            throw new NotImplementedException();
        }
    }
}
