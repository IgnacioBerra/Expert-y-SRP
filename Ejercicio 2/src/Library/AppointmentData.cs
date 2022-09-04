using System;


namespace Library
{
        
    public class AppointmentData
    {
        public string AppointmentId;
        public string Name;
        public string Age;
        public string Id;
        public string PhoneNumber;
        public string Date;
        public string AppointmentPlace;
        public string DoctorName;
        public string DoctorSpecialization;
        public AppointmentData(string appointmentId, string name, string age, string id, string phoneNumber, DateTime date, string appointmentPlace, string doctorName, string doctorSpecialization)
        {
           this.AppointmentId = appointmentId;
           this.Name = name;
           this.Age = age;
           this.Id = id;
           this.PhoneNumber = phoneNumber;
           this.AppointmentPlace = appointmentPlace;
           this.DoctorName = doctorName;
           this.DoctorSpecialization = doctorSpecialization;
        }

    }
}
