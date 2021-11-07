
namespace Basic_Command
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnLoad = new System.Windows.Forms.Button();
			this.lvCategory = new System.Windows.Forms.ListView();
			this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btnThem = new System.Windows.Forms.Button();
			this.btnCapNhat = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtID = new System.Windows.Forms.TextBox();
			this.txtCategoryName = new System.Windows.Forms.TextBox();
			this.txtType = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDelete = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmViewFood = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(12, 182);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(148, 37);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Lấy danh sách";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// lvCategory
			// 
			this.lvCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chName,
            this.chType});
			this.lvCategory.ContextMenuStrip = this.contextMenuStrip1;
			this.lvCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvCategory.FullRowSelect = true;
			this.lvCategory.HideSelection = false;
			this.lvCategory.Location = new System.Drawing.Point(12, 237);
			this.lvCategory.MultiSelect = false;
			this.lvCategory.Name = "lvCategory";
			this.lvCategory.Size = new System.Drawing.Size(776, 316);
			this.lvCategory.TabIndex = 1;
			this.lvCategory.UseCompatibleStateImageBehavior = false;
			this.lvCategory.View = System.Windows.Forms.View.Details;
			this.lvCategory.Click += new System.EventHandler(this.lvCategory_Click);
			// 
			// chID
			// 
			this.chID.Text = "Mã loại";
			this.chID.Width = 103;
			// 
			// chName
			// 
			this.chName.Text = "Tên món ăn";
			this.chName.Width = 291;
			// 
			// chType
			// 
			this.chType.Text = "Loại";
			this.chType.Width = 518;
			// 
			// btnThem
			// 
			this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(311, 182);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(148, 37);
			this.btnThem.TabIndex = 2;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = true;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnCapNhat
			// 
			this.btnCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCapNhat.Location = new System.Drawing.Point(475, 182);
			this.btnCapNhat.Name = "btnCapNhat";
			this.btnCapNhat.Size = new System.Drawing.Size(148, 37);
			this.btnCapNhat.TabIndex = 3;
			this.btnCapNhat.Text = "Cập nhật";
			this.btnCapNhat.UseVisualStyleBackColor = true;
			this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
			// 
			// btnXoa
			// 
			this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(640, 182);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(148, 37);
			this.btnXoa.TabIndex = 4;
			this.btnXoa.Text = "Xoá";
			this.btnXoa.UseVisualStyleBackColor = true;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(38, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 17);
			this.label1.TabIndex = 5;
			this.label1.Text = "Mã nhóm";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(38, 57);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(123, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Tên nhóm thức ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(38, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "Loại";
			// 
			// txtID
			// 
			this.txtID.Location = new System.Drawing.Point(167, 19);
			this.txtID.Name = "txtID";
			this.txtID.Size = new System.Drawing.Size(243, 20);
			this.txtID.TabIndex = 6;
			// 
			// txtCategoryName
			// 
			this.txtCategoryName.Location = new System.Drawing.Point(167, 57);
			this.txtCategoryName.Name = "txtCategoryName";
			this.txtCategoryName.Size = new System.Drawing.Size(243, 20);
			this.txtCategoryName.TabIndex = 7;
			// 
			// txtType
			// 
			this.txtType.Location = new System.Drawing.Point(167, 99);
			this.txtType.Name = "txtType";
			this.txtType.Size = new System.Drawing.Size(243, 20);
			this.txtType.TabIndex = 8;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDelete,
            this.tsmViewFood});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(200, 48);
			// 
			// tsmDelete
			// 
			this.tsmDelete.Name = "tsmDelete";
			this.tsmDelete.Size = new System.Drawing.Size(199, 22);
			this.tsmDelete.Text = "Xoá nhóm sản phẩm";
			this.tsmDelete.Click += new System.EventHandler(this.tsmDelete_Click);
			// 
			// tsmViewFood
			// 
			this.tsmViewFood.Name = "tsmViewFood";
			this.tsmViewFood.Size = new System.Drawing.Size(199, 22);
			this.tsmViewFood.Text = "Xem danh sách món ăn";
			this.tsmViewFood.Click += new System.EventHandler(this.tsmViewFood_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 565);
			this.Controls.Add(this.txtType);
			this.Controls.Add(this.txtCategoryName);
			this.Controls.Add(this.txtID);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnCapNhat);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.lvCategory);
			this.Controls.Add(this.btnLoad);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.ListView lvCategory;
		private System.Windows.Forms.ColumnHeader chID;
		private System.Windows.Forms.ColumnHeader chName;
		private System.Windows.Forms.ColumnHeader chType;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnCapNhat;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtID;
		private System.Windows.Forms.TextBox txtCategoryName;
		private System.Windows.Forms.TextBox txtType;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmDelete;
		private System.Windows.Forms.ToolStripMenuItem tsmViewFood;
	}
}

