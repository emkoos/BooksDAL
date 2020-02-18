using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;

namespace BooksDAL.Repos
{
    public class OrderPositionRepo : BaseRepo<OrderPosition>, IRepo<OrderPosition>
    {
        public int Add(OrderPosition entity)
        {
            Context.OrderPosition.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(OrderPosition entity)
        {
            Context.OrderPosition.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<OrderPosition> entities)
        {
            Context.OrderPosition.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<OrderPosition> entities)
        {
            Context.OrderPosition.AddRange(entities);
            return SaveChangesAsync();
        }
        public int Save(OrderPosition entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(OrderPosition entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new OrderPosition()
            {
                OrderPositionId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new OrderPosition()
            {
                OrderPositionId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
        public int Delete(OrderPosition entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(OrderPosition entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public OrderPosition GetOne(int? id)
            => Context.OrderPosition.Find(id);

        public Task<OrderPosition> GetOneAsync(int? id)
            => Context.OrderPosition.FindAsync(id);

        public List<OrderPosition> GetAll()
            => Context.OrderPosition.ToList();

        public Task<List<OrderPosition>> GetAllAsync()
            => Context.OrderPosition.ToListAsync();

        public List<OrderPosition> ExecuteQuery(string sql)
            => Context.OrderPosition.SqlQuery(sql).ToList();

        public Task<List<OrderPosition>> ExecuteQueryAsync(string sql)
            => Context.OrderPosition.SqlQuery(sql).ToListAsync();
        public List<OrderPosition> ExecuteQuery(
            string sql, object[] sqlParametersObjects)
            => Context.OrderPosition.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<OrderPosition>> ExecuteQueryAsync(
            string sql, object[] sqlParametersObjects)
            => Context.OrderPosition.SqlQuery(sql).ToListAsync();
    }
}
