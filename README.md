# 🚀 AI CHAT WITH CUSTOM DATA

This project is an **AI chat application** demonstrating how to interact with **custom data** using an AI language model.

---

### ⚙️ NOTE:
Before running this project, you **MUST CONFIGURE** API keys or endpoints for your chosen AI model provider. See details below.

---

### 🔐 CONFIGURE THE AI MODEL PROVIDER

To use models hosted by **GitHub Models**, you need a **GitHub personal access token** with the `models:read` permission **ONLY** (no other scopes). For help, visit:  

- 📚 [Prototyping with AI models](https://docs.github.com/github-models/prototyping-with-ai-models)  
- 🔑 [Managing your personal access tokens](https://docs.github.com/authentication/keeping-your-account-and-data-secure/managing-your-personal-access-tokens)

Run these commands to configure your token with .NET User Secrets:

```bash
cd <<YOUR-PROJECT-DIRECTORY>>
dotnet user-secrets set GitHubModels:Token YOUR-TOKEN
