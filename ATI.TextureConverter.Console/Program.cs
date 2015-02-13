using System;
using System.Runtime.InteropServices;

namespace ATI.TextureConverter.Console
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			byte[] data = new byte[128 * 128 * 4];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;

			try {
				byte[] compressed = ATICompressor.Compress (data, 128, 128, ATICompressor.CompressionFormat.AtcRgbaExplicitAlpha);
			} catch {
				System.Console.WriteLine ("Error");
			}

			try {
				byte[] compressed = ATICompressor.Compress (data, 128, 128, ATICompressor.CompressionFormat.AtcRgbaInterpolatedAlpha);
			} catch {
				System.Console.WriteLine ("Error");
			}

			System.Console.ReadLine ();
		}
	}
}
