namespace BMS.UI.ViewModels
{
    using BMS.Application.DTOs;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.RazorPages;
    using System.Net.Http;
    using System.Text;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class AddModel : PageModel
    {
        private readonly HttpClient _httpClient;

        [BindProperty]
        public Book Book { get; set; } = new();

        public AddModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var content = new StringContent(JsonSerializer.Serialize(Book), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("https://localhost:7178/api/Books", content);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToPage("Index");
            }
            ModelState.AddModelError(string.Empty, "An error occurred while adding the book.");
            return Page();
        }
    }
}