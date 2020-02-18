using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;

namespace BooksDAL.Repos
{
    public class CategoryRepo : BaseRepo<Category>, IRepo<Category>
    {
        public int Add(Category entity)
        {
            Context.Categories.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(Category entity)
        {
            Context.Categories.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<Category> entities)
        {
            Context.Categories.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<Category> entities)
        {
            Context.Categories.AddRange(entities);
            return SaveChangesAsync();
        }
        public int Save(Category entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(Category entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new Category()
            {
                CategoryId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new Category()
            {
                CategoryId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
        public int Delete(Category entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(Category entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Category GetOne(int? id)
            => Context.Categories.Find(id);

        public Task<Category> GetOneAsync(int? id)
            => Context.Categories.FindAsync(id);

        public List<Category> GetAll()
            => Context.Categories.ToList();

        public Task<List<Category>> GetAllAsync()
            => Context.Categories.ToListAsync();

        public List<Category> ExecuteQuery(string sql)
            => Context.Categories.SqlQuery(sql).ToList();

        public Task<List<Category>> ExecuteQueryAsync(string sql)
            => Context.Categories.SqlQuery(sql).ToListAsync();
        public List<Category> ExecuteQuery(
            string sql, object[] sqlParametersObjects)
            => Context.Categories.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<Category>> ExecuteQueryAsync(
            string sql, object[] sqlParametersObjects)
            => Context.Categories.SqlQuery(sql).ToListAsync();
    }
}
