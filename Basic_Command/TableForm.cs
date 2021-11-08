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
	public partial class TableForm : Form
	{
		public TableForm()
		{
			InitializeComponent();
		}

		private void TableForm_Load(object sender, EventArgs e)
		{

		}

		public void LoadTable()
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "select* from [Table]";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Tables");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvTable.DataSource = dt;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void thêmBanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddTable frm = new AddTable();
			if (frm.ShowDialog() == DialogResult.OK)
			{
				this.LoadTable();
			}
		}

		private void xoaBanToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvTable.Rows.Count > 0)
			{
				DataGridViewRow row = dgvTable.SelectedRows[0];
				string id = row.Cells[0].Value.ToString();

				// Tạo đối tượng kết nối
				string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
				SqlConnection sqlConnection = new SqlConnection(connectionString);

				// tạo đối tượng thực thi lệnh
				SqlCommand sqlCommand = sqlConnection.CreateCommand();

				sqlConnection.Open();

				sqlCommand.CommandText = "delete from [Table] where [ID] = " + id;

				int numOfRowEffered = sqlCommand.ExecuteNonQuery();

				if (numOfRowEffered == 1)
				{
					MessageBox.Show("Xóa bàn thành cônng");
					this.LoadTable();
				}
				else
				{
					MessageBox.Show("Xóa bàn thất bại");
				}

				sqlConnection.Close();
				sqlConnection.Dispose();
			}
		}

		private void xemDanhMucHoaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (dgvTable.Rows.Count > 0)
			{
				DataGridViewRow row = dgvTable.SelectedRows[0];
				string id = row.Cells[0].Value.ToString();
				BillForm frm = new BillForm();
				frm.Show(this);
				frm.LoadBills(id);
			}
		}
	}
}
