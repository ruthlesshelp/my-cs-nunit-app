# Makefile for C# NUnit project

# Default target
.PHONY: help
help:
	@echo "Available commands:"
	@echo "  make build        - Build the solution"
	@echo "  make test         - Run all tests"
	@echo "  make test-watch   - Run tests in watch mode"
	@echo "  make clean        - Clean build artifacts"
	@echo "  make restore      - Restore NuGet packages"
	@echo "  make rebuild      - Clean and build"
	@echo "  make coverage     - Run tests with coverage report"
	@echo "  make lint         - Run static code analysis"
	@echo "  make format       - Format code according to .editorconfig"
	@echo "  make format-check - Check if code is properly formatted"
	@echo "  make analyze      - Run comprehensive code analysis"
	@echo "  make fix          - Auto-fix formatting and some code issues"

# Build the solution
.PHONY: build
build:
	dotnet build MySolution.sln

# Run tests
.PHONY: test
test:
	dotnet test MySolution.sln --verbosity normal

# Run tests in watch mode
.PHONY: test-watch
test-watch:
	dotnet test MySolution.sln --watch

# Clean build artifacts
.PHONY: clean
clean:
	dotnet clean MySolution.sln

# Restore NuGet packages
.PHONY: restore
restore:
	dotnet restore MySolution.sln

# Clean and build
.PHONY: rebuild
rebuild: clean build

# Run tests with coverage
.PHONY: coverage
coverage:
	dotnet test MySolution.sln --collect:"XPlat Code Coverage" --verbosity normal

# Run static code analysis (lint)
.PHONY: lint
lint:
	@echo "Running static code analysis..."
	dotnet build MySolution.sln --verbosity normal --configuration Debug
	@echo "Code analysis complete. Check build output for warnings and errors."

# Format code according to .editorconfig
.PHONY: format
format:
	dotnet format MySolution.sln --verbosity diagnostic

# Check if code is properly formatted
.PHONY: format-check
format-check:
	dotnet format MySolution.sln --verify-no-changes --verbosity diagnostic

# Run comprehensive code analysis with detailed reporting
.PHONY: analyze
analyze:
	@echo "Running comprehensive code analysis..."
	dotnet build MySolution.sln --configuration Debug --verbosity detailed
	@echo "Running format verification..."
	dotnet format MySolution.sln --verify-no-changes --verbosity diagnostic || echo "Format issues found. Run 'make format' to fix."
	@echo "Analysis complete."

# Auto-fix formatting and some code issues
.PHONY: fix
fix:
	@echo "Auto-fixing code formatting and style issues..."
	dotnet format MySolution.sln --verbosity diagnostic
	@echo "Running build to validate fixes..."
	dotnet build MySolution.sln --verbosity normal
	@echo "Fixes applied successfully."

# List all test projects
.PHONY: list-tests
list-tests:
	dotnet test MySolution.sln --list-tests

# Run specific test project
.PHONY: test-myapp
test-myapp:
	dotnet test MyTests/MyTests.csproj --verbosity normal

# Install dotnet format tool globally (run once)
.PHONY: install-tools
install-tools:
	@echo "Installing .NET tools..."
	dotnet tool install -g dotnet-format || echo "dotnet-format already installed or installation failed"
	@echo "Tools installation complete."

# Security analysis
.PHONY: security
security:
	@echo "Running security analysis..."
	dotnet list MySolution.sln package --vulnerable --include-transitive
	@echo "Security analysis complete."

# Generate code metrics report
.PHONY: metrics
metrics:
	@echo "Generating code metrics..."
	dotnet build MySolution.sln --configuration Release --verbosity quiet
	@echo "Code metrics available in build output."

# Full CI pipeline
.PHONY: ci
ci: restore format-check lint test coverage
	@echo "CI pipeline completed successfully."