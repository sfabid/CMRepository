﻿using System;
using System.Threading.Tasks;

namespace CM.Application.DataAccess
{
    public interface IUnitOfWorkFactory
    {
        IUnitOfWork GetUnitOfWork();
    }


    public interface IUnitOfWork : IDisposable
    {
        IDocumentRepository DocumentMetaData { get; }
        IExceptionLogRepository Exceptions { get; set; }

        int SaveChanges();

        Task<int> SaveChangesAsync();
    }
}