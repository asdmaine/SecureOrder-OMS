# SecureOrder OMS - Frontend-Backend Integration

**Course 7 Capstone Project** *A full-stack integration demonstration connecting an ASP.NET Core Web API with a dynamic JavaScript frontend.*

## 📌 Project Overview
This project represents the final integration phase of the SecureOrder Order Management System. The goal was to bridge the gap between the backend logic and the user interface, ensuring secure data transfer, structured JSON responses, and optimized performance.

## 🚀 Key Features (Grading Rubric Highlights)

### 1. Seamless Frontend-Backend Communication
* **Technology:** Implemented the JavaScript `Fetch API` to consume RESTful endpoints.
* **Architecture:** The client-side logic is decoupled into a dedicated `apiService.js` module to maintain clean separation of concerns.
* **CORS Configuration:** Enabled **Cross-Origin Resource Sharing (CORS)** in the ASP.NET Core middleware to allow the frontend (running on a local server) to safely request data from the backend API.

### 2. Structured JSON API
The API returns data in a strict, predictable JSON structure using Data Transfer Objects (DTOs).
* **Example Response (`GET /api/products`):**
    ```json
    [
      {
        "id": 1,
        "name": "Laptop",
        "price": 1200.00,
        "stock": 5
      },
      {
        "id": 2,
        "name": "Mouse",
        "price": 25.50,
        "stock": 50
      }
    ]
    ```

---

## 🤖 Reflection: Development with Microsoft Copilot

This project utilized AI assistance to debug integration issues and optimize performance.

### 1. Debugging Integration Issues (CORS)
**Challenge:** During initial testing, the browser blocked the fetch request with the error: `Access to fetch at '...' has been blocked by CORS policy`.
**Copilot Solution:** I provided the error log to Microsoft Copilot. It identified that the backend was missing the CORS middleware and generated the specific C# code for `Program.cs` to allow requests from my development origin (`http://127.0.0.1:5500`).

### 2. Optimizing Performance
**Challenge:** The initial JavaScript code for rendering the UI was blocking and slow.
**Copilot Solution:** I asked Copilot to review the `apiService.js` file. It suggested using `async/await` patterns to handle promises more cleanly and recommended segregating the UI rendering logic from the data fetching logic. This reduced the "Time to Interactive" (TTI) for the user.

---

## 🛠️ How to Run the Project

### Prerequisites
* .NET 8.0 SDK
* Visual Studio Code (with Live Server extension recommended)

### Step 1: Start the Backend
1.  Navigate to the `Backend` folder:
    ```bash
    cd Backend
    ```
2.  Run the application:
    ```bash
    dotnet run
    ```
3.  The API will start (usually on `http://localhost:5000` or `https://localhost:5001`).

### Step 2: Start the Frontend
1.  Open the `Frontend` folder in Visual Studio Code.
2.  Open `index.html`.
3.  Click "Go Live" (Live Server) or open the file in your browser.
4.  Click the **"Load Products"** button to trigger the API integration.

---
