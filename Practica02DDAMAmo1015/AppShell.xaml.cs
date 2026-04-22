namespace Practica02DDAMAmo1015
{
    /// <summary>
    /// Clase que define la estructura de navegación de la aplicación mediante Shell.
    /// Registra rutas y carga los elementos definidos en AppShell.xaml.
    /// </summary>
    public partial class AppShell : Shell
    {
        /// <summary>
        /// Constructor del Shell principal.
        /// Inicializa los componentes y registra las rutas necesarias.
        /// </summary>
        public AppShell()
        {
            InitializeComponent();

            // Ruta para navegar a la página de detalles de un animal
            Routing.RegisterRoute("detalleAnimal", typeof(Views.DetalleAnimalPage));
        }
    }
}
