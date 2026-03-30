# Selenium E2E Tests (.NET)

End-to-End automation tests for [saucedemo.com](https://www.saucedemo.com/) using Selenium WebDriver and NUnit.

## Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download)
- [Allure CLI](https://allurereport.org/docs/install/)
- Google Chrome (v146) and Mozilla Firefox (v149) installed

## How to Run Tests

Run all tests (Chrome + Firefox in parallel):
```bash
dotnet test
```

## How to generate Allure report

Generate allure report after testing:
```bash
allure serve allure-results
```

