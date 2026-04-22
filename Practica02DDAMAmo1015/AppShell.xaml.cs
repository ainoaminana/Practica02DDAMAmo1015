namespace Practica02DDAMAmo1015
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("detalleAnimal", typeof(Views.DetalleAnimalPage));
        }
    }
}
