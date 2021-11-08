
namespace Basic_Command
{
	partial class TableForm
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
			this.dgvTable = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.thêmBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xoaBanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemDanhMucHoaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xemNhâtKyHoaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvTable
			// 
			this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTable.ContextMenuStrip = this.contextMenuStrip1;
			this.dgvTable.Location = new System.Drawing.Point(12, 12);
			this.dgvTable.Name = "dgvTable";
			this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvTable.Size = new System.Drawing.Size(452, 426);
			this.dgvTable.TabIndex = 0;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmBanToolStripMenuItem,
            this.xoaBanToolStripMenuItem,
            this.xemDanhMucHoaĐơnToolStripMenuItem,
            this.xemNhâtKyHoaĐơnToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(203, 92);
			// 
			// thêmBanToolStripMenuItem
			// 
			this.thêmBanToolStripMenuItem.Name = "thêmBanToolStripMenuItem";
			this.thêmBanToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.thêmBanToolStripMenuItem.Text = "Thêm bàn";
			this.thêmBanToolStripMenuItem.Click += new System.EventHandler(this.thêmBanToolStripMenuItem_Click);
			// 
			// xoaBanToolStripMenuItem
			// 
			this.xoaBanToolStripMenuItem.Name = "xoaBanToolStripMenuItem";
			this.xoaBanToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xoaBanToolStripMenuItem.Text = "Xoá bàn";
			this.xoaBanToolStripMenuItem.Click += new System.EventHandler(this.xoaBanToolStripMenuItem_Click);
			// 
			// xemDanhMucHoaĐơnToolStripMenuItem
			// 
			this.xemDanhMucHoaĐơnToolStripMenuItem.Name = "xemDanhMucHoaĐơnToolStripMenuItem";
			this.xemDanhMucHoaĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xemDanhMucHoaĐơnToolStripMenuItem.Text = "Xem danh mục hoá đơn";
			this.xemDanhMucHoaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemDanhMucHoaĐơnToolStripMenuItem_Click);
			// 
			// xemNhâtKyHoaĐơnToolStripMenuItem
			// 
			this.xemNhâtKyHoaĐơnToolStripMenuItem.Name = "xemNhâtKyHoaĐơnToolStripMenuItem";
			this.xemNhâtKyHoaĐơnToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
			this.xemNhâtKyHoaĐơnToolStripMenuItem.Text = "Xem nhật ký hoá đơn";
			// 
			// TableForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(479, 450);
			this.Controls.Add(this.dgvTable);
			this.Name = "TableForm";
			this.Text = "TableForm";
			this.Load += new System.EventHandler(this.TableForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvTable;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem thêmBanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xoaBanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemDanhMucHoaĐơnToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xemNhâtKyHoaĐơnToolStripMenuItem;
	}
}