using Session_5___AsyncSql___Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Session_5___AsyncSql___DA
{
    public class PersonDA
    {
        string connString;

        public PersonDA()
        {
            connString = ConfigurationManager.ConnectionStrings["laptop"].ToString();
        }

        // CRUD - GetAllAsync
        public async Task<List<Person>> GetAllAsync()
        {
            List<Person> personList = new List<Person>();
            string command = "SELECT * FROM dbo.persons";
            using SqlConnection dbConn = new SqlConnection(connString);

            SqlCommand sqlCommand = new SqlCommand(command, dbConn);

            try
            {
                await dbConn.OpenAsync();

                using SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Person person = new Person();
                    person.Id = (int)reader["Id"];
                    person.FirstName = (string)reader["Firstname"];
                    person.LastName = (string)reader["Lastname"];
                    person.Address = (string)reader["Address"];
                    person.City = (string)reader["City"];
                    person.PostalCode = (int)reader["Postalcode"];
                    person.Email = (string)reader["Email"];
                    person.Phone = (int)reader["Phone"];

                    personList.Add(person);
                }

                return personList;
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return new List<Person>();
            }
            catch (InvalidOperationException invalidOpEx)
            {
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
                return new List<Person>();
            }
            catch (ConfigurationErrorsException configEx)
            {
                Console.WriteLine($"Configuration Error: {configEx.Message}");
                return new List<Person>();
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }

        // CRUD - GetOneAsync - bruges til søgefeldt
        public async Task<List<Person>> GetOneAsync(string searchTerm)
        {
            List<Person> persons = new List<Person>();
            string command = "SELECT * FROM dbo.persons WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm";

            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

            try
            {
                await dbConn.OpenAsync();
                using SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                while (await reader.ReadAsync())
                {
                    Person person = new Person
                    {
                        Id = (int)reader["Id"],
                        FirstName = (string)reader["Firstname"],
                        LastName = (string)reader["Lastname"],
                        Address = (string)reader["Address"],
                        City = (string)reader["City"],
                        PostalCode = (int)reader["Postalcode"],
                        Email = (string)reader["Email"],
                        Phone = (int)reader["Phone"]
                    };

                    persons.Add(person);
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");                
            }
            catch (InvalidOperationException invalidOpEx)
            {
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            return persons;
        }

        // CRUD - GetOneAsync
        public async Task<Person> GetOneAsync(int id)
        {
            Person person = null;
            string command = "SELECT * FROM dbo.persons WHERE Id = @Id";

            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            try
            {
                await dbConn.OpenAsync();
                using SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();
                if (await reader.ReadAsync())
                {
                    person = new Person
                    {
                        Id = (int)reader["Id"],
                        FirstName = (string)reader["Firstname"],
                        LastName = (string)reader["Lastname"],
                        Address = (string)reader["Address"],
                        City = (string)reader["City"],
                        PostalCode = (int)reader["Postalcode"],
                        Email = (string)reader["Email"],
                        Phone = (int)reader["Phone"]
                    };
                }
            }
            catch (SqlException sqlEx)
            {
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
            }
            catch (InvalidOperationException invalidOpEx)
            {
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
            finally
            {
                await dbConn.CloseAsync();
            }
            return person;
        }



        // CRUD - CreateAsync
        public async Task<bool> CreateAsync(Person person)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            using SqlCommand sqlCommand = new SqlCommand(
                  "INSERT INTO dbo.persons (Id, Firstname, Lastname, Address, City, Postalcode, Email, Phone) " +
    "               VALUES (@Id, @Firstname, @Lastname, @Address, @City, @Postalcode, @Email, @Phone)", dbConn
                );

            sqlCommand.Parameters.AddWithValue("@Id", person.Id);
            sqlCommand.Parameters.AddWithValue("@Firstname", person.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lastname", person.LastName);
            sqlCommand.Parameters.AddWithValue("@Address", person.Address);
            sqlCommand.Parameters.AddWithValue("@City", person.City);
            sqlCommand.Parameters.AddWithValue("@Postalcode", person.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Email", person.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", person.Phone);

            try
            {
                dbConn.Open();
                int result = await sqlCommand.ExecuteNonQueryAsync();
                if (result == 0)
                {
                    return false;
                }
                else 
                { 
                    return true;
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (InvalidOperationException invalidOpEx)
            {
                // Handle InvalidOperationException (e.g., connection already open)
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
                return false;
            }
            catch (ConfigurationErrorsException configEx)
            {
                // Handle configuration-related exceptions
                Console.WriteLine($"Configuration Error: {configEx.Message}");
                return false;
            }
            finally
            {
                await dbConn.CloseAsync();
            }
        }

        // CRUD - UpdateAsync
        public async Task<bool> UpdateAsync(Person person)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            string command = "UPDATE dbo.persons SET FirstName = @Firstname, LastName = @Lastname, Address = @Address, City = @City, PostalCode = @Postalcode, Email = @Email, Phone = @Phone WHERE Id = @Id";

            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", person.Id);
            sqlCommand.Parameters.AddWithValue("@Firstname", person.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lastname", person.LastName);
            sqlCommand.Parameters.AddWithValue("@Address", person.Address);
            sqlCommand.Parameters.AddWithValue("@City", person.City);
            sqlCommand.Parameters.AddWithValue("@Postalcode", person.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Email", person.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", person.Phone);

            try
            {
                await dbConn.OpenAsync();
                int rowAffected = await sqlCommand.ExecuteNonQueryAsync();               
                return rowAffected > 0;
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (InvalidOperationException invalidOpEx)
            {
                // Handle InvalidOperationException (e.g., connection already open)
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
                return false;
            }
            catch (ConfigurationErrorsException configEx)
            {
                // Handle configuration-related exceptions
                Console.WriteLine($"Configuration Error: {configEx.Message}");
                return false;
            }
            finally
            {
                // Always close the connection, even if an exception occurs
                await dbConn.CloseAsync();
            }
        }

        // CRUD - DeleteAsync
        public async Task<bool> DeleteAsync(int id)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            string command = "DELETE FROM dbo.persons WHERE id = @Id";
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);

            try
            {
                await dbConn.OpenAsync();
                int rowAffected = await sqlCommand.ExecuteNonQueryAsync();
                return rowAffected > 0;
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-related exceptions
                Console.WriteLine($"SQL Error: {sqlEx.Message}");
                return false;
            }
            catch (InvalidOperationException invalidOpEx)
            {
                // Handle InvalidOperationException (e.g., connection already open)
                Console.WriteLine($"Invalid Operation Error: {invalidOpEx.Message}");
                return false;
            }
            catch (ConfigurationErrorsException configEx)
            {
                // Handle configuration-related exceptions
                Console.WriteLine($"Configuration Error: {configEx.Message}");
                return false;
            }
            finally
            {
                // Always close the connection, even if an exception occurs
                await dbConn.CloseAsync();
            }
        }

        // FindNextId()
        public int FindNextId()
        {
            int nextId = 0;
            string command = "SELECT MAX(Id) FROM dbo.persons";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            dbConn.Open();
            object result = sqlCommand.ExecuteScalar();
            dbConn.Close();

            if (result != DBNull.Value)
            {
                nextId = Convert.ToInt32(result);
            }
            return nextId + 1;
        }

    }
}
