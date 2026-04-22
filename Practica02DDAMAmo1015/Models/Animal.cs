namespace Practica02DDAMAmo1015.Models
{
    /// <summary>
    /// Representa un animal mostrado en la galería.
    /// Contiene su nombre, imagen y descripción.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Nombre del animal.
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Ruta o nombre del archivo de imagen asociado al animal.
        /// </summary>
        public string Imagen { get; set; }

        /// <summary>
        /// Descripción breve del animal.
        /// </summary>
        public string Descripcion { get; set; }
    }
}
