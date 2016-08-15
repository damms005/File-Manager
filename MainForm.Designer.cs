namespace File_manager
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.iTalk_Label4 = new iTalk.iTalk_Label();
			this.iTalk_Label3 = new iTalk.iTalk_Label();
			this.iTalk_CheckBox_foldercleanup = new iTalk.iTalk_CheckBox();
			this.Label_info_status_log = new Ambiance.Ambiance_Label();
			this.iTalk_Toggle_filetype = new iTalk.iTalk_Toggle();
			this.intellisort_sizetoggle = new iTalk.iTalk_Toggle();
			this.ambiance_ThemeContainer1 = new Ambiance.Ambiance_ThemeContainer();
			this.label1 = new System.Windows.Forms.Label();
			this.ambiance_TabControl1 = new Ambiance.Ambiance_TabControl();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.iTalk_CheckBox_overwrite = new iTalk.iTalk_CheckBox();
			this.iTalk_RadioButton_move = new iTalk.iTalk_RadioButton();
			this.iTalk_RadioButton_copy = new iTalk.iTalk_RadioButton();
			this.iTalk_Label1 = new iTalk.iTalk_Label();
			this.abort_toggle_control = new iTalk.iTalk_Toggle();
			this.destinationfoldertxtbx = new Ambiance.Ambiance_TextBox();
			this.destination_folder_btn = new iTalk.iTalk_Button_2();
			this.startbtn = new iTalk.iTalk_Button_2();
			this.workingfoldertxtbx = new Ambiance.Ambiance_TextBox();
			this.outputtxtbx = new System.Windows.Forms.TextBox();
			this.outputmessage_label = new Ambiance.Ambiance_Label();
			this.cwfolderbtn = new iTalk.iTalk_Button_2();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.iTalk_Label2 = new iTalk.iTalk_Label();
			this.iTalk_Toggle_promptbeforedelete = new iTalk.iTalk_Toggle();
			this.iTalk_ProgressIndicator1 = new iTalk.iTalk_ProgressIndicator();
			this.listBox_files = new System.Windows.Forms.ListBox();
			this.preview_directoy_TextBox = new Ambiance.Ambiance_TextBox();
			this.select_working_folder_btn = new iTalk.iTalk_Button_2();
			this.txtBox_preview = new System.Windows.Forms.TextBox();
			this.ambiance_ControlBox1 = new Ambiance.Ambiance_ControlBox();
			this.ambiance_Label1 = new Ambiance.Ambiance_Label();
			this.ambiance_ThemeContainer1.SuspendLayout();
			this.ambiance_TabControl1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// iTalk_Label4
			// 
			this.iTalk_Label4.AutoSize = true;
			this.iTalk_Label4.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label4.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label4.Location = new System.Drawing.Point(455, 115);
			this.iTalk_Label4.Name = "iTalk_Label4";
			this.iTalk_Label4.Size = new System.Drawing.Size(96, 13);
			this.iTalk_Label4.TabIndex = 49;
			this.iTalk_Label4.Text = "FiletypeIntellisort";
			this.toolTip1.SetToolTip(this.iTalk_Label4, "Create folders appropriately in the destination folder to sort files according to" +
        " file type");
			// 
			// iTalk_Label3
			// 
			this.iTalk_Label3.AutoSize = true;
			this.iTalk_Label3.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label3.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label3.Location = new System.Drawing.Point(319, 115);
			this.iTalk_Label3.Name = "iTalk_Label3";
			this.iTalk_Label3.Size = new System.Drawing.Size(79, 13);
			this.iTalk_Label3.TabIndex = 47;
			this.iTalk_Label3.Text = "Size Intellisort";
			this.toolTip1.SetToolTip(this.iTalk_Label3, "Create folders appropriately in the destination folder to sort files according to" +
        " file size");
			// 
			// iTalk_CheckBox_foldercleanup
			// 
			this.iTalk_CheckBox_foldercleanup.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_CheckBox_foldercleanup.Checked = true;
			this.iTalk_CheckBox_foldercleanup.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.iTalk_CheckBox_foldercleanup.Location = new System.Drawing.Point(610, 115);
			this.iTalk_CheckBox_foldercleanup.Name = "iTalk_CheckBox_foldercleanup";
			this.iTalk_CheckBox_foldercleanup.Size = new System.Drawing.Size(110, 15);
			this.iTalk_CheckBox_foldercleanup.TabIndex = 43;
			this.iTalk_CheckBox_foldercleanup.Text = "Folder cleanup";
			this.toolTip1.SetToolTip(this.iTalk_CheckBox_foldercleanup, "Deletes empty folders on filemove");
			// 
			// Label_info_status_log
			// 
			this.Label_info_status_log.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.Label_info_status_log.AutoSize = true;
			this.Label_info_status_log.BackColor = System.Drawing.Color.Transparent;
			this.Label_info_status_log.Font = new System.Drawing.Font("Segoe UI", 11F);
			this.Label_info_status_log.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.Label_info_status_log.Location = new System.Drawing.Point(12, 543);
			this.Label_info_status_log.Name = "Label_info_status_log";
			this.Label_info_status_log.Size = new System.Drawing.Size(18, 20);
			this.Label_info_status_log.TabIndex = 56;
			this.Label_info_status_log.Text = "...";
			this.toolTip1.SetToolTip(this.Label_info_status_log, "Sorts the file in the folder according to file size");
			// 
			// iTalk_Toggle_filetype
			// 
			this.iTalk_Toggle_filetype.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iTalk_Toggle_filetype.Location = new System.Drawing.Point(551, 112);
			this.iTalk_Toggle_filetype.Name = "iTalk_Toggle_filetype";
			this.iTalk_Toggle_filetype.Size = new System.Drawing.Size(41, 23);
			this.iTalk_Toggle_filetype.TabIndex = 48;
			this.iTalk_Toggle_filetype.Text = "Sorts the file in the folder according to file size";
			this.iTalk_Toggle_filetype.Toggled = true;
			this.toolTip1.SetToolTip(this.iTalk_Toggle_filetype, "Create folders appropriately in the destination folder to sort files according to" +
        " file type");
			this.iTalk_Toggle_filetype.Type = iTalk.iTalk_Toggle._Type.OnOff;
			// 
			// intellisort_sizetoggle
			// 
			this.intellisort_sizetoggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.intellisort_sizetoggle.Location = new System.Drawing.Point(398, 112);
			this.intellisort_sizetoggle.Name = "intellisort_sizetoggle";
			this.intellisort_sizetoggle.Size = new System.Drawing.Size(41, 23);
			this.intellisort_sizetoggle.TabIndex = 46;
			this.intellisort_sizetoggle.Text = "Sorts the file in the folder according to file size";
			this.intellisort_sizetoggle.Toggled = true;
			this.toolTip1.SetToolTip(this.intellisort_sizetoggle, "Create folders appropriately in the destination folder to sort files according to" +
        " file size");
			this.intellisort_sizetoggle.Type = iTalk.iTalk_Toggle._Type.OnOff;
			// 
			// ambiance_ThemeContainer1
			// 
			this.ambiance_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
			this.ambiance_ThemeContainer1.Controls.Add(this.label1);
			this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_TabControl1);
			this.ambiance_ThemeContainer1.Controls.Add(this.ambiance_ControlBox1);
			this.ambiance_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ambiance_ThemeContainer1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.ambiance_ThemeContainer1.Location = new System.Drawing.Point(0, 0);
			this.ambiance_ThemeContainer1.Name = "ambiance_ThemeContainer1";
			this.ambiance_ThemeContainer1.Padding = new System.Windows.Forms.Padding(20, 56, 20, 16);
			this.ambiance_ThemeContainer1.RoundCorners = false;
			this.ambiance_ThemeContainer1.Sizable = true;
			this.ambiance_ThemeContainer1.Size = new System.Drawing.Size(1000, 700);
			this.ambiance_ThemeContainer1.SmartBounds = false;
			this.ambiance_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.ambiance_ThemeContainer1.TabIndex = 0;
			this.ambiance_ThemeContainer1.Text = "File Manager";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(20, 669);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(783, 15);
			this.label1.TabIndex = 43;
			this.label1.Text = "Developed by IQ+ | Website: www.iqplusknowledge.com | Email: admin@iqplusknowledg" +
    "e.com, emmanueldami@gmail.com | Office: 07033010564";
			// 
			// ambiance_TabControl1
			// 
			this.ambiance_TabControl1.Controls.Add(this.tabPage3);
			this.ambiance_TabControl1.Controls.Add(this.tabPage1);
			this.ambiance_TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ambiance_TabControl1.ItemSize = new System.Drawing.Size(80, 24);
			this.ambiance_TabControl1.Location = new System.Drawing.Point(20, 56);
			this.ambiance_TabControl1.Multiline = true;
			this.ambiance_TabControl1.Name = "ambiance_TabControl1";
			this.ambiance_TabControl1.SelectedIndex = 0;
			this.ambiance_TabControl1.Size = new System.Drawing.Size(960, 628);
			this.ambiance_TabControl1.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tabPage3.Controls.Add(this.iTalk_CheckBox_overwrite);
			this.tabPage3.Controls.Add(this.iTalk_Label4);
			this.tabPage3.Controls.Add(this.iTalk_Toggle_filetype);
			this.tabPage3.Controls.Add(this.iTalk_Label3);
			this.tabPage3.Controls.Add(this.intellisort_sizetoggle);
			this.tabPage3.Controls.Add(this.iTalk_RadioButton_move);
			this.tabPage3.Controls.Add(this.iTalk_RadioButton_copy);
			this.tabPage3.Controls.Add(this.iTalk_CheckBox_foldercleanup);
			this.tabPage3.Controls.Add(this.iTalk_Label1);
			this.tabPage3.Controls.Add(this.abort_toggle_control);
			this.tabPage3.Controls.Add(this.destinationfoldertxtbx);
			this.tabPage3.Controls.Add(this.destination_folder_btn);
			this.tabPage3.Controls.Add(this.startbtn);
			this.tabPage3.Controls.Add(this.workingfoldertxtbx);
			this.tabPage3.Controls.Add(this.outputtxtbx);
			this.tabPage3.Controls.Add(this.outputmessage_label);
			this.tabPage3.Controls.Add(this.cwfolderbtn);
			this.tabPage3.Location = new System.Drawing.Point(4, 28);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(952, 596);
			this.tabPage3.TabIndex = 0;
			this.tabPage3.Text = "Sorting";
			// 
			// iTalk_CheckBox_overwrite
			// 
			this.iTalk_CheckBox_overwrite.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_CheckBox_overwrite.Checked = false;
			this.iTalk_CheckBox_overwrite.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.iTalk_CheckBox_overwrite.Location = new System.Drawing.Point(726, 115);
			this.iTalk_CheckBox_overwrite.Name = "iTalk_CheckBox_overwrite";
			this.iTalk_CheckBox_overwrite.Size = new System.Drawing.Size(80, 15);
			this.iTalk_CheckBox_overwrite.TabIndex = 50;
			this.iTalk_CheckBox_overwrite.Text = "Overwrite";
			// 
			// iTalk_RadioButton_move
			// 
			this.iTalk_RadioButton_move.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_RadioButton_move.Checked = true;
			this.iTalk_RadioButton_move.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.iTalk_RadioButton_move.Location = new System.Drawing.Point(249, 115);
			this.iTalk_RadioButton_move.Name = "iTalk_RadioButton_move";
			this.iTalk_RadioButton_move.Size = new System.Drawing.Size(56, 15);
			this.iTalk_RadioButton_move.TabIndex = 45;
			this.iTalk_RadioButton_move.Text = "Move";
			// 
			// iTalk_RadioButton_copy
			// 
			this.iTalk_RadioButton_copy.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_RadioButton_copy.Checked = false;
			this.iTalk_RadioButton_copy.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.iTalk_RadioButton_copy.Location = new System.Drawing.Point(183, 115);
			this.iTalk_RadioButton_copy.Name = "iTalk_RadioButton_copy";
			this.iTalk_RadioButton_copy.Size = new System.Drawing.Size(56, 15);
			this.iTalk_RadioButton_copy.TabIndex = 44;
			this.iTalk_RadioButton_copy.Text = "Copy";
			// 
			// iTalk_Label1
			// 
			this.iTalk_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iTalk_Label1.AutoSize = true;
			this.iTalk_Label1.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label1.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label1.Location = new System.Drawing.Point(871, 166);
			this.iTalk_Label1.Name = "iTalk_Label1";
			this.iTalk_Label1.Size = new System.Drawing.Size(31, 13);
			this.iTalk_Label1.TabIndex = 42;
			this.iTalk_Label1.Text = "Stop";
			// 
			// abort_toggle_control
			// 
			this.abort_toggle_control.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.abort_toggle_control.Location = new System.Drawing.Point(905, 162);
			this.abort_toggle_control.Name = "abort_toggle_control";
			this.abort_toggle_control.Size = new System.Drawing.Size(41, 23);
			this.abort_toggle_control.TabIndex = 41;
			this.abort_toggle_control.Text = "iTalk_Toggle1";
			this.abort_toggle_control.Toggled = false;
			this.abort_toggle_control.Type = iTalk.iTalk_Toggle._Type.YesNo;
			this.abort_toggle_control.ToggledChanged += new iTalk.iTalk_Toggle.ToggledChangedEventHandler(this.abort_toggle);
			// 
			// destinationfoldertxtbx
			// 
			this.destinationfoldertxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.destinationfoldertxtbx.BackColor = System.Drawing.Color.Transparent;
			this.destinationfoldertxtbx.Font = new System.Drawing.Font("Tahoma", 9F);
			this.destinationfoldertxtbx.ForeColor = System.Drawing.Color.DimGray;
			this.destinationfoldertxtbx.Location = new System.Drawing.Point(183, 66);
			this.destinationfoldertxtbx.MaxLength = 32767;
			this.destinationfoldertxtbx.Multiline = false;
			this.destinationfoldertxtbx.Name = "destinationfoldertxtbx";
			this.destinationfoldertxtbx.ReadOnly = false;
			this.destinationfoldertxtbx.Size = new System.Drawing.Size(763, 25);
			this.destinationfoldertxtbx.TabIndex = 38;
			this.destinationfoldertxtbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.destinationfoldertxtbx.UseSystemPasswordChar = false;
			// 
			// destination_folder_btn
			// 
			this.destination_folder_btn.BackColor = System.Drawing.Color.Transparent;
			this.destination_folder_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.destination_folder_btn.ForeColor = System.Drawing.Color.White;
			this.destination_folder_btn.Image = null;
			this.destination_folder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.destination_folder_btn.Location = new System.Drawing.Point(16, 66);
			this.destination_folder_btn.Name = "destination_folder_btn";
			this.destination_folder_btn.Size = new System.Drawing.Size(154, 30);
			this.destination_folder_btn.TabIndex = 37;
			this.destination_folder_btn.Text = "Select destination folder";
			this.destination_folder_btn.TextAlignment = System.Drawing.StringAlignment.Center;
			this.destination_folder_btn.Click += new System.EventHandler(this.destination_folder_button_Click);
			// 
			// startbtn
			// 
			this.startbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.startbtn.BackColor = System.Drawing.Color.Transparent;
			this.startbtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.startbtn.ForeColor = System.Drawing.Color.White;
			this.startbtn.Image = null;
			this.startbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startbtn.Location = new System.Drawing.Point(812, 103);
			this.startbtn.Name = "startbtn";
			this.startbtn.Size = new System.Drawing.Size(134, 27);
			this.startbtn.TabIndex = 35;
			this.startbtn.Text = "Start";
			this.startbtn.TextAlignment = System.Drawing.StringAlignment.Center;
			this.startbtn.Click += new System.EventHandler(this.go_Click);
			// 
			// workingfoldertxtbx
			// 
			this.workingfoldertxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.workingfoldertxtbx.BackColor = System.Drawing.Color.Transparent;
			this.workingfoldertxtbx.Font = new System.Drawing.Font("Tahoma", 9F);
			this.workingfoldertxtbx.ForeColor = System.Drawing.Color.DimGray;
			this.workingfoldertxtbx.Location = new System.Drawing.Point(183, 24);
			this.workingfoldertxtbx.MaxLength = 32767;
			this.workingfoldertxtbx.Multiline = false;
			this.workingfoldertxtbx.Name = "workingfoldertxtbx";
			this.workingfoldertxtbx.ReadOnly = false;
			this.workingfoldertxtbx.Size = new System.Drawing.Size(763, 25);
			this.workingfoldertxtbx.TabIndex = 27;
			this.workingfoldertxtbx.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.workingfoldertxtbx.UseSystemPasswordChar = false;
			// 
			// outputtxtbx
			// 
			this.outputtxtbx.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.outputtxtbx.Font = new System.Drawing.Font("Tahoma", 11F);
			this.outputtxtbx.ForeColor = System.Drawing.Color.DimGray;
			this.outputtxtbx.Location = new System.Drawing.Point(23, 195);
			this.outputtxtbx.Multiline = true;
			this.outputtxtbx.Name = "outputtxtbx";
			this.outputtxtbx.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.outputtxtbx.Size = new System.Drawing.Size(923, 383);
			this.outputtxtbx.TabIndex = 24;
			this.outputtxtbx.WordWrap = false;
			// 
			// outputmessage_label
			// 
			this.outputmessage_label.AutoSize = true;
			this.outputmessage_label.BackColor = System.Drawing.Color.Transparent;
			this.outputmessage_label.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.outputmessage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.outputmessage_label.Location = new System.Drawing.Point(23, 159);
			this.outputmessage_label.Name = "outputmessage_label";
			this.outputmessage_label.Size = new System.Drawing.Size(16, 15);
			this.outputmessage_label.TabIndex = 19;
			this.outputmessage_label.Text = "...";
			// 
			// cwfolderbtn
			// 
			this.cwfolderbtn.BackColor = System.Drawing.Color.Transparent;
			this.cwfolderbtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.cwfolderbtn.ForeColor = System.Drawing.Color.White;
			this.cwfolderbtn.Image = null;
			this.cwfolderbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.cwfolderbtn.Location = new System.Drawing.Point(16, 24);
			this.cwfolderbtn.Name = "cwfolderbtn";
			this.cwfolderbtn.Size = new System.Drawing.Size(154, 30);
			this.cwfolderbtn.TabIndex = 2;
			this.cwfolderbtn.Text = "Select working folder";
			this.cwfolderbtn.TextAlignment = System.Drawing.StringAlignment.Center;
			this.cwfolderbtn.Click += new System.EventHandler(this.cwfolder_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
			this.tabPage1.Controls.Add(this.ambiance_Label1);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.iTalk_Label2);
			this.tabPage1.Controls.Add(this.iTalk_Toggle_promptbeforedelete);
			this.tabPage1.Controls.Add(this.iTalk_ProgressIndicator1);
			this.tabPage1.Controls.Add(this.Label_info_status_log);
			this.tabPage1.Controls.Add(this.listBox_files);
			this.tabPage1.Controls.Add(this.preview_directoy_TextBox);
			this.tabPage1.Controls.Add(this.select_working_folder_btn);
			this.tabPage1.Controls.Add(this.txtBox_preview);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(952, 596);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "File Management";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(176, 67);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(291, 23);
			this.textBox1.TabIndex = 64;
			this.textBox1.Visible = false;
			// 
			// iTalk_Label2
			// 
			this.iTalk_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iTalk_Label2.AutoSize = true;
			this.iTalk_Label2.BackColor = System.Drawing.Color.Transparent;
			this.iTalk_Label2.Font = new System.Drawing.Font("Segoe UI", 8F);
			this.iTalk_Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
			this.iTalk_Label2.Location = new System.Drawing.Point(777, 77);
			this.iTalk_Label2.Name = "iTalk_Label2";
			this.iTalk_Label2.Size = new System.Drawing.Size(116, 13);
			this.iTalk_Label2.TabIndex = 62;
			this.iTalk_Label2.Text = "Prompt before delete";
			// 
			// iTalk_Toggle_promptbeforedelete
			// 
			this.iTalk_Toggle_promptbeforedelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.iTalk_Toggle_promptbeforedelete.Location = new System.Drawing.Point(898, 72);
			this.iTalk_Toggle_promptbeforedelete.Name = "iTalk_Toggle_promptbeforedelete";
			this.iTalk_Toggle_promptbeforedelete.Size = new System.Drawing.Size(41, 23);
			this.iTalk_Toggle_promptbeforedelete.TabIndex = 61;
			this.iTalk_Toggle_promptbeforedelete.Text = "iTalk_Toggle1";
			this.iTalk_Toggle_promptbeforedelete.Toggled = true;
			this.iTalk_Toggle_promptbeforedelete.Type = iTalk.iTalk_Toggle._Type.YesNo;
			// 
			// iTalk_ProgressIndicator1
			// 
			this.iTalk_ProgressIndicator1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.iTalk_ProgressIndicator1.Location = new System.Drawing.Point(436, 258);
			this.iTalk_ProgressIndicator1.MinimumSize = new System.Drawing.Size(80, 80);
			this.iTalk_ProgressIndicator1.Name = "iTalk_ProgressIndicator1";
			this.iTalk_ProgressIndicator1.P_AnimationColor = System.Drawing.Color.DimGray;
			this.iTalk_ProgressIndicator1.P_AnimationSpeed = 100;
			this.iTalk_ProgressIndicator1.P_BaseColor = System.Drawing.Color.DarkGray;
			this.iTalk_ProgressIndicator1.Size = new System.Drawing.Size(80, 80);
			this.iTalk_ProgressIndicator1.TabIndex = 58;
			this.iTalk_ProgressIndicator1.Text = "iTalk_ProgressIndicator1";
			this.iTalk_ProgressIndicator1.Visible = false;
			// 
			// listBox_files
			// 
			this.listBox_files.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.listBox_files.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.listBox_files.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
			this.listBox_files.FormattingEnabled = true;
			this.listBox_files.ItemHeight = 17;
			this.listBox_files.Location = new System.Drawing.Point(16, 101);
			this.listBox_files.Name = "listBox_files";
			this.listBox_files.ScrollAlwaysVisible = true;
			this.listBox_files.Size = new System.Drawing.Size(451, 429);
			this.listBox_files.TabIndex = 55;
			this.listBox_files.SelectedIndexChanged += new System.EventHandler(this.listBox_files_SelectedIndexChanged);
			this.listBox_files.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox_files_KeyUp);
			// 
			// preview_directoy_TextBox
			// 
			this.preview_directoy_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.preview_directoy_TextBox.BackColor = System.Drawing.Color.Transparent;
			this.preview_directoy_TextBox.Font = new System.Drawing.Font("Tahoma", 9F);
			this.preview_directoy_TextBox.ForeColor = System.Drawing.Color.DimGray;
			this.preview_directoy_TextBox.Location = new System.Drawing.Point(176, 36);
			this.preview_directoy_TextBox.MaxLength = 32767;
			this.preview_directoy_TextBox.Multiline = false;
			this.preview_directoy_TextBox.Name = "preview_directoy_TextBox";
			this.preview_directoy_TextBox.ReadOnly = false;
			this.preview_directoy_TextBox.Size = new System.Drawing.Size(763, 25);
			this.preview_directoy_TextBox.TabIndex = 45;
			this.preview_directoy_TextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
			this.preview_directoy_TextBox.UseSystemPasswordChar = false;
			this.preview_directoy_TextBox.TextChanged += new System.EventHandler(this.preview_directoy_TextBox_TextChanged);
			// 
			// select_working_folder_btn
			// 
			this.select_working_folder_btn.BackColor = System.Drawing.Color.Transparent;
			this.select_working_folder_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.select_working_folder_btn.ForeColor = System.Drawing.Color.White;
			this.select_working_folder_btn.Image = null;
			this.select_working_folder_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.select_working_folder_btn.Location = new System.Drawing.Point(16, 34);
			this.select_working_folder_btn.Name = "select_working_folder_btn";
			this.select_working_folder_btn.Size = new System.Drawing.Size(154, 30);
			this.select_working_folder_btn.TabIndex = 43;
			this.select_working_folder_btn.Text = "Select working folder";
			this.select_working_folder_btn.TextAlignment = System.Drawing.StringAlignment.Center;
			this.select_working_folder_btn.Click += new System.EventHandler(this.select_working_folder_Click);
			// 
			// txtBox_preview
			// 
			this.txtBox_preview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBox_preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
			this.txtBox_preview.ForeColor = System.Drawing.Color.DimGray;
			this.txtBox_preview.Location = new System.Drawing.Point(473, 101);
			this.txtBox_preview.Multiline = true;
			this.txtBox_preview.Name = "txtBox_preview";
			this.txtBox_preview.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtBox_preview.Size = new System.Drawing.Size(466, 424);
			this.txtBox_preview.TabIndex = 63;
			// 
			// ambiance_ControlBox1
			// 
			this.ambiance_ControlBox1.BackColor = System.Drawing.Color.Transparent;
			this.ambiance_ControlBox1.EnableMaximize = true;
			this.ambiance_ControlBox1.Font = new System.Drawing.Font("Marlett", 7F);
			this.ambiance_ControlBox1.Location = new System.Drawing.Point(5, 13);
			this.ambiance_ControlBox1.Name = "ambiance_ControlBox1";
			this.ambiance_ControlBox1.Size = new System.Drawing.Size(64, 22);
			this.ambiance_ControlBox1.TabIndex = 23;
			this.ambiance_ControlBox1.Text = "ambiance_ControlBox1";
			// 
			// ambiance_Label1
			// 
			this.ambiance_Label1.AutoSize = true;
			this.ambiance_Label1.BackColor = System.Drawing.Color.Transparent;
			this.ambiance_Label1.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ambiance_Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
			this.ambiance_Label1.Location = new System.Drawing.Point(20, 7);
			this.ambiance_Label1.Name = "ambiance_Label1";
			this.ambiance_Label1.Size = new System.Drawing.Size(856, 19);
			this.ambiance_Label1.TabIndex = 65;
			this.ambiance_Label1.Text = "Simply use this to quickly glance into a document to know if it is something you " +
    "want. Else, click on \'Delete\' on you keyboard to yank it off!";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.ambiance_ThemeContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(261, 65);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "File Manager";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.ambiance_ThemeContainer1.ResumeLayout(false);
			this.ambiance_ThemeContainer1.PerformLayout();
			this.ambiance_TabControl1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Ambiance.Ambiance_ThemeContainer ambiance_ThemeContainer1;
		private iTalk.iTalk_Button_2 cwfolderbtn;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private Ambiance.Ambiance_Label outputmessage_label;
		private System.Windows.Forms.ToolTip toolTip1;
		private Ambiance.Ambiance_ControlBox ambiance_ControlBox1;
		private System.Windows.Forms.TextBox outputtxtbx;
		private Ambiance.Ambiance_TextBox workingfoldertxtbx;
		private iTalk.iTalk_Button_2 startbtn;
		private Ambiance.Ambiance_TextBox destinationfoldertxtbx;
		private iTalk.iTalk_Button_2 destination_folder_btn;
		private iTalk.iTalk_Toggle abort_toggle_control;
		private iTalk.iTalk_Label iTalk_Label1;
		private System.Windows.Forms.Label label1;
		private Ambiance.Ambiance_TabControl ambiance_TabControl1;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage1;
		private Ambiance.Ambiance_TextBox preview_directoy_TextBox;
		private iTalk.iTalk_Button_2 select_working_folder_btn;
		private Ambiance.Ambiance_Label Label_info_status_log;
		private System.Windows.Forms.ListBox listBox_files;
		private iTalk.iTalk_ProgressIndicator iTalk_ProgressIndicator1;
		private iTalk.iTalk_Label iTalk_Label2;
		private iTalk.iTalk_Toggle iTalk_Toggle_promptbeforedelete;
		private System.Windows.Forms.TextBox txtBox_preview;
		private System.Windows.Forms.TextBox textBox1;
		private iTalk.iTalk_CheckBox iTalk_CheckBox_foldercleanup;
		private iTalk.iTalk_Label iTalk_Label3;
		private iTalk.iTalk_Toggle intellisort_sizetoggle;
		private iTalk.iTalk_RadioButton iTalk_RadioButton_move;
		private iTalk.iTalk_RadioButton iTalk_RadioButton_copy;
		private iTalk.iTalk_Label iTalk_Label4;
		private iTalk.iTalk_Toggle iTalk_Toggle_filetype;
		private iTalk.iTalk_CheckBox iTalk_CheckBox_overwrite;
		private Ambiance.Ambiance_Label ambiance_Label1;
	}
}

