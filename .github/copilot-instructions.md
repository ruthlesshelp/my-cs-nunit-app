# Copilot Instructions for C# NUnit Project

## Project Architecture

This is a .NET 9.0 library project (`MyApp`) with comprehensive NUnit testing (`MyTests`). The solution follows a simple two-project structure with extensive code quality tooling.

**Key Projects:**
- `MyApp/` - Main library with XML-documented public APIs
- `MyTests/` - NUnit 4.2.2 test project with project reference to MyApp
- Solution file: `MySolution.sln`

## Essential Developer Workflows

### Build & Test Commands (Use Make, not dotnet directly)
```bash
make build        # Primary build command
make test         # Run all NUnit tests
make test-watch   # Development mode with file watching
make coverage     # Generate coverage reports with coverlet
make ci           # Full CI pipeline (format-check, lint, test, coverage)
```

### Code Quality Workflow
```bash
make format       # Auto-format code (dotnet format)
make lint         # Static analysis via build
make analyze      # Comprehensive analysis + format verification
make fix          # Auto-fix formatting then validate build
```

## Project-Specific Code Patterns

### File Headers & Documentation
All C# files require structured headers and XML documentation:
```csharp
// <copyright file="ClassName.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

// <summary>Brief file description</summary>
// <author>Your Name</author>
// <created>Date</created>

namespace MyApp; // File-scoped namespaces

/// <summary>XML doc required for all public members</summary>
public class ExampleClass
{
    /// <summary>XML doc required for public methods</summary>
    /// <param name="input">Parameter description required</param>
    /// <returns>Return value description required</returns>
    public int ExampleMethod(int input) { }
}
```

### NUnit Test Conventions
Tests follow strict naming and structure patterns in `MyTests/`:
```csharp
[Test]
public void TestMethodName_Scenario_ExpectedResult()
{
    // Arrange
    var classUnderTest = new Class1();
    
    // Act  
    var actual = classUnderTest.Method();
    
    // Assert
    Assert.That(actual, Is.EqualTo(expected));
}
```

## Code Quality Configuration

### Analyzer Stack
- **StyleCop.Analyzers** (1.2.0-beta.556) - Enforces file headers, documentation, formatting
- **Microsoft.CodeAnalysis.NetAnalyzers** (9.0.0) - Latest .NET analysis rules
- **NUnit.Analyzers** (4.4.0) - NUnit-specific patterns
- **Analysis Mode**: "All" with latest rules enabled

### Key Settings
- `Nullable=enable` - Null reference types required
- `ImplicitUsings=enable` - Global usings for common namespaces  
- `GenerateDocumentationFile=true` - XML docs generated for both projects
- `TreatWarningsAsErrors=false` - Warnings allowed but analyzed

### Configuration Files
- `CodeAnalysis.ruleset` - Custom static analysis rules
- `stylecop.json` - StyleCop behavior (company name, copyright, documentation requirements)
- `global.json` - .NET SDK 9.0.305 with latestMinor rollForward

## Testing Approach

### Coverage & Quality
- **Framework**: NUnit 4.2.2 with `Microsoft.NET.Test.Sdk` 17.12.0
- **Coverage**: Coverlet collector for cross-platform coverage
- **Global Usings**: `NUnit.Framework` automatically available in test files
- **Test Discovery**: Tests auto-discovered by adapter

### Test Project Structure
- Project reference to `MyApp` (not package reference)
- Same analyzer configuration as main project for consistency
- Separate namespace (`MyTests`) from main project (`MyApp`)

## When Adding New Features

1. **Add to MyApp**: Create class with full XML documentation
2. **Add to MyTests**: Create corresponding test class with comprehensive scenarios
3. **Validate**: Run `make ci` to ensure all quality gates pass
4. **Coverage**: Use `make coverage` to verify test completeness

## Critical Quality Gates

- All public APIs must have XML documentation
- Code must pass StyleCop analysis (file headers, naming, documentation)
- Tests must follow Arrange-Act-Assert pattern with descriptive names
- Use `make format` before committing to ensure consistent formatting
- Run `make analyze` for comprehensive quality validation

This project prioritizes code quality and maintainability through automated tooling and strict conventions.