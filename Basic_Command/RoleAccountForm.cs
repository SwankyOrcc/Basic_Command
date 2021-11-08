using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Command
{
	public partial class RoleAccountForm : Form
	{
		public RoleAccountForm()
		{
			InitializeComponent();
		}

		private void RoleAccountForm_Load(object sender, EventArgs e)
		{

		}

		public void LoadRoles(string accountName)
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "select A.AccountName as 'Tên tài khoản',A.FullName as 'Họ và tên',C.RoleName as 'Vai trò' from Account A, RoleAccount B,Role C " +
				 "where A.AccountName = B.AccountName and B.RoleID = C.ID and A.AccountName = N'" + accountName + "'";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Roles");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvRoles.DataSource = dt;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
