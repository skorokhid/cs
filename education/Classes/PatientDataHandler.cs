using System.IO;
using System;
using System.Text.Json;

namespace cs
{
    public class PatientDataHandler
    {
        private readonly string folderPath;

        public PatientDataHandler(string folderPath)
        {
            this.folderPath = folderPath;
        }

        /*     public void WriteDataFromJson()
             {
                 // Запит даних пацієнта з консолі
                 Console.Write("Enter patient's name: ");
                 string name = Console.ReadLine();

                 Console.Write("Enter patient's adress: ");
                 string adress = Console.ReadLine();

                 Console.Write("Enter patient's DateOfBirth : ");
                 int dateOfBirth = int.Parse(Console.ReadLine());

                 Console.Write("Enter patient's id : ");
                 int patientId = int.Parse(Console.ReadLine());

                 Console.Write("Enter patient's PolicyNumber : ");
                 string insurancePolicyNumber = Console.ReadLine();

                 // Створення екземпляра пацієнта
                 Patient patient = new Patient
                 {
                     Name = name,
                     Adress = adress,
                     DateOfBirth = dateOfBirth,
                     PatientId = patientId,
                     InsurancePolicyNumber = insurancePolicyNumber

                 };

                 // Серіалізація пацієнта в JSON
                 string jsonString = JsonSerializer.Serialize(patient);
                 string fileName = "patient.json";
                 string filePath = Path.Combine(folderPath, fileName);

                 // Запис JSON у файл
                 File.WriteAllText(filePath, jsonString);

                 Console.WriteLine("Data has been written to: " + filePath);
                 Console.ReadKey();
             }*/
        public void HandlePatientData()
        {
            // Запит даних пацієнта з консолі
            Console.Write("Enter patient's name: ");
            string name = Console.ReadLine();

            Console.Write("Enter patient's adress: ");
            string adress = Console.ReadLine();

            Console.Write("Enter patient's DateOfBirth : ");
            int dateOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Enter patient's id : ");
            int patientId = int.Parse(Console.ReadLine());

            Console.Write("Enter patient's PolicyNumber : ");
            string insurancePolicyNumber = Console.ReadLine();

            // Створення екземпляра пацієнта
            Patient patient = new Patient
            {
                Name = name,
                Adress = adress,
                DateOfBirth = dateOfBirth,
                PatientId = patientId,
                InsurancePolicyNumber = insurancePolicyNumber

            };

            // Серіалізація пацієнта в JSON
            string jsonString = JsonSerializer.Serialize(patient);
            string fileName = "patient.json";
            string filePath = Path.Combine(folderPath, fileName);

            // Запис JSON у файл
            File.WriteAllText(filePath, jsonString);

            Console.WriteLine("Data has been written to: " + filePath);
            string jsonData = File.ReadAllText(filePath);
            Patient? jsonToObject = JsonSerializer.Deserialize<Patient>(jsonData);
            Console.WriteLine("Deserialized object here : {0}", jsonToObject.Name);
            
            Console.ReadKey();
        }
    }
}