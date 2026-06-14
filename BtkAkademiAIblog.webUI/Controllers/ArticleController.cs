using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using BtkAkademiAIblog.webUI.Dtos.ArticleDtos;

namespace BtkAkademiAIblog.webUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ArticleController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult ArticleDetail()
        {
            return View();
        }

        public async Task<IActionResult> ArticleList()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5181/api/Articles");

            if (!responseMessage.IsSuccessStatusCode)
                return View(new List<ResultArticleDto>());

            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(jsonData))
                return View(new List<ResultArticleDto>());

            var values = JsonSerializer.Deserialize<List<ResultArticleDto>>(
                jsonData,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return View(values ?? new List<ResultArticleDto>());
        }

        public async Task<IActionResult> ArticleList2()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5181/api/Articles");

            if (!responseMessage.IsSuccessStatusCode)
                return View(new List<ResultArticleDto>());

            var jsonData = await responseMessage.Content.ReadAsStringAsync();

            if (string.IsNullOrEmpty(jsonData))
                return View(new List<ResultArticleDto>());

            var values = JsonSerializer.Deserialize<List<ResultArticleDto>>(
                jsonData,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });

            return View(values ?? new List<ResultArticleDto>());
        }

        public IActionResult ArticleListByCategory()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}