# 🏥 HealthSync-EventDriven-Azure

## 📖 Overview

HealthSync is a cloud-native Hospital Management System built using **ASP.NET Core Web API** and **Microsoft Azure**. The application enables patient registration, doctor management, appointment booking, medical record management, automated email notifications, and secure medical report storage.

The project demonstrates a modern **event-driven architecture** using Azure services such as API Management, Service Bus, Logic Apps, Azure Functions, Blob Storage, SQL Database, and Key Vault.

---

## 🚀 Features

### 👨‍⚕️ Patient Management

* Register new patients
* View patient details
* Update patient information
* Delete patient records

### 🩺 Doctor Management

* Add doctors
* Manage doctor information
* Assign appointments

### 📅 Appointment Booking

* Book appointments with doctors
* Store appointment details in database
* Trigger automated workflows

### 📧 Automated Email Notifications

* Appointment booking sends a message to Azure Service Bus
* Azure Logic App automatically processes the message
* Confirmation email sent to patient

### 📄 Medical Report Management

* Doctors upload patient reports in PDF format
* Files stored securely in Azure Blob Storage
* Azure Function automatically processes uploaded files

---

## ☁️ Azure Services Used

| Service              | Purpose                                          |
| -------------------- | ------------------------------------------------ |
| Azure API Management | API Gateway, Rate Limiting, Security Policies    |
| Azure App Service    | Hosts ASP.NET Core Web API                       |
| Azure SQL Database   | Stores application data                          |
| Azure Service Bus    | Message Queue for asynchronous processing        |
| Azure Logic Apps     | Sends appointment confirmation emails            |
| Azure Blob Storage   | Stores medical reports and documents             |
| Azure Functions      | Blob Trigger processing                          |
| Azure Key Vault      | Secure storage of secrets and connection strings |

---

## 🏗️ Architecture Flow

### Appointment Booking Workflow

1. Patient books an appointment.
2. Request passes through Azure API Management.
3. ASP.NET Core Web API processes the request.
4. Appointment data is saved in Azure SQL Database.
5. A message is sent to Azure Service Bus Queue.
6. Azure Logic App detects the message.
7. Logic App sends a confirmation email to the patient.

### Medical Report Upload Workflow

1. Doctor uploads a medical report PDF.
2. PDF is stored in Azure Blob Storage.
3. Azure Blob Trigger Function automatically executes.
4. Function processes the uploaded file.
5. Processing information is logged automatically.

---

## 🔐 Security Features

* Azure API Management policies
* Rate Limiting
* CORS Configuration
* Azure Key Vault integration
* Secure connection string management

### Rate Limiting Policy

* Maximum 2 requests per 10 seconds per client
* Returns HTTP 429 (Too Many Requests) when limit exceeds

---

## 💻 Technologies Used

### Backend

* ASP.NET Core Web API
* C#
* Entity Framework Core
* Repository Pattern
* Async/Await Programming

### Cloud Platform

* Microsoft Azure

### Database

* Azure SQL Database

### API Testing

* Swagger UI

---

## 📂 Project Structure

```text
HealthSync-EventDriven-Azure
│
├── HOSPITAL
│   ├── Controllers
│   ├── Models
│   ├── Repositories
│   ├── Program.cs
│   └── Configuration Files
│
├── FunctionApp
│   ├── Blob Trigger Function
│   ├── Program.cs
│   └── host.json
│
└── README.md
```

---

## 📡 API Endpoints

### Patients

* GET /api/patients
* GET /api/patients/{id}
* POST /api/patients
* PUT /api/patients/{id}
* DELETE /api/patients/{id}

### Doctors

* GET /api/doctors
* POST /api/doctors

### Appointments

* GET /api/appointments
* POST /api/appointments

### Medical Records

* GET /api/medicalrecords
* POST /api/medicalrecords/upload

---

## 🎯 Key Concepts Demonstrated

* Cloud-Native Application Development
* Event-Driven Architecture
* Serverless Computing
* Repository Pattern
* Asynchronous Programming
* API Management
* Messaging Systems
* Workflow Automation
* Secure Cloud Storage

---

## 📈 Future Enhancements

* JWT Authentication
* Role-Based Authorization
* Patient Portal
* Doctor Dashboard
* SMS Notifications
* Appointment Rescheduling
* Telemedicine Integration

---

## 📫 Contact

**Vikash Kumar Gupta**  
📍 Bokaro Steel City, Jharkhand  
✉️ [vikashkumargupta907@gmail.com](mailto:vikashkumargupta907@gmail.com)  
🔗 [LinkedIn](https://linkedin.com/in/vikash1995) | [GitHub](https://github.com/KrVikashGupta)

---

## ⭐ Project Goal

This project was developed to demonstrate real-world Microsoft Azure cloud services integration with ASP.NET Core Web API using modern enterprise architecture patterns and event-driven workflows.
