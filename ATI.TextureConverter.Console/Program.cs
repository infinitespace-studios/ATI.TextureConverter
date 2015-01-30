using System;
using System.Runtime.InteropServices;

namespace ATI.TextureConverter.Console
{
	class MainClass
	{
		public static bool CompressRGBAToATITC(byte[] image, uint width, uint height, out byte[] compressedData, out QFormat format)
		{
			compressedData = null; 
			format = QFormat.Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA;
			var textureIn = NativeMethods.CreateEmptyQonvertImage ();
			var textureOut = NativeMethods.CreateEmptyQonvertImage ();

			textureIn.nWidth = width;
			textureIn.nHeight = height;
			textureIn.nFormat = (uint)QFormat.Q_FORMAT_RGBA_8UI;
			textureIn.nDataSize = width * height * 4;

			GCHandle byteArrayPtr = GCHandle.Alloc(image,GCHandleType.Pinned);

			textureIn.pData = byteArrayPtr.AddrOfPinnedObject ();

			textureOut.nWidth       = width;
			textureOut.nHeight      = height;
			textureOut.nFormat      = (uint)QFormat.Q_FORMAT_ATITC_RGBA;
			textureOut.nDataSize    = 0;
			textureOut.pData        = IntPtr.Zero; 

			if (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS)
				return false;

			System.Diagnostics.Debug.WriteLine ("Format : {0}", (QFormat)textureOut.nFormat);
			System.Diagnostics.Debug.WriteLine ("DataSize : {0" +"}", textureOut.nDataSize);

			compressedData = new byte[textureOut.nDataSize];
			GCHandle compressedDataPtr = GCHandle.Alloc(compressedData,GCHandleType.Pinned);

			textureOut.pData = compressedDataPtr.AddrOfPinnedObject ();

			if (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS)
				return false;

			format = (QFormat)textureOut.nFormat;
			return true;
		}

		public static bool CompressRGBToETC1(byte[] image, uint width, uint height, out byte[] compressedData, out QFormat format)
		{
			compressedData = null; 
			format = QFormat.Q_FORMAT_ETC1_RGB8;
			var textureIn = NativeMethods.CreateEmptyQonvertImage ();
			var textureOut = NativeMethods.CreateEmptyQonvertImage ();

			textureIn.nWidth = width;
			textureIn.nHeight = height;
			textureIn.nFormat = (uint)QFormat.Q_FORMAT_RGB_8UI;
			textureIn.nDataSize = width * height * 3;

			GCHandle byteArrayPtr = GCHandle.Alloc(image,GCHandleType.Pinned);

			textureIn.pData = byteArrayPtr.AddrOfPinnedObject ();

			textureOut.nWidth       = width;
			textureOut.nHeight      = height;
			textureOut.nFormat      = (uint)QFormat.Q_FORMAT_ETC1_RGB8;
			textureOut.nDataSize    = 0;
			textureOut.pData        = IntPtr.Zero; 

			if (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS)
				return false;

			System.Diagnostics.Debug.WriteLine ("Format : {0}", (QFormat)textureOut.nFormat);
			System.Diagnostics.Debug.WriteLine ("DataSize : {0" +"}", textureOut.nDataSize);

			compressedData = new byte[textureOut.nDataSize];
			GCHandle compressedDataPtr = GCHandle.Alloc(compressedData,GCHandleType.Pinned);

			textureOut.pData = compressedDataPtr.AddrOfPinnedObject ();

			if (NativeMethods.Qonvert (ref textureIn, ref textureOut, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS)
				return false;

			format = (QFormat)textureOut.nFormat;
			return true;
		}

		public static void Main (string[] args)
		{
			byte[] data = new byte[128 * 128 * 4];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;

			byte[] compressedData;
			QFormat format;
			if (!MainClass.CompressRGBAToATITC (data, 128, 128, out compressedData, out format))
				System.Console.WriteLine ("Error");


			byte[] data2 = new byte[128 * 128 * 3];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;

			byte[] compressedData2;
			QFormat format2;
			if (!MainClass.CompressRGBToETC1 (data2, 128, 128, out compressedData2, out format2))
				System.Console.WriteLine ("Error");

			System.Console.ReadLine ();
		}
	}
}
