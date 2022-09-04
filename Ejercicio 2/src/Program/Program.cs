using System;
using Library;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            AppointmentData Consulta1 = new AppointmentData (" ","Steven Jhonson","", "986782342", "5555-555-555", DateTime.Now, "Wall Street", "Armand","");
            IsValid ConsultaUno = new IsValid();
            ConsultaUno.IsItValid(Consulta1);
            PrintService Status1 = new PrintService(ConsultaUno);

            AppointmentData Consulta2 = new AppointmentData ("02","Ralf Manson","19", "5556895", "5555-555-555", DateTime.Now, "Queen Street", "Carlos","Cirujano");
            IsValid ConsultaDos = new IsValid();
            ConsultaDos.IsItValid(Consulta2);
            PrintService Status2 = new PrintService(ConsultaDos);
        }
    }
}
