namespace Practica02DDAMAmo1015.Views;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnGaleriaClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//galeria");
    }

    private async void OnConfigClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("//configuracion");
    }
}
