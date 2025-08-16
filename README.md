# Blazor Web Server SignalR Chat

A simple real-time chat application built with Blazor Web Server (.NET 8.0) and SignalR, demonstrating WebSocket communication basics.

## Features

- Real-time messaging using SignalR
- Online user count tracking
- Minimal UI demonstrating core functionality
- Blazor Web Server implementation
- .NET 8.0 compatible

## Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Visual Studio 2022 (or VS Code with C# extensions)

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/yourusername/blazor-signalr-chat.git
2.  Open the solution in Visual Studio or your preferred IDE
3. Build and run the application (F5 in Visual Studio)

## Project Structure
1. Program.cs
   - SignalR services configuration.
2. Hubs/Chathub.cs
   - SignalR hub handling connections and messaging
4. Components/Pages/ChatPage.razor
   - Blazor component for chat UI
  
## How It Works
- Users connect to the SignalR hub when navigating to the chat page-
-  Messages are broadcast to all connected clients
- Online user count is updated in real-time
- Simple UI shows message history and sender information

   ## Contributing
   Contributions are welcome! Please open an issue or submit a pull request.

## 👋 About Me
I'm Eman Ali, a backend engineer and student at Air University Islamabad. Building practical examples to help others learn. Connect with me:
- [GitHub Profile](https://github.com/emanau)
- [LinkedIn](https://www.linkedin.com/in/eman-ali-168a542aa/)
