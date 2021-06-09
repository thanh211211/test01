//using Halliburton.App.Core.Entities;
//using Halliburton.App.Core.Interfaces;
//using Halliburton.App.Core.Resources;
//using Halliburton.App.Core.SharedKernel;
//using Halliburton.App.Infrastructure.Exension;
//using Microsoft.Extensions.Logging;
//using MongoDB.Bson;
//using MongoDB.Driver;
using Halliburton.App.Core.Interfaces;
using Halliburton.App.Core.SharedKernel;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Halliburton.App.Infrastructure.Repositories
{
    public abstract class Repository : IRepository
    {
        //private readonly IMongoDatabase _database = null;
        private readonly ILogger<Repository> _logger;

        public Repository(ILogger<Repository> logger)
        {
            _logger = logger;
            //_database = mongoClient?.GetDatabase(mongodb?.Client.Database);
            // Create indexes
            //Task.Run(async () => await CreateIndexs().ConfigureAwait(false));
        }

        public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            try
            {
                //var collection = _database.GetCollection<T>(typeof(T).Name.ToPluralNoun());
                //await collection.InsertOneAsync(entity).ConfigureAwait(false);
                //return new T();
            } catch (Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
            }
            return null;
        }

        public async Task AddManyAsync<T>(List<T> entityList) where T : BaseEntity
        {
            try 
            {
                //var collection = _database.GetCollection<T>(typeof(T).Name.ToPluralNoun());
                //await collection.InsertManyAsync(entityList).ConfigureAwait(false);
                //return await null;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
            }
        }

        public Task<List<T>> GetAllAsync<T>() where T : BaseEntity
        {
            //return new List<T>();
            return null;
        }

        public async Task<T> GetByIdAsync<T>(int id) where T : BaseEntity
        {
            try 
            { 
                //var collection = _database.GetCollection<T>(typeof(T).Name.ToPluralNoun());

                //var documents = await collection.FindAsync(new BsonDocument("_id", id));

                //var entity = await documents.FirstOrDefaultAsync();
                //if (entity?.IsDeleted == false && entity?.Id != null) return entity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
            }
            return null;
        }

        public async Task<IEnumerable<T>> GetByIdsAsync<T>(IEnumerable<int> ids) where T : BaseEntity
        {
            try
            {
                var collection = _database.GetCollection<T>(typeof(T).Name.ToPluralNoun());

                var filterDef = new FilterDefinitionBuilder<T>();

                var filter = filterDef.In(StringConstants.IdField, ids.Cast<ObjectId>().ToArray());

                var documents = await collection.FindAsync(filter);

                var docToList = await documents.ToListAsync();

                var filterDeleted = docToList.Where(r => r.IsDeleted == false);
                return filterDeleted;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message + "\n" + ex.StackTrace);
            }
            return null;
        }



    }
}