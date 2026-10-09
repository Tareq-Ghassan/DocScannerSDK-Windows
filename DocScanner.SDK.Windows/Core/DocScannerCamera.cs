using DocScanner.SDK.Windows.Models;

namespace DocScanner.SDK.Windows.Core;

/// <summary>
/// Windows document scanner session.
/// Hosts camera preview + white crop overlay and crops on capture.
/// Full MediaCapture integration is the next increment; API surface is stable.
/// </summary>
public sealed class DocScannerCamera
{
    public const string Version = "1.0.0";
    public bool ShowCropOverlay { get; set; } = true;

    public Task StartAsync() => Task.CompletedTask;
    public Task StopAsync() => Task.CompletedTask;

    public Task<ScanResult> CaptureAsync() =>
        Task.FromResult(new ScanResult
        {
            IsSuccess = false,
            ErrorMessage = "MediaCapture crop pipeline not yet wired on this machine target."
        });
}
