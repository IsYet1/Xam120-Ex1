using Xamarin.Forms;

public class MainPage : ContentPage
{
    public MainPage()
    {
        Content = new StackLayout
        {
            VerticalOptions = LayoutOptions.Center,
            Children =
            {
                new Label
                {
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = "Welcome to Xamarin Forms!"
                }
            }
        };
    }
}