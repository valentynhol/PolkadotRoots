using PlutoFramework.Components.WebView;

namespace BohemiaApp.Components;

public partial class ClaimNftButtonView : ContentView
{
	public ClaimNftButtonView()
	{
		InitializeComponent();

        BindingContext = new ClaimNftButtonViewModel();
    }
}