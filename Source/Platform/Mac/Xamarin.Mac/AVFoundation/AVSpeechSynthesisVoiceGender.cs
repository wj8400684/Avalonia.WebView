using ObjCRuntime;

namespace AVFoundation;

[Introduced(PlatformName.WatchOS, 6, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.iOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.TvOS, 13, 0, PlatformArchitecture.All, null)]
[Introduced(PlatformName.MacOSX, 10, 15, PlatformArchitecture.All, null)]
[Native]
public enum AVSpeechSynthesisVoiceGender : long
{
	Unspecified,
	Male,
	Female
}