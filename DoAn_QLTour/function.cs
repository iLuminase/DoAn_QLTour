using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DuAnCuoiKy
{
    internal class Function
    {
        private string connectionString = "Data Source=_HEHENIKEN; Database=QuanLyTour; Integrated Security=True";

        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public DataSet GetData(string query)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            using (SqlDataAdapter da = new SqlDataAdapter(cmd))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
        }

        public void ExecuteQuery(string query, string message)
        {
            using (SqlConnection con = GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader GetDataReaderForCombo(string query)
        {
            SqlConnection con = GetConnection();
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
