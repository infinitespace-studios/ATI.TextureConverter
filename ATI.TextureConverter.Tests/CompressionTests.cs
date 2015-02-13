using NUnit.Framework;
using System;
using ATI.TextureConverter;
using System.Runtime.InteropServices;

namespace ATI.TextureConverter.Tests
{
	[TestFixture]
	public class CompressionTests
	{
		[Test]
		public void TestRGBAToATITCCompression ()
		{
			byte[] data = new byte[128 * 128 * 4];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;
			var output = ATICompressor.Compress (data, 128, 128, ATICompressor.CompressionFormat.AtcRgbaExplicitAlpha);
			Assert.AreEqual (16384, output.Length, "Compressed data was not the correct length");
		}

		[Test]
		public void TestRGBToETC1Compression ()
		{
			byte[] data = new byte[128 * 128 * 4];
			for (int i = 0; i < data.Length; i++)
				data [i] = (i % 2) == 0 ? (byte)0 : (byte)1;
			var output = ATICompressor.Compress (data, 128, 128, ATICompressor.CompressionFormat.Etc1);
			Assert.AreEqual (8192, output.Length, "Compressed data was not the correct length");

		}
	}
}

