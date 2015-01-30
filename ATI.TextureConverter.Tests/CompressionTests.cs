using NUnit.Framework;
using System;
using ATI.TextureConverter;
using System.Runtime.InteropServices;

namespace ATI.TextureConverter.Tests
{
	[TestFixture ()]
	public class CompressionTests
	{
		[Test ()]
		public void TestRGBAToATITCCompression ()
		{
			byte[] compressedData = null; 
			QFormat format = QFormat.Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA;

			uint width = 128;
			uint height = 128;

			byte[] data = new byte[width * height * 4];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;

			var textureIn = NativeMethods.CreateEmptyQonvertImage ();
			var textureOut = NativeMethods.CreateEmptyQonvertImage ();

			textureIn.nWidth = width;
			textureIn.nHeight = height;
			textureIn.nFormat = (uint)QFormat.Q_FORMAT_RGBA_8UI;
			textureIn.nDataSize = width * height * 4;

			GCHandle byteArrayPtr = GCHandle.Alloc(data,GCHandleType.Pinned);

			textureIn.pData = byteArrayPtr.AddrOfPinnedObject ();

			textureOut.nWidth       = width;
			textureOut.nHeight      = height;
			textureOut.nFormat      = (uint)QFormat.Q_FORMAT_ATITC_RGBA;
			textureOut.nDataSize    = 0;
			textureOut.pData        = IntPtr.Zero; 

			Assert.IsTrue (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) == (uint)TReturnCode.Q_SUCCESS, "Qovert failed to get data size");

			Assert.AreEqual (16384,textureOut.nDataSize, "Dataize is not what was expected");
			Assert.AreEqual (QFormat.Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA, (QFormat)textureOut.nFormat, "Format is not what was expected");

			compressedData = new byte[textureOut.nDataSize];
			GCHandle compressedDataPtr = GCHandle.Alloc(compressedData,GCHandleType.Pinned);

			textureOut.pData = compressedDataPtr.AddrOfPinnedObject ();

			Assert.IsTrue (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) == (uint)TReturnCode.Q_SUCCESS,"Qovert Failed to compress image");
		
		}

		[Test ()]
		public void TestRGBToETC1Compression ()
		{
			byte[] compressedData = null; 
			QFormat format = QFormat.Q_FORMAT_ETC1_RGB8;


			uint width = 128;
			uint height = 128;

			byte[] data = new byte[width * height * 3];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;

			var textureIn = NativeMethods.CreateEmptyQonvertImage ();
			var textureOut = NativeMethods.CreateEmptyQonvertImage ();

			textureIn.nWidth = width;
			textureIn.nHeight = height;
			textureIn.nFormat = (uint)QFormat.Q_FORMAT_RGB_8UI;
			textureIn.nDataSize = width * height * 4;

			GCHandle byteArrayPtr = GCHandle.Alloc(data,GCHandleType.Pinned);

			textureIn.pData = byteArrayPtr.AddrOfPinnedObject ();

			textureOut.nWidth       = width;
			textureOut.nHeight      = height;
			textureOut.nFormat      = (uint)QFormat.Q_FORMAT_ETC1_RGB8;
			textureOut.nDataSize    = 0;
			textureOut.pData        = IntPtr.Zero; 

			Assert.IsTrue (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) == (uint)TReturnCode.Q_SUCCESS, "Qovert failed to get data size");

			Assert.AreEqual (8192,textureOut.nDataSize, "Dataize is not what was expected");
			Assert.AreEqual (QFormat.Q_FORMAT_ETC1_RGB8, (QFormat)textureOut.nFormat, "Format is not what was expected");

			compressedData = new byte[textureOut.nDataSize];
			GCHandle compressedDataPtr = GCHandle.Alloc(compressedData,GCHandleType.Pinned);

			textureOut.pData = compressedDataPtr.AddrOfPinnedObject ();

			Assert.IsTrue (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) == (uint)TReturnCode.Q_SUCCESS,"Qovert Failed to compress image");

		}
	}
}

