using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comandosbasic.models
{
    public class Alumno
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad {  get; set; }
        public List<double> listados { get; set; }
        public Alumno() { listados = new List<double>();
            listados.Add(2.1);
            listados.Add(5.2);
            listados.Add(8.9);

        }
        public double promedio() 
        {
            double suma = 0;
           foreach (double item in listados)
            {
                suma = suma + item;

            }
            double Promedio = suma / listados.Count;
            return Promedio;
        }
    }
}
