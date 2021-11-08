using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Command
{
	public partial class AccountManager : Form
	{
		public AccountManager()
		{
			InitializeComponent();
		}

		private void AccountManager_Load(object sender, EventArgs e)
		{

		}

		public void LoadAccount()
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "select B.AccountName,B.FullName,B.Email,B.Tell,A.Actived,C.RoleName " +
				 " from RoleAccount A, Account B, Role C " +
				 " where A.AccountName = B.AccountName and C.ID= A.RoleID ";
			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Account");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvAccount.DataSource = dt;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}
	}
}
