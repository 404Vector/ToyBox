using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyBox.StdLib.Mvvm;

namespace ToyBox.App.DB
{
    /// <summary>
    /// Class for set connectionString with MariaDB
    /// * How to use
    ///  - input all property
    ///  - call .ToString() Method
    /// </summary>
    public class ConnectionString : NotifyPropertyChanged
    {
        private string iP = "127.0.0.1";
        private string port = "3306";
        private string database = "toyboxdb";
        private string userID = "admin";
        private string userPW = "admin";

        /// <summary>
        /// Server IP
        /// - default : "127.0.0.1"
        /// </summary>
        public virtual string IP { get => iP; set => OnPropertyChanged(ref iP, value); }

        /// <summary>
        /// Server port
        ///  - default : "3306"
        /// </summary>
        public virtual string Port { get => port; set => OnPropertyChanged(ref port, value); }

        /// <summary>
        /// Database name
        ///  - default : "toyboxdb"
        /// </summary>
        public virtual string Database { get => database; set => OnPropertyChanged(ref database, value); }

        /// <summary>
        /// UserID
        ///  - default : "admin"
        /// </summary>
        public virtual string UserID { get => userID; set => OnPropertyChanged(ref userID, value); }

        /// <summary>
        /// UserPW
        ///  - default : "admin"
        /// </summary>
        public virtual string UserPW { get => userPW; set => OnPropertyChanged(ref userPW, value); }

        /// <summary>
        /// This method has been overridden.
        /// You can call this method when you need a connection string for connecting the database.
        /// </summary>
        /// <returns>string ConnectionString</returns>
        public override string ToString()
        {
            return string.Format("Server={0};port={1};Database={2};Uid={3};Pwd={4}", IP, Port, Database, UserID, UserPW);
        }
    }
}