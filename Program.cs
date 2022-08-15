using Pre_Entrega_1.Handler;
using Pre_Entrega_1.Model;

namespace PreEntrega
{
    public class TestingObjetos
    {
        static void Main(string[] args)
        {
            string usuario;
            string password;

            Console.WriteLine("Ingrese usuario: ");
            usuario = Console.ReadLine().ToString();

            Console.WriteLine("Ingrese contraseña: ");
            password = Console.ReadLine().ToString();

            UsuarioHandler userHandler = new UsuarioHandler();
            Usuario res = userHandler.GetUsuarioByUser(usuario);

            if(res != null)
            {
                if (res.Password == password)
                {
                    Console.WriteLine("El usuario y contraseña ingresado son correctos.");
                }
                else
                {
                    Console.WriteLine("La clave ingresada es incorrecta.");
                }
            }
            else
            {
                Console.WriteLine("El usuario ingresado no existe");
            }

            userHandler.GetUsuarios();

            ProductoHandler productoHandler = new ProductoHandler();
            productoHandler.GetProductos();

            ProductoVendidoHandler productoVendido = new ProductoVendidoHandler();
            productoVendido.GetProductosVendidos();

            VentasHandler ventas = new VentasHandler();
            ventas.GetVentas();


        }
    }
}