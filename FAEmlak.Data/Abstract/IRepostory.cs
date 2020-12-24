﻿using System;
namespace FAEmlak.Data.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
