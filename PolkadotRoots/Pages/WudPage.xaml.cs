using PlutoFramework.Components.NetworkSelect;
using PlutoFramework.Model;

namespace PolkadotRoots.Pages;

public partial class WudPage : ContentPage
{

	public WudPage()
	{
        NavigationPage.SetHasNavigationBar(this, false);
        Shell.SetNavBarIsVisible(this, false);

        InitializeComponent();
    }
}