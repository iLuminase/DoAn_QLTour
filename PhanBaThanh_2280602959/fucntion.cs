using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System;

public class function
{
    private string connectionString = "Data Source=ADMIN-PC\\SQL; Database=QuanLyTour; Integrated Security=True";

    // Đổi protected thành public
    public SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    public DataSet getData(string query)
    {
        using (SqlConnection con = GetConnection())
        {
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }

    public void setData(string query, string message)
    {
        using (SqlConnection con = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(query, con))
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }

        MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    public SqlDataReader getForCombo(string query)
    {
        SqlConnection con = GetConnection();
        SqlCommand cmd = new SqlCommand(query, con);
        con.Open();
        return cmd.ExecuteReader(CommandBehavior.CloseConnection);
    }
}
