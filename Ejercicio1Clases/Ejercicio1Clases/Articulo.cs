using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace Ejercicio1Clases
{
    class Articulo
    {
        static List<Articulo> articulos = new List<Articulo>();

        public static int contadorArticulo;
        private int codigoArticulo;
        private string nombreArticulo;
        private string categoriaArticulo;
        private long precioArticulo;
        private int existenciasArticulo;

        //Acceso get
        public int CodigoArticulo { get; }
        public string NombreArticulo { get; set; }
        public string CategoriaArticulo { get; set; }
        public long PrecioArticulo { get; }
        public int ExistenciasArticulo { get; }

        public override string ToString()
        {
            return "Codigo: " + CodigoArticulo + " Nombre: " + NombreArticulo + " Categoria: " + categoriaArticulo + " Precio: " + precioArticulo + " Existencias: " + ExistenciasArticulo;
        }

        //constructor sin argumentos
        public Articulo()
        {
            Console.WriteLine("Objeto creado sin argumentos.");
        }
        //constructor con argumentos
        public Articulo(string nombreArticulo, string categoriaArticulo, long precioArticulo, int existenciasArticulo)
        {
            contadorArticulo++;
            codigoArticulo = contadorArticulo;
            this.nombreArticulo = nombreArticulo;
            this.categoriaArticulo = categoriaArticulo;
            this.precioArticulo = precioArticulo;
            this.existenciasArticulo = existenciasArticulo;

        }

        private void actualizarExistencias(int cantidadPedido)
        {
            if (existenciasArticulo < cantidadPedido)
            {
                Console.WriteLine("No hay suficientes existencias");
            }
            else
            {
                existenciasArticulo -= cantidadPedido;
                Console.WriteLine("Importe del pedido: {0} euros", cantidadPedido * (precioArticulo));
            }
            Console.WriteLine("Existencias actualizadas: {0}", existenciasArticulo);
        }

        public void imprimirArticulo()
        {
            Console.WriteLine();
            foreach (Articulo a in articulos)
            {
                Console.WriteLine(a);
            }
        }

        public void Alta(int contador)
        {
            Console.WriteLine("Se dará de alta a un artículo: \n");
            Console.WriteLine("Escriba su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Escriba su categoria: ");
            string cat = Console.ReadLine();
            Console.WriteLine("Escriba su precio: ");
            int precio = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba sus existencias: ");
            int exist = int.Parse(Console.ReadLine());

            articulos.Add(new Articulo(nombreArticulo, categoriaArticulo, precioArticulo, existenciasArticulo) { codigoArticulo = contador, nombreArticulo = nombre, categoriaArticulo = cat, precioArticulo = precio, existenciasArticulo = exist });

        }

        public void Consulta()
        {
            Console.WriteLine("Que articulo quieres buscar? ");
            string busca = Console.ReadLine();

            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].nombreArticulo == busca)
                {
                    Console.WriteLine("Articulo encontrado: \nNombre:" + articulos[i].nombreArticulo);
                }
            }

        }

        public void Listar()
        {
            Console.WriteLine("Quieres mostrar: \n a) Todos los artículos.\n b) Articulos en mínimos.\n c) Artículos por categoria.");
            char eleccion = char.Parse(Console.ReadLine());
            switch (eleccion)
            {
                case 'a':
                    for (int i = 0; i < articulos.Count; i++){imprimirArticulo();}
                    break;

                case 'b':
                    for (int i = 0; i < articulos.Count; i++){
                        if (articulos[i].existenciasArticulo < 10) {imprimirArticulo();}}; break;

                case 'c': Console.WriteLine("Escribe una categoria: "); string cat = Console.ReadLine(); 
                    for (int i = 0; i < articulos.Count; i++){
                        if (articulos[i].categoriaArticulo== cat) { imprimirArticulo();}};break;

                default: Console.WriteLine("No está esa opción."); break;
            }
        }

        public void Pedido()
        {
            Console.WriteLine("Cuál es el codigo del articulo? ");
            int cod = int.Parse(Console.ReadLine());
            Console.WriteLine("Qué cantidad quiere? ");
            int cantidad = int.Parse(Console.ReadLine());

            for (int i = 0; i < articulos.Count; i++)
            {
                if (articulos[i].codigoArticulo == codigoArticulo)
                {
                    actualizarExistencias(cantidad);

                    Console.WriteLine("Articulo encontrado: \nNombre:" + articulos[i].nombreArticulo);
                }
                else Console.WriteLine("Articulo no encontrado.");
            }
        }

        public void Eliminar()
        {
            Console.WriteLine("Escriba el codigo del articulo a eliminar: ");
            int cod = int.Parse(Console.ReadLine());

            foreach (Articulo a in articulos)
            {
                if(cod==a.CodigoArticulo)
                Console.WriteLine("encontrado");
            }
        }
        public int Menu()
        {
            int opcion;

            Console.WriteLine("------Menu-----\n1.Alta a un artículo\n2.Consulta \n3.Listar\n4.Pedido\n5.Eliminar\n6.Salir.");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1: Alta(contadorArticulo); break;
                case 2: Consulta(); break;
                case 3: Listar(); break;
                case 4: Pedido(); break;
                case 5: Eliminar(); break;

            }

            return opcion;
        }
    }
    class TestArticulo
    {
        static void Main(string[] args)
        {
            Articulo a = new Articulo();
            while (a.Menu() != 6)
            {
                Console.WriteLine("");
            }
        }
    }
} 