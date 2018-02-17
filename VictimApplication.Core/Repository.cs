using VictimApplication.Core.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VictimApplication.Core
{
    public class Repository
    {
        private readonly SQLiteAsyncConnection connection;

        //Showing actual status
        public string StatusMessage { get; set; }

        public Repository(string dbPath)
        {
            connection = new SQLiteAsyncConnection(dbPath);
            connection.CreateTableAsync<User>();
        }

        public async Task CreateUser (User user)
        {
            try 
            {
                if (string.IsNullOrWhiteSpace(user.Login))
                {
                    throw new Exception("Login is Required!");
                }
                else if (string.IsNullOrWhiteSpace(user.Password))
                {
                    throw new Exception("Password is Required!");
                }
                else if (string.IsNullOrWhiteSpace(user.Name))
                {
                    throw new Exception("Name is Required!");
                }

                //Add user to database
                var result = await connection.InsertAsync(user).ConfigureAwait(continueOnCapturedContext: false);
                //Change Status Message to show actual state of program
                StatusMessage = $"Result: {result} ";

            }
            catch (Exception ex)
            {
                StatusMessage = $"Failed to create user. Error: {ex.Message}";
            }
        }

        public Task<List<User>> GetAllUsers()
        {
            return connection.Table<User>().ToListAsync();
        }
     }
}
