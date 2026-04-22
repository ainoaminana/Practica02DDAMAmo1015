namespace Practica02DDAMAmo1015.Views
{
    /// <summary>
    /// Página de configuración de la aplicación.
    /// Permite personalizar el tamaño, color y tipografía del texto
    /// mediante recursos dinámicos aplicados globalmente.
    /// </summary>
    public partial class ConfiguracionPage : ContentPage
    {
        /// <summary>
        /// Constructor de la página de configuración.
        /// Inicializa los componentes visuales definidos en XAML.
        /// </summary>
        public ConfiguracionPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento que se ejecuta al modificar el tamaño del texto mediante el slider.
        /// Actualiza el recurso dinámico global "GlobalFontSize".
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Valores del evento, incluyendo el nuevo tamaño.</param>
        private void OnTextSizeChanged(object sender, ValueChangedEventArgs e)
        {
            Application.Current.Resources["GlobalFontSize"] = e.NewValue;
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar un color en el Picker.
        /// Actualiza el recurso dinámico global "GlobalFontColor".
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void OnColorChanged(object sender, EventArgs e)
        {
            string color = ColorPicker.SelectedItem as string;

            Application.Current.Resources["GlobalFontColor"] = color switch
            {
                "Negro" => Colors.Black,
                "Rojo" => Colors.Red,
                "Azul" => Colors.Blue,
                "Verde" => Colors.Green,
                _ => Colors.Black
            };
        }

        /// <summary>
        /// Evento que se ejecuta al seleccionar una tipografía en el Picker.
        /// Actualiza el recurso dinámico global "GlobalFontFamily".
        /// </summary>
        /// <param name="sender">Control que dispara el evento.</param>
        /// <param name="e">Argumentos del evento.</param>
        private void OnFontChanged(object sender, EventArgs e)
        {
            string font = FontPicker.SelectedItem as string;

            Application.Current.Resources["GlobalFontFamily"] = font switch
            {
                "Sans" => "OpenSansRegular",
                "Serif" => "OpenSansBold",
                "Monospace" => "CourierPrime",
                _ => "OpenSansRegular"
            };
        }
    }
}