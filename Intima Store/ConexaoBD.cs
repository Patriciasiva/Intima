using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Intima_Store
{
    public static class ConexaoBD
    {
        private static string _connectionString = 
            "Server=localhost;Port=3306;Database=pdv;Uid=root;Pwd=Info@2025";
        
        private static MySqlConnection _connection;

        public static MySqlConnection GetConnection()
        {
            if (_connection == null)
                _connection = new MySqlConnection(_connectionString);

            return _connection;
        }
    }
}
        
        
        
    }
} 
     

    

