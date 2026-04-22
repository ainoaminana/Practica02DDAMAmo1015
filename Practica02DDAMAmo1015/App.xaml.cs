namespace Practica02DDAMAmo1015;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new Views.LoginPage());
    }
}
