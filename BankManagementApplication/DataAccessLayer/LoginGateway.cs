using BusinessLayer.Model;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;
using System.Data;

namespace BusinessLayer.DataAccesLayer
{
    public class LoginGateway : GenericDataGateway<LoginUser>
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public override LoginUser Insert(LoginUser entity)
        {
            connection = new MySqlConnection("server = localhost; user id = mihai; password = mihai; persistsecurityinfo = True; database = bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            command = new MySqlCommand("INSERT INTO login_accounts(user,password,type) VALUES (@user,@password,@type)", connection);
            command.Parameters.AddWithValue("@user", entity.User);
            command.Parameters.AddWithValue("@password", entity.Password);
            command.Parameters.AddWithValue("@type", entity.Type);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }

        public override LoginUser Select(LoginUser entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }

            command = new MySqlCommand("SELECT * FROM login_accounts WHERE user = @user", connection);
            command.Parameters.AddWithValue("@user", entity.User);

            MySqlDataReader dataReader = command.ExecuteReader();

           
            if (!dataReader.Read())
            {
                return null;
            }
            return new LoginUser(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetString(2));
        }

        public override LoginUser Update(LoginUser entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            command = new MySqlCommand("UPDATE login_accounts SET password=@password,type=@type WHERE user = @user", connection);
            command.Parameters.AddWithValue("@password", entity.Password);
            command.Parameters.AddWithValue("@type", entity.Type);
            command.Parameters.AddWithValue("@user", entity.User);
            command.ExecuteNonQuery();
            connection.Close();

            return entity;
        }

        public override LoginUser Delete(LoginUser entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }

            command = new MySqlCommand("DELETE FROM login_accounts WHERE user = @user", connection);
            command.Parameters.AddWithValue("@user", entity.User);
            command.ExecuteNonQuery();
            connection.Close();
            return entity;
        }

        public override DataTable Find(LoginUser entity)
        {
            connection = new MySqlConnection("server=localhost;user id=mihai;password=mihai;persistsecurityinfo=True;database=bankdb");
            try
            {
                connection.Open();
            }
            catch
            {
                connection.Close();
                return null;
            }
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM login_accounts WHERE user = '" + entity.User + "'", "server = localhost; user id = mihai; password = mihai; persistsecurityinfo = True; database = bankdb");
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
