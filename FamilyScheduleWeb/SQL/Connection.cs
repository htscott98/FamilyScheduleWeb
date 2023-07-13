using Microsoft.Data.SqlClient;

namespace FamilyScheduleWeb
{
    public class Connection
    {

        public static SqlConnection InitDBConnection()
        {
            return new SqlConnection("Server=192.185.6.102; Database=hoverhub_PRD; User Id=hoverhub_Admin; Password=Aintn0sucka!; Encrypt=false;");
        }

    }
}
