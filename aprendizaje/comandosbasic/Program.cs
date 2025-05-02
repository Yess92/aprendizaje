namespace comandosbasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nombre;
            string apellido;
            Console.Write("Escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.Write("Escribe tu apellido:");
            apellido=Console.ReadLine();
            Console.WriteLine($"Hola,{nombre} {apellido}");
            
        }
    }
}
