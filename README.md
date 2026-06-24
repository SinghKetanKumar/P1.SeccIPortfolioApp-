# P1 SECCl Portfolio Application

## Overview

This project is a Blazor WebAssembly application integrated with the SECCl Staging API.

The application allows users to:

* Authenticate with the SECCl API
* Retrieve a list of portfolios
* View portfolio details
* Navigate between portfolio list and detail pages
* Handle loading states and API errors

---

## Technologies Used

* ASP.NET Core
* Blazor WebAssembly
* C#
* REST API
* HttpClient
* Dependency Injection
* SECCl Staging API

---

## Features Implemented

### Authentication

Implemented SECCl authentication using the username/password authentication endpoint.

A bearer token is generated and used for subsequent API requests.

Credentials are stored in configuration and are not hardcoded in the source code.

---

### Portfolio List Page

Implemented a portfolio listing page that:

* Retrieves portfolio data from SECCl
* Displays portfolio identifier
* Displays client name
* Displays portfolio status
* Allows users to select a portfolio
* Navigates to the portfolio detail page

API Used:

```text
GET /portfolio/{firmId}
```

---

### Portfolio Detail Page

Implemented a portfolio detail page that:

* Displays selected portfolio information
* Displays portfolio identifier
* Displays client name
* Displays portfolio status
* Displays currency
* Displays account count
* Displays current valuation
* Displays growth information
* Supports navigation back to the portfolio list

API Used:

```text
GET /api/portfolio/{id}
```

---

### Error Handling

Implemented error handling using try/catch blocks in:

* Portfolio List page
* Portfolio Detail page
* API Controller

Application displays user-friendly error messages when API calls fail.

---

### Loading States

Implemented loading indicators while data is being retrieved from the API.

Example:

```text
Loading...
```

---

## Project Structure

### Client

Contains:

* PortfolioList.razor
* PortfolioDetail.razor
* Models
* UI Components

### Server

Contains:

* PortfolioController
* PortfolioService
* Authentication logic
* SECCl API integration
* Configuration

### Shared

Contains shared models and contracts.

---

## Configuration

Update appsettings.json with valid SECCl credentials before running the application.

Example:

```json
{
  "SecclSettings": {
    "BaseUrl": "https://pfolio-api-staging.seccl.tech",
    "FirmId": "<YOUR_FIRM_ID>",
    "Id": "<YOUR_USER_ID>",
    "Password": "<YOUR_PASSWORD>"
  }
}
```

Actual credentials should not be committed to source control.

## SECCL Configuration

Update appsettings.json with the SECCL staging credentials provided in the technical test:

{
  "SecclApi": {
    "BaseUrl": "https://pfolio-api-staging.seccl.tech",
    "FirmId": "<YOUR_FIRM_ID>",
    "Id": "<YOUR_USER_ID>",
    "Password": "<YOUR_PASSWORD>"
  }
}

Credentials are intentionally excluded from source control in accordance with the test requirements.

---

## Running the Application

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Configure SECCl credentials.
4. Build the solution.
5. Run the Server project.
6. Open the application in a browser.

---

## Assumptions

* SECCl staging environment is available.
* Portfolio information is retrieved from the SECCl API.
* Portfolio details are displayed using available portfolio data.

---

## Future Improvements

Given additional time, the following improvements could be implemented:

* Token caching and refresh handling
* Holdings summary integration
* Dedicated balances and valuations endpoints
* Unit tests
* Integration tests
* Improved UI styling and responsiveness
* Logging using Serilog

---

## Time Spent

Approximately 8–10 hours.

---

## Git History

Git was used throughout development with incremental commits to demonstrate development progress and source control practices.
