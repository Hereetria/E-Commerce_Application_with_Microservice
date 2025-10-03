# 🛍️ MultiShop E-Commerce Microservices — Modern E-Commerce Application

<br>

[![Report Bug](https://img.shields.io/badge/🐛_Report_Bug-red?style=for-the-badge)](../../issues/new?labels=bug)
[![Request Feature](https://img.shields.io/badge/✨_Request_Feature-blue?style=for-the-badge)](../../issues/new?labels=enhancement)

<br>

## 📌 Project Overview

MultiShop is a **full-featured e-commerce platform** built with a modern **microservices architecture**.  
It supports **guest users**, **authenticated users**, and **admins**, each with dedicated authorization flows.  
Users can browse products, filter by category, view details, add items to their cart, and manage their shopping experience through a dynamic interface.  
The project was developed by following **Murat Yücedağ’s 56-hour Udemy microservices course**, with a focus on **clean code** and **SOLID principles**.  
In several parts of the project, **the original architecture was modified and improved** to enhance structure and maintainability.  
All databases are containerized using Docker, and content can be managed entirely through the admin panel without direct code changes.

<br>

## ✨ Features

- 🧭 **Guest, User, and Admin roles** with separate authorization mechanisms  
- 🛒 Product browsing, category filtering, detailed product pages, and cart operations  
- 🧱 **Fully dynamic pages** managed from the admin panel without code edits  
- 🧹 Clean architecture applying **SOLID principles** throughout  
- 🐳 **Dockerized databases** and service orchestration  
- 📡 **Microservices communication** through API Gateway and Ocelot  
- 🔐 **Authentication and Authorization** with Identity Server and JWT  
- 🧠 **Onion Architecture**, **CQRS**, **Mediator**, and **Repository** patterns  
- ⚡ **Dapper** for efficient data access and **AutoMapper** for object mapping  
- 📜 **Swagger** for API documentation and testing  

<br>

## 🖼️ Screenshots
Shown below in order:  
**1. Landing** · **2. Categories & Products** · **3. Shop**<br>
**4. Payment** · **5. Dashboard** 

<p align="center">
  <img src="./docs/screenshots/landing.png" width="32%">
  <img src="./docs/screenshots/categories-and-products.png" width="32%">
  <img src="./docs/screenshots/shop.png" width="32%">
</p>

<p align="center">
  <img src="./docs/screenshots/payment.png" width="32%">
  <img src="./docs/screenshots/dashboard.png" width="32%">
  <img src="https://upload.wikimedia.org/wikipedia/commons/c/ce/Transparent.gif" width="32%">
</p>

<br>

## 🧰 Tech Stack

<p>
  <img src="https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/ASP.NET_Core_API-512BD4?style=for-the-badge&logo=dotnet&logoColor=white" />
  <img src="https://img.shields.io/badge/Docker-2496ED?style=for-the-badge&logo=docker&logoColor=white" />
  <img src="https://img.shields.io/badge/Redis-DC382D?style=for-the-badge&logo=redis&logoColor=white" />
  <img src="https://img.shields.io/badge/MongoDB-47A248?style=for-the-badge&logo=mongodb&logoColor=white" />
  <br>
  <img src="https://img.shields.io/badge/PostgreSQL-4169E1?style=for-the-badge&logo=postgresql&logoColor=white" />
  <img src="https://img.shields.io/badge/MSSQL-CC2927?style=for-the-badge&logo=microsoft-sql-server&logoColor=white" />
  <img src="https://img.shields.io/badge/Ocelot_Gateway-000000?style=for-the-badge&logo=shield&logoColor=white" />
  <img src="https://img.shields.io/badge/Identity_Server-2C3E50?style=for-the-badge&logo=openid&logoColor=white" />
</p>

<br>

## 📥 Installation

### Prerequisites
- Docker & Docker Compose  
- .NET 6+ SDK  
- PostgreSQL, MSSQL, MongoDB images available locally or pulled via Docker

### Setup
```bash
git clone [repository-url]
cd multishop-ecommerce-microservices

# Build and run all services using Docker
docker-compose up -d --build

```

<br>

## 📜 License

[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](LICENSE)

This project is licensed under the terms described in the [LICENSE](./LICENSE) file.

---

© 2025 Yusuf Okan Sirkeci — [Hereetria](https://github.com/Hereetria)
