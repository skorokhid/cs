
using System;
namespace cs
{
    class Program
    {
        static void Main()
        {
            string folderPath = @"D:\cs\education\education\JsonData";
            PatientDataHandler patientDataHandler = new PatientDataHandler(folderPath);
            patientDataHandler.HandlePatientData();
        }
    }
}
