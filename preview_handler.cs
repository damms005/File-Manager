using System.IO;
using System.Threading;
using EPocalipse.IFilter;

namespace File_manager
{
	public partial class MainForm
	{
		public string pdf_previewer( string filename )
		{
			string contents = null;

			ThreadStart ts = new ThreadStart(
				() =>
				{
					try
					{
						PDFParser pdfParser = new PDFParser();

						string temp_file = Path.GetDirectoryName( filename );

						temp_file = Path.Combine( temp_file, Path.GetFileNameWithoutExtension( filename ) + ".txt" );

						pdfParser.ExtractText( filename, temp_file );

						if( File.Exists( temp_file ) )
						{
							using( StreamReader fs_reader = new StreamReader( temp_file ) )
							{
								contents = fs_reader.ReadToEnd();
								fs_reader.Close();
							}

							File.Delete( temp_file );
						}

						if( contents != null )
						{
							this.setpreviewedcontent( contents );
						}
						else
						{
							setpreviewedcontent( "Error: file format not supported!" );
						}
					}
					catch
					{
						setpreviewedcontent( "Error: corrupted file!" );
					}

					stop_indicator( "" );
				}
		);

			Thread t = new Thread( ts );
			t.IsBackground = true;
			t.Start();

			while( !t.IsAlive )
			{
				Thread.Sleep( 100 );
			}
			try
			{
				//t.Join();
			}
			catch
			{
				;
			}


			return contents;
		}


		public string ms_office_previewer( string filename )
		{
			string contents = null;

			ThreadStart ts = new ThreadStart(
				() =>
				{
					try
					{
						TextReader reader = new FilterReader( filename );
						using( reader )
						{
							contents = reader.ReadToEnd();
						}

						if( contents != null )
						{
							this.setpreviewedcontent( contents );
						}
						else
						{
							setpreviewedcontent( "Error: file format not supported!" );
						}
					}
					catch
					{
						setpreviewedcontent( "Error: corrupted file!" );
					}

					stop_indicator( "" );
				}
		);

			Thread t = new Thread( ts );
			t.IsBackground = true;
			t.Start();

			while( !t.IsAlive )
			{
				Thread.Sleep( 100 );
			}
			try
			{
				//t.Join();
			}
			catch
			{
				;
			}


			return contents;
		}
	}
}
