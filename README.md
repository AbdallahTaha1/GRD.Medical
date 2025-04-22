# GRD.Medical

**GRD.Medical** is a full-featured web application inspired by platforms like **Doctor Anywhere** and **Konsilmed**, developed as a **final year project** at **Mansoura University, Computer Science and Engineering Department (CSED)**. It aims to streamline and modernize patient-doctor interactions.

## 🩺 Features

- 👤 User Registration & Authentication (JWT)
- 🔍 Filter & Search for Doctors
- 📅 Schedule Appointments
- 💬 Real-Time Chat (SignalR)
- 📝 Post Reviews & Ask Medical Questions
- 📚 Browse Medical Articles
- 🔔 Receive Notifications
- 🔐 Secure Password Reset
- 💳 Stripe Payment Integration

## 🛠️ Tech Stack

**Frontend:**
- Angular
- HTML, CSS, Bootstrap
- TypeScript

**Backend:**
- .NET Web API
- Entity Framework Core
- AutoMapper
- Mediator
- CQRS Pattern
- Onion Architecture
- Fluent Validation
- SignalR
- Stripe API
- SQL Server

## 📁 Project Structure

Follows the **Onion Architecture** to ensure clean separation of concerns.

```
GRD.Medical
│
├── GRD.Medical.API             # ASP.NET Core Web API
├── GRD.Medical.Application     # Application layer (CQRS, Services, Validators)
├── GRD.Medical.Domain          # Core domain models and interfaces
├── GRD.Medical.Infrastructure  # EF Core & external integrations
└── GRD.Medical.Frontend        # Angular frontend
```

## 🚀 Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server
- Node.js & Angular CLI

### Backend Setup
```bash
cd GRD.Medical.API
dotnet restore
dotnet ef database update
dotnet run
```

### Frontend Setup
```bash
cd GRD.Medical.Frontend
npm install
ng serve
```

## 📷 Screenshots
![image](https://github.com/user-attachments/assets/d501c613-2ed0-41e3-95df-2c2f98a51e73)
![image](https://github.com/user-attachments/assets/23606643-74b2-4571-b640-b5d7f0940a0f)
![image](https://github.com/user-attachments/assets/a8a75742-cc1c-4f74-a9ce-d845de11a27b)
![image](https://github.com/user-attachments/assets/79b3eaa6-3bd0-4e5b-bd45-a44808c388c4)
![image](https://github.com/user-attachments/assets/29c835b1-8e92-4de2-8a48-57c8e0edd94d)
![image](https://github.com/user-attachments/assets/2d5fe758-ef06-4bd6-a3d8-10269341a084)
![image](https://github.com/user-attachments/assets/990b1d82-b38c-4650-95db-e3e2cd251a2e)

## 🎓 Academic Acknowledgement

This project was developed as part of the graduation requirements for the **Computer Science and Engineering Department** at **Mansoura University**.

## 🤝 Contributing

Pull requests are welcome! For major changes, please open an issue first to discuss.
