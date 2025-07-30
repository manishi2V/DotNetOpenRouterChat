using System.Net.Http.Headers;
using System.Net.Http.Json;

string apiKey = Environment.GetEnvironmentVariable("OPENROUTER_API_KEY")!;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", apiKey);
httpClient.DefaultRequestHeaders.Add("HTTP-Referer", "http://localhost");
httpClient.DefaultRequestHeaders.Add("X-Title", "DotNet ChatBot");

// Use a chat history list to simulate an ongoing conversation
var chatHistory = new List<Message>();

Console.WriteLine("🤖 Welcome to ChatGPT via OpenRouter! Type 'exit' to quit.\n");

while (true)
{
    Console.Write("You: ");
    string userInput = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(userInput)) continue;
    if (userInput.ToLower() == "exit") break;

    // Add user's message to chat history
    chatHistory.Add(new Message { role = "user", content = userInput });

    var requestBody = new
    {
        model = "mistralai/mistral-7b-instruct", // or any other supported model
        messages = chatHistory
    };

    var response = await httpClient.PostAsJsonAsync("https://openrouter.ai/api/v1/chat/completions", requestBody);

    if (response.IsSuccessStatusCode)
    {
        var result = await response.Content.ReadFromJsonAsync<OpenRouterResponse>();
        var reply = result?.choices?[0]?.message?.content?.Trim();

        if (!string.IsNullOrEmpty(reply))
        {
            // Add AI response to chat history
            var assistantMessage = new Message { role = "assistant", content = reply };
            chatHistory.Add(assistantMessage);

            Console.WriteLine("\n🤖 GPT: " + reply + "\n");
        }
        else
        {
            Console.WriteLine("🤖 GPT gave no reply.\n");
        }
    }
    else
    {
        Console.WriteLine($"❌ API Error: {response.StatusCode}");
        Console.WriteLine(await response.Content.ReadAsStringAsync());
    }
}

// --- Models ---
public class OpenRouterResponse
{
    public List<Choice> choices { get; set; }
}

public class Choice
{
    public Message message { get; set; }
}

public class Message
{
    public string role { get; set; }
    public string content { get; set; }
}
