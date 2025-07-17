using PlutoFramework.Templates.PageTemplate;

namespace PolkadotRoots.Pages;

public partial class SettingsPage : PageTemplate
{
	public SettingsPage()
	{
		InitializeComponent();

		BindingContext = new SettingsPageViewModel();
    }
}