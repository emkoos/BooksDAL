using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.Models;

namespace BooksDAL.Repos
{
    public class UserRepo : BaseRepo<User>, IRepo<User>
    {
        public int Add(User entity)
        {
            Context.Users.Add(entity);
            return SaveChanges();
        }

        public Task<int> AddAsync(User entity)
        {
            Context.Users.Add(entity);
            return SaveChangesAsync();
        }

        public int AddRange(IList<User> entities)
        {
            Context.Users.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<User> entities)
        {
            Context.Users.AddRange(entities);
            return SaveChangesAsync();
        }
        public int Save(User entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public Task<int> SaveAsync(User entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChangesAsync();
        }

        public int Delete(int id, byte[] timeStamp)
        {
            Context.Entry(new User()
            {
                UserId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(int id, byte[] timeStamp)
        {
            Context.Entry(new User()
            {
                UserId = id,
                Timestamp = timeStamp
            }).State = EntityState.Deleted;
            return SaveChangesAsync();
        }
        public int Delete(User entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public Task<int> DeleteAsync(User entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChangesAsync();
        }

        public User GetOne(int? id)
            => Context.Users.Find(id);

        public Task<User> GetOneAsync(int? id)
            => Context.Users.FindAsync(id);

        public List<User> GetAll()
            => Context.Users.ToList();

        public Task<List<User>> GetAllAsync()
            => Context.Users.ToListAsync();

        public List<User> ExecuteQuery(string sql)
            => Context.Users.SqlQuery(sql).ToList();

        public Task<List<User>> ExecuteQueryAsync(string sql)
            => Context.Users.SqlQuery(sql).ToListAsync();
        public List<User> ExecuteQuery(
            string sql, object[] sqlParametersObjects)
            => Context.Users.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<User>> ExecuteQueryAsync(
            string sql, object[] sqlParametersObjects)
            => Context.Users.SqlQuery(sql).ToListAsync();
    }
}
