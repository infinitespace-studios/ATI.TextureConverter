﻿using System;
using System.Runtime.InteropServices;

namespace ATI.TextureConverter
{
	internal enum QFormat : uint
	{

		/// Q_FORMAT_RGBA_8UI -> 1
		Q_FORMAT_RGBA_8UI = 1,

		Q_FORMAT_RGBA_8I,

		Q_FORMAT_RGB5_A1UI,

		Q_FORMAT_RGBA_4444,

		Q_FORMAT_RGBA_16UI,

		Q_FORMAT_RGBA_16I,

		Q_FORMAT_RGBA_32UI,

		Q_FORMAT_RGBA_32I,

		Q_FORMAT_PALETTE_8_RGBA_8888,

		Q_FORMAT_PALETTE_8_RGBA_5551,

		Q_FORMAT_PALETTE_8_RGBA_4444,

		Q_FORMAT_PALETTE_4_RGBA_8888,

		Q_FORMAT_PALETTE_4_RGBA_5551,

		Q_FORMAT_PALETTE_4_RGBA_4444,

		Q_FORMAT_PALETTE_1_RGBA_8888,

		Q_FORMAT_PALETTE_8_RGB_888,

		Q_FORMAT_PALETTE_8_RGB_565,

		Q_FORMAT_PALETTE_4_RGB_888,

		Q_FORMAT_PALETTE_4_RGB_565,

		Q_FORMAT_R2_GBA10UI,

		Q_FORMAT_RGB10_A2UI,

		Q_FORMAT_RGB10_A2I,

		Q_FORMAT_RGBA_F,

		Q_FORMAT_RGBA_HF,

		Q_FORMAT_RGB9_E5,

		Q_FORMAT_RGB_8UI,

		Q_FORMAT_RGB_8I,

		Q_FORMAT_RGB_565,

		Q_FORMAT_RGB_16UI,

		Q_FORMAT_RGB_16I,

		Q_FORMAT_RGB_32UI,

		Q_FORMAT_RGB_32I,

		Q_FORMAT_RGB_F,

		Q_FORMAT_RGB_HF,

		Q_FORMAT_RGB_11_11_10_F,

		Q_FORMAT_RG_F,

		Q_FORMAT_RG_HF,

		Q_FORMAT_RG_32UI,

		Q_FORMAT_RG_32I,

		Q_FORMAT_RG_16I,

		Q_FORMAT_RG_16UI,

		Q_FORMAT_RG_8I,

		Q_FORMAT_RG_8UI,

		Q_FORMAT_RG_S88,

		Q_FORMAT_R_32UI,

		Q_FORMAT_R_32I,

		Q_FORMAT_R_F,

		Q_FORMAT_R_16F,

		Q_FORMAT_R_16I,

		Q_FORMAT_R_16UI,

		Q_FORMAT_R_8I,

		Q_FORMAT_R_8UI,

		Q_FORMAT_LUMINANCE_ALPHA_88,

		Q_FORMAT_LUMINANCE_8,

		Q_FORMAT_ALPHA_8,

		Q_FORMAT_LUMINANCE_ALPHA_F,

		Q_FORMAT_LUMINANCE_F,

		Q_FORMAT_ALPHA_F,

		Q_FORMAT_LUMINANCE_ALPHA_HF,

		Q_FORMAT_LUMINANCE_HF,

		Q_FORMAT_ALPHA_HF,

		Q_FORMAT_DEPTH_16,

		Q_FORMAT_DEPTH_24,

		Q_FORMAT_DEPTH_24_STENCIL_8,

		Q_FORMAT_DEPTH_32,

		Q_FORMAT_BGR_565,

		Q_FORMAT_BGRA_8888,

		Q_FORMAT_BGRA_5551,

		Q_FORMAT_BGRX_8888,

		Q_FORMAT_BGRA_4444,

		Q_FORMAT_ATITC_RGBA,

		/// Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA -> Q_FORMAT_ATITC_RGBA
		Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA = QFormat.Q_FORMAT_ATITC_RGBA,

		Q_FORMAT_ATITC_RGB,

		/// Q_FORMAT_ATC_RGB -> Q_FORMAT_ATITC_RGB
		Q_FORMAT_ATC_RGB = QFormat.Q_FORMAT_ATITC_RGB,

		Q_FORMAT_ATC_RGBA_INTERPOLATED_ALPHA,

		Q_FORMAT_ETC1_RGB8,

		Q_FORMAT_3DC_X,

		Q_FORMAT_3DC_XY,

		Q_FORMAT_ETC2_RGB8,

		Q_FORMAT_ETC2_RGBA8,

		Q_FORMAT_ETC2_RGB8_PUNCHTHROUGH_ALPHA1,

		Q_FORMAT_ETC2_SRGB8,

		Q_FORMAT_ETC2_SRGB8_ALPHA8,

		Q_FORMAT_ETC2_SRGB8_PUNCHTHROUGH_ALPHA1,

		Q_FORMAT_EAC_R_SIGNED,

		Q_FORMAT_EAC_R_UNSIGNED,

		Q_FORMAT_EAC_RG_SIGNED,

		Q_FORMAT_EAC_RG_UNSIGNED,

		Q_FORMAT_S3TC_DXT1_RGB,

		Q_FORMAT_S3TC_DXT1_RGBA,

		Q_FORMAT_S3TC_DXT3_RGBA,

		Q_FORMAT_S3TC_DXT5_RGBA,

		Q_FORMAT_AYUV_32,

		Q_FORMAT_I444_24,

		Q_FORMAT_YUYV_16,

		Q_FORMAT_UYVY_16,

		Q_FORMAT_I420_12,

		Q_FORMAT_YV12_12,

		Q_FORMAT_NV21_12,

		Q_FORMAT_NV12_12,

		Q_FORMAT_ASTC_8,

		Q_FORMAT_ASTC_16,
	}

	internal enum TEncodeFlag
	{

		/// Q_FLAG_ENCODE_NONE -> 0
		Q_FLAG_ENCODE_NONE = 0,

		/// Q_FLAG_ENCODE_DEFAULT -> 0
		Q_FLAG_ENCODE_DEFAULT = 0,

		Q_FLAG_ENCODE_ATITC_FAST,
	}

	internal enum TScaleFilterFlag
	{

		/// Q_FLAG_SCALEFILTER_DEFAULT -> 0
		Q_FLAG_SCALEFILTER_DEFAULT = 0,

		Q_FLAG_SCALEFILTER_NEAREST,

		Q_FLAG_SCALEFILTER_MEAN,

		Q_FLAG_SCALEFILTER_BILINEAR,

		Q_FLAG_SCALEFILTER_BICUBIC,

		Q_FLAG_SCALEFILTER_KAISER,
	}

	internal enum TNormalMapFlag
	{

		/// Q_FLAG_NORMALMAP_NONE -> 0
		Q_FLAG_NORMALMAP_NONE = 0,

		Q_FLAG_NORMALMAP_ROBERTSCROSS,

		Q_FLAG_NORMALMAP_SOBEL,

		Q_FLAG_NORMALMAP_PREWITTGRADIENT,
	}

	internal enum TDebugFlags
	{

		/// Q_FLAG_DEBUG_DEFAULT -> 0
		Q_FLAG_DEBUG_DEFAULT = 0,

		/// Q_FLAG_DEBUG_DISABLE_VERBOSE -> 0x00000001
		Q_FLAG_DEBUG_DISABLE_VERBOSE = 1,

		/// Q_FLAG_DEBUG_VERSION -> 0x00000002
		Q_FLAG_DEBUG_VERSION = 2,
	}

	internal enum TReturnCode
	{

		/// Q_SUCCESS -> 0
		Q_SUCCESS = 0,

		Q_ERROR_UNSUPPORTED_DIMENSIONS,

		Q_ERROR_UNSUPPORTED_SRC_FORMAT,

		Q_ERROR_UNSUPPORTED_DST_FORMAT,

		Q_ERROR_UNSUPPORTED_SRC_FORMAT_FLAG,

		Q_ERROR_UNSUPPORTED_DST_FORMAT_FLAG,

		Q_ERROR_INCORRECT_SRC_PARAMETER,

		Q_ERROR_INCORRECT_DST_PARAMETER,

		Q_ERROR_INCORRECT_DATASIZE,

		Q_ERROR_OTHER,
	}

	[System.Runtime.InteropServices.StructLayoutAttribute (System.Runtime.InteropServices.LayoutKind.Sequential)]
	internal struct TFormatFlags
	{

		/// unsigned int
		public uint nStride;

		/// unsigned int
		public uint nMaskRed;

		/// unsigned int
		public uint nMaskGreen;

		/// unsigned int
		public uint nMaskBlue;

		/// unsigned int
		public uint nMaskAlpha;

		/// unsigned int
		public uint nFlipX;

		/// unsigned int
		public uint nFlipY;

		/// unsigned int
		public uint nEncodeFlag;

		/// unsigned int
		public uint nScaleFilterFlag;

		/// unsigned int
		public uint nNormalMapFlag;

		/// unsigned int
		public uint nNormalMapScale;

		/// unsigned int
		public uint nNormalMapWrap;

		/// unsigned int
		public uint nDebugFlags;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute (System.Runtime.InteropServices.LayoutKind.Sequential)]
	internal struct TQonvertImage
	{

		/// unsigned int
		public uint nWidth;

		/// unsigned int
		public uint nHeight;

		/// unsigned int
		public uint nFormat;

		/// TFormatFlags*
		public System.IntPtr pFormatFlags;

		/// unsigned int
		public uint nDataSize;

		/// unsigned char*
		//[MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)]
		public System.IntPtr pData;

		/// void*
		public System.IntPtr compressionOptions;
	}

	internal enum CompressionOptionsType
	{

		/// CompType_None -> 0
		CompType_None = 0,

		CompType_ASTC,

		CompType_ASTC_16,

		CompType_Count,
	}

	internal enum ASTCCompressionOptionsSpeed
	{

		/// ASTC_EXHAUSTIVE -> 0
		ASTC_EXHAUSTIVE = 0,

		ASTC_THOROUGH,

		ASTC_MEDIUM,

		ASTC_FAST,

		ASTC_VERY_FAST,
	}

	internal enum ASTCCompressionOptionsMode
	{

		/// ASTC_HDR -> 0
		ASTC_HDR = 0,

		ASTC_SRGB,

		ASTC_LINEAR,
	}

	internal enum ASTCCompressionOptionsDefaultOrCustom
	{

		/// DEFAULT -> 0
		DEFAULT = 0,

		CUSTOM,
	}

	internal enum ASTCCompressionOptionsUseBitRate
	{

		/// USE_BITRATE -> 0
		USE_BITRATE = 0,

		USE_BLOCK_DIMENSIONS,
	}

	internal enum ASTCCompressionOptionsCommand
	{

		/// COMPRESS -> 0
		COMPRESS = 0,

		DECOMPRESS,
	}

	internal enum ASTC_BIT_FIDELITY
	{

		/// ASTC_8_BIT -> 1
		ASTC_8_BIT = 1,

		ASTC_16_BIT,

		ASTC_32_BIT,
	}

	[System.Runtime.InteropServices.StructLayoutAttribute (System.Runtime.InteropServices.LayoutKind.Sequential)]
	internal struct ASTCOptions
	{

		/// int
		public int CompressionSpeed;

		/// int
		public int CompressionMode;

		/// int
		public int UseBitRate;

		/// float
		public float BitRate;

		/// int
		public int xDimension;

		/// int
		public int yDimension;

		/// int
		public int UseBuiltInOptimizations;

		/// int
		public int ApplyPSNROptimization;

		/// int
		public int ApplyPerceptualOptimization;

		/// int
		public int ApplyMaskOptimization;

		/// int
		public int ApplyAlphaOptimization;

		/// int
		public int ApplyHDROptimization;

		/// int
		public int ApplyHDRWithAlphaChannelOptimization;

		/// int
		public int ApplyHDRForLogErrorOptimization;

		/// int
		public int ApplyHDRWithAlphaChannelForLogErrorOptimization;

		/// int
		public int BitFidelity;

		/// int
		public int ASTCCompressionMode;

		/// unsigned char*
		[System.Runtime.InteropServices.MarshalAsAttribute (System.Runtime.InteropServices.UnmanagedType.LPStr)]
		public string astc_pData;

		/// TQonvertImage*
		public System.IntPtr astc_pSrc;

		/// TQonvertImage*
		public System.IntPtr astc_pDest;
	}

	[System.Runtime.InteropServices.StructLayoutAttribute (System.Runtime.InteropServices.LayoutKind.Sequential)]
	internal struct StandardOptions
	{

		/// int
		public int ImageType;

		/// int
		public int CompressionType;

		/// void*
		public System.IntPtr CompressionOptions;
	}

	internal partial class NativeMethods
	{

		/// Return Type: unsigned short
		///nByte: unsigned char
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "UByteToUInt16")]
		public static extern  ushort UByteToUInt16 (byte nByte) ;


		/// Return Type: short
		///nByte: unsigned char
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "UByteToInt16")]
		public static extern  short UByteToInt16 (byte nByte) ;


		/// Return Type: _TQonvertImage*
		///param0: _TQonvertImage*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "NewTQonvertImage")]
		public static extern  System.IntPtr NewTQonvertImage (ref TQonvertImage param0) ;


		/// Return Type: unsigned int
		///pSrcImg: TQonvertImage*
		///pDstImg: TQonvertImage*
		///options: void*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "Qonvert")]
		public static extern  uint Qonvert (ref TQonvertImage pSrcImg, ref TQonvertImage pDstImg, System.IntPtr options) ;


		/// Return Type: _ASTCOptions*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "NewASTCOptions")]
		public static extern  System.IntPtr NewASTCOptions () ;


		/// Return Type: _ASTCOptions*
		///param0: _ASTCOptions*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "NewASTCOptionsCopy")]
		public static extern  System.IntPtr NewASTCOptionsCopy (ref ASTCOptions param0) ;


		/// Return Type: boolean
		///me: _ASTCOptions*
		///other: _ASTCOptions*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "ASTCOptionsEqual")]
		[return: System.Runtime.InteropServices.MarshalAsAttribute (System.Runtime.InteropServices.UnmanagedType.I1)]
		public static extern  bool ASTCOptionsEqual (ref ASTCOptions me, ref ASTCOptions other) ;


		/// Return Type: _StandardOptions*
		///param0: int
		///param1: int
		///param2: void*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "NewStandardOptions")]
		public static extern  System.IntPtr NewStandardOptions (int param0, int param1, System.IntPtr param2) ;


		/// Return Type: _StandardOptions*
		///options: _StandardOptions*
		[System.Runtime.InteropServices.DllImportAttribute ("TextureConverter", EntryPoint = "NewStandardOptionsCopy")]
		public static extern  System.IntPtr NewStandardOptionsCopy (ref StandardOptions options) ;

		static T Alloc<T> ()
		{
			int typeSize = Marshal.SizeOf (typeof(T));
			unsafe {
				IntPtr ptr = Marshal.AllocHGlobal (typeSize);
				byte* basePtr = (byte*)ptr.ToPointer ();
				for (int idx = 0; idx < typeSize; idx++)
					*basePtr++ = 0;
				return (T)Marshal.PtrToStructure (ptr, typeof(T));
			}
		}

		public static TQonvertImage CreateEmptyQonvertImage ()
		{
			return Alloc<TQonvertImage> ();
		}

		public static TFormatFlags CreateFormatFlags() {
			return Alloc<TFormatFlags> ();
		}

	}

	public class ATICompressor {

		public enum CompressionFormat
		{
			AtcRgbaExplicitAlpha,
			AtcRgbaInterpolatedAlpha,
			AtcRgb,
			Etc1,
			Etc2Rgba
		}

		public static byte[] Compress(byte[] data, int width, int height, CompressionFormat targetFormat)
		{
			try {
				QFormat format = QFormat.Q_FORMAT_RGBA_8UI;
				switch (targetFormat) {
				case CompressionFormat.AtcRgb:
					format = QFormat.Q_FORMAT_ATC_RGB;
					break;
				case CompressionFormat.AtcRgbaExplicitAlpha:
					format = QFormat.Q_FORMAT_ATC_RGBA_EXPLICIT_ALPHA;
					break;
				case CompressionFormat.AtcRgbaInterpolatedAlpha:
					format = QFormat.Q_FORMAT_ATC_RGBA_INTERPOLATED_ALPHA;
					break;
				case CompressionFormat.Etc1:
					format = QFormat.Q_FORMAT_ETC1_RGB8;
					break;
				case CompressionFormat.Etc2Rgba:
					format = QFormat.Q_FORMAT_ETC2_RGBA8;
					break;
				}

				uint uwidth = (uint)width;
				uint uheight = (uint)height;

				var src = NativeMethods.CreateEmptyQonvertImage ();
				var dst = NativeMethods.CreateEmptyQonvertImage ();

				var handle = GCHandle.Alloc (data, GCHandleType.Pinned);
				try {
					src.nWidth = uwidth;
					src.nHeight = uheight;
					src.nFormat = (uint)QFormat.Q_FORMAT_RGBA_8UI;
					src.pData = handle.AddrOfPinnedObject();

					dst.nWidth = uwidth;
					dst.nHeight = uheight;
					dst.nFormat = (uint)format;
					dst.pData = IntPtr.Zero;

					if (NativeMethods.Qonvert (ref src, ref dst, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS) {
						throw new Exception("Error getting compressed data size for ATC Compression");
					}

					byte[] compressed = new byte[dst.nDataSize];
					var compressedHandle = GCHandle.Alloc (compressed, GCHandleType.Pinned);
					try {
						dst.pData = compressedHandle.AddrOfPinnedObject ();

						if (NativeMethods.Qonvert (ref src, ref dst, IntPtr.Zero) != (uint)TReturnCode.Q_SUCCESS) {
							throw new Exception("Error getting compressed texture ATC Compression");
						}
						return compressed;
					} finally {
						compressedHandle.Free ();
					}

				} finally {
					handle.Free ();
				}
			} catch (DllNotFoundException ex) {
				throw new DllNotFoundException (string.Format("{0}{1}See Documentation for more details {1}{2}",ex.Message,
					Environment.NewLine,
					"https://github.com/infinitespace-studios/ATI.TextureConverter/blob/main/README.md"));
			}
		}
	}

}

