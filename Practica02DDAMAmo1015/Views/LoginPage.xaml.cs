namespace Practica02DDAMAmo1015;

public partial class LoginPage : ContentPage
{
    private const string UsuarioCorrecto = "admin";
    private const string PasswordCorrecta = "1234";

    public LoginPage()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        if (UsernameEntry.Text == UsuarioCorrecto &&
            PasswordEntry.Text == PasswordCorrecta)
        {
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}