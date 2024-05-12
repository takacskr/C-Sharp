using System;

namespace Data
{
    public static class EmployeeService
    {
        private static readonly string[] exampleNames = new[]
        {
            "Nancy", "Margaret", "Michael", "Robert", "Anne"
        };

        private static readonly string[] exampleMail = new[]
        {
            "nancy@domain.com", "margaret@domain.com", "michael@domain.com", "robert@domain.com","anne@domain.com"
        };

        //public static async Task<int> TestAsync()
        //{
        //    await Task.Delay(1000);
        //    return 1;
        //}

        public static async Task<EmployeeModel[]> GetEmployeeAsync(DateTime startDate)
        {
            int returnLength = 5;

            EmployeeModel[] employeeModels = new EmployeeModel[returnLength];

            for (int i = 0; i < returnLength; i++)
            {
                employeeModels[i] = new EmployeeModel
                {
                    joined = startDate.AddDays(i),
                    name = exampleNames[i],
                    email = exampleMail[i],
                    image = "../img/" + exampleNames[i] + ".jpg",
                    id = Random.Shared.Next(200, 555)
                };
            }

            return employeeModels;
        }
    }
}
