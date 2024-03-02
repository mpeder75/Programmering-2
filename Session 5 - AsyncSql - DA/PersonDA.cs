using Session_5___AsyncSql___Models;
using System.Configuration;
using System.Data.SqlClient;

namespace Session_5___AsyncSql___DA
{
    public class PersonDA
    {

        string connString;

        public PersonDA()
        {
            connString = ConfigurationManager.ConnectionStrings["home"].ToString();
        }

        // CRUD - GEetAll
        public List<Person> GetAll()
        {
            List<Person> personList = new List<Person>();
            string command = "SELECT * FROM persons";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);                 
            dbConn.Open();

            using SqlDataReader reader = sqlCommand.ExecuteReader();            
            while(reader.Read())
            {
                Person person = new Person();
                person.Id = (int)reader["Id"];
                person.FirstName = (string)reader["Firstname"];
                person.LastName = (string)reader["Lastname"];
                person.Address = (string)reader["Address"];
                person.PostalCode = (int)reader["Postalcode"];
                person.Email = (string)reader["Email"];
                person.Phone = (int)reader["Phone"];
            }
            dbConn.Close();
            return personList;         
        }

        // CRUD - GetOne
        public Person GetOne(int id)
        {
            Person person = new Person();
            string command = "SELECT * FROM persons WHERE Id=@Id";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand( command, dbConn);

            sqlCommand.Parameters.AddWithValue("@Id", id);
            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while(reader.Read())
            {
                person.Id = (int)reader["Id"];
                person.FirstName = (string)reader["Firstname"];
                person.LastName = (string)reader["Lastname"];
                person.Address = (string)reader["Address"];
                person.PostalCode = (int)reader["Postalcode"];
                person.Email = (string)reader["Email"];
                person.Phone = (int)reader["Phone"];
            }

            dbConn.Close();
            return person;
        }

        // CRUD - Create
        public bool Create(Person person)
        {
            using SqlConnection dbConn = new SqlConnection( connString);
            using SqlCommand sqlCommand = new SqlCommand
                (
                "INSERT INTO persons (Id, Firstname, Lastname, Address, City, Postalcode, Email, Phone)", dbConn
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
            }
            catch (Exception)
            {
                return false;
            }

            int result = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            if (result == 0) return false; return true;
        }

        // CRUD - Update
        public bool Update(Person person) 
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            string command = "UPDATE dbo.persons SET FirstName = @Firstname, LastName = @Lastname, Address = @Address, City = @City, PostalCode = @Postalcode, Email = @Email, Phone = @Phone";

            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", person.Id);
            sqlCommand.Parameters.AddWithValue("@Firstname", person.FirstName);
            sqlCommand.Parameters.AddWithValue("@Lastname", person.LastName);
            sqlCommand.Parameters.AddWithValue("@Address", person.Address);
            sqlCommand.Parameters.AddWithValue("@City", person.City);
            sqlCommand.Parameters.AddWithValue("@Postalcode", person.PostalCode);
            sqlCommand.Parameters.AddWithValue("@Email", person.Email);
            sqlCommand.Parameters.AddWithValue("@Phone", person.Phone);

            dbConn.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowAffected > 0;
        }

        // CRUD - Delete
        public bool Delete(int id) 
        {
            string command = "DELETE FROM dbo.persons WHERE id = @Id";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@Id", id);
            dbConn.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowAffected > 0;
        }
    }
}
