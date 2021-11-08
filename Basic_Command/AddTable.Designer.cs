
namespace Basic_Command
{
	partial class AddTable
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTableID = new System.Windows.Forms.TextBox();
			this.txtTableName = new System.Windows.Forms.TextBox();
			this.cbbStatus = new System.Windows.Forms.ComboBox();
			this.nudCapacity = new System.Windows.Forms.NumericUpDown();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(41, 35);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(43, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã bàn";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(41, 76);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên bàn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(41, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Trạng thái";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(41, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Số chỗ";
			// 
			// txtTableID
			// 
			this.txtTableID.Location = new System.Drawing.Point(113, 32);
			this.txtTableID.Name = "txtTableID";
			this.txtTableID.Size = new System.Drawing.Size(168, 20);
			this.txtTableID.TabIndex = 4;
			// 
			// txtTableName
			// 
			this.txtTableName.Location = new System.Drawing.Point(113, 73);
			this.txtTableName.Name = "txtTableName";
			this.txtTableName.Size = new System.Drawing.Size(168, 20);
			this.txtTableName.TabIndex = 5;
			// 
			// cbbStatus
			// 
			this.cbbStatus.FormattingEnabled = true;
			this.cbbStatus.Location = new System.Drawing.Point(113, 120);
			this.cbbStatus.Name = "cbbStatus";
			this.cbbStatus.Size = new System.Drawing.Size(168, 21);
			this.cbbStatus.TabIndex = 6;
			// 
			// nudCapacity
			// 
			this.nudCapacity.Location = new System.Drawing.Point(113, 169);
			this.nudCapacity.Name = "nudCapacity";
			this.nudCapacity.Size = new System.Drawing.Size(168, 20);
			this.nudCapacity.TabIndex = 7;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(64, 228);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(85, 31);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(215, 228);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(85, 31);
			this.btnUpdate.TabIndex = 9;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// AddTable
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(351, 287);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.nudCapacity);
			this.Controls.Add(this.cbbStatus);
			this.Controls.Add(this.txtTableName);
			this.Controls.Add(this.txtTableID);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "AddTable";
			this.Text = "AddTable";
			this.Load += new System.EventHandler(this.AddTable_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTableID;
		private System.Windows.Forms.TextBox txtTableName;
		private System.Windows.Forms.ComboBox cbbStatus;
		private System.Windows.Forms.NumericUpDown nudCapacity;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
	}
}