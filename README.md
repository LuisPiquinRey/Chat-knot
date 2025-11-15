# Chat-Knot: Real-Time Communication Platform

[![.NET](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)
[![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-SignalR-blue.svg)](https://dotnet.microsoft.com/apps/aspnet)
[![Architecture](https://img.shields.io/badge/Architecture-Modular%20Monolith-lightgrey.svg)](https://www.kamilgrzybek.com/blog/posts/modular-monolith-primer)
[![DDD](https://img.shields.io/badge/Pattern-DDD-brightgreen.svg)](https://dddcommunity.org/)
[![License](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)
[![Status](https://img.shields.io/badge/Status-Under%20Construction-orange.svg)](https://github.com)

> **⚠️ PROJECT STATUS: UNDER CONSTRUCTION**  
> This project is actively being developed and is not yet production-ready. Some components may be incomplete or subject to change.

---

## 📖 Overview

**Chat-Knot** is a **real-time communication platform** built with **ASP.NET Core** and **SignalR**, leveraging **Domain-Driven Design (DDD)** and **modular monolith architecture** principles.
It provides a scalable foundation for event-driven chat applications with well-defined bounded contexts, supporting user messaging, presence tracking, and distributed communication flows.

---

### 🧩 Key Architectural Features

- **Real-Time Messaging** via SignalR
- **Modular Monolith Architecture** with independent bounded contexts
- **Domain-Driven Design (DDD)** for modular and maintainable domain logic
- **Event-Driven Communication** using in-process events (MediatR)
- **Clean Architecture** with clear separation of concerns per module
- **Simple Deployment** as a single application (easily extractable to microservices)  

---

## ⚙️ Technology Stack

- **Backend:** ASP.NET Core 9.0, SignalR
- **Architecture:** Modular Monolith, DDD, Clean Architecture
- **Messaging:** MediatR (in-process events)
- **Data Storage:** SQL Server / MongoDB (polyglot persistence)
- **Deployment:** Single application (Docker support)

---

## 🏗️ Project Structure

```
Chat-Knot/
├── src/
│   └── Modules/                    # Bounded Contexts
│       ├── Users/                  # User Management Module
│       │   ├── User.Domain/        # Domain entities, value objects, events
│       │   ├── User.Application/   # Use cases, commands, queries (CQRS)
│       │   ├── User.Infrastructure/# Data access, EF Core configurations
│       │   └── User.Api/           # API endpoints for this module
│       ├── Chats/                  # Chat Module (planned)
│       └── Notifications/          # Notifications Module (planned)
├── ChatKnot.sln                    # Solution file
└── README.md
```

Each module follows **Clean Architecture** principles with clear separation:
- **Domain**: Pure business logic, entities, value objects
- **Application**: Use cases, CQRS handlers, domain event handlers
- **Infrastructure**: Database, external services, implementations
- **Api**: HTTP endpoints, controllers, DTOs

---

## 📦 Project Goals

- Build a **modular, scalable** chat system using clean architecture and DDD
- Explore **real-time event orchestration** with SignalR
- Serve as a **reference project** for modular monolith with clear bounded contexts
- Design for easy extraction to microservices when needed  

---

## 👤 Author

**Luis Piquin Rey**

- GitHub: [@luispiquinrey](https://github.com/luispiquinrey)  
- Email: piquin.rey@gmail.com  

---

**⚠️ Note:** This project is under active development. Some features are experimental and may evolve over time.  
Use at your own risk in non-production environments.
