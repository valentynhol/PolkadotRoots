using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.WebView;
using PlutoFramework.Model;
using Substrate.NetApi;

namespace PolkadotRoots.Components
{
    public partial class ClaimNftButtonViewModel : ObservableObject
    {
        [ObservableProperty]
        string code = "";

        [RelayCommand]
        public async Task OnButtonPressedAsync() {
            await Shell.Current.Navigation.PushAsync(new WebViewPage($"https://dotmemo.xyz/claim/{code}?address={Utils.GetAddressFrom(KeysModel.GetPublicKeyBytes(), 0)}"));
        }
    }
}
