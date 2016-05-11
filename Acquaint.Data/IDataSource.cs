﻿using System.Threading.Tasks;
using System.Collections.Generic;

namespace Acquaint.Data
{
    public interface IDataSource<T>
    {
        Task SaveItem(T item);
        Task DeleteItem(string id);
        Task<T> GetItem(string id);
        Task<ICollection<T>> GetItems(int start = 0, int count = 100, string query = "");
    }
}

