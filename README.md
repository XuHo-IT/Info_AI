AI Chat with Custom Data
This project is an AI chat application demonstrating how to interact with custom data using an AI language model. It’s currently in early preview, so your feedback is welcome! Please consider taking a brief survey.

Note:
Before running this project, you need to configure API keys or endpoints for your chosen AI model provider. See details below.

Configure the AI Model Provider
If you want to use models hosted by GitHub Models, you must create a GitHub personal access token with models:read permission only (no additional scopes). For guidance, see:

Prototyping with AI models

Managing your personal access tokens

To configure the token for this project using .NET User Secrets, run:
cd <<your-project-directory>>
dotnet user-secrets set GitHubModels:Token YOUR-TOKEN

How to Use Your Own Data
You can clone this repository, then replace or add your own PDF documents to customize the data your AI chat app uses. Simply update the references to your PDF files in the project to have the AI read and answer questions based on your documents.

Feel free to modify and enhance the project to suit your specific needs!
