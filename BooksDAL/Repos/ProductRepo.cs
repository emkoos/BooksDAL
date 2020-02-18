using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;
using BooksDAL.Repos;

namespace BooksDAL.Repos
{
    public class ProductRepo : BaseRepo<Product>, IRepo<Product>
    {
        public int Add(Product entity)
        {
            Context.Products.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(Product entity)
        {
            Context.Products.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<Product> entities)
        {
            Context.Products.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<Product> entities)
        {
            Context.Products.AddRange(entities);
            return SaveChangesAsync();
        }
        public int Save(Product entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(Product entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new Product()
            {
                ProductId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new Product()
            {
                ProductId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public int Delete(Product entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(Product entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public Product GetOne(int? id)
            => Context.Products.Find(id);

        public Task<Product> GetOneAsync(int? id)
            => Context.Products.FindAsync(id);

        public List<Product> GetAll()
            => Context.Products.ToList();

        public Task<List<Product>> GetAllAsync()
            => Context.Products.ToListAsync();

        public List<Product> ExecuteQuery(string sql)
            => Context.Products.SqlQuery(sql).ToList();

        public Task<List<Product>> ExecuteQueryAsync(string sql)
            => Context.Products.SqlQuery(sql).ToListAsync();
        public List<Product> ExecuteQuery(
            string sql, object[] sqlParametersObjects)
            => Context.Products.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<Product>> ExecuteQueryAsync(
            string sql, object[] sqlParametersObjects)
            => Context.Products.SqlQuery(sql).ToListAsync();

    }
}
