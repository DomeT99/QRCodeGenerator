using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
namespace QRCodeGenerator.Models;
internal partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _qrCodeInput;
    [ObservableProperty]
    private string? _qrCodeOutput = "Assets/Splash/meme.png"; // Default value

    [RelayCommand]
    private void GenerateQRCode()
    {

    }
}