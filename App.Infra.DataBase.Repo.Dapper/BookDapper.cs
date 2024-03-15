using App.Core;
using Dapper;
using Microsoft.Data.SqlClient;
using System.ComponentModel.Design;

namespace App.Infra.DataBase.Repo.Dapper
{
    public class BookDapper
    {
        public List<Book> GetBooks()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CW21;Integrated Security=True;TrustServerCertificate=True;";
            using var cn = new SqlConnection(connectionString);
            var sql = "Select * from dbo.books";
            var cmd = new CommandDefinition(sql);
            var result = cn.Query<Book>(cmd);
            return result.ToList();
        }

        public Book GetById(int id)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CW21;Integrated Security=True;TrustServerCertificate=True;";
            using var cn = new SqlConnection(connectionString);
            var sql = "Select * from dbo.books as b" +
                "Where b.Id = @Id ";
            var cmd = new CommandDefinition(sql, new { Id = id });
            var result = cn.QuerySingle<Book>(cmd);
            return result;
        }
    }
}
