# NLayer_App: A .NET Web Application with Layered Architecture

This repository showcases my skills in developing a robust and scalable .NET web application using the MVC design pattern and a layered architecture.  The project demonstrates consumption of a .NET Web API, highlighting my understanding of API integration and best practices.  It serves as a practical example of my ability to build enterprise-grade applications using .NET technologies.

## Table of Contents

* [Project Overview](#project-overview)
* [Technical Stack](#technical-stack)
* [Architecture](#architecture)
* [Key Features](#key-features)
* [Database Design](#database-design)
* [Validation](#validation)
* [Mapping](#mapping)
* [Future Enhancements](#future-enhancements)

## Project Overview

The NLayer_App project is a learning exercise designed to deepen my understanding of building .NET web applications with a well-defined layered architecture.  It focuses on separating concerns and promoting maintainability, scalability, and testability.  The application provides CRUD operations for products and categories, demonstrating core web development functionalities.  A key aspect of the project is the integration with a separate .NET Web API, showcasing my ability to work with APIs and understand client-server communication.

## Technical Stack

* **.NET Framework/Core:**  .NET 6 and .NET Framework 6.0.3 versions used.
* **ASP.NET MVC:**  Implementation of the Model-View-Controller design pattern.
* **ASP.NET Web API:**  Building and consuming RESTful APIs.
* **Entity Framework Core:**  Object-Relational Mapping (ORM) for database interactions.
* **MSSQL Server:**  Relational database management system.
* **AutoMapper:**  Object-to-object mapping.
* **Fluent Validation:**  Validation library for data integrity.

## Architecture

The project adheres to a layered architecture, promoting separation of concerns and modularity:

* **Core:** Contains the domain models and interfaces.
* **Repository:** Provides data access logic and abstracts database interactions.
* **Service:** Implements the business logic of the application.
* **API:**  Exposes the application's functionality through RESTful endpoints.
* **MVC:** Handles user interface and interacts with the API.

This layered approach demonstrates my understanding of architectural best practices and my ability to build maintainable and scalable applications.

## Key Features

* **CRUD Operations:**  Full Create, Read, Update, and Delete functionality for products and categories.
* **Web API Integration:**  Consuming a separate .NET Web API.
* **Relational Database:**  Utilizing MSSQL Server with Entity Framework Core.
* **Code-First Approach:**  Defining the database schema through code.
* **Data Validation:**  Implementing robust validation using Fluent Validation.
* **Object Mapping:**  Using AutoMapper for efficient object transformations.
* **Layered Architecture:**  Promoting separation of concerns and maintainability.
* **Relationship Management:** Handling one-to-many, many-to-many, and one-to-one relationships between entities.

## Database Design

The database schema includes tables for Products and Categories, with appropriate relationships to represent their associations. The project demonstrates my understanding of database design principles and my ability to model complex relationships.

## Validation

Fluent Validation is used to ensure data integrity and enforce business rules.  This demonstrates my commitment to building robust and reliable applications.

## Mapping

AutoMapper simplifies the process of mapping between different object types, improving code readability and maintainability.

## Future Enhancements

* **Unit Testing:** Implementing comprehensive unit tests for all layers.
* **Authentication and Authorization:**  Adding security features to protect the API.
* **Error Handling:** Implementing global exception handling and logging.
* **Improved Caching Strategies:** Exploring more advanced caching techniques.
* **Deployment:**  Automating the deployment process.
* **Caching:** Implementing Memory Caching