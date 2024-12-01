
string uri = "http://URI";

using (HttpClient client = new HttpClient())
{
    HttpResponseMessage response = await client.GetAsync(uri);
    string ResponseBody = await response.Content.ReadAsStringAsync();
    Console.WriteLine(ResponseBody);
}