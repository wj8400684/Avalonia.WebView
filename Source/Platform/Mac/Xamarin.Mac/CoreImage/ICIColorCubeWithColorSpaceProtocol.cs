using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;

namespace CoreImage;

[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Protocol(Name = "CIColorCubeWithColorSpace", WrapperType = typeof(CIColorCubeWithColorSpaceProtocolWrapper))]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "InputImage", Selector = "inputImage", PropertyType = typeof(CIImage), GetterSelector = "inputImage", SetterSelector = "setInputImage:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubeDimension", Selector = "cubeDimension", PropertyType = typeof(float), GetterSelector = "cubeDimension", SetterSelector = "setCubeDimension:", ArgumentSemantic = ArgumentSemantic.None)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "CubeData", Selector = "cubeData", PropertyType = typeof(NSData), GetterSelector = "cubeData", SetterSelector = "setCubeData:", ArgumentSemantic = ArgumentSemantic.Retain)]
[ProtocolMember(IsRequired = true, IsProperty = true, IsStatic = false, Name = "ColorSpace", Selector = "colorSpace", PropertyType = typeof(CGColorSpace), GetterSelector = "colorSpace", SetterSelector = "setColorSpace:", ArgumentSemantic = ArgumentSemantic.Assign)]
public interface ICIColorCubeWithColorSpaceProtocol : INativeObject, IDisposable, ICIFilterProtocol
{
	[Preserve(Conditional = true)]
	CIImage? InputImage
	{
		[Export("inputImage", ArgumentSemantic.Retain)]
		get;
		[Export("setInputImage:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	float CubeDimension
	{
		[Export("cubeDimension")]
		get;
		[Export("setCubeDimension:")]
		set;
	}

	[Preserve(Conditional = true)]
	NSData CubeData
	{
		[Export("cubeData", ArgumentSemantic.Retain)]
		get;
		[Export("setCubeData:", ArgumentSemantic.Retain)]
		set;
	}

	[Preserve(Conditional = true)]
	CGColorSpace? ColorSpace
	{
		[Export("colorSpace", ArgumentSemantic.Assign)]
		get;
		[Export("setColorSpace:", ArgumentSemantic.Assign)]
		set;
	}
}