using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Documentos.Connection
{
    class SQLConnection
    {
        private static string programDirectoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        private static string configurationFileName = "/App.config.xml";
        
        private static SQLConnection connectionInstance = null;

        private SqlConnection connection = null;
        private string serverName;
        private string dataBaseName;
        private string user;
        private string password;

        public static SQLConnection getInstance() {
            if (connectionInstance == null)
                connectionInstance = new SQLConnection();
            return connectionInstance;
        }

        public SqlConnection getSqlConnection() {
            if (connection == null)
                connection = new SqlConnection(getConnectionString());
            openConnection();
            return connection;
        }

        private void openConnection() {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        private string getConnectionString() {
            return (string.Format(
                "Data Source={0};"+
                "Initial Catalog={1};"+
                "User ID={2};"+
                "Password={3};"+
                "Integrated Security=False;"+
                "Connect Timeout=7"
                , this.serverName,
                this.dataBaseName,
                this.user,
                this.password));
        }
        private SQLConnection() 
        {
            xmlConfiguration conf = new xmlConfiguration(getConfigurationFilePath());
            this.serverName = conf.getServerName();
            this.dataBaseName = conf.getDataBaseName();
            this.user = conf.getUserName();
            this.password = conf.getPassword();
        }

        private static string getConfigurationFilePath(){
            return Path.GetFullPath(programDirectoryPath + configurationFileName);
        }
        
    }
}
