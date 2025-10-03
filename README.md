# My C# NUnit Application

[![.NET](https://img.shields.io/badge/.NET-9.0-blue.svg)](https://dotnet.microsoft.com/download/dotnet/9.0)
[![C#](https://img.shields.io/badge/C%23-latest-blue.svg)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![NUnit](https://img.shields.io/badge/NUnit-4.2.2-green.svg)](https://nunit.org/)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

Starter project for .NET using C# with modern development tools and best practices.

A modern C# .NET 9.0 application with comprehensive testing, static code analysis, and build automation using Make. This project demonstrates best practices for C# development with a focus on code quality, maintainability, and developer experience.

## 🚀 Features

- **Modern .NET 9.0** with latest C# language features
- **Comprehensive Testing** with NUnit framework and code coverage
- **Static Code Analysis** with multiple analyzers and quality checks
- **Build Automation** using Makefile for cross-platform development
- **XML Documentation** generation for API documentation
- **StyleCop Integration** for consistent code formatting
- **Security Analysis** for dependency vulnerability checking

## 📁 Project Structure

```
├── MyApp/                          # Main application library
│   ├── Class1.cs                   # Example class with documented methods
│   └── MyApp.csproj                # Project file with analyzers
├── MyTests/                        # Unit tests
│   ├── UnitTest1.cs                # Example unit tests
│   └── MyTests.csproj              # Test project with NUnit
├── CodeAnalysis.ruleset            # Static analysis rules
├── stylecop.json                   # StyleCop configuration
├── global.json                     # .NET SDK version specification
├── Makefile                        # Build automation commands
└── MySolution.sln                  # Visual Studio solution
```

## 🛠️ Prerequisites

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0) or later
- [Make](https://www.gnu.org/software/make/) (for build automation)
- IDE: [Visual Studio](https://visualstudio.microsoft.com/), [VS Code](https://code.visualstudio.com/), or [JetBrains Rider](https://www.jetbrains.com/rider/)

### Installation

#### Windows
```powershell
# Install via Chocolatey
choco install make

# Or via Scoop
scoop install make
```

#### macOS
```bash
# Make is typically pre-installed
# Or install via Homebrew
brew install make
```

#### Linux
```bash
# Ubuntu/Debian
sudo apt-get install build-essential

# CentOS/RHEL
sudo yum groupinstall "Development Tools"
```

## 🚀 Quick Start

### 1. Clone and Setup
```bash
git clone git@github.com:ruthlesshelp/my-cs-nunit-app.git
cd my-cs-nunit-app
make restore
```

### 2. Build and Test
```bash
# Build the solution
make build

# Run all tests
make test

# Run tests with coverage
make coverage
```

### 3. Development Workflow
```bash
# Auto-format code
make format

# Run static analysis
make lint

# Run comprehensive CI pipeline
make ci
```
## 📋 Make Commands Reference

Display all available commands:
```bash
make help
```

### Core Development
| Command | Description |
|---------|-------------|
| `make build` | Build the entire solution |
| `make test` | Run all unit tests |
| `make clean` | Clean build artifacts |
| `make restore` | Restore NuGet packages |
| `make rebuild` | Clean and build (clean + build) |

### Code Quality & Analysis
| Command | Description |
|---------|-------------|
| `make lint` | Run static code analysis |
| `make format` | Auto-format code according to rules |
| `make format-check` | Verify code formatting (no changes) |
| `make analyze` | Comprehensive analysis (build + format check) |
| `make fix` | Auto-fix formatting and addressable issues |
| `make security` | Check for vulnerable NuGet packages |

### Testing & Coverage
| Command | Description |
|---------|-------------|
| `make test-watch` | Run tests in watch mode |
| `make coverage` | Run tests with code coverage collection |
| `make list-tests` | List all available tests |
| `make test-myapp` | Run specific test project |

### CI/CD & Automation
| Command | Description |
|---------|-------------|
| `make ci` | Full CI pipeline (restore, format-check, lint, test, coverage) |
| `make install-tools` | Install required .NET global tools |
| `make metrics` | Generate code metrics report |

## 🔧 Code Quality & Static Analysis

This project implements a comprehensive code quality strategy with multiple layers of analysis and enforcement.

### 📊 Analysis Tools Stack

#### 1. **Core .NET Analyzers**
- **Microsoft.CodeAnalysis.NetAnalyzers** - Core .NET analysis rules
- **Microsoft.CodeAnalysis.Analyzers** - Roslyn analyzer diagnostics  
- **StyleCop.Analyzers** - Code style and formatting enforcement
- **NUnit.Analyzers** - NUnit-specific test analysis

#### 2. **Configuration Files**

| File | Purpose | Key Features |
|------|---------|--------------|
| `CodeAnalysis.ruleset` | Analysis rule severity | Security rules as errors, performance optimizations |
| `.editorconfig` | Code formatting | Indentation, spacing, naming conventions |
| `stylecop.json` | StyleCop settings | Documentation rules, layout preferences |
| `global.json` | .NET SDK version | Ensures consistent SDK across environments |

#### 3. **Quality Gates**

- **Build-time Analysis**: Static analysis runs automatically during build
- **IDE Integration**: Real-time analysis in VS/VS Code with quick fixes
- **CI Pipeline**: Automated quality checks prevent poor code from merging
- **Documentation**: XML documentation generation and validation

### 🎯 Code Standards Enforced

#### Security & Reliability
- SQL injection prevention
- P/Invoke safety checks
- Critical reliability issues as build errors
- Vulnerable dependency detection

#### Performance & Design
- Performance optimization suggestions
- API design guidelines
- Consistent naming conventions
- Code complexity metrics

#### Documentation & Style
- XML documentation requirements for public APIs
- Consistent code formatting
- Proper using directive organization
- File header and copyright enforcement

## 🧪 Testing Strategy

### Test Framework: NUnit 4.2.2
- **Modern Assertions**: `Assert.That()` syntax for readable tests
- **Test Organization**: Grouped by functionality with descriptive names
- **Code Coverage**: Integrated coverage collection with Coverlet
- **Continuous Testing**: Watch mode for rapid feedback during development

### Test Structure
```csharp
[Test]
public void MethodName_Scenario_ExpectedResult()
{
    // Arrange - Set up test data and dependencies
    var sut = new SystemUnderTest();
    
    // Act - Execute the method being tested
    var result = sut.Method(input);
    
    // Assert - Verify the expected outcome
    Assert.That(result, Is.EqualTo(expected));
}
```

## 🛡️ Security & Maintenance

### Dependency Management
```bash
# Check for security vulnerabilities
make security

# View all package dependencies
dotnet list package --include-transitive
```

### Code Metrics
```bash
# Generate comprehensive metrics
make metrics

# Analyze build output for complexity warnings
make analyze
```

## 🔄 Development Workflow

### Daily Development
```bash
# Start your day
make restore && make build

# During development (continuous testing)
make test-watch

# Before committing changes
make ci
```

### Code Quality Workflow
```bash
# 1. Format your code
make format

# 2. Run static analysis
make lint

# 3. Verify tests pass
make test

# 4. Check coverage
make coverage

# 5. Security check (weekly)
make security
```

### Adding New Features
1. **Create/modify classes** in `MyApp/` with proper XML documentation
2. **Write tests** in `MyTests/` following AAA pattern (Arrange, Act, Assert)
3. **Run tests** continuously with `make test-watch`
4. **Validate quality** with `make ci` before committing

## ⚙️ Configuration & Customization

### Modifying Analysis Rules

#### Adjust Rule Severity
Edit `CodeAnalysis.ruleset`:
```xml
<Rule Id="CA1034" Action="Warning" />  <!-- Change from Error to Warning -->
<Rule Id="SA1600" Action="None" />     <!-- Disable documentation requirement -->
```

#### Update Code Style
Modify `.editorconfig`:
```ini
[*.cs]
csharp_prefer_braces = true
csharp_new_line_before_open_brace = all
```

#### Configure StyleCop
Update `stylecop.json`:
```json
{
  "settings": {
    "documentationRules": {
      "documentInternalElements": false
    }
  }
}
```

### Project-Specific Overrides
In `.csproj` files:
```xml
<PropertyGroup>
  <NoWarn>$(NoWarn);CA1812</NoWarn>           <!-- Suppress specific warnings -->
  <WarningsAsErrors>CA2007;CA2012</WarningsAsErrors>  <!-- Elevate warnings to errors -->
</PropertyGroup>
```

## 🚀 Deployment & Distribution

### Build for Release
```bash
# Clean release build
dotnet build -c Release

# Create NuGet packages (if applicable)
dotnet pack -c Release
```

### Generate Documentation
```bash
# XML documentation files are generated automatically
# Located in: bin/Debug/net9.0/*.xml

# For external documentation tools
dotnet build --verbosity detailed
```

## 🤝 Contributing

### Code Standards
- All public APIs must have XML documentation
- Tests required for new functionality
- Follow existing code style and patterns
- Run `make ci` before submitting pull requests

### Pull Request Checklist
- [ ] Code builds without warnings (`make build`)
- [ ] All tests pass (`make test`)
- [ ] Code coverage maintained (`make coverage`)
- [ ] Static analysis passes (`make lint`)
- [ ] Code properly formatted (`make format`)
- [ ] Security check passes (`make security`)
- [ ] Documentation updated (if applicable)

## 📚 Additional Resources

### .NET & C# Resources
- [.NET 9.0 Documentation](https://docs.microsoft.com/en-us/dotnet/)
- [C# Language Reference](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET API Browser](https://docs.microsoft.com/en-us/dotnet/api/)

### Testing Resources
- [NUnit Documentation](https://docs.nunit.org/)
- [Unit Testing Best Practices](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-best-practices)
- [Code Coverage with Coverlet](https://github.com/coverlet-coverage/coverlet)

### Code Quality Tools
- [StyleCop Analyzers Rules](https://github.com/DotNetAnalyzers/StyleCopAnalyzers/blob/master/DOCUMENTATION.md)
- [.NET Code Analysis](https://docs.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview)
- [EditorConfig Reference](https://editorconfig.org/)

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🐛 Troubleshooting

### Common Issues

#### Build Failures
```bash
# Clear all build artifacts and rebuild
make clean && make build

# Restore packages if corrupted
rm -rf ~/.nuget/packages
make restore
```

#### Test Failures
```bash
# Run tests with detailed output
dotnet test --verbosity detailed

# Run specific test
make test-myapp
```

#### Analysis Warnings
```bash
# Check specific analyzer output
make lint --verbosity detailed

# Temporarily disable specific rules in project files
```

---

**Made with ❤️ using .NET 9.0, C#, and modern development practices**
