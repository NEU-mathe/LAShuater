namespace xxdswinform.Utils
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    internal class SqlHelper
    {
        private static string connStr = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;

        public static DataTable ExecuteDataTable(string sql, params SqlParameter[] parameter)
        {
            DataTable table;
            DataSet dataSet = new DataSet();
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddRange(parameter);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);
                        table = dataSet.Tables[0];
                    }
                }
            }
            return table;
        }

        public static int ExecuteNonQuery(string sql, params SqlParameter[] parameter)
        {
            int num;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.Parameters.AddRange(parameter);
                    command.CommandText = sql;
                    connection.Open();
                    num = command.ExecuteNonQuery();
                }
            }
            return num;
        }

        public static object ExecuteSacalar(string sql, params SqlParameter[] parameter)
        {
            object obj2;
            using (SqlConnection connection = new SqlConnection(connStr))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    obj2 = command.ExecuteScalar();
                }
            }
            return obj2;
        }
    }
}

