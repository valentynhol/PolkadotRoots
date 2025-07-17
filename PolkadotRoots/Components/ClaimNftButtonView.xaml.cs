using PlutoFramework.Components.WebView;

namespace PolkadotRoots.Components;

public partial class ClaimNftButtonView : ContentView
{
	public ClaimNftButtonView()
	{
		InitializeComponent();

        BindingContext = new ClaimNftButtonViewModel();
    }
}