using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace File_manager
{

	public class I_O_Class
	{
		private static MD5 md5 = MD5.Create();
		internal static string badFile = "";
		internal static string Class_arms = "";
		private const int defBufferSize = 0xfa00;
		private const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;
		internal static string grading = "";
		internal static string high_classes = "";
		public bool IO_ErrorHappened = false;
		public bool IO_lockdown = false;
		public bool IO_readErrorHappened = false;
		public bool IsWriteOperation = false;
		public string lastError = "";
		public string logo = "";
		internal static Dictionary<string, string> promoCriteriaManager = new Dictionary<string, string>();
		internal static string promotion_criteria = "";
		internal static string promotionCrit_mode = "";
		internal static string quotient = "";
		internal static readonly object safe_IO_threadLock = new object();
		internal static string school_config = "";
		internal static string school_data = "";
		public string sep = Path.DirectorySeparatorChar.ToString();
		internal static string sss_classifications = "";
		internal static string status = "";

		public string ByteArrayToString( byte[] ba )
		{
			return BitConverter.ToString( ba ).Replace( "-", "" );
		}

		[DllImport( "kernel32", SetLastError = true )]
		private static extern SafeFileHandle CreateFile( string FileName, uint DesiredAccess, uint ShareMode, IntPtr SecurityAttributes, uint CreationDisposition, uint FlagsAndAttributes, IntPtr hTemplate );
		
		private void display_IO_data_loss_message( string fileName )
		{
			MessageBox.Show( "Loss of data due to a previous I/O interruption\r\n\r\nFile: " + fileName, "SchoolServer Data Loss", MessageBoxButtons.OK, MessageBoxIcon.Hand );
		}

		private void display_IO_warning_message( string fileName )
		{
			MessageBox.Show( "Possible loss of data due to a previous I/O interruption\r\n\r\nFile: " + fileName, "SchoolServer I/O Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
		}

		private void endIOoperation( string originalFilename )
		{
			string path = originalFilename + ".ssmonitor";
			string str2 = originalFilename + ".ssbuffer";
			try
			{
				if( System.IO.File.Exists( str2 ) )
				{
					System.IO.File.Delete( str2 );
				}
				if( System.IO.File.Exists( path ) )
				{
					System.IO.File.Delete( path );
				}
			}
			catch
			{
			}
		}

		[DllImport( "kernel32", SetLastError = true )]
		private static extern int FlushFileBuffers( SafeFileHandle handle );

		public byte[] GetEncryptedByteStream( string stringToEncrypt )
		{
			IO_ErrorHappened = false;
			ICryptoTransform transform = new DESCryptoServiceProvider { Key = Encoding.UTF8.GetBytes( "13^07v90" ), IV = Encoding.UTF8.GetBytes( "13^07v90" ), Padding = PaddingMode.PKCS7 }.CreateEncryptor();
			byte[] bytes = Encoding.UTF8.GetBytes( stringToEncrypt );
			byte[] buffer2 = new byte[1];
			using( MemoryStream stream = new MemoryStream() )
			{
				using( CryptoStream stream2 = new CryptoStream( stream, transform, CryptoStreamMode.Write ) )
				{
					try
					{
						stream2.Write( bytes, 0, bytes.Length );
						stream2.Flush();
						buffer2 = new byte[stream.Length];
						buffer2 = stream.ToArray();
						stream2.Close();
						stream.Close();
					}
					catch( Exception exception )
					{
						MessageBox.Show( "Outside error: " + exception.Message );
						IO_ErrorHappened = true;
						return new byte[1];
					}
				}
			}
			return buffer2;
		}

		private bool hardCopy( string source, string dest )
		{
			bool flag;
			try
			{
				if( System.IO.File.Exists( dest ) )
				{
					System.IO.File.Delete( dest );
				}
				SafeFileHandle handle = CreateFile( source, 1, 3, IntPtr.Zero, 4, 0x80000000, IntPtr.Zero );
				SafeFileHandle handle2 = CreateFile( dest, 2, 3, IntPtr.Zero, 4, 0x80000000, IntPtr.Zero );
				using( FileStream stream = new FileStream( handle, FileAccess.Read ) )
				{
					using( FileStream stream2 = new FileStream( handle2, FileAccess.Write ) )
					{
						byte[] buffer = new byte[stream.Length];
						int offset = 0;
						int count = 0xfa00;
						int num3 = 0;
						long length = stream.Length;
						while( length > 0L )
						{
							if( count > length )
							{
								count = ( int )length;
							}
							num3 += stream.Read( buffer, offset, count );
							length = stream.Length - num3;
							offset = num3;
						}
						offset = 0;
						length = stream.Length;
						count = 0xfa00;
						while( length > 0L )
						{
							if( count > length )
							{
								count = ( int )length;
							}
							stream2.Write( buffer, offset, count );
							offset += count;
							length = stream.Length - offset;
						}
						stream2.Flush( true );


						int outcome = FlushFileBuffers( handle2 );
						int error = Marshal.GetLastWin32Error();
						if( error != 0 )
						{
							MessageBox.Show( "Data write error: " + ( new Win32Exception( error ).Message ) );
							return false;
						}




						flag = true;
					}
				}
			}
			catch( Exception exception )
			{
				MessageBox.Show( exception.ToString() );
				flag = false;
			}
			return flag;
		}

		internal static string plainTextReader( string fLocation )
		{
			if( System.IO.File.Exists( fLocation ) )
			{
				try
				{
					using( FileStream stream = new FileStream( fLocation, FileMode.Open, FileAccess.Read, FileShare.ReadWrite ) )
					{
						using( StreamReader reader = new StreamReader( stream ) )
						{
							return reader.ReadToEnd();
						}
					}
				}
				catch
				{
				}
			}
			else
			{
				MessageBox.Show( fLocation + " does not exist" );
			}
			return "";
		}

		public bool plainTextWriter( string content, string fLocation )
		{
			try
			{
				if( System.IO.File.Exists( fLocation ) )
				{
					System.IO.File.Delete( fLocation );
				}
				using( FileStream stream = new FileStream( fLocation, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite ) )
				{
					using( StreamWriter writer = new StreamWriter( stream ) )
					{
						writer.Write( content );
						return true;
					}
				}
			}
			catch( Exception exception )
			{
				lastError = exception.Message;
			}
			return false;
		}

	}
}

