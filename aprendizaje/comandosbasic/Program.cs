using comandosbasic.models;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace comandosbasic
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Explicacion Clase");
            Alumno alumno1 = new Alumno();
            Console.Write("Escribe tu nombre:");
            alumno1.nombre = Console.ReadLine();
            Console.Write("Escribe tu edad:");
            alumno1.edad = int.Parse(Console.ReadLine());
            Console.WriteLine($" Tu nombre es:{alumno1.nombre}");
            Console.WriteLine($" Tu edad es:{alumno1.edad}");
            double promedio = alumno1.promedio();

            Console.WriteLine($" Tu promedio es:{promedio}");


            


            Console.WriteLine("Fin de explicacion Clase");
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
            ////Console.WriteLine($"La suma total de los primeros 100 numeros enteros es:{suma}");
            //int contador = 0;
            //int suma = 0;
            //for (contador=0,suma=0; contador <= 50;contador++)
            //{

            //    if (contador >= 5 && contador <= 20)
            //    {

            //        suma = suma + contador;

            //    }
            //    else
            //    {



            //        Console.WriteLine($"Numero:{contador}");
            //    }


            //}
            //Console.WriteLine($"La suma total es:{suma}");  



            //string edad;
            //Console.Write("Escriba su edad: "); 
            //edad=Console.ReadLine();
            //int edad1= int.Parse( edad);
            //if (edad1 <= 18) 
            //    Console.WriteLine("Infante");

            //int c1 = 1, c2=2, c3=3, c4=4, c5=5, c6=6, c7=7, c8=8, c9=9, c10=10;
            //double prom = (c1 + c2 + c3 + c4 + c5 + c6 + c7 + c8 + c9 + c10) / 10;


            //double[] calif = new double[]{ 8.5, 7.2, 5, 8.2};

            //for(int x=0 ; x < calif.Length ;x++ )
            //{
            //   // Console.WriteLine(calif[x]);
            //}

            //List<double> lista = new List<double>() { 5.2, 4.3 };

            //lista.Add(8.5);
            //lista.Add(7.2);
            //lista.Add(5);
            //lista.Add(8.2);
            //lista.Add(10);
            //lista.Add(9.3);

            //foreach (double x in lista)
            //{
            //    Console.WriteLine(x);
            //}

            //Console.WriteLine(lista.Count);


            //double[] listaNumeros = new double[100];

            //for (int x = 0; x < listaNumeros.Length; x++)
            //{
            //    listaNumeros[x] = x + 1;
            //}

            //for (int x = 0; x < listaNumeros.Length; x++) //<----
            //{
            //    Console.WriteLine(listaNumeros[x]);
            //}


            // Teniendo una LISTA (List<double>) de calif, sacar el promedio de 10 calif. Usando foreach


            // Teniendo, hacer que imprima al revez de 100,...,1 en palabras de listaNumeros[99],....,listaNumeros[0]

            //List<double> listaCalif = new List<double>() { 5.2, 4.3, 5, 8.2, 6.3, 4, 7.9, 8, 9.9, 10 };
            //double prom = 

            //Saludo("Abraham",40);
            //Saludo("Jessica",28);

            //int[] arreglo1 = new int[] { 1, 2, 3, 4, 5 };
            //int[] arreglo2 = new int[] { 1, 2, 3, 4, 5 ,6,7,8,9};
            //int[] arreglo3 = new int[] { 1, 2};

            //int metodoInt = Suma(arreglo1);
            //int metodoInt2 = Suma(arreglo2);
            //int metodoInt3 = Suma(arreglo3);

            //Console.WriteLine($"La suma es: {metodoInt}");
            //Console.WriteLine($"La suma es: {metodoInt2}");
            //Console.WriteLine($"La suma es: {metodoInt3}");







            ////double[] listaNumeros = new double[100];

            ////for (int x = listaNumeros.Length-1; x >= 0  ; x--)
            ////{
            ////    listaNumeros[x] = x + 1;
            ////    Console.WriteLine(listaNumeros[x]);
            ////}

            //List<double> calif1 = new List<double>();
            //List<double> calif2 = new List<double>();
            //List<double> calif3 = new List<double>();
            //List<double> calif4 = new List<double>();

            //calif1.Add(8.5);
            //foreach (int i in calif1) {
            //    //////////
            //    /////////////
            //    /////////////
            //    /////////////
            //}

            //foreach (int i in calif2)
            //{
            //    //////////
            //    /////////////
            //    /////////////
            //    /////////////
            //}

            //foreach (int i in calif3)
            //{
            //    //////////
            //    /////////////
            //    /////////////
            //    /////////////
            //}

            //foreach (int i in calif4)
            //{
            //    //////////
            //    /////////////
            //    /////////////
            //    /////////////
            //}
            //int[] arreglo1 = new int[] { 5,9,3 };
            //int[] arreglo2 = new int[] { 9,5,2,8,7 };
            //int[] arreglo3 = new int[] { 10 };
            //double metodoInt = Promedio(arreglo1 );
            //Console.WriteLine( metodoInt );
            //Console.WriteLine(Promedio(arreglo2));
            //Console.WriteLine(Promedio(arreglo3));
            //Limpio();
        }

        //(Que regreso) Como me llamo (Que necesito)
        //     ///Como lo hago)
        //static void Saludo(string nombre,int edad)
        //{
        //    Console.WriteLine($"Hola {nombre} que tiene {edad} años");
        //}

        static int Suma(int[] valores)
        {
            int acumulado = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                acumulado = acumulado + valores[i];
            }

            return acumulado;
        }


        static double Promedio(int[]valores)
        {
            double suma=0;
            for (int i = 0; i < valores.Length; i++)
            {
                suma = suma + valores[i];

            }
            double Promedio = suma / valores.Length;
            return Promedio;
        }


        static void Limpio()
        {
            string nombre;
            string edad;
            Console.Write("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola,{nombre}");
            Console.Write($"Escribe tu edad");
            edad = Console.ReadLine();
            
            int edad1= int.Parse(edad);
            Console.WriteLine($"Tu edad es {edad}"); 
        }
        

        
        
    }
}
