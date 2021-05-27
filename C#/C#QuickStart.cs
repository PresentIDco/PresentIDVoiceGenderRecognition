var client = new HttpClient();
var request = new HttpRequestMessage
{
    Method = HttpMethod.Post,
    RequestUri = new Uri("https://voice-gender-recognition.p.rapidapi.com/api/gender"),
    Headers =
    {
        { "x-rapidapi-key", "1c8c1abfe5msh7360a3ec3b0be2fp1b001fjsn7c31862917bf" },
        { "x-rapidapi-host", "voice-gender-recognition.p.rapidapi.com" },
    },
    Content = new MultipartFormDataContent
    {
        new StringContent("")
        {
            Headers =
            {
                ContentType = new MediaTypeHeaderValue("application/octet-stream"),
                ContentDisposition = new ContentDispositionHeaderValue("form-data")
                {
                    Name = "sound",
                }
            }
        },
    },
};
using (var response = await client.SendAsync(request))
{
    response.EnsureSuccessStatusCode();
    var body = await response.Content.ReadAsStringAsync();
    Console.WriteLine(body);
}
