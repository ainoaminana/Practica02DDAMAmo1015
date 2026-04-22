using Practica02DDAMAmo1015.Models;
namespace Practica02DDAMAmo1015.Views;

[QueryProperty(nameof(Animal), "animal")]
public partial class DetalleAnimalPage : ContentPage
{
    public Animal Animal
    {
        set
        {
            ImagenAnimal.Source = value.Imagen;
            NombreAnimal.Text = value.Nombre;
            DescripcionAnimal.Text = value.Descripcion;
        }
    }

    public DetalleAnimalPage()
    {
        InitializeComponent();
    }
}