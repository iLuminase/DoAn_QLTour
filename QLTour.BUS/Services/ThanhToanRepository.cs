using System.Configuration;
using System.Data.SqlClient;

public class ThanhToanRepository
{
    private string connectionString;

    public ThanhToanRepository()
    {
        connectionString = ConfigurationManager.ConnectionStrings["ModelTourDB"].ConnectionString;
    }

    public int GetThanhToanCount()
    {
        int count = 0;
        string query = "SELECT COUNT(*) FROM ThanhToan"; // Thay 'ThanhToan' bằng tên bảng hóa đơn của bạn

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            count = (int)command.ExecuteScalar();
        }

        return count;
    }
}