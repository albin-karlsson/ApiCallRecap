using Newtonsoft.Json;

namespace ApiCallRecap.DAL
{
    public class ApiCaller
    {
        public async Task<RootModel?> MakeCall()
        {
            // Skapa en HttpClient för att kunna göra ett call
            HttpClient client = new();

            // Gör callet!
            var response = await client.GetAsync("https://dummyjson.com/users");

            // Evaluera responset
            if (response.IsSuccessStatusCode)
            {
                // Läs responset som json
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Konvertera json till C#-objekt
                RootModel? apiData = JsonConvert.DeserializeObject<RootModel>(jsonResponse);

                // Returnera C#-objekt
                return apiData;
            }
            else
            {
                return null;
            }
        }
    }
}
