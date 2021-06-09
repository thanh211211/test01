using Halliburton.App.Core.SharedKernel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Halliburton.App.Core.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        //Task<T> AddAsync<T>(T entity) where T : BaseEntity;
        //Task<IEnumerable<T>> AddManyAsync<T>(List<T> entityList) where T : BaseEntity;

        //Task<bool> UpdateAsync<T>(T entity) where T : BaseEntity;
        //Task<bool> UpdateManyAsync<T>(List<T> entityList) where T : BaseEntity;

        //Task<List<T>> GetAllAsync<T>() where T : BaseEntity;
        //Task<T> GetByIdAsync<T>(int id) where T : BaseEntity;

        List<T> GetAllAsync<T>() where T : BaseEntity;
        T GetByIdAsync<T>(int id) where T : BaseEntity;

        //Task<IEnumerable<T>> GetByIdsAsync<T>(IEnumerable<int> ids) where T : BaseEntity;

        //Task<bool> DeleteAsync<T>(int id) where T : BaseEntity;
        //Task<bool> DeleteManyAsync<T>();
        //Task<bool> DeleteManyByGivenIdFieldAsync<T>(string fieldName, int id) where T : BaseEntity;

        //Task<List<T>> FindAsync<T>(Expression<Func<T, bool>> filter, string orderBy, bool ascending) where T : BaseEntity;
        //Task<T> FindOneOrDefaultAsync<T>(Expression<Func<T, bool>> filter) where T : BaseEntity;
    }
}
