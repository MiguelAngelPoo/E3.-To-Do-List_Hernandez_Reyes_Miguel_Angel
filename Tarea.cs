using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{   //heredamos los datos de la clase datos tarea
    class Tarea:Datos_Tarea1
    {
        //se declaran global la lista
        public List<Datos_Tarea1> Dt = new List<Datos_Tarea1>();
       
        //metodo para mostrar la lista de tareas 
        public void Lista_Tarea()
        {
            Console.WriteLine("Lista de tareas: ");
            foreach (Datos_Tarea1 P in Dt)
            {
                //con el foreach se busca dentro de la lista los elementos  y despues ponemos un cw para mostrarlos
                Console.WriteLine("Tarea : " + P.NombreTarea);
            }
            Console.ReadKey();
            //con el crk hacemos que tengan que poner alguna tecla para avanzar
        }
       
        
        
        
        //metodo que sirve para buscar una tarea y mirar todos los detalle que tienes osea todos sus datos
        public void Tarea_Detalle()
        {   //ingresamos un cw para capturar el nombre a buscar
            Console.WriteLine("ingrese nombre de tarea a buscar: ");
            string opc = Console.ReadLine();
            foreach (Datos_Tarea1 P in Dt)
            {
                //se compara el dato capturado con los nombres de tareas de la lista y si conincide se muentran todos sus datos
                
                if (opc == P.NombreTarea )
                {   //mostramos todos los datos de una tarea
                    Console.WriteLine("nombre tarea: " + P.NombreTarea);
                    Console.WriteLine("Nombre del usuario : " + P.NombreUsuario);
                    Console.WriteLine("hora : " + P.Hora);
                    Console.WriteLine("fecha : " + P.fecha);
                    Console.WriteLine("status : " + P.Estatus);
                    Console.ReadKey();
                }

            } 
               
            
        }

        
        
        //con este metodo se capturan las tareas y se van guardando en la lista
        public void Crear_Tarea()
        {
            //instanciamos la lista
            Datos_Tarea1 D1 = new Datos_Tarea1();
           
            Console.WriteLine("ingrese Nombre del usuario: ");
            D1.NombreUsuario = Console.ReadLine();
            Console.WriteLine("ingrese Nombre de la tarea: ");
            D1.NombreTarea = Console.ReadLine();
            Console.WriteLine("ingrese Hora de la tarea: ");
            D1.Hora = Console.ReadLine();
            Console.WriteLine("ingrese fecha: ");
            D1.fecha = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("ingrese tipo de estatus finalizado,progreso o iniciado");
            D1.Estatus = Console.ReadLine();
            //agregamos los datos del objeto d1 a la lista que tiene datos o atributos en datos tarea
            Dt.Add(D1);
            Console.Clear();
        }



        //cambiar statu realiza 3 operaciones una es buscar la tarea y si esta coincide con los guardado en la lista da la opcion de cambiar el statu o mejor dicho remplazarlo
        public void  cambiar_estau()
        {   //instancia 
            Datos_Tarea1 D = new Datos_Tarea1();
            
            
            //capturamos un dato que sera el que usaremos para buscar la tarea
            Console.WriteLine("dame tarea de la que decea cambiar statu");
            string opc2 = Console.ReadLine();
            foreach (Datos_Tarea1 P in Dt)
            {

                //si el dato coincide con la tarea se accede a realizar el remplazo o cambio
                if ((opc2 == P.NombreTarea))
                {

                    //se cambia el valor de statu por uno nuevo
                    Console.WriteLine("ingrese nuevo statu ");
                    P.Estatus= Console.ReadLine();
                   //se muestra que la accion se realizo con exito
                    Console.WriteLine("statu cambiado correctamente el nuevo es: "+ P.Estatus);
                    Console.ReadKey();
                }



            }

        }




        //metodo que muestra la lista de los status y los divide en  3 tipos iniciado, finalizado y en progreso
        public void Lista_estatu()
        {
            Console.WriteLine("tareas terminadas-");
            foreach (Datos_Tarea1 P in Dt)
            {

               //con el foreach se busca en la lista  y si coinciden con el if que se puso de condicion mostrara en  este caso todos los finalizado juntos
                if (P.Estatus == "finalizado")
                {
                    //condicion
                    Console.WriteLine("nombre tarea: " + P.NombreTarea);
                    Console.ReadKey();
                }


               
            }
            //con el foreach se busca en la lista  y si coinciden con el if que se puso de condicion mostrara en  este caso todos los en progreso juntos
            Console.WriteLine("tareas en progreso-");
            foreach (Datos_Tarea1 P in Dt)
            {

                //condicion
                if (P.Estatus == "progreso")
                {
                    
                    Console.WriteLine("nombre tarea: " + P.NombreTarea);
                    Console.ReadKey();
                   
                }


                
            }
            //con el foreach se busca en la lista  y si coinciden con el if que se puso de condicion mostrara en  este caso todos los iniciado juntos
            Console.WriteLine("tareas iniciadas:- ");
            foreach (Datos_Tarea1 P in Dt)
            {

                //condicion
                if (P.Estatus == "iniciado")
                {
                    
                    Console.WriteLine("nombre tarea: " + P.NombreTarea);
                    Console.ReadKey();
                }


            }


            
        }

        //metodo de menu
        public void Menu()
        {
            //opciones del menu
            Console.WriteLine("Bienvenido a menu de lista");
            Console.WriteLine("1.-Crear tarea");
            Console.WriteLine("2.-Lista de tareas");
            Console.WriteLine("3.-Detalle de tareas");
            Console.WriteLine("4.-Lista statu");
            Console.WriteLine("5.-cambiar statu");
            Console.WriteLine("Elige la opcion");
            //switch para colocar los metodos en las opciones y acceder a ellos
            switch (Console.ReadLine())
            {
                case "1":
                    //llamada del metodo
                    Crear_Tarea();
                    Console.Clear();
                    break;
                case "2":
                    Lista_Tarea();
                    Console.Clear();
                    break;
                case "3":
                    Tarea_Detalle();
                    Console.Clear();
                    break;
                case "4":
                    Lista_estatu();
                    Console.Clear();
                    break;
                case "5":
                    cambiar_estau();
                    Console.Clear();
                    break;
                default:
                    break;
            }
            Menu();
            //llamada del menu despues de cada metodo
        }



    }
}
