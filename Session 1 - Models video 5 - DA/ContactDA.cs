using Session_1___Models_video_5___Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Reflection.Metadata;

namespace Session_1___Models_video_5___DA
{
    public class ContactDA
    {
        string connString;

        private List<Contact> contacts;

        public ContactDA()
        {
            connString = ConfigurationManager.ConnectionStrings["home"].ToString();
        }

        //? Create()
        public bool Create(Contact contact)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            using SqlCommand sqlCommand = new SqlCommand
                (
                "INSERT INTO dbo.contacts (Id, FirstName, LastName) VALUES (@Id, @FirstName, @LastName)",
                dbConn
                );

            sqlCommand.Parameters.AddWithValue("@Id", contact.Id);
            sqlCommand.Parameters.AddWithValue("@FirstName", contact.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", contact.LastName);
            dbConn.Open();
            int res = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            if (res == 0) return false; return true;
        }

        //? GetAll() - returner alle contacts
        public List<Contact> GetAll()
        {
            List<Contact> peopleList = new List<Contact>();
            string command = "SELECT * FROM dbo.contacts"; 
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                Contact contact = new Contact();
                contact.Id = (int)reader["ID"];
                contact.FirstName = (string)reader["FirstName"];
                contact.LastName = (string)reader["LastName"]; 
                peopleList.Add(contact);
            }

            dbConn.Close();
            return peopleList;
        }

        //?GetOne - returner EN element
        public Contact GetOne(int id)
        {
            Contact contact = new Contact();

            string command = "SELECT * FROM dbo.contacts WHERE id = @ID";

            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(@command, dbConn);

            sqlCommand.Parameters.AddWithValue("@ID", id);

            dbConn.Open();
            using SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                contact.Id = (int)reader["ID"];
                contact.FirstName = (string)reader["FirstName"];
                contact.FirstName = (string)reader["LastName"];
            }
            dbConn.Close();
            return contact;
        }


        //? Update()     
        public bool Update(Contact contact)
        {
            using SqlConnection dbConn = new SqlConnection(connString);
            string command = "UPDATE dbo.contacts SET FirstName = @FirstName, LastName = @LastName WHERE ID = @ID";
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", contact.Id);
            sqlCommand.Parameters.AddWithValue("@FirstName", contact.FirstName);
            sqlCommand.Parameters.AddWithValue("@LastName", contact.LastName);
            dbConn.Open();
            int rowAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowAffected > 0;
        }

        //? Delete()
        public bool Delete(int id)
        {
            string command = "DELETE FROM dbo.contacts WHERE id = @ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlCommand = new SqlCommand(command, dbConn);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            dbConn.Open();
            int rowsAffected = sqlCommand.ExecuteNonQuery();
            dbConn.Close();
            return rowsAffected > 0;

        }

        //? FindNextId()
        int FindNextId()
        {
            int nextId = 0;
            foreach (var element in contacts)
            {
                if (element.Id > nextId)
                {
                    nextId = element.Id;
                }
            }
            return nextId + 1;
        }

    }

}
