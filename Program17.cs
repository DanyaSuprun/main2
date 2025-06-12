
public class Doctor
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Appointment
{
    public int Id { get; set; }
    public int DoctorId { get; set; }
    public int PatientId { get; set; }
    public DateTime Date { get; set; }
}


public class Repository<T> where T : class
{
    private List<T> items = new List<T>();
    private int nextId = 1;

    public List<T> GetAll() => items;

    public void Add(T item)
    {
        var property = item.GetType().GetProperty("Id");
        property?.SetValue(item, nextId++);
        items.Add(item);
    }

    public void Update(int id, T newItem)
    {
        var property = newItem.GetType().GetProperty("Id");
        property?.SetValue(newItem, id);
        var index = items.FindIndex(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
        if (index >= 0) items[index] = newItem;
    }

    public void Delete(int id)
    {
        items.RemoveAll(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
    }

    public T GetById(int id)
    {
        return items.FirstOrDefault(x => (int)x.GetType().GetProperty("Id").GetValue(x) == id);
    }
}

public class DoctorService
{
    private Repository<Doctor> repo = new Repository<Doctor>();

    public void AddDoctor(string name) => repo.Add(new Doctor { Name = name });
    public List<Doctor> GetAll() => repo.GetAll();
    public void DeleteDoctor(int id) => repo.Delete(id);
    public void UpdateDoctor(int id, string name) => repo.Update(id, new Doctor { Name = name });
}

public class PatientService
{
    private Repository<Patient> repo = new Repository<Patient>();

    public void AddPatient(string name) => repo.Add(new Patient { Name = name });
    public List<Patient> GetAll() => repo.GetAll();
    public void DeletePatient(int id) => repo.Delete(id);
    public void UpdatePatient(int id, string name) => repo.Update(id, new Patient { Name = name });
}

public class AppointmentService
{
    private Repository<Appointment> repo = new Repository<Appointment>();

    public void AddAppointment(int doctorId, int patientId, DateTime date)
        => repo.Add(new Appointment { DoctorId = doctorId, PatientId = patientId, Date = date });

    public List<Appointment> GetAll() => repo.GetAll();
    public void DeleteAppointment(int id) => repo.Delete(id);
    public void UpdateAppointment(int id, int doctorId, int patientId, DateTime date)
        => repo.Update(id, new Appointment { DoctorId = doctorId, PatientId = patientId, Date = date });
}


enum Menu
{
    Exit,
    AddDoctor,
    ListDoctors,
    AddPatient,
    ListPatients,
    AddAppointment,
    ListAppointments
}

class Program
{
    static void Main()
    {
        var doctorService = new DoctorService();
        var patientService = new PatientService();
        var appointmentService = new AppointmentService();

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            foreach (var item in Enum.GetValues(typeof(Menu)))
                Console.WriteLine($"{(int)item}. {item}");

            if (!int.TryParse(Console.ReadLine(), out int choice) || !Enum.IsDefined(typeof(Menu), choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            switch ((Menu)choice)
            {
                case Menu.Exit:
                    return;

                case Menu.AddDoctor:
                    Console.Write("Doctor name: ");
                    doctorService.AddDoctor(Console.ReadLine());
                    break;

                case Menu.ListDoctors:
                    foreach (var d in doctorService.GetAll())
                        Console.WriteLine($"{d.Id}: {d.Name}");
                    break;

                case Menu.AddPatient:
                    Console.Write("Patient name: ");
                    patientService.AddPatient(Console.ReadLine());
                    break;

                case Menu.ListPatients:
                    foreach (var p in patientService.GetAll())
                        Console.WriteLine($"{p.Id}: {p.Name}");
                    break;

                case Menu.AddAppointment:
                    Console.Write("Doctor ID: ");
                    int docId = int.Parse(Console.ReadLine());
                    Console.Write("Patient ID: ");
                    int patId = int.Parse(Console.ReadLine());
                    Console.Write("Date (yyyy-mm-dd): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    appointmentService.AddAppointment(docId, patId, date);
                    break;

                case Menu.ListAppointments:
                    foreach (var a in appointmentService.GetAll())
                        Console.WriteLine($"Appointment {a.Id}: Doctor {a.DoctorId}, Patient {a.PatientId}, Date {a.Date}");
                    break;
            }
        }
    }
}
