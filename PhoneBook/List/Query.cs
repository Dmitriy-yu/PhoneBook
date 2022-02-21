using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PhoneBook.List
{
    class Query
    {
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter dataAdapter;
        DataTable bufferTable;
        public Query(string conn)
        {
            connection = new OleDbConnection(conn);
            bufferTable = new DataTable();

        }
        public DataTable UpdatePerson()
        {
            connection.Open();
           dataAdapter = new OleDbDataAdapter("Select * FROM Test2" , connection); 
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
          
        }

        public void Add(string FirstName, string LastName,string PhoneNumber,int Id)
        {
          connection.Open();
            command = new OleDbCommand("Insert  INTO Test2(FirstName,LastName,PhoneNumber,Id)Values(@FirstName,@LastName,PhoneNumber,Id)", connection);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("PhoneNumber", PhoneNumber);
           command.Parameters.AddWithValue("Id", Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Delete(int Id)
        {
            connection.Open();
            command = new OleDbCommand($"Delete FROM Test2 where Id={Id}", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Correct(int Id,string FirstName,string LastName,string PhoneNumber)
        {
            
        
        }


    }
}
