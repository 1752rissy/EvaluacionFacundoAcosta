using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            //TENER EN CUENTA LOS NOMBRES DE LOS COMPONENTES QUE USA. 
            //OpBusqueda : no se esta nombrando correctamente a la clase . USE OperacionesBusqueda. NUNCA ABREVIAR LOS NOMBRES. 
            Alumno Facu = new Alumno();
            OpAbm op1 = new OpAbm(Facu);
            OpBusqueda opb1 = new OpBusqueda(Facu);
            Profesor Andres = new Profesor();
            OpAbm op2 = new OpAbm(Andres);
            OpBusqueda opb2 = new OpBusqueda(Andres);
            Materia mat1 = new Materia();
            OpAbm op3 = new OpAbm(mat1);


            Console.WriteLine(op1.Altas());
            Console.WriteLine(op1.Bajas());
            Console.WriteLine(op1.Modificaciones());
            Console.WriteLine(opb1.Busqueda());
            Console.WriteLine(opb1.BusquedaDni());

            Console.WriteLine(op2.Altas());
            Console.WriteLine(op2.Bajas());
            Console.WriteLine(op2.Modificaciones());
            Console.WriteLine(opb2.Busqueda());
            Console.WriteLine(opb2.BusquedaDni());

            Console.WriteLine(op3.Altas());
            Console.WriteLine(op3.Bajas());
            Console.WriteLine(op3.Modificaciones());

            Console.ReadLine();




        }
    }
}
