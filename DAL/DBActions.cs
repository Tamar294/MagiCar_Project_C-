using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DBActions
    {
        static string connString;
        IConfiguration config;

        public DBActions(IConfiguration config)
        {
            this.config = config;
        }
        public string GetConnectionString(string connStrNameInCnfig)
        {
            if (connString != null)
            {
                return connString;
            }
            string connStr = config.GetConnectionString(connStrNameInCnfig);
            Console.WriteLine("Connection String from GetConnectionString: " + connStr);
            Debug.WriteLine("Connection String from GetConnectionString: " + connStr);
            connStr = ReplaceWithCurrentLocation(connStr);
            Console.WriteLine("Connection String after ReplaceWithCurrentLocation: " + connStr);
            Debug.WriteLine("Connection String after ReplaceWithCurrentLocation: " + connStr);
            return connStr;
        }

        private string ReplaceWithCurrentLocation(string connStr)
        {
            //string str = AppDomain.CurrentDomain.BaseDirectory;
            //string directryAboveBin = str.Substring(0, str.IndexOf("\\bin"));
            //string twoDirectoriesAboveBin = directryAboveBin.Substring(0, directryAboveBin.LastIndexOf("\\"));
            //connStr = string.Format(connStr, twoDirectoriesAboveBin);
            //return connStr;
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine("Base Directory: " + baseDirectory);
            Debug.WriteLine("Base Directory: " + baseDirectory);

            // Adjust the logic to calculate the correct path
            string projectRootDirectory = baseDirectory.Substring(0, baseDirectory.IndexOf("\\bin"));
            Console.WriteLine("Project Root Directory: " + projectRootDirectory);
            Debug.WriteLine("Project Root Directory: " + projectRootDirectory);

            connStr = string.Format(connStr, projectRootDirectory);
            return connStr;
        }
    }
}
