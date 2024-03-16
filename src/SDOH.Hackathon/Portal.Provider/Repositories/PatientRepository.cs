using Portal.Provider.Interfaces;
using Portal.Provider.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Portal.Provider.Repositories
{
    public class PatientRepository : IRepository<Patient>
    {
        private static readonly Random random = new Random();

        private List<Patient> MockPatients { get; set; }

        public PatientRepository()
        {
            List<Patient> mockPatientList = new List<Patient>();

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
                    RiskFactors = GenerateRandomRiskFactors(),
                    RiskLevel = GenerateRandomRiskLevel()
                };

                mockPatientList.Add(patient);
            }

            MockPatients = mockPatientList;
        }

        public Patient Get(string id)
        {
            return MockPatients.FirstOrDefault(patient => patient.Id == id);
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

            // Realistic COPD interventions related to social determinants of health
            Dictionary<string, string> interventionDescriptions = new Dictionary<string, string>()
            {
                { "Smoking cessation programs", "Smoking cessation programs provide support and resources to individuals trying to quit smoking, including counseling, medication, and behavioral therapy." },
                { "Access to affordable housing", "Access to affordable housing initiatives aim to provide stable housing options for individuals with COPD, reducing exposure to environmental triggers and improving overall health outcomes." },
                { "Education on indoor air quality", "Education on indoor air quality raises awareness about common indoor pollutants and how to mitigate them, including proper ventilation, use of air purifiers, and avoiding harmful substances." },
                { "Community support for physical activity", "Community support for physical activity programs promote exercise and physical activity among individuals with COPD, focusing on activities suitable for their condition and abilities." },
                { "Access to nutritious food", "Access to nutritious food initiatives ensure individuals have access to healthy, balanced diets, which can help manage COPD symptoms and improve overall health." },
                { "Mental health support services", "Mental health support services address the psychological impact of COPD, providing counseling, therapy, and support groups to manage stress, anxiety, and depression associated with the condition." }
            };

            // Generate random number of interventions (between 0 and 5)
            int numberOfInterventions = random.Next(6);

            // Randomly select interventions from the dictionary
            var selectedInterventions = interventionDescriptions.Keys.OrderBy(x => random.Next()).Take(numberOfInterventions);

            foreach (var interventionName in selectedInterventions)
            {
                interventions.Add(new Intervention
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = interventionName,
                    Description = interventionDescriptions[interventionName]
                });
            }

            return interventions;
        }

        private List<RiskFactor> GenerateRandomRiskFactors()
        {
            List<RiskFactor> riskFactors = new List<RiskFactor>();

            // Generate random number of risk factors (between 0 and 5)
            int numberOfRiskFactors = random.Next(6);

            // Realistic COPD risk factors related to social determinants of health
            string[] riskFactorNames = {
                "Exposure to secondhand smoke",
                "Occupational exposure to pollutants",
                "Poor indoor air quality",
                "Low socioeconomic status",
                "Lack of access to healthcare",
                "Limited education"
            };

            for (int i = 0; i < numberOfRiskFactors; i++)
            {
                riskFactors.Add(new RiskFactor
                {
                    Name = riskFactorNames[random.Next(riskFactorNames.Length)]
                });
            }

            return riskFactors;
        }

        private string GenerateRandomRiskLevel()
        {
            string[] riskLevels = { "Low", "Medium", "High" }; // Add more levels as needed
            return riskLevels[random.Next(riskLevels.Length)];
        }
    }
}
