﻿using MasteringEFCore.Concurrencies.Starter.Core.Commands;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace MasteringEFCore.Concurrencies.Starter.Infrastructure.Commands
{
    public class TransactionScope : ITransactionScope, IDisposable
    {
        // Flag: Has Dispose already been called?
        private bool disposed = false;
        public TransactionScope()
        {
            Transactions = new List<IDbContextTransaction>();
        }

        ~TransactionScope()
        {
            Dispose(false);
        }

        public List<IDbContextTransaction> Transactions { get; set; }

        public void Commit()
        {
            Transactions.ForEach(item =>
            {
                item.Commit();
            });
        }

        public void Rollback()
        {
            Transactions.ForEach(item =>
            {
                item.Rollback();
            });
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                // Free any other managed objects here.
                //
            }

            // Free any unmanaged objects here.
            //
            disposed = true;
        }
    }
}
