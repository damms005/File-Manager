using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace File_manager
{
	public partial class MainForm : Form
	{

		Dictionary<string, string> filemap = new Dictionary<string, string>();
		string[] entries;
		static string fmanager_working_directory;

		private void dowork()
		{
			Thread t = new Thread( previewer_workerthread );
			t.Name = "file previewer";
			t.Start();
		}
				
		private void previewer_workerthread()
		{
			try
			{
				string[] wantings = Directory.GetFiles( fmanager_working_directory, "*", SearchOption.AllDirectories );
				filemap = new Dictionary<string, string>();

				foreach( string eachfile in wantings )
				{
					string thefilename = new FileInfo( eachfile ).Name;
					if( !filemap.ContainsKey( thefilename ) )
					{
						filemap.Add( thefilename, eachfile );
					}
				}

				var efs = from eachFileEnty in filemap
						  select eachFileEnty.Key;

				List<string> new_entries = efs.ToList();

				entries = new string[new_entries.Count];
				entries = new_entries.ToArray();
				cast_to_view( "" );

				setstatustext( new_entries.Count + " files" );

				stop_indicator( "" );
			}
			catch
			{
				;
			}
		}

		void cast_to_view( string Data )
		{
			try
			{
				if( listBox_files.InvokeRequired )
				{
					SetTextCallback methodcall = new SetTextCallback( cast_to_view );
					listBox_files.Invoke( methodcall, new object[] { Data } );
				}
				else
				{
					listBox_files.Items.Clear();
					listBox_files.Items.AddRange( entries );
				}
			}
			catch
			{
				;
			}

			Application.DoEvents();
		}

		void stop_indicator( string Data )
		{
			try
			{
				if( iTalk_ProgressIndicator1.InvokeRequired )
				{
					SetTextCallback methodcall = new SetTextCallback( stop_indicator );
					iTalk_ProgressIndicator1.Invoke( methodcall, new object[] { Data } );
				}
				else
				{
					iTalk_ProgressIndicator1.Visible = false;
				}
			}
			catch
			{
				;
			}
		}
	}
}
