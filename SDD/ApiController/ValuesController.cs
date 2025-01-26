using EntityLayer.Concrate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using System.Text.Json;

namespace SDD.ApiController
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ValuesController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpPost("send-base64-image")]
        public async Task<IActionResult> SendImage([FromBody] Photo request)
        {
            try
            {
                string FlaskApiUrl = "http://127.0.0.1:5000/processImage";
                var client = _httpClientFactory.CreateClient();
                var json = JsonSerializer.Serialize(new { imageBase64 = request.photoPath });
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                var response = await client.PostAsync(FlaskApiUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    return BadRequest($"Flask API çağrısı başarısız oldu. Durum Kodu: {response.StatusCode}");
                }
                var resultJson = await response.Content.ReadAsStringAsync();
                return Ok(resultJson);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Hata: {ex.Message}");
            }
           }
        }

    }
