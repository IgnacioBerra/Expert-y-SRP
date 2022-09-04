
using System;

namespace Library
{
    public class PrintService 
    {
        public PrintService (IsValid Objeto)
        {
            Console.WriteLine ("Intentando crear la cita...");

            if (Objeto.Error.Length == 0)
            {
                Console.WriteLine ("Cita creada con éxito!");
            }
            else
            {
                Console.WriteLine($"La cita no fue creada con éxito, faltaron o fueron ingresados de manera incorrecta los siguientes datos:");
                Console.WriteLine(Objeto.Error);
            }
          
        }
    }
}