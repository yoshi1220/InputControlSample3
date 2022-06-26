using Dapper;
using InputControlSample.Data.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;

namespace InputControlSample.Repositories
{
    public class UserRepositoryDapper : IUserRepository
    {
        private string _connectionString;

        public UserRepositoryDapper()
        {
            _connectionString = ConfigurationManager.ConnectionStrings["sqlite"].ConnectionString;
        }

        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            using (IDbConnection db = new SQLiteConnection("Data Source=" + _connectionString))
            {
                db.Open();
                return db.Query<User>("SELECT * FROM Users", commandType: CommandType.Text);
            }
        }

        public void Remove(User entity)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }


        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity, int id)
        {
            throw new NotImplementedException();
        }
    }
}
