# ATI.TextureConverter
A C# Wrapper for the TextureConverter native library to allow developers to convert images to ATI supported compressed textures.
Such as ATITC and ETC1

## Installation

In order to use this library you need to download the appropriate native TextureConverter dymanic library for your system. To do that you *MUST* sign up for Qualcomm's developer program and accept their licence terms. You can then download the appropriate Adreno SDK from 

https://developer.qualcomm.com/mobile-development/maximize-hardware/mobile-gaming-graphics-adreno

Once you have extracted the files you will need to copy the appropriate library into the same directory as the ATI.TextureConverter assembly.

* MacOS   : libTextureConverter.dylib
* Linux   : libTextureConverter.so
* Windows : TextureConverter.dll

*Note*, the mac library is 32 bit only. There are both 32 and 64 bit versions of the linux and windows libraries available. Make sure you use the correct one.

## Usage

Once you have the native library you should then be able and a reference to your project and do the following

```csharp
byte[] compressed = ATICompressor.Compress (data, 128, 128, ATICompressor.CompressionFormat.AtcRgbaExplicitAlpha);
```

NOTE the input data MUST be in RGBA 32 bit format (8 bits per pixel). The library will throw an exception if anything goes wrong, if all is well the data returned will be the raw compressed data. The raw data has no information about width or height it is just the raw compressed pixels. You will need to figure out how to load and use it in your own code.

The different types of compression supported are 

* AtcRgbaExplicitAlpha
* AtcRgbaInterpolatedAlpha
* AtcRgb
* Etc1
* Etc2Rgba

more might be added in the future.
	
