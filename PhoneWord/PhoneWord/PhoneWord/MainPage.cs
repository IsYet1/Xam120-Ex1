using Xamarin.Forms;

public class MainPage : ContentPage
{
    Entry _entry;
    Button _translateBtn;
    Button _callBtn;

    public MainPage()
    {
        this.Padding = new Thickness(20,
            Device.OnPlatform<double>(40,20,20),20,20);

        StackLayout panel = new StackLayout {
            VerticalOptions = LayoutOptions.FillAndExpand,
            HorizontalOptions = LayoutOptions.FillAndExpand,
            Orientation = StackOrientation.Vertical,
            Spacing = 15,
        };

        panel.Children.Add(
            new Label
            {
                HorizontalTextAlignment = TextAlignment.Start,
                Text = "Enter a Phoneword"
            }
        );

        panel.Children.Add(
            _entry = new Entry { Text = "1-855-Xamarin"}
        );

        panel.Children.Add(
            _translateBtn = new Button
            {
                Text = "Translate"
            }
        );

        panel.Children.Add(
            _callBtn = new Button
            {
                Text = "Call",
                IsEnabled = false
            }
        );

        this.Content = panel;

    }
}