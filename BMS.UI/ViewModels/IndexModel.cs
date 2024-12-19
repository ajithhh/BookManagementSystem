namespace BMS.UI.ViewModels
{
    using BMS.Application.DTOs;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class IndexModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public List<Book> Books { get; private set; } = new();

        public IndexModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task OnGetAsync()
        {
            var response = await _httpClient.GetAsync("https://localhost:7178/api/Books");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Books = JsonSerializer.Deserialize<List<Book>>(content) ?? new List<Book>();
            }
        }
    }

}
