using System.Data.SqlClient;

namespace myDataBase
{
    internal class MySqlCommand
    {
        private string sqlSelectAll;
        private SqlConnection myCon;

        public MySqlCommand(string sqlSelectAll, SqlConnection myCon)
        {
            this.sqlSelectAll = sqlSelectAll;
            this.myCon = myCon;
        }
    }
}