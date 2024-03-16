using Portal.Provider.Interfaces;
using Portal.Provider.ViewModels;
using System;
using System.Collections.Generic;

namespace Portal.Provider.Repositories
{
    public class PatientRepository : IRepository<Patient>
    {
        private static readonly Random random = new Random();

        private List<Patient> MockPatients { get; set; }

        public PatientRepository() {

            List<Patient> mockPatientList = new();

            for (int i = 0; i < 30; i++)
            {
                // Generating fake data for the patient
                Patient patient = new Patient
                {
                    Id = Guid.NewGuid().ToString(), // Generate a unique ID for each patient
                    FirstName = GenerateRandomFirstName(),
                    LastName = GenerateRandomLastName(),
                    MiddleInitial = GenerateRandomMiddleInitial(),
                    DateOfBirth = GenerateRandomDateOfBirth(),
                    Interventions = GenerateRandomInterventions(),
                    RiskLevel = GenerateRandomRiskLevel()
                };

                mockPatientList.Add(patient);
            }

            MockPatients = mockPatientList;
        }

        public Patient Get(string id)
        {
            return MockPatients.First(patient => patient.Id == id);
        }

        public List<Patient> GetAll()
        {
            return MockPatients;
        }

        // Helper methods to generate random fake data

        private string GenerateRandomFirstName()
        {
            string[] firstNames = { "John", "Jane", "Michael", "Emily", "William", "Olivia", "James", "Sophia" }; // Add more names as needed
            return firstNames[random.Next(firstNames.Length)];
        }

        private string GenerateRandomLastName()
        {
            string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson" }; // Add more names as needed
            return lastNames[random.Next(lastNames.Length)];
        }

        private char GenerateRandomMiddleInitial()
        {
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            return alphabet[random.Next(alphabet.Length)];
        }

        private DateTime GenerateRandomDateOfBirth()
        {
            DateTime start = new DateTime(1950, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(range));
        }

        private List<Intervention> GenerateRandomInterventions()
        {
            List<Intervention> interventions = new List<Intervention>();

            // Generating random number of interventions (between 0 and 5)
            int numberOfInterventions = random.Next(6);
            string[] interventionNames = { "Intervention A", "Intervention B", "Intervention C", "Intervention D", "Intervention E" }; // Sample intervention names

            for (int i = 0; i < numberOfInterventions; i++)
            {
                interventions.Add(new Intervention
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = interventionNames[random.Next(interventionNames.Length)]
                });
            }

            return interventions;
        }

        private string GenerateRandomRiskLevel()
        {
            string[] riskLevels = { "Low", "Medium", "High" }; // Add more levels as needed
            return riskLevels[random.Next(riskLevels.Length)];
        }
    }
}
