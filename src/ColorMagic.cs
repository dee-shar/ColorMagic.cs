using System.Net.Http;

namespace ColorMagicApi
{
    public class ColorMagic
    {
        private readonly HttpClient httpClient;
        private readonly string apiUrl = "https://colormagic.app/api";
        public ColorMagic()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/142.0.0.0 Safari/537.36");
        }

        public async Task<string> SearchColor(string query) =>
            await (await httpClient.GetAsync($"{apiUrl}/palette/search?q={query}")).Content.ReadAsStringAsync();
    }
}
