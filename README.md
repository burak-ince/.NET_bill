# Mobile Provider API

## Introduction

Welcome to the Mobile Provider API project! This API serves as a backend system for managing mobile bills and payments for a fictional mobile provider. It provides endpoints for adding bills, querying unpaid bills, querying bill details, and paying bills.

## Source Code

The source code for this project is hosted on [GitHub](https://github.com/burak-ince/.NET_bill).

## Design Overview

This project is structured using the ASP.NET Core framework, which provides robust tools for building RESTful APIs. It utilizes Entity Framework Core for data access and management. The API is divided into several controllers, each responsible for a specific set of operations:

- **AdminController:** Handles administrative operations such as adding bills.
- **BankingAppQueryBillController:** Provides endpoints for querying unpaid bills, accessible through a banking application.
- **MobileBillController:** Manages mobile bill inquiries and provides detailed bill information.
- **PayBillController:** Handles bill payment operations.

## Assumptions

During the development process, the following assumptions were made:
- Each subscriber has a unique subscriber number.
- Bill amounts are fixed for simplicity, but can be customized.
- Payment status is represented as a boolean (true for paid, false for unpaid).

## Issues Encountered

During development, we encountered the following issues:
- Challenges in configuring Entity Framework Core to work with multiple databases.
- Authentication and authorization mechanisms need further enhancement for production use.

## Video Presentation

A short video presenting the project can be viewed [here](https://drive.google.com/file/d/1isaqrgnRxrWbBwPlMEpvRYoXIoNNWHoG/view?usp=sharing).
