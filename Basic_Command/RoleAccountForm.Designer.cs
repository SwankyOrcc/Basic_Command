﻿
namespace Basic_Command
{
	partial class RoleAccountForm
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
			this.dgvRoles = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRoles
			// 
			this.dgvRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRoles.Location = new System.Drawing.Point(12, 12);
			this.dgvRoles.Name = "dgvRoles";
			this.dgvRoles.Size = new System.Drawing.Size(696, 383);
			this.dgvRoles.TabIndex = 1;
			// 
			// RoleAccountForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(720, 407);
			this.Controls.Add(this.dgvRoles);
			this.Name = "RoleAccountForm";
			this.Text = "RoleAccountForm";
			this.Load += new System.EventHandler(this.RoleAccountForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvRoles)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRoles;
	}
}