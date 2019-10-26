using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicativo
{
    public class Conexao : IDisposable
    {

        public readonly IDbConnection _conexao;

        //IConfiguration config
        public Conexao()
        {
            //_conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\E.MENDES\DOCUMENTS\BANCODADOSAPP.MDF");
           _conexao = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\APIS\App.NET Core\BancodeDados\BancoDadosApp.mdf");
            //_conexao = new SqlConnection(config["connectionString"]);
            _conexao.Open();
        }
       

        public void Dispose()
        {
            _conexao.Close();
        }
    }
}
