using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TeaTime.Repository.Interface;

namespace TeaTime.Repository.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly IDbConnection _connection;
        public GenericRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var tableName = typeof(T).Name;
            var sql = $"SELECT * FROM {tableName}";
            return _connection.Query<T>(sql);
        }

        public async Task<T> GetById(int id)
        {
            var tableName = typeof(T).Name;
            var sql = $"SELECT * FROM {tableName} WHERE Id = @Id";
            return await _connection.QueryFirstOrDefaultAsync<T>(sql, new { Id = id });
        }

        public async Task<int> InsertAsync(T entity)
        {
            var tableName = typeof(T).Name;
            var sql = $"INSERT INTO {tableName} (/* columns */) VALUES (/* values */)"; // Update with actual columns and values
            return await _connection.ExecuteAsync(sql, entity);
        }

        public async Task<int> UpdateAsync(T entity)
        {
            var tableName = typeof(T).Name;
            var sql = $"UPDATE {tableName} SET /* columns = values */ WHERE Id = @Id"; // Update with actual columns and values
            return await _connection.ExecuteAsync(sql, entity);
        }

        public async Task<int> DeleteAsync(int id)
        {
            var tableName = typeof(T).Name;
            var sql = $"DELETE FROM {tableName} WHERE Id = @Id";
            return await _connection.ExecuteAsync(sql, new { Id = id });
        }
    }
}
