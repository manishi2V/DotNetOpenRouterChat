<p align="center">
  <img src="https://avatars.githubusercontent.com/u/165612349?s=200&v=4" width="100" alt="OpenRouter Logo" />
  <h1 align="center">DotNetOpenRouterChat 🤖</h1>
  <p align="center">Interactive Console Chatbot using .NET 9 + OpenRouter API</p>
</p>

<p align="center">
  <img alt=".NET Version" src="https://img.shields.io/badge/.NET-9.0-blue?logo=dotnet" />
  <img alt="License" src="https://img.shields.io/github/license/manishi2V/DotNetOpenRouterChat" />
  <img alt="OpenRouter API" src="https://img.shields.io/badge/OpenRouter-AI%20Gateway-green?logo=openai" />
</p>

---

## ✅ Prerequisites

- [.NET SDK 9.0.302](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- API key from [OpenRouter.ai](https://openrouter.ai/settings/keys) - You can use OpenRouter.ai without adding any credit if you stick to free models. For GPT-4, Claude, or Gemini, you'll need to purchase credit.

---

## 🔐 Set OpenRouter API Key as Environment Variable (Windows)

1. Open **System Properties**
2. Go to the **Advanced** tab
3. Click **Environment Variables**
4. Under **User variables**, click **New**
5. Add:
   - **Variable name**: `OPENROUTER_API_KEY`
   - **Variable value**: `xxxxx` (Replace with your actual key)
6. Click **OK** three times to apply

> 💡 Restart Command Prompt or IDE to reflect changes

---

## 🚀 Clone and Run

```bash
git clone https://github.com/manishi2V/DotNetOpenRouterChat.git
cd DotNetOpenRouterChat
dotnet build
dotnet run
````

---

## 💬 How It Works

* The app launches a chatbot in your console.
* You type your query just like ChatGPT.
* The response is fetched live from OpenRouter's LLMs.
* Conversation continues until you type `exit`.

---

## 🧠 Example

```bash
You: What is the capital of France?
🤖 GPT: The capital of France is Paris.

You: Tell me a joke.
🤖 GPT: Why don’t skeletons fight each other? Because they don’t have the guts!
```

---

## ⚙️ Customizing the Model

In `Program.cs`, you can modify the `model` variable to use any supported OpenRouter model.

Default:

```csharp
model = "mistralai/mistral-7b-instruct";
```

Change to:

```csharp
model = "meta-llama/llama-3-8b-instruct";
```

Explore more models 👉 [https://openrouter.ai/models](https://openrouter.ai/models)

---

## 📄 License

This project is licensed under the **MIT License**. Feel free to use and adapt.

---

## 🙌 Credits

* Built with ❤️ using [.NET 9](https://dotnet.microsoft.com/)
* Powered by [OpenRouter.ai](https://openrouter.ai)

---

> ⭐ If you found this helpful, give it a star on [GitHub](https://github.com/manishi2V/DotNetOpenRouterChat)!
