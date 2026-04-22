namespace Practica02DDAMAmo1015
{
    /// <summary>
    /// Clase principal de la aplicación MAUI.
    /// Configura la página inicial y carga los recursos globales definidos en XAML.
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Constructor de la aplicación.
        /// Inicializa los componentes y establece AppShell como página raíz.
        /// </summary>
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
