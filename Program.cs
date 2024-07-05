using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

class SmsGatewayHub
{
    static void Main(string[] args)
    {
        string apiKey = "YourAPIkey";
        string senderId = "TESTIN";
        string message = "YOUR MESSAGE HERE";
        string number = "91989xxxxxxx"; // MULTIPLE NUMBER VARIABLES PUT HERE...!
        string entityId = "Registered-Entity-Id";
        string dltTemplateId = "Registered-DLT-Template-Id";
        string route = "clickhere";

        string url = $"https://www.smsgatewayhub.com/api/mt/SendSMS";
        string queryParams = $"APIKey={apiKey}&senderid={senderId}&channel=2&DCS=0&flashsms=0&number={number}&text={Uri.EscapeDataString(message)}&route={route}&EntityId={entityId}&dlttemplateid={dltTemplateId}";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync(url + "?" + queryParams).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseBody = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(responseBody);
            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }
        }
    }
}
