

using System.Net.Http.Headers;

namespace MvcMovie.Utils
{
    public class RequestClient
    {
        private readonly HttpClient client = new();

        public RequestClient()
        {
            client.BaseAddress = new Uri("http://localhost:3000");

        }




        public async Task<string> PostTask<T>(string url, T Model)
        {


            Console.WriteLine("class running");

            var response = await client.PostAsJsonAsync<T>(url, Model);

            response.EnsureSuccessStatusCode();
            var responseString = await response.Content.ReadAsStringAsync();


            return responseString;
        }



        public async Task<T> GetTask<T>(string url)

        {
            var response = await client.GetFromJsonAsync<T>(url);
            return response!;
        }

    }
}