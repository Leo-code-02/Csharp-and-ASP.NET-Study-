namespace Fields___Properties_K_and_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto("Producto 1", "P001", -10.5, -100);
            //producto1.CodigoReferencia = 29;

            Console.WriteLine($"Nombre: {producto1.Nombre}");
            Console.WriteLine($"Código de Referencia: {producto1.CodigoReferencia}");
            Console.WriteLine($"Precio: {producto1.Precio}");
            Console.WriteLine($"Stock: {producto1.Stock}");
        }
    }
}
