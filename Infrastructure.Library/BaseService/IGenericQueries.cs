﻿using Infrastructure.Library.Models.Controls;

namespace Infrastructure.Library.BaseService
{
    public interface IGenericQueries
    {
        string GetCount();
        string ShowAll(string paging);
        string Search(string value);
        string ShowFromTo(string from, string to);
        IEnumerable<KeyValue<long>> TitleValue();
    }
}