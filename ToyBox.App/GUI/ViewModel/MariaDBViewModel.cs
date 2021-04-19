using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.Windows;
using ToyBox.App.DB;

namespace ToyBox.App.GUI.ViewModel
{
    public class MariaDBViewModel : ViewModelBase
    {
        private ConnectionString connectionString = new ConnectionString();
        private MySqlConnection sqlConnection;

        public ConnectionString ConnectionString { get => connectionString; set { connectionString = value; RaisePropertyChanged(); } }

        public MySqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        public void DBSelectTestBtn_Clicked(object sender, EventArgs e)
        {
            ConnectDB(ConnectionString, out sqlConnection);
        }

        private static bool ConnectDB(ConnectionString connectionString, out MySqlConnection connection)
        {
            connection = new MySqlConnection(connectionString.ToString());
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}