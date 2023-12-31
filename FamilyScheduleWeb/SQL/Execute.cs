﻿using Microsoft.Data.SqlClient;
using System.Data;

namespace FamilyScheduleWeb
{
    public class Execute
    {
        public static bool ExecuteStatementReturnBool(SqlConnection connection, string sqlStatement)
        {
            int count;
            bool success = false;
            using (var cnn = connection)
            {
                using (var command = new SqlCommand(sqlStatement, cnn))
                {
                    cnn.Open();
                    count = command.ExecuteNonQuery();
                }
            }
            if (count > 0)
            {
                success = true;
            }
            return success;
        }
        
        public static DataTable ExecuteSelectReturnDT(SqlConnection connection, string sqlStatement)
        {
            DataTable dt = new DataTable();
            using (var cnn = connection)
            {
                using (var command = new SqlCommand(sqlStatement, cnn))
                {
                    cnn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                }
            }
            return dt;
        }

    }
}
