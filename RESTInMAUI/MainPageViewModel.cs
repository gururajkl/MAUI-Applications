using System.Text;
using System.Text.Json;
using System.Windows.Input;

namespace RESTInMAUI
{
    public class MainPageViewModel
    {
        HttpClient client;
        JsonSerializerOptions options;
        string baseUrl = "https://653b3fc72e42fd0d54d4d8b8.mockapi.io";
        private List<Users> Users = new();

        public MainPageViewModel()
        {
            client = new HttpClient();
            options = new JsonSerializerOptions { WriteIndented = true };
        }

        public ICommand AddAllUserCommand => new Command(async () =>
        {
            string url = $"{baseUrl}/users";
            var response = await client.GetAsync(url);

            if (response.IsSuccessStatusCode)
            {
                using (var responseStream = await response.Content.ReadAsStreamAsync())
                {
                    var data = await JsonSerializer.DeserializeAsync<List<Users>>(responseStream, options);
                    Users = data;
                }
            }
        });

        public ICommand AddSingleUserCommand => new Command(async () =>
        {
            string url = $"{baseUrl}/users/25";
            var respose = await client.GetAsync(url);
        });

        public ICommand CreateNewUser => new Command(async () =>
        {
            Users user = new Users
            {
                avatar = "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1241.jpg",
                name = "Hector",
                createdAt = DateTime.Now
            };

            string url = $"{baseUrl}/users";
            string json = JsonSerializer.Serialize<Users>(user, options);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(url, content);
        });

        public ICommand EditUserCommand => new Command(async () =>
        {
            Users user = Users.FirstOrDefault(x => x.id == "1");
            user.name = "Guru";

            string url = $"{baseUrl}/users/{user.id}";
            string json = JsonSerializer.Serialize<Users>(user, options);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync(url, stringContent);
        });

        public ICommand DeleteUserCommand => new Command(async () =>
        {
            Users user = Users.FirstOrDefault(x => x.id == "1");
            string url = $"{baseUrl}/users/{user.id}";
            string json = JsonSerializer.Serialize<Users>(user, options);
            var response = await client.DeleteAsync(url);
        });
    }
}
