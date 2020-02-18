using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BooksDAL.EF;

namespace BooksDAL.Repos
{
    public abstract class BaseRepo<T> : IDisposable where T:class,new()
    {
        public BooksEntities Context { get; } = new BooksEntities();
        protected DbSet<T> Table;

        public T GetOne(int? id) => Table.Find(id);
        public Task<T> GetOneAsync(int? id) => Table.FindAsync(id);
        public List<T> GetAll() => Table.ToList();
        public Task<List<T>> GettAllAsync() => Table.ToListAsync();

        public List<T> ExecuteQuery(string sql) => Table.SqlQuery(sql).ToList();
        public Task<List<T>> ExecuteQueryAsync(string sql)
            => Table.SqlQuery(sql).ToListAsync();
        public List<T> ExecuteQuery(string sql, object[] sqlParametersObjects)
            => Table.SqlQuery(sql, sqlParametersObjects).ToList();
        public Task<List<T>> ExecuteQueryAsync(string sql, object[] sqlParametersObjects)
            => Table.SqlQuery(sql).ToListAsync();

        public int Add(T entity)
        {
            Table.Add(entity);
            return SaveChanges();
        }

        public async Task<int> AddAsync(T entity)
        {
            Table.Add(entity);
            return await SaveChangesAsync();
        }

        public int AddRange(IList<T> entities)
        {
            Table.AddRange(entities);
            return SaveChanges();
        }
        public Task<int> AddRangeAsync(IList<T> entities)
        {
            Table.AddRange(entities);
            return SaveChangesAsync();
        }

        public int Save(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return SaveChanges();
        }

        public async Task<int> SaveAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
            return await SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public async Task<int> DeleteAsync(T entity)
        {
            Context.Entry(entity).State = EntityState.Deleted;
            return await SaveChangesAsync();
        }

        internal int SaveChanges()
        {
            try
            {
                return Context.SaveChanges();
            }
            catch(DbUpdateConcurrencyException ex)
            {
                //Concurrency error, throw exception
                throw;
            }
            catch(DbUpdateException ex)
            {
                //Database upgrade failed
                throw;
            }
            catch(CommitFailedException ex)
            {
                //Transaction-related errors
                throw;
            }
            catch(Exception ex)
            {
                //Other exceptions
                throw;
            }
        }

        internal async Task<int> SaveChangesAsync()
        {
            try
            {
                return await Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                //Concurrency error, throw exception
                throw;
            }
            catch (DbUpdateException ex)
            {
                //Database upgrade failed
                throw;
            }
            catch (CommitFailedException ex)
            {
                //Transaction-related errors
                throw;
            }
            catch (Exception ex)
            {
                //Other exceptions
                throw;
            }
        }
        
        bool _disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                Context.Dispose();
                // Free any managed objects here. 
            }

            // Free any unmanaged objects here. 
            _disposed = true;
        }
    }
}
