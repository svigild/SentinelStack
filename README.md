# SentinelStack

SentinelStack is a cross-platform security orchestrator and real-time monitoring dashboard designed to bridge the gap between low-level system auditing and high-level data visualization. It features a distributed architecture where lightweight agents perform security scans and report findings to a centralized intelligence hub.

## Key Features

* **Multi-Language Interoperability**: Implements communication protocols between a C# Security Agent and a Java/Spring Boot API Gateway.
* **Real-time Vulnerability Detection**: Performs system-level scanning for exposed credentials, insecure configurations, and sensitive patterns.
* **Enterprise Security**: Provides secure data ingestion using JWT authentication and Spring Security frameworks.
* **Live Dashboard**: Delivers instant security alerts and incident visualization built with Angular and WebSockets.

## Tech Stack

* **Security Agent**: .NET 9 (C#)
* **API Gateway / Backend**: Spring Boot 3.4+ (Java)
* **Frontend**: Angular 19+ and Tailwind CSS
* **Database**: PostgreSQL
* **Infrastructure**: Docker and GitHub Actions

## Architecture

1. **The Sensor (C#)**: A high-performance console application that audits local files and system logs for security patterns. It acts as the primary data collector.
2. **The Hub (Java)**: A robust REST API that processes incoming alerts from multiple sensors, validates data integrity, and manages persistence.
3. **The Dashboard (Angular)**: A reactive web interface that consumes data from the Hub to provide a real-time overview of the system's security posture.

## Installation and Setup

1. Clone the repository.
2. Deploy the PostgreSQL instance using Docker Compose.
3. Configure and start the Spring Boot backend service.
4. Execute the .NET Sensor and point it to the designated API endpoint.

---
**Developed by Sergio Vigil Diaz**
Full Stack Developer specializing in C#, Java, and Cybersecurity.
