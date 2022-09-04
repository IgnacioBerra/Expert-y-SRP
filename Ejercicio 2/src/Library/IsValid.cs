using System;
using System.Text;
using System.Collections.Generic;

namespace Library
{
    public class IsValid
    {
       public StringBuilder Error = new  StringBuilder(); 
        public StringBuilder IsItValid (AppointmentData Object)
        {
            
            if (string.IsNullOrEmpty(Object.AppointmentId) || string.IsNullOrWhiteSpace(Object.AppointmentId))
            {
                Error.AppendLine("Appointment Id");
            }

            if (string.IsNullOrEmpty(Object.Name) || string.IsNullOrWhiteSpace(Object.Name))
            {
              Error.AppendLine("Name");
            }

            if (string.IsNullOrEmpty(Object.Age) || string.IsNullOrWhiteSpace(Object.Age))
            {
                Error.AppendLine("Age");
            }

            if (string.IsNullOrEmpty(Object.Id) || string.IsNullOrWhiteSpace(Object.Id))
            {
                Error.AppendLine("Id");
            }

            if (string.IsNullOrEmpty(Object.PhoneNumber) || string.IsNullOrWhiteSpace(Object.PhoneNumber))
            {
                Error.AppendLine("Phone Number");
            }

            if (string.IsNullOrEmpty(Object.AppointmentPlace) || string.IsNullOrWhiteSpace(Object.AppointmentPlace))
            {
                Error.AppendLine("Appointment Place");
            }


            if (string.IsNullOrEmpty(Object.DoctorName) || string.IsNullOrWhiteSpace(Object.DoctorName))
            {
                Error.AppendLine("Doctor Name");
            }
            
            if (string.IsNullOrEmpty(Object.DoctorSpecialization) || string.IsNullOrWhiteSpace(Object.DoctorSpecialization))
            {
                Error.AppendLine("Doctor Specialization");
            }
           
           return Error;
         }
        
    }

}