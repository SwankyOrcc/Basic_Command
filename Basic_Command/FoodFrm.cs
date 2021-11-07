using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace Basic_Command
{
	public partial class FoodFrm : Form
	{
		public FoodFrm()
		{
			InitializeComponent();
		}

		private void FoodFrm_Load(object sender, EventArgs e)
		{

		}

		public void LoadFood(int categoryID)
		{
			//Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			//Tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			//Thiết lập lệnh truy vấn đối tượng Command
			sqlCommand.CommandText = "SELECT Name FROM Category where ID = " + categoryID;

			// Mở kết nối tới cơ sở dữ liệu
			sqlConnection.Open();

			//Gán tên nhóm sản phẩm cho tiêu đề
			string catName = sqlCommand.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + catName;

			sqlCommand.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			//Tạo Datatable để chứa dữ liệu
			DataTable dt = new DataTable("Food");
			da.Fill(dt);

			//Hiển thị danh sách món ăn lên Form
			dgvFood.DataSource = dt;

			//Đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				//Tạo đối tượng kết nối
				string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXEC [UpdateFood] @id ,@Name ,@Unit ,@FoodCategoryID ,@Price ,@Notes ";

				//thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);
				cmd.Parameters.Add("@name", SqlDbType.NVarChar,1000);
				cmd.Parameters.Add("@unit", SqlDbType.NVarChar,100);
				cmd.Parameters.Add("@foodCategoryId", SqlDbType.Int);
				cmd.Parameters.Add("@price", SqlDbType.Int);
				cmd.Parameters.Add("@notes", SqlDbType.NVarChar,3000);

				//if (dgvFood.SelectedRows.Count <= 0) return;
				DataGridViewRow dataGridViewRow = dgvFood.SelectedRows[0];
				cmd.Parameters["@id"].Value = dataGridViewRow.Cells[0].Value;
				cmd.Parameters["@name"].Value = dataGridViewRow.Cells[1].Value;
				cmd.Parameters["@unit"].Value = dataGridViewRow.Cells[2].Value;
				cmd.Parameters["@foodCategoryID"].Value = dataGridViewRow.Cells[3].Value;
				cmd.Parameters["@price"].Value = dataGridViewRow.Cells[4].Value;
				cmd.Parameters["@notes"].Value = dataGridViewRow.Cells[5].Value;
				//mở kết nối
				conn.Open();
				int numRowAffected = cmd.ExecuteNonQuery();

				//Thông báo kết quả
				if(numRowAffected>0)
				{
					//string foodID = cmd.Parameters["@id"].Value.ToString();
					MessageBox.Show("Successfully updating food", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Updating food failed");
				}

				//đóng kết nối
				conn.Close();
				conn.Dispose();
			}
			catch(SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch(Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			try
			{
				//Tạo đối tượng kết nối
				string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
				SqlConnection conn = new SqlConnection(connectionString);
				SqlCommand cmd = conn.CreateCommand();
				cmd.CommandText = "EXEC [DeleteFood] @id ";

				//thêm tham số vào đối tượng command
				cmd.Parameters.Add("@id", SqlDbType.Int);



				DataGridViewRow dataGridViewRow = dgvFood.SelectedRows[0];
				cmd.Parameters["@id"].Value = dataGridViewRow.Cells[0].Value;
				
				//mở kết nối
				conn.Open();
				int numRowAffected = cmd.ExecuteNonQuery();

				//Thông báo kết quả
				if (numRowAffected > 0)
				{
					//string foodID = cmd.Parameters["@id"].Value.ToString();
					MessageBox.Show("Successfully deleting food", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Deleting food failed");
				}

				//đóng kết nối
				conn.Close();
				conn.Dispose();
			}
			catch (SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}
	}
}
