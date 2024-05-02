namespace BlazorWebAssemblyStandaloneAppBasics.wwwroot.Data
{
    // Az alkalmazottak adatainak szolgáltató osztály
    public class EmployeeService
    {
        // Alkalmazottak neveinek tömbje
        private static readonly string[] Name = new[]
        {
            "Nancy", "Margaret", "Michael", "Robert", "Anne"
        };

        // Alkalmazottak e-mail címeinek tömbje
        private static readonly string[] Mail = new[]
        {
            "nancy@domain.com", "margaret@domain.com", "michael@domain.com", "robert@domain.com","anne@domain.com"
        };

        // Az alkalmazottak adatainak lekérdezése aszinkron módon
        public Task<EmployeeModel[]> GetEmployeeAsync(DateTime startDate)
        {
            // Visszatér egy feladattal, ami megadja az alkalmazottakat
            return Task.FromResult(Enumerable.Range(0, 5).Select(index => new EmployeeModel
            {
                // Az alkalmazott belépési dátuma az adott dátumtól számított napok alapján
                Joined = startDate.AddDays(index),
                // Az alkalmazott neve a tárolt nevek tömbjéből
                Name = Name[index],
                // Az alkalmazott e-mail címe a tárolt e-mail címek tömbjéből
                Email = Mail[index],
                // Az alkalmazott képe a nevével azonos PNG fájl
                Image = "../img/" + Name[index] + ".jpg",
                // Az alkalmazott azonosítója egy véletlenszerűen generált szám lesz
                ID = Random.Shared.Next(200, 555)
            }).ToArray());
        }
    }
}
