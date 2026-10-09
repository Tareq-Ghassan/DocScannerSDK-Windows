namespace DocScanner.SDK.Windows.Models;

public sealed class ScanResult
{
    public string? FrontImagePath { get; init; }
    public string? BackImagePath { get; init; }
    public bool IsSuccess { get; init; }
    public string? ErrorMessage { get; init; }
}
