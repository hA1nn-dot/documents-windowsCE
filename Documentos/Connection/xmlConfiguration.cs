using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
namespace Documentos.Connection
{
    class xmlConfiguration
    {
        private string configurationFilePath;
        private string server;
        private string database;
        private string user;
        private string password;

        public xmlConfiguration(string path) {
            this.configurationFilePath = path;
            config();
        }

        public string getPassword() 
        {
            return password;
        }
        public string getUserName() 
        {
            return user;
        }
        public string getDataBaseName() 
        {
            return database;
        }
        public string getServerName(){
            return server;
        }


        private void config() 
        {
            try
            {

                XmlDocument doc = new XmlDocument();
                doc.Load(configurationFilePath);

                foreach (XmlNode node in doc.DocumentElement.ChildNodes)
                {
                    String id = node.Attributes["id"].Value;
                    if (node.HasChildNodes)
                    {
                        for (int i = 0; i < node.ChildNodes.Count; i++)
                        {
                            if (node.ChildNodes[i].Name == "server")
                            {
                                this.server = node.ChildNodes[i].InnerText;
                            }
                            if (node.ChildNodes[i].Name == "database")
                            {
                                this.database = node.ChildNodes[i].InnerText;
                            }
                            if (node.ChildNodes[i].Name == "user")
                            {
                                this.user = node.ChildNodes[i].InnerText;
                            }
                            if (node.ChildNodes[i].Name == "password")
                            {
                                this.password = node.ChildNodes[i].InnerText;
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException notfound)
            {
                throw notfound;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
