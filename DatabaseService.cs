using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RouteCicleRegistrationApp
{
    internal class DatabaseService
    {
        private readonly string connectionString = "Data Source=130.171.191.142;Initial Catalog=FIS;User Id=program_user;Password=praga;Persist Security Info=True;TrustServerCertificate=True;Connection Timeout=10";

        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(connectionString);
        }

        public ObservableCollection<Route> GetRoutesBuilding(string building)
        {
            ObservableCollection<Route> routes = new();
            SqlConnection sqlConnection = GetSqlConnection();
            try
            {
                sqlConnection.Open();

                string queryString = $"SELECT * FROM [PCL].[dbo].[VMR_Routes] WHERE building ='{building}'";
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Route route = new();
                    route.RouteName = reader["name"].ToString();
                    route.Id = (int)reader["id"];
                    routes.Add(route);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }

            return routes;
        }

        public void InsertRegister(Route route)
        {
            ObservableCollection<Route> routes = new();
            SqlConnection sqlConnection = GetSqlConnection();
            try
            {
                sqlConnection.Open();

                string queryString = $"INSERT INTO [PCL].[dbo].[VMR_Records] (route_id,date) VALUES({route.Id},GETDATE()); EXECUTE [PCL].[dbo].[VMR_BreaksToRegisters]";
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                command.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }
            finally
            {
                sqlConnection.Close();
            }
             
        }


    }
}
