﻿using MohamedRefaat_TechnicalTest.Domain.IRepository;
using MohamedRefaat_TechnicalTest.Infra.Data.Context;

namespace MohamedRefaat_TechnicalTest.Infra.Data.Repository
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly ApplicationDbContext _dbContext;
        public UnitOfWork(ApplicationDbContext db)
        {
            _dbContext = db;
            Repository = new RepositoryAsync<T>(_dbContext);
        }
        public IRepositoryAsync<T> Repository { get; private set; }
      
        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public async Task<bool> CommitAsync()
        {
                if (await _dbContext.SaveChangesAsync() >= 0)
                    return true;
                else
                    return false;
        }

      
        bool IUnitOfWork<T>.Commit()
        {
            try
            {
                if (_dbContext.SaveChanges() >= 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

    }
}
