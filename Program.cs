using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{   //hacemos la herencia
    class Program: Tarea
    {
        static void Main(string[] args)
        {   //instanciamos y mandamos a llamar al menu que se encuentra en tareas
            Tarea T = new Tarea();
            T.Menu();
        }
    }
}
