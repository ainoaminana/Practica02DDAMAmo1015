using Practica02DDAMAmo1015.Models;

namespace Practica02DDAMAmo1015.Views
{
    /// <summary>
    /// Página que muestra una galería de animales marinos.
    /// Permite seleccionar un animal para ver su información detallada.
    /// </summary>
    public partial class GaleriaPage : ContentPage
    {
        /// <summary>
        /// Constructor de la página de galería.
        /// Inicializa los componentes y carga la lista de animales.
        /// </summary>
        public GaleriaPage()
        {
            InitializeComponent();

            AnimalesView.ItemsSource = new List<Animal>
            {
                new Animal
                {
                    Nombre = "Tiburón Blanco",
                    Imagen = "tiburon_blanco.jpg",
                    Descripcion = "El depredador marino más famoso, rápido y poderoso."
                },
                new Animal
                {
                    Nombre = "Tiburón Martillo",
                    Imagen = "tiburon_martillo.png",
                    Descripcion = "Reconocible por su cabeza en forma de T, es un excelente cazador."
                },
                new Animal
                {
                    Nombre = "Tiburón Toro",
                    Imagen = "tiburon_toro.jpg",
                    Descripcion = "Agresivo y adaptable, es capaz de vivir en agua dulce."
                },
                new Animal
                {
                    Nombre = "Tiburón Zorro",
                    Imagen = "tiburón_zorro.jpg",
                    Descripcion = "Con una cola enorme que usa para aturdir a sus presas y saltar sobre el agua."
                }
            };
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar un animal de la lista.
        /// Navega a la página de detalles del animal seleccionado.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento, incluyendo el elemento seleccionado.</param>
        private async void OnAnimalSelected(object sender, SelectionChangedEventArgs e)
        {
            if (e.CurrentSelection.FirstOrDefault() is Animal animal)
            {
                await Shell.Current.GoToAsync("detalleAnimal", true, new Dictionary<string, object>
                {
                    { "animal", animal }
                });

                // Limpia la selección para evitar que quede resaltado
                AnimalesView.SelectedItem = null;
            }
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar una tarjeta (Frame) de animal.
        /// Aplica una animación visual de pulsación.
        /// </summary>
        /// <param name="sender">El Frame que fue pulsado.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnCardTapped(object sender, TappedEventArgs e)
        {
            if (sender is Frame frame)
            {
                await frame.ScaleTo(0.95, 100, Easing.CubicOut);
                await frame.TranslateTo(0, 3, 100, Easing.CubicOut);

                await frame.ScaleTo(1, 100, Easing.CubicIn);
                await frame.TranslateTo(0, 0, 100, Easing.CubicIn);
            }
        }
    }
}