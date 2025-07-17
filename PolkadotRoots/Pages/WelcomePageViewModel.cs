

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PlutoFramework.Components.Password;

namespace PolkadotRoots.Pages
{
    public partial class WelcomePageViewModel : ObservableObject
    {
        [RelayCommand]
        public Task JoinAsync() => Shell.Current.Navigation.PushAsync(new SetupPasswordPage
        {
            Navigation = App.GenerateNewAccountAsync
        });
    }
}
