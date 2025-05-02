namespace comandosbasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string edad;
            ///*string nombre;
            //string apellido;*/
            ////Console.Write("Escribe tu nombre:");
            ////nombre = Console.ReadLine();
            ////Console.Write("Escribe tu apellido:");
            ////apellido=Console.ReadLine();
            ////Console.WriteLine($"Hola,{nombre} {apellido}");
            //Console.Write("Escribe tu edad:");
            //edad = Console.ReadLine();
            ////Console.WriteLine($"Tu edad es:{edad}");
            //int edad1 = int.Parse(edad);
            ////Console.WriteLine($"La edad es:{edad1}");

            //if (edad1 < 0) // Condicional

            //{
            //    Console.WriteLine($"Edad no valida");
            //}
            //else
            //{
            //    if (edad1 >= 3 && edad1 <=10)
            //    {
            //        Console.WriteLine($"Es niño");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"No es un niño");
            //    }


            //}


            //Bluces o ciclos
            //while, do-while, for, foreach
            //int contador = 0;
            //while(contador <= 9)
            //{
            //    Console.WriteLine($"While Numer: {contador}");
            //    contador++;                

            //    //Console.WriteLine(contador++);
            //}


            //contador = 0;
            //do
            //{
            //    Console.WriteLine($"Do-While Numer: {contador}");
            //    contador++;
            //} while (contador <= 9);

            //for (contador = 0;  contador <= 9 ; contador++)
            //{
            //    Console.WriteLine($"For Numer: {contador}");

            //}

            //string nombre = "Abraham";
            //foreach (var c in nombre)
            //{
            //    Console.WriteLine(c);
            //}

            //Un ciclo va a sumar 1 - 100 La suma es: ----

            //Un ciclo que cuente del 1 - 50 pero que sume 5 - 20, imprime los valores que no se suman esto es:
            // 1,2,3,4,21,22,..,50 La suma es: ---

            //int contador = 0;
            //int suma = 0;
            //while (contador <= 100)
            //{
            //    //Console.WriteLine($"While Numer: {contador}");

            //    suma = suma + contador;
            //    contador++;


            //}
            //Console.WriteLine($"La suma total de los primeros 100 numeros enteros es:{suma}");
            int contador = 0;
            int suma = 0;
            for (contador=0,suma=0; contador <= 50;contador++)
            {
                
                if (contador >= 5 && contador <= 20)
                {

                    suma = suma + contador;

                }
                else
                {
                    
                    

                    Console.WriteLine($"Numero:{contador}");
                }
                

            }
            Console.WriteLine($"La suma total es:{suma}");  





        }
    }
}
