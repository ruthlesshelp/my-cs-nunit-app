# My C# NUnit Application

[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![C#](https://img.shields.io/badge/C%23-latest-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![NUnit](https://img.shields.io/badge/NUnit-4.2.2-green.svg)](https://nunit.org/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

## Project

A modern C# .NET 9.0 starter project demonstrating best practices for library development with comprehensive testing, static code analysis, and build automation. This project serves as a foundation for building maintainable C# applications with quality-focused development workflows.

## Installation

### Prerequisites
- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Make](https://www.gnu.org/software/make/) (for build automation)

### Platform-specific Setup

**Windows:**
```powershell
choco install make
```

**macOS:**
```bash
brew install make  # (usually pre-installed)
```

**Linux:**
```bash
sudo apt-get install build-essential
```

### Getting Started
```bash
git clone git@github.com:ruthlesshelp/my-cs-nunit-app.git
cd my-cs-nunit-app
make restore
make build
```

## Usage

### Basic Commands
```bash
make build        # Build the solution
make test         # Run all tests
make coverage     # Run tests with coverage report
make clean        # Clean build artifacts
```

### Development Workflow
```bash
make test-watch   # Run tests in watch mode during development
make format       # Auto-format code
make lint         # Run static code analysis
make ci           # Run full CI pipeline
```
## Coding Style

This project enforces consistent coding standards through automated tools:

- **StyleCop Analyzers**: Enforces C# coding conventions
- **EditorConfig**: Defines consistent formatting rules
- **XML Documentation**: Required for all public APIs
- **Nullable Reference Types**: Enabled for null safety

### Code Quality Tools
- Static analysis with Microsoft.CodeAnalysis.NetAnalyzers
- Real-time formatting in IDEs
- Automated formatting via `make format`
- Comprehensive linting with `make lint`

## Tests

Tests are written using NUnit 4.2.2 framework with the following conventions:

### Running Tests
```bash
make test              # Run all tests
make test-watch        # Run tests in watch mode
make coverage          # Run tests with coverage report
```

### Test Structure
```csharp
[Test]
public void TestMethodName_Scenario_ActualIsEqualToExpected()
{
    // Arrange
    var classUnderTest = new ClassUnderTest();
    var input = 42;
    var expected = 42;
    
    // Act
    var actual = classUnderTest.Method(input);
    
    // Assert
    Assert.That(actual, Is.EqualTo(expected));
}
```

### Test Requirements
- All new functionality must include unit tests
- Follow AAA pattern (Arrange, Act, Assert)
- Use descriptive test method names
- Maintain high code coverage

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## � Additional Documentation

For comprehensive technical information, build commands, and development guidelines, see [docs/DEVELOPER_GUIDELINES.md](docs/DEVELOPER_GUIDELINES.md).
