using CommunityToolkit.Mvvm.Input;

namespace PolkadotRoots.Components.BottomNavBar;

public partial class NavBarButtonView : ContentView
{
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(
        nameof(Title), typeof(string), typeof(NavBarButtonView),
        defaultValue: string.Empty, defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (NavBarButtonView)bindable;
            control.titleLabel.Text = (string)newValue;
        });

    public static readonly BindableProperty IconUnselectedProperty = BindableProperty.Create(
        nameof(IconUnselected), typeof(ImageSource), typeof(NavBarButtonView),
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (NavBarButtonView)bindable;
            control.iconUnselected.Source = (ImageSource)newValue;
        });

    public static readonly BindableProperty IconSelectedProperty = BindableProperty.Create(
        nameof(IconSelected), typeof(ImageSource), typeof(NavBarButtonView),
        defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (NavBarButtonView)bindable;
            control.iconSelected.Source = (ImageSource)newValue;
        });

    public static readonly BindableProperty IsSelectedProperty = BindableProperty.Create(
        nameof(IsSelected), typeof(bool), typeof(NavBarButtonView),
        defaultValue: false, defaultBindingMode: BindingMode.TwoWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (NavBarButtonView)bindable;
            control.iconUnselected.IsVisible = !(bool)newValue;
            control.iconSelected.IsVisible = (bool)newValue;

            control.selectedHighlight.IsVisible = (bool)newValue;

            if ((bool)newValue)
            {
                control.titleLabel.TextColor = Color.FromArgb("#ff2670");
            }
            else
            {
                control.titleLabel.TextColor = Color.FromArgb("#ffffff");
            }
        });

    public static readonly BindableProperty CommandProperty = BindableProperty.Create(
        nameof(Command), typeof(IAsyncRelayCommand), typeof(NavBarButtonView),
        defaultValue: null, defaultBindingMode: BindingMode.OneWay,
        propertyChanged: (bindable, oldValue, newValue) =>
        {
            var control = (NavBarButtonView)bindable;
            control.tapGestureRecognizer.Command = (IAsyncRelayCommand)newValue;
        }
        );

    public NavBarButtonView()
	{
		InitializeComponent();
	}

    public string Title
    {
        get => (string)GetValue(TitleProperty);
        set => SetValue(TitleProperty, value);
    }

    public ImageSource IconUnselected
    {
        get => (ImageSource)GetValue(IconUnselectedProperty);
        set => SetValue(IconUnselectedProperty, value);
    }

    public ImageSource IconSelected
    {
        get => (ImageSource)GetValue(IconSelectedProperty);
        set => SetValue(IconSelectedProperty, value);
    }

    public bool IsSelected
    {
        get => (bool)GetValue(IsSelectedProperty);
        set => SetValue(IsSelectedProperty, value);
    }

    public IAsyncRelayCommand Command
    {
        get => (IAsyncRelayCommand)GetValue(CommandProperty);
        set => SetValue(CommandProperty, value);
    }
}