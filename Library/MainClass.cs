using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    class MainClass
    {
        public static SqlConnection connection;
        public static MainForm form;
        public static void OpenConnection()
        {
            string connectionString = @"Data Source=.\; Initial Catalog = library; Integrated Security = True";

            connection = new SqlConnection(connectionString);
            connection.Open();
        }
        public static void CloseConnection()
        {
            connection.Close();
        }
        public static void AddGenre(string name)
        {
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = MainClass.connection;
            addCommand.CommandType = CommandType.Text;

            string sqlComm = String.Format("INSERT INTO [genres] Values ('{0}')", name);
                addCommand.CommandText = sqlComm;
            addCommand.ExecuteNonQuery();
            
        }
        public static void EditGenre(string name, int id)
        {
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = MainClass.connection;
            addCommand.CommandType = CommandType.Text;

            string sqlComm = String.Format("update [genres] set genre_name='{0}' where id_genre={1}", name,id);
            addCommand.CommandText = sqlComm;
            addCommand.ExecuteNonQuery();

        }
        public static void AddBook(string name, int genreId)
        {
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = MainClass.connection;
            addCommand.CommandType = CommandType.Text;

            string sqlComm = String.Format("INSERT INTO [books] Values ('{0}',{1})", name, genreId);
            addCommand.CommandText = sqlComm;
            addCommand.ExecuteNonQuery();
        }
        public static void EditBook(string name, int bookId)
        {
            SqlCommand addCommand = new SqlCommand();
            addCommand.Connection = MainClass.connection;
            addCommand.CommandType = CommandType.Text;

            string sqlComm = String.Format("update [books] set book_name='{0}' Where id_book={1}", name, bookId);
            addCommand.CommandText = sqlComm;
            addCommand.ExecuteNonQuery();
        }
    }
}
