﻿using System;
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
	public partial class BillForm : Form
	{
		public BillForm()
		{
			InitializeComponent();
		}

		private void BillForm_Load(object sender, EventArgs e)
		{

		}

		public void LoadBills()
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "SELECT [ID],[Name] as 'Tên hóa đơn',[TableID] as 'ID Bàn',[Amount] as 'Tổng tiền',[Discount] as 'Chiết khấu',[Tax] as 'Thuế',[Status] as 'Trạng thái',[CheckoutDate] as 'Ngày lập hóa đơn',[Account] as 'Người lập hóa đơn' FROM Bills";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvBills.DataSource = dt;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		public void LoadBills(string id)
		{
			// Tạo đối tượng kết nối
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "SELECT [ID],[Name] as 'Tên hóa đơn',[TableID] as 'ID Bàn',[Amount] as 'Tổng tiền',[Discount] as 'Chiết khấu',[Tax] as 'Thuế',[Status] as 'Trạng thái',[CheckoutDate] as 'Ngày lập hóa đơn',[Account] as 'Người lập hóa đơn' FROM Bills where [TableID] = " + id + "";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvBills.DataSource = dt;

			// đóng kết nối và giải phóng bộ nhớ
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void btnTim_Click(object sender, EventArgs e)
		{
			string connectionString = "server= DESKTOP-ONTGILH\\SQLEXPRESS; database = RestaurantManagement; InteGrated Security = true; ";
			SqlConnection sqlConnection = new SqlConnection(connectionString);

			// tạo đối tượng thực thi lệnh
			SqlCommand sqlCommand = sqlConnection.CreateCommand();

			sqlConnection.Open();

			sqlCommand.CommandText = "SELECT *" +
				 " FROM Bills WHERE CheckoutDate >= '" + dtpFrom.Value.ToString("MM/dd/yyyy") +
				 "' AND CheckoutDate <= '" + dtpTo.Value.ToString("MM/dd/yyyy") + "'";

			//Tạo đối tượng DataAdapter
			SqlDataAdapter da = new SqlDataAdapter(sqlCommand);

			// tạo datatable để chứa dữ liệu
			DataTable dt = new DataTable("Bills");
			da.Fill(dt);

			// Hiển thị danh sách món ăn lên form
			dgvBills.DataSource = dt;

			// Đóng cổng và giải phóng bộ nhớ 
			sqlConnection.Close();
			sqlConnection.Dispose();
			da.Dispose();
		}

		private void dgvBills_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridViewRow row = dgvBills.Rows[e.RowIndex];
			string BillID = row.Cells[0].Value.ToString();
			BillDetails frm = new BillDetails();
			frm.Show(this);
			frm.LoadBillDetails(BillID);
		}
	}
}
