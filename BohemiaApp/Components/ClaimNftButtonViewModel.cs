using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.WebView;

namespace BohemiaApp.Components
{
    public partial class ClaimNftButtonViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task OnButtonPressedAsync() {
            await Shell.Current.Navigation.PushAsync(new WebViewPage("https://dotmemo.xyz/claim"));
        }
    }
}
