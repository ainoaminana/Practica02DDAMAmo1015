using Practica02DDAMAmo1015.Models;
namespace Practica02DDAMAmo1015.Views;

public partial class GaleriaPage : ContentPage
{
    public GaleriaPage()
    {
        InitializeComponent();

        AnimalesView.ItemsSource = new List<Animal>
        {
            new Animal { Nombre="León", Imagen="leon.jpg", Descripcion="Rey de la selva" },
            new Animal { Nombre="Tigre", Imagen="tigre.jpg", Descripcion="Felino poderoso" }
        };
    }

    private async void OnAnimalSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Animal animal)
        {
            await Shell.Current.GoToAsync("detalleAnimal", true, new Dictionary<string, object>
            {
                { "animal", animal }
            });
        }
    }
}
