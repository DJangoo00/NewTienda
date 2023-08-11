namespace Tienda.View
{
    public class MenuView
    {
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine("****************************************************************");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SuperTienda Ab3");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("****************************************************************");
            Console.WriteLine("\t1. Registrar Producto");
            Console.WriteLine("\t2. Registrar Categoria");
            //Console.WriteLine("\t3. Listar Producto");
            //Console.WriteLine("\t4. Listar Categoria");
            //Console.WriteLine("\t5. Costo total del inventario");
            Console.WriteLine("\t6. Salir");
            Console.WriteLine("****************************************************************");
            return int.Parse(Console.ReadLine());
        }
    }
}