using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml.Serialization;

namespace DoctorAppointmentApp
{
    
    public class Appointment
    {
        public string Doctor { get; set; }
        public string Patient { get; set; }
        public string Date { get; set; }
    }

   
    public interface IStorage
    {
        void Save(List<Appointment> appointments);
        List<Appointment> Load();
    }

    
    public class JsonStorage : IStorage
    {
        private readonly string _filePath = "appointments.json";

        public void Save(List<Appointment> appointments)
        {
            var json = JsonSerializer.Serialize(appointments, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_filePath, json);
        }

        public List<Appointment> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Appointment>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Appointment>>(json) ?? new List<Appointment>();
        }
    }

    
    public class XmlStorage : IStorage
    {
        private readonly string _filePath = "appointments.xml";

        public void Save(List<Appointment> appointments)
        {
            var serializer = new XmlSerializer(typeof(List<Appointment>));
            using (var writer = new StreamWriter(_filePath))
            {
                serializer.Serialize(writer, appointments);
            }
        }

        public List<Appointment> Load()
        {
            if (!File.Exists(_filePath))
                return new List<Appointment>();

            var serializer = new XmlSerializer(typeof(List<Appointment>));
            using (var reader = new StreamReader(_filePath))
            {
                return (List<Appointment>)serializer.Deserialize(reader);
            }
        }
    }

    
    class Program
    {
        static void Main()
        {
            Console.Write("Оберіть формат збереження (json/xml): ");
            string format = Console.ReadLine()?.ToLower();

            IStorage storage = format switch
            {
                "json" => new JsonStorage(),
                "xml" => new XmlStorage(),
                _ => null
            };

            if (storage == null)
            {
                Console.WriteLine("Невідомий формат.");
                return;
            }

            var appointments = storage.Load();

            
            appointments.Add(new Appointment
            {
                Doctor = "Dr. Shevchenko",
                Patient = "Ivan Petrov",
                Date = "2025-07-06"
            });

            storage.Save(appointments);

            Console.WriteLine("\nСписок прийомів:");
            foreach (var appt in appointments)
            {
                Console.WriteLine($"{appt.Date}: {appt.Doctor} приймає {appt.Patient}");
            }
        }
    }
}
