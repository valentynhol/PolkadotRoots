namespace PolkadotRoots.Components;

public partial class PlayWudButtonView : ContentView
{
	public PlayWudButtonView()
	{
		InitializeComponent();

        BindingContext = new PlayWudButtonViewModel();
    }
}