# AGENTS.md - AI Agent Information

This file provides structured information for AI agents working with this C# NUnit project.

## Project Overview

**Project Type**: C# .NET 9.0 Library with NUnit Testing
**Language**: C# (latest)
**Framework**: .NET 9.0
**Testing Framework**: NUnit 4.2.2
**Build System**: Makefile + MSBuild
**Repository**: my-cs-nunit-app (Owner: ruthlesshelp)

## Architecture & Structure

### Solution Structure
```
MySolution.sln              # Visual Studio solution file
├── MyApp/                  # Main application library
│   ├── Class1.cs          # Example class with documented methods
│   └── MyApp.csproj       # Library project file
└── MyTests/               # Unit test project
    ├── UnitTest1.cs       # Example NUnit tests
    └── MyTests.csproj     # Test project file
```

### Key Configuration Files
- `global.json` - .NET SDK version specification
- `CodeAnalysis.ruleset` - Static analysis rules configuration
- `stylecop.json` - StyleCop code style configuration
- `Makefile` - Build automation and development workflows
- `LICENSE` - MIT license

## Development Environment

### Prerequisites
- .NET 9.0 SDK or later
- Make (for build automation)
- Compatible IDE (Visual Studio, VS Code, JetBrains Rider)

### Package Dependencies

**MyApp Project:**
- Microsoft.CodeAnalysis.Analyzers (3.3.4)
- Microsoft.CodeAnalysis.NetAnalyzers (9.0.0)
- StyleCop.Analyzers (1.2.0-beta.556)

**MyTests Project:**
- Microsoft.NET.Test.Sdk (17.12.0)
- NUnit (4.2.2)
- NUnit.Analyzers (4.4.0)
- NUnit3TestAdapter (4.6.0)
- coverlet.collector (6.0.2) - for code coverage

## Build & Development Commands

### Essential Make Commands
```bash
make help         # Show all available commands
make build        # Build the solution
make test         # Run all tests
make test-watch   # Run tests in watch mode
make clean        # Clean build artifacts
make restore      # Restore NuGet packages
make rebuild      # Clean and build
make coverage     # Run tests with coverage report
make lint         # Run static code analysis
make format       # Format code according to .editorconfig
make format-check # Check if code is properly formatted
make analyze      # Run comprehensive code analysis
make fix          # Auto-fix formatting and some code issues
```

### Direct .NET CLI Commands
```bash
dotnet build                    # Build solution
dotnet test                     # Run tests
dotnet test --collect:"XPlat Code Coverage"  # Run with coverage
dotnet clean                    # Clean artifacts
dotnet restore                  # Restore packages
```

## Code Quality & Standards

### Static Analysis
- **Enabled Analyzers**: Microsoft.CodeAnalysis.NetAnalyzers, StyleCop.Analyzers
- **Analysis Level**: Latest with "All" mode
- **Code Analysis Ruleset**: Custom rules in `CodeAnalysis.ruleset`
- **Documentation**: XML documentation generation enabled

### Code Style
- **StyleCop Integration**: Enforces consistent C# coding standards
- **Nullable Reference Types**: Enabled
- **Implicit Usings**: Enabled
- **Language Version**: Latest C#

### Testing Standards
- **Framework**: NUnit 4.2.2 with analyzers
- **Coverage**: Coverlet for cross-platform code coverage
- **Naming**: Tests follow NUnit conventions
- **Documentation**: XML documentation required for test classes

## Project Features & Capabilities

### Current Implementation
- **Class1**: Simple class with input/output functionality
  - `Function1(int input)`: Sets an integer value
  - `Function2()`: Returns the stored integer value
- **UnitTest1**: Comprehensive test coverage for Class1 functionality

### Supported Development Workflows
- Continuous Integration ready
- Code coverage reporting
- Static code analysis
- Automated formatting
- Documentation generation
- Security analysis for dependencies

## AI Agent Guidelines

### When Adding New Features
1. Follow existing namespace conventions (`MyApp` for library, `MyTests` for tests)
2. Add corresponding unit tests in `MyTests` project
3. Include XML documentation for all public members
4. Run `make lint` to verify code quality
5. Use `make test` to ensure all tests pass
6. Consider running `make coverage` for coverage reports

### When Modifying Code
1. Preserve existing XML documentation standards
2. Maintain StyleCop compliance
3. Update corresponding tests
4. Run `make analyze` for comprehensive checks
5. Use `make format` before committing changes

### Project File Modifications
- **MyApp.csproj**: Library configuration with analyzers
- **MyTests.csproj**: Test project with NUnit and coverage tools
- **Analyzer Packages**: Keep versions aligned between projects

### Best Practices for AI Agents
1. **Test-Driven Development**: Always add/update tests when modifying functionality
2. **Documentation**: Maintain XML documentation for all public APIs
3. **Code Quality**: Respect existing analyzer and StyleCop rules
4. **Build Verification**: Use `make build` and `make test` to verify changes
5. **Coverage**: Aim for high test coverage using `make coverage`

### Comprehensive Testing Guidelines

#### Coverage Analysis and Test Quality
Line coverage alone is insufficient for determining test quality. Use `make coverage` to generate coverage reports, but supplement with comprehensive test scenario analysis:

```bash
make coverage  # Generate coverage report
# Review coverage.cobertura.xml for detailed line-by-line analysis
```

#### Essential Test Categories

**1. Different Input Values**
- **Positive Values**: Test with various positive integers (1, 42, 1000)
- **Negative Values**: Test with various negative integers (-1, -42, -1000)
- **Zero**: Test with zero value
- **Boundary Values**: Test with `int.MaxValue` and `int.MinValue`

**2. Edge Cases and Default States**
- **Default State**: Test behavior before any initialization
- **Multiple Operations**: Test multiple calls to the same method
- **Sequence Testing**: Test different operation sequences
- **Boundary Conditions**: Test at the limits of data types

**3. Behavioral Testing**
- **State Persistence**: Verify state remains consistent across method calls
- **State Transitions**: Test how state changes with different inputs
- **Overwrite Behavior**: Test how new values replace previous ones
- **Immutability**: Verify returned values don't affect internal state

#### Test Scenario Framework

For each public method, ensure tests cover:

```csharp
// Example comprehensive test structure for Class1
[TestFixture]
public class Class1Tests
{
    [TestCase(0, 0)]
    [TestCase(1, 1)]
    [TestCase(-1, -1)]
    [TestCase(int.MaxValue, int.MaxValue)]
    [TestCase(int.MinValue, int.MinValue)]
    public void TestFunction1_WithVariousInputs_StoresAndReturnsCorrectValue(int input, int expected)
    {
        // Arrange
        var classUnderTest = new Class1();
        classUnderTest.Function1(input);

        // Act
        var actual = classUnderTest.Function2();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }

    [Test]
    public void TestFunction2_WithoutPriorFunction1Call_ReturnsDefaultValue()
    {
        // Arrange
        var classUnderTest = new Class1();

        // Act
        var actual = classUnderTest.Function2();

        // Assert
        Assert.That(actual, Is.EqualTo(0));
    }

    [Test]
    public void TestFunction1_MultipleCalls_OverwritesPreviousValue()
    {
        // Arrange
        var classUnderTest = new Class1();
        classUnderTest.Function1(42);
        classUnderTest.Function1(24);

        // Act
        actual = classUnderTest.Function2();

        // Assert
        Assert.That(, Is.EqualTo(24));
    }
}
```

#### Quality Metrics
- **Line Coverage**: Aim for 100% but verify meaningfulness
- **Branch Coverage**: Test all conditional paths
- **Method Coverage**: Exercise all public methods
- **Scenario Coverage**: Test all realistic use cases

#### Testing Checklist
- [ ] All positive, negative, and zero input values tested
- [ ] Boundary values (min/max) tested
- [ ] Default/uninitialized state tested
- [ ] Multiple method calls tested
- [ ] State persistence verified
- [ ] Edge cases identified and tested
- [ ] Error conditions handled appropriately

### Common File Patterns
- **C# Classes**: Follow `MyApp` namespace, include file headers
- **Unit Tests**: Follow `MyTests` namespace, use NUnit attributes
- **Project References**: MyTests references MyApp project
- **Build Outputs**: Located in `bin/` and `obj/` directories (ignored in git)

## Troubleshooting

### Build Issues
- Run `make clean` followed by `make restore` and `make build`
- Check .NET SDK version matches `global.json` specification
- Verify all package references are properly restored

### Test Issues
- Use `make test` for standard test execution
- Use `make test-watch` for interactive development
- Check test project references MyApp correctly

### Code Quality Issues
- Run `make lint` to identify static analysis problems
- Use `make format` to auto-fix formatting issues
- Review `CodeAnalysis.ruleset` for custom rule configurations

## Extensions & Customization

### Adding New Projects
1. Create project directory under solution root
2. Add project reference to `MySolution.sln`
3. Update `Makefile` targets if needed
4. Maintain consistent analyzer package references

### Modifying Analysis Rules
- Edit `CodeAnalysis.ruleset` for custom static analysis rules
- Modify `stylecop.json` for code style preferences
- Update analyzer package versions consistently across projects

This project is designed for maintainability, testability, and code quality, making it suitable for AI-assisted development workflows.