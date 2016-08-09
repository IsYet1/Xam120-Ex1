using Xamarin.Forms;

public class MainPage : ContentPage
{
    Entry _enteredNumber;
    string _translatedNumber;
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
            _enteredNumber = new Entry { Text = "1-855-Xamarin"}
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

        _translateBtn.Clicked += OnTranslate;
        _callBtn.Clicked += OnCall;

        this.Content = panel;

    }

    private async void OnCall(object sender, System.EventArgs e)
    {
        var doCall = await this.DisplayAlert(
            "Dial a Number", $"Would you like to call {_translatedNumber}?", "Yes", "No"
            );
    }

    private void OnTranslate(object sender, System.EventArgs e)
    {
        var translateThis = _enteredNumber.Text;
        _translatedNumber = Core.PhonewordTranslator.ToNumber(translateThis);

        if (!string.IsNullOrEmpty(_translatedNumber))
        {
            _callBtn.Text = $"Call: {_translatedNumber}";
            _callBtn.IsEnabled = true;
        }
        else
        {
            _callBtn.Text = "Call";
            _callBtn.IsEnabled = false;
        }
    }
}