using System;
using Microsoft.Maui.Controls;

namespace Practica02DDAMAmo1015.Views
{
    /// <summary>
    /// Página principal que se muestra tras iniciar sesión.
    /// Permite navegar hacia la galería de animales o hacia la configuración.
    /// </summary>
    public partial class HomePage : ContentPage
    {
        /// <summary>
        /// Constructor de la página Home.
        /// Inicializa los componentes visuales definidos en XAML.
        /// </summary>
        public HomePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón que navega a la galería.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnGaleriaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//galeria");
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón que navega a la configuración.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnConfigClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//configuracion");
        }
    }
}