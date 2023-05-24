﻿namespace Linux.WebView.Core;

public interface ILinuxWebView : IDisposable
{
    WebKit.WebView WebView { get; }
    nint NativeHandle { get; }
}