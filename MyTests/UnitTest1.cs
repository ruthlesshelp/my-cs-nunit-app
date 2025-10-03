// <copyright file="UnitTest1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

// <summary>
// This file contains unit tests for the MyApp project using NUnit framework.
// </summary>

// <author>Your Name</author>
// <created>October 3, 2025</created>
namespace MyTests;

using MyApp;

/// <summary>
/// Contains unit tests for the MyApp project functionality.
/// </summary>
internal sealed class UnitTest1
{
    /// <summary>
    /// Sets up test environment before each test execution.
    /// Currently no specific setup is required for these tests.
    /// </summary>
    [SetUp]
    public void Setup()
    {
    }

    /// <summary>
    /// Tests that Function2 returns the value that was previously set by Function1.
    /// </summary>
    /// <remarks>
    /// This test verifies the basic input/output functionality of Class1:
    /// 1. A value is stored using Function1
    /// 2. The same value is retrieved using Function2
    /// This specific test case uses zero as the input value.
    /// </remarks>
    [Test]
    public void Function2_WithInputZero_ReturnsZero()
    {
        // Arrange
        var class1 = new Class1();
        class1.Function1(0);
        int expected = 0;

        // Act
        int actual = class1.Function2();

        // Assert
        Assert.That(actual, Is.EqualTo(expected));
    }
}
