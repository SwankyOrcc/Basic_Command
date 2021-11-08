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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			//Tạo chuỗi kết nối với Dữ liệu
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";

			//Tạo đối tượng kết nối
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn cho đối tượng Command
			string query = "SELECT ID, Name, Type FROM Category";

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			sqlCommand.CommandText = query;
			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			//Gọi hàm hiển thị dữ liệu lên màn hình
			this.DisplayCategory(sqlDataReader);

			//Đóng kết nối
			sqlConnection.Close();
		}

		private void DisplayCategory(SqlDataReader reader)
		{
			lvCategory.Items.Clear();
			while(reader.Read())
			{
				// Tạo một dòng mới trong list view
				ListViewItem item = new ListViewItem(reader["ID"].ToString());

				//Thêm dòng mới vào Listview
				lvCategory.Items.Add(item);

				//Bổ sung các thông tin khác cho ListViewItem
				item.SubItems.Add(reader["Name"].ToString());
				item.SubItems.Add(reader["Type"].ToString());
			}
		}

		private void btnThem_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn đối tượng cho command
			sqlCommand.CommandText = "INSERT INTO Category(Name,[Type])" + "VALUES (N'" + txtCategoryName.Text + "'," + txtType.Text + ")";

			//Mở kết nối tới dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương pháp ExcuteReader
			
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối 
			sqlConnection.Close();

			if(numOfRowsEffected==1)
			{
				MessageBox.Show("Thêm nhóm món ăn thành công");
				//Tải lại dữ liệu
				btnLoad.PerformClick();

				//Xoá các ô nhập
				txtCategoryName.Text = "";
				txtType.Text = "";
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra vui lòng thử lại");
			}

		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			//Lấy dòng được chọn trong Listview
			ListViewItem item = lvCategory.SelectedItems[0];

			//Hiển thị dữ liệu trên Textbox
			txtID.Text = item.Text;
			txtCategoryName.Text = item.SubItems[1].Text;
			txtType.Text = item.SubItems[1].Text == "0" ? "Thức uống" : "Đồ ăn";

			//Hiển thị nút cập nhật và xoá
			btnCapNhat.Enabled = true;
			btnXoa.Enabled = true;
		}

		private void btnCapNhat_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn cho đối tượng
			sqlCommand.CommandText = "UPDATE Category SET Name = N'" + txtCategoryName.Text + "', [Type] = " + txtType.Text + " WHERE ID = " + txtID.Text;

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương thức ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if(numOfRowsEffected==1)
			{
				//Cập nhật dữ liệu trên Listview
				ListViewItem item = lvCategory.SelectedItems[0];

				item.SubItems[1].Text = txtCategoryName.Text;
				item.SubItems[2].Text = txtType.Text;

				//Xoá các ô nhập
				txtID.Text = "";
				txtCategoryName.Text = "";
				txtType.Text = "";

				//Disable các nút xoá và cập nhật
				btnCapNhat.Enabled = false;
				btnXoa.Enabled = false;

				MessageBox.Show("Cập nhật món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void btnXoa_Click(object sender, EventArgs e)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn đối tượng command
			sqlCommand.CommandText = "DELETE FROM Category " + "WHERE ID = " + txtID.Text;

			//Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Thực thi lệnh bằng phương pháp ExcuteReader
			int numOfRowsEffected = sqlCommand.ExecuteNonQuery();

			//Đóng kết nối
			sqlConnection.Close();

			if(numOfRowsEffected==1)
			{
				//Cập nhật lại dữ liệu trên Listview
				ListViewItem item = lvCategory.SelectedItems[0];
				lvCategory.Items.Remove(item);

				//Xoá các ô nhập
				txtID.Text = "";
				txtCategoryName.Text = "";
				txtType.Text = "";

				//Disable các nút xoá và cập nhật
				btnCapNhat.Enabled = false;
				btnXoa.Enabled = false;

				MessageBox.Show("Xoá nhóm món ăn thành công");
			}
			else
			{
				MessageBox.Show("Đã có lỗi xảy ra. Vui lòng thử lại");
			}
		}

		private void tsmDelete_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
				btnXoa.PerformClick();
		}

		private void tsmViewFood_Click(object sender, EventArgs e)
		{
			if(txtID.Text !="")
			{
				FoodFrm foodFrm = new FoodFrm();
				foodFrm.Show(this);
				foodFrm.LoadFood(Convert.ToInt32(txtID.Text));
			}
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			BillForm billfrm = new BillForm();
			billfrm.Show();
			billfrm.LoadBills();
		}

		private void xemBanToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void tableToolStripMenuItem_Click(object sender, EventArgs e)
		{
			TableForm frm = new TableForm();
			frm.Show(this);
			frm.LoadTable();
		}

		private void accountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AccountManager frm = new AccountManager();
			frm.Show(this);
			frm.LoadAccount();
		}

		private void billsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			BillForm billForm = new BillForm();
			billForm.Show(this);
			billForm.LoadBills();
		}
	}
}
