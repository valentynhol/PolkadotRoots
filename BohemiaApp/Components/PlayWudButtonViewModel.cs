using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.WebView;

namespace BohemiaApp.Components
{
    public partial class PlayWudButtonViewModel : ObservableObject
    {
        [RelayCommand]
        public async Task OnButtonPressedAsync()
        {
            await Shell.Current.Navigation.PushAsync(new WebViewPage("https://flappywud.lol"));
        }
    }
}
