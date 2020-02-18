using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;

namespace BooksDAL.Repos
{
    public class CartPositionRepo : BaseRepo<CartPosition>, IRepo<CartPosition>
    {
        public int Add(CartPosition entity)
        {
            Context.CartPosition.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(CartPosition entity)
        {
            Context.CartPosition.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<CartPosition> entities)
        {
            Context.CartPosition.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<CartPosition> entities)
        {
            Context.CartPosition.AddRange(entities);
            return SaveChangesAsync();
        }
        public int Save(CartPosition entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(CartPosition entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new CartPosition()
            {
                CartPostionId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new CartPosition()
            {
                CartPostionId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
        public int Delete(CartPosition entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(CartPosition entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public CartPosition GetOne(int? id)
            => Context.CartPosition.Find(id);

        public Task<CartPosition> GetOneAsync(int? id)
            => Context.CartPosition.FindAsync(id);

        public List<CartPosition> GetAll()
            => Context.CartPosition.ToList();

        public Task<List<CartPosition>> GetAllAsync()
            => Context.CartPosition.ToListAsync();

        public List<CartPosition> ExecuteQuery(string sql)
            => Context.CartPosition.SqlQuery(sql).ToList();

        public Task<List<CartPosition>> ExecuteQueryAsync(string sql)
            => Context.CartPosition.SqlQuery(sql).ToListAsync();
        public List<CartPosition> ExecuteQuery(
            string sql, object[] sqlParametersObjects)
            => Context.CartPosition.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<CartPosition>> ExecuteQueryAsync(
            string sql, object[] sqlParametersObjects)
            => Context.CartPosition.SqlQuery(sql).ToListAsync();
    }
}
