using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace File_manager
{
	public partial class MainForm : Form
	{
		static string working_directory;
		static string destinationfolder;
		static string outputmessage_label_string;
		static string action;
		string[] working_directory_filelist;
		List<string> extensionlists;

		enum size_categories
		{
			categories_1kb,
			categories_100kb,
			categories_500kb,
			categories_1Mb,
			categories_100Mb,
			categories_500Mb,
			categories_1Gb,
			categories_1Gb_plus
		}

		bool actionprompt = true;
		bool abort = false;

		static int founds;


		public MainForm()
		{
			InitializeComponent();
		}

		private void go_Click( object sender, EventArgs e )
		{
			//get all the files
			//call worker on it

			if( workingfoldertxtbx.Text.Trim() == String.Empty )
			{
				MessageBox.Show( "Please select working folder" );
				return;
			}

			if( destinationfoldertxtbx.Text.Trim() == String.Empty )
			{
				MessageBox.Show( "Please select destination folder" );
				return;
			}

			working_directory = workingfoldertxtbx.Text;
			destinationfolder = destinationfoldertxtbx.Text;

			outputtxtbx.Text = "";

			founds = 0;
			working_directory_filelist = null;
			extensionlists = new List<string>();

			working_directory_filelist = Directory.GetFiles( working_directory, "*", SearchOption.AllDirectories );

			if( working_directory_filelist == null )
			{
				MessageBox.Show( "No data to process" );
				return;
			}

			outputmessage_label_string = "Found " + working_directory_filelist.Length + " files";
			outputmessage_label.Text = outputmessage_label_string;

			Thread t = new Thread( worker );
			t.Name = "worker thread";
			t.Start();
		}


		private void worker()
		{
			try
			{
				string file_new_destination;
				string ext;
				string destination_dir = destinationfolder;
				FileInfo thisfile;

				foreach( string fileentry in working_directory_filelist )
				{
					if( abort )
					{
						resetappendtoggle( "" );
						abort = false;
						break;
					}

					thisfile = new FileInfo( fileentry );

					if( iTalk_Toggle_filetype.Toggled )
					{
						ext = thisfile.Extension;
						ext = ext.Replace( ".", "" );
						destination_dir = Path.Combine( destinationfolder, ext );
					}


					if( intellisort_sizetoggle.Toggled == true )
					{
						size_categories sizecat = get_size_cat( thisfile.Length );
						string foldername = get_folder_size_name( sizecat );
						destination_dir = Path.Combine( destination_dir, foldername );
					}

					if( !Directory.Exists( destination_dir ) )
					{
						Directory.CreateDirectory( destination_dir );
					}

					file_new_destination = Path.Combine( destination_dir, thisfile.Name );

					if( String.Equals( fileentry, file_new_destination, StringComparison.OrdinalIgnoreCase ) )
					{
						appendInfoToInfoBox( "Error: Same file >> \"" + file_new_destination + "\" and \"" + fileentry + "\"" );
						continue;
					}

					if( File.Exists( file_new_destination ) )
					{
						if( !iTalk_CheckBox_overwrite.Checked )
						{
							appendInfoToInfoBox( "*" + file_new_destination + " already exists" );
							continue;
						}

						try
						{
							File.Delete( file_new_destination );
							appendInfoToInfoBox( "*" + " Set to overwrite: " + file_new_destination );
						}
						catch( Exception f )
						{
							appendInfoToInfoBox( "Error: " + f.Message + " >> " + file_new_destination );
							appendInfoToOutputLabel( "Error: " + f.Message + " >> " + file_new_destination );
							return;
						}
					}

					if( iTalk_RadioButton_copy.Checked )
					{
						File.Copy( fileentry, file_new_destination );
						action = "Copied";
					}
					else
					{
						File.Move( fileentry, file_new_destination );
						action = "Moved";
					}

					founds++;

					appendInfoToOutputLabel( action + " " + founds.ToString() + " files" );
					appendInfoToInfoBox( action + " " + fileentry + " > " + file_new_destination );


					if( iTalk_RadioButton_move.Checked )//if we are moving, delete empties
					{
						if( iTalk_CheckBox_foldercleanup.Checked )
						{
							List<string> filesin = new List<string>( Directory.GetFiles( Path.GetDirectoryName( fileentry ), "*", SearchOption.AllDirectories ) );

							string nxtfolder = Path.GetDirectoryName( fileentry );

							//delete till up the tree

							while( filesin.Count < 1 )
							{
								try
								{
									//deal with status quo

									Directory.Delete( nxtfolder );
									appendInfoToInfoBox( "Deleted " + nxtfolder );


									//prepare for its parent

									nxtfolder = Directory.GetParent( nxtfolder ).FullName;

									filesin = new List<string>( Directory.GetFiles( nxtfolder, "*", SearchOption.AllDirectories ) );

								}
								catch
								{
									break;
								}
							}
						}
					}
				}

				appendInfoToInfoBox( "Completed\r\n" );
			}
			catch( Exception x )
			{
				MessageBox.Show( "Error: " + x.Message + "\r\n\r\nDetails:" + x.StackTrace + "\r\n\r\nMore details:" + x.InnerException );
				return;
			}
		}

		private void appendInfoToInfoBox( string Data )
		{
			try
			{
				if( outputtxtbx.InvokeRequired )
				{
					SetTextCallback methodcalling = new SetTextCallback( appendInfoToInfoBox );
					outputtxtbx.Invoke( methodcalling, new object[] { Data } );
				}
				else
				{
					outputtxtbx.AppendText( Data + "\r\n" );

					Update();
					Application.DoEvents();
				}
			}
			catch
			{
			}
		}


		private void resetappendtoggle( string Data )
		{
			try
			{
				if( abort_toggle_control.InvokeRequired )//resetappendtoggle
				{
					SetTextCallback methodcalling = new SetTextCallback( resetappendtoggle );
					abort_toggle_control.Invoke( methodcalling, new object[] { Data } );
				}
				else
				{
					abort_toggle_control.Toggled = false;

					Update();
					Application.DoEvents();
				}
			}
			catch
			{
			}
		}

		private void appendInfoToOutputLabel( string Data )
		{
			try
			{
				if( outputmessage_label.InvokeRequired )
				{
					SetTextCallback methodcall = new SetTextCallback( appendInfoToOutputLabel );
					outputmessage_label.Invoke( methodcall, new object[] { Data } );
				}
				else
				{
					outputmessage_label.Text = outputmessage_label_string + ( "\r\n" + Data );
				}
			}
			catch
			{
			}
		}

		private void cwfolder_Click( object sender, EventArgs e )
		{
			if( folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
			{
				working_directory = folderBrowserDialog1.SelectedPath;
				workingfoldertxtbx.Text = working_directory;
			}
		}

		private void workingfolderlabel_Enter( object sender, EventArgs e )
		{
			working_directory = null;
		}

		private delegate void SetTextCallback( string text );

		private void Toggle_actionprompt_ToggledChanged()
		{
			actionprompt = intellisort_sizetoggle.Toggled;
		}

		private void destination_folder_button_Click( object sender, EventArgs e )
		{
			if( folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
			{
				destinationfolder = folderBrowserDialog1.SelectedPath;
				destinationfoldertxtbx.Text = destinationfolder;
			}
		}

		string get_folder_size_name( size_categories thesize )
		{
			switch( thesize )
			{
				case size_categories.categories_1Gb_plus:
					{
						return "+1Gb";
					}

				case size_categories.categories_1Gb:
					{
						return "-1Gb";
					}

				case size_categories.categories_500Mb:
					{
						return "-500Mb";
					}

				case size_categories.categories_100Mb:
					{
						return "-100Mb";
					}

				case size_categories.categories_1Mb:
					{
						return "-1Mb";
					}

				case size_categories.categories_500kb:
					{
						return "-500kb";
					}

				case size_categories.categories_100kb:
					{
						return "-100kb";
					}

				case size_categories.categories_1kb:
					{
						return "-1kb";
					}



				default:
					{
						return "+1Gb";
					}
			}
		}

		private void abort_toggle()
		{
			if( abort_toggle_control.Toggled )
			{
				abort = true;
			}
		}

		size_categories get_size_cat( long thesize )
		{

			if( thesize < 1000 )//1kb
			{
				return size_categories.categories_1kb;
			}
			else
			{
				if( thesize < 100000 )//100kb
				{
					return size_categories.categories_100kb;
				}
				else
				{
					if( thesize < 500000 )//500kb
					{
						return size_categories.categories_500kb;
					}
					else
					{
						if( thesize < 1000000 )//1Mb
						{
							return size_categories.categories_1Mb;
						}
						else
						{
							if( thesize < 100000000 )//100Mb
							{
								return size_categories.categories_100Mb;
							}
							else
							{
								if( thesize < 500000000 )//500Mb
								{
									return size_categories.categories_500Mb;
								}
								else
								{
									if( thesize < 1000000000 )//1Gb
									{
										return size_categories.categories_1Gb;
									}
									else
									{
										return size_categories.categories_1Gb_plus;
									}
								}

							}

						}
					}
				}
			}
		}

		private void MainForm_Load( object sender, EventArgs e )
		{
			this.Location = new Point( ( Screen.PrimaryScreen.WorkingArea.Width - this.Width ) / 2,
						  ( Screen.PrimaryScreen.WorkingArea.Height - this.Height ) / 2 );
		}

		private void listBox_files_KeyUp( object sender, KeyEventArgs e )
		{
			try
			{
				string currfile = listBox_files.SelectedItem.ToString();

				if( e.KeyCode == Keys.Delete )
				{
					if( iTalk_Toggle_promptbeforedelete.Toggled )
					{
						if( MessageBox.Show( "Do want to delete " + currfile, "Confirm file delete", MessageBoxButtons.YesNo ) == System.Windows.Forms.DialogResult.No )
						{
							return;
						}
					}

					try
					{
						string realfile = filemap[currfile];
						File.Delete( realfile );
						txtBox_preview.Text = "";
						dowork();
					}
					catch( Exception w )
					{
						MessageBox.Show( w.Message );
					}
				}
			}
			catch
			{
				;
			}
		}


		public void setpreviewedcontent( string Data )
		{
			try
			{
				if( txtBox_preview.InvokeRequired )
				{
					SetTextCallback methodcall = new SetTextCallback( setpreviewedcontent );
					txtBox_preview.Invoke( methodcall, new object[] { Data } );
				}
				else
				{
					txtBox_preview.Text = Data;
				}
			}
			catch
			{
				;
			}
		}

		public void setstatustext( string Data )
		{
			try
			{
				if( Label_info_status_log.InvokeRequired )
				{
					SetTextCallback methodcall = new SetTextCallback( setstatustext );
					Label_info_status_log.Invoke( methodcall, new object[] { Data } );
				}
				else
				{
					Label_info_status_log.Text = Data;
				}
			}
			catch
			{
				;
			}
		}

		private void select_working_folder_Click( object sender, EventArgs e )
		{
			try
			{
				if( folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
				{
					iTalk_ProgressIndicator1.Visible = true;
					fmanager_working_directory = folderBrowserDialog1.SelectedPath;
					preview_directoy_TextBox.Text = fmanager_working_directory;
					dowork();
				}
			}
			catch
			{
				;
			}
		}

		private void preview_directoy_TextBox_TextChanged( object sender, EventArgs e )
		{
			if( Directory.Exists( preview_directoy_TextBox.Text ) )
			{
				fmanager_working_directory = preview_directoy_TextBox.Text;
				dowork();
			}
		}

		private void listBox_files_SelectedIndexChanged( object sender, EventArgs e )
		{
			try
			{
				iTalk_ProgressIndicator1.Visible = true;
				Update();
				Application.DoEvents();

				string thisfile = listBox_files.SelectedItem.ToString();
				//get its entry therein
				//fileinfo to know what to use
				//show it

				string targetfile = filemap[thisfile];
				Label_info_status_log.Text = targetfile;
				FileInfo thisfileInfo = new FileInfo( targetfile );

				switch( thisfileInfo.Extension.ToLower() )
				{
					case ".xml":
					case ".sql":
					case ".html":
					case ".css":
					case ".php":
					case ".js":
					case ".json":
					case ".csv":
					case ".txt":
						{
							txtBox_preview.Text = new StreamReader( targetfile ).ReadToEnd();
							break;
						}

					case ".doc":
					case ".docx":
					case ".ppt":
					case ".pptx":
					case ".xls":
					case ".xlsx":
						{
							ms_office_previewer( targetfile );
							break;
						}



					case ".pdf":
						{
							pdf_previewer( targetfile );
							break;
						}

					default:
						{
							if( thisfileInfo.Length < 500000000 )//500 Mb file you can still just dump it
							{
								try
								{
									txtBox_preview.Text = "\r\n\r\n-----APP ERROR: Unsurported document format (" + thisfileInfo.Extension + ")-----\r\n\r\n" + new StreamReader( targetfile ).ReadToEnd();
								}
								catch
								{
									txtBox_preview.Text = "Unable to read file type: '" + thisfileInfo.Extension + "'";
								}
							}
							else
							{
								txtBox_preview.Text = "Unknown file type: '" + thisfileInfo.Extension + "'";
							}

							break;
						}
				}

				stop_indicator( "" );
			}
			catch( Exception v )
			{
				Label_info_status_log.Text = "Error: " + v.Message;
			}
		}
	}
}