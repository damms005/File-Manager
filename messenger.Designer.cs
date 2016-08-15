namespace File_manager
{
	partial class messenger
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.iTalk_ThemeContainer1 = new iTalk.iTalk_ThemeContainer();
			this.iTalk_Button_yes = new iTalk.iTalk_Button_1();
			this.iTalk_Button_no = new iTalk.iTalk_Button_2();
			this.textBox_query = new System.Windows.Forms.TextBox();
			this.iTalk_ThemeContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// iTalk_ThemeContainer1
			// 
			this.iTalk_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.iTalk_ThemeContainer1.Controls.Add(this.textBox_query);
			this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Button_no);
			this.iTalk_ThemeContainer1.Controls.Add(this.iTalk_Button_yes);
			this.iTalk_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.iTalk_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_ThemeContainer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
			this.iTalk_ThemeContainer1.Name = "iTalk_ThemeContainer1";
			this.iTalk_ThemeContainer1.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
			this.iTalk_ThemeContainer1.Sizable = true;
			this.iTalk_ThemeContainer1.Size = new System.Drawing.Size(500, 200);
			this.iTalk_ThemeContainer1.SmartBounds = false;
			this.iTalk_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.iTalk_ThemeContainer1.TabIndex = 0;
			this.iTalk_ThemeContainer1.Text = "Remove this line?";
			// 
			// iTalk_Button_yes
			// 
			this.iTalk_Button_yes.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Button_yes.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.iTalk_Button_yes.Image = null;
			this.iTalk_Button_yes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iTalk_Button_yes.Location = new System.Drawing.Point(50, 124);
			this.iTalk_Button_yes.Name = "iTalk_Button_yes";
			this.iTalk_Button_yes.Size = new System.Drawing.Size(166, 40);
			this.iTalk_Button_yes.TabIndex = 1;
			this.iTalk_Button_yes.Text = "Yes";
			this.iTalk_Button_yes.TextAlignment = System.Drawing.StringAlignment.Center;
			this.iTalk_Button_yes.Click += new System.EventHandler(this.iTalk_Button_yes_Click);
			// 
			// iTalk_Button_no
			// 
			this.iTalk_Button_no.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Button_no.Font = new System.Drawing.Font("Segoe UI", 14F);
			this.iTalk_Button_no.ForeColor = System.Drawing.Color.White;
			this.iTalk_Button_no.Image = null;
			this.iTalk_Button_no.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.iTalk_Button_no.Location = new System.Drawing.Point(260, 124);
			this.iTalk_Button_no.Name = "iTalk_Button_no";
			this.iTalk_Button_no.Size = new System.Drawing.Size(166, 40);
			this.iTalk_Button_no.TabIndex = 2;
			this.iTalk_Button_no.Text = "No";
			this.iTalk_Button_no.TextAlignment = System.Drawing.StringAlignment.Center;
			this.iTalk_Button_no.Click += new System.EventHandler(this.iTalk_Button_no_Click);
			// 
			// textBox_query
			// 
			this.textBox_query.BackColor = System.Drawing.SystemColors.Menu;
			this.textBox_query.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_query.Location = new System.Drawing.Point(15, 78);
			this.textBox_query.Name = "textBox_query";
			this.textBox_query.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.textBox_query.Size = new System.Drawing.Size(470, 15);
			this.textBox_query.TabIndex = 3;
			// 
			// messenger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(500, 200);
			this.Controls.Add(this.iTalk_ThemeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.MinimumSize = new System.Drawing.Size(126, 39);
			this.Name = "messenger";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Remove this line?";
			this.TopMost = true;
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.Load += new System.EventHandler(this.messenger_Load);
			this.iTalk_ThemeContainer1.ResumeLayout(false);
			this.iTalk_ThemeContainer1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private iTalk.iTalk_ThemeContainer iTalk_ThemeContainer1;
		private System.Windows.Forms.TextBox textBox_query;
		private iTalk.iTalk_Button_2 iTalk_Button_no;
		private iTalk.iTalk_Button_1 iTalk_Button_yes;
	}
}