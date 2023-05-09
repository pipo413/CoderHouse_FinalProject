using System.ComponentModel.DataAnnotations;

namespace CoderHouse_FinalProject
{
    public class Usuario
    {
        public string Id { get; set; } 
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public string Mail { get; set; }
    }

    public class Producto
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public double Costo { get; set; }
        public double PrecioVenta { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
    }

    public class ProductoVendido
    {
        public string Id { get; set; }
        public int IdProducto { get; set; }
        public int Stock { get; set; }
        public string IdVenta { get; set; }
    }
    public class  Venta
    {
        public string Id { get; set; }
        public string Comentarios { get; set; }
        public string IdUsuar { get; set; }
    }

}


    