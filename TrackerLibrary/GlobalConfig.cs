using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.DataAccess;

namespace TrackerLibrary
{
    public static class GlobalConfig //cannot be instatiated; it's always visibla to anyone
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        //private set = any class inside GlobalConfig class can change the value of Connections
        //pulic get = everyone can read the Connections

        public static void InitializeConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Setup the SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
