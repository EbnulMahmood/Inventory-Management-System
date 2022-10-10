using InventoryManagementSystem.Application.IDaos;
using InventoryManagementSystem.Domain.Entities;
using NHibernate;

namespace InventoryManagementSystem.Infrastructure.Daos
{
    public class CategoryDao : ICategoryDao
    {
        private readonly ISession _session;
        private readonly ICriteria _criteria;

        public CategoryDao(ISession session)
        {
            _session = session;
            _criteria = _session.CreateCriteria<Category>();
        }

        public async Task<IEnumerable<Category>> LoadCategoriesAsync()
        {
            using var transaction = _session.BeginTransaction();
            string descOrderBy = "CreatedAt";
            try
            {
                IQuery sqlQuery = _session.CreateSQLQuery($"SELECT * FROM Categories " +
                    $"ORDER BY {descOrderBy} DESC")
                    .AddEntity(typeof(Category));

                IEnumerable<Category> entities = await sqlQuery.ListAsync<Category>();
                await transaction.CommitAsync();

                return entities;
            }
            catch
            {
                await transaction.RollbackAsync();
                throw new Exception();
            }
            finally
            {
                if (transaction != null)
                {
                    transaction.Dispose();
                }
            };
        }

        public Task<Category> GetCategoryByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
