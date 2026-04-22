using Microsoft.Maui.ApplicationModel;
using Microsoft.Maui.Controls;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace Practica02DDAMAmo1015.Views
{
    /// <summary>
    /// Página de inicio de sesión de la aplicación.
    /// Permite autenticarse mediante usuario/contraseña o mediante huella dactilar.
    /// </summary>
    public partial class LoginPage : ContentPage
    {
        /// <summary>
        /// Usuario válido para la autenticación manual.
        /// </summary>
        private const string UsuarioCorrecto = "admin";

        /// <summary>
        /// Contraseña válida para la autenticación manual.
        /// </summary>
        private const string PasswordCorrecta = "1234";

        /// <summary>
        /// Constructor de la página de login.
        /// Inicializa los componentes visuales definidos en XAML.
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón "Acceder".
        /// Valida el usuario y la contraseña introducidos.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnLoginClicked(object sender, EventArgs e)
        {
            if (UsernameEntry.Text == UsuarioCorrecto &&
                PasswordEntry.Text == PasswordCorrecta)
            {
                await Shell.Current.GoToAsync("//home");
            }
            else
            {
                await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
            }
        }

        /// <summary>
        /// Evento que se ejecuta al pulsar el botón "Acceder con huella".
        /// Realiza la autenticación biométrica mediante huella dactilar.
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private async void OnFingerprintClicked(object sender, EventArgs e)
        {
            var availability = await CrossFingerprint.Current.GetAvailabilityAsync();

            if (availability != FingerprintAvailability.Available)
            {
                await DisplayAlert("Error", "La huella no está disponible en este dispositivo.", "OK");
                return;
            }

            var request = new AuthenticationRequestConfiguration(
                "Huella dactilar",
                "Autentícate con tu huella para acceder");

            var result = await CrossFingerprint.Current.AuthenticateAsync(request);

            if (result.Authenticated)
            {
                await Shell.Current.GoToAsync("//home");
            }
            else
            {
                await DisplayAlert("Error", "No se pudo autenticar la huella.", "OK");
            }
        }
    }
}