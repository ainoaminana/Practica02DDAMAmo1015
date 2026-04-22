using Practica02DDAMAmo1015.Models;

namespace Practica02DDAMAmo1015.Views
{
    /// <summary>
    /// Página que muestra la información detallada de un animal seleccionado.
    /// Recibe el objeto Animal mediante navegación con QueryProperty.
    /// </summary>
    [QueryProperty(nameof(Animal), "animal")]
    public partial class DetalleAnimalPage : ContentPage
    {
        /// <summary>
        /// Propiedad que recibe el animal seleccionado desde la galería.
        /// Al asignarse, actualiza la interfaz con los datos del animal.
        /// </summary>
        public Animal Animal
        {
            set
            {
                ImagenAnimal.Source = value.Imagen;
                NombreAnimal.Text = value.Nombre;
                DescripcionAnimal.Text = value.Descripcion;
            }
        }

        /// <summary>
        /// Constructor de la página de detalles.
        /// Inicializa los componentes visuales definidos en XAML.
        /// </summary>
        public DetalleAnimalPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón "Volver".
        /// Regresa a la página anterior en la pila de navegación.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnVolverClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}