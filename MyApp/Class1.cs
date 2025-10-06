// <copyright file="Class1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace MyApp;

// <summary>
// This file contains the Class1 implementation for the MyApp project.
// </summary>

// <author>Your Name</author>
// <created>October 3, 2025</created>
using System.Collections.ObjectModel;

/// <summary>
/// Represents a simple class with input validation and list generation functionality.
/// This class stores an integer value and provides methods to set it and generate a predefined list when the value is zero.
/// </summary>
public class Class1
{
    /// <summary>
    /// The stored input value that can be set via Function1 and retrieved via Function2.
    /// </summary>
    private int input;

    /// <summary>
    /// Sets the internal input value that can later be retrieved.
    /// </summary>
    /// <param name="input">The integer value to store internally.</param>
    public void Function1(int input)
    {
        this.input = input;
    }

    /// <summary>
    /// Returns a list of integers based on the stored input value.
    /// </summary>
    /// <returns>A ReadOnlyCollection of integers { 1, 0, 5, 0, 10, 0, 25, 0 } when input is zero.</returns>
    /// <exception cref="InvalidOperationException">Thrown when the stored input value is not valid.</exception>
    public ReadOnlyCollection<int> Function2()
    {
        List<int> result;

        if (this.input == 0)
        {
            result = [1, 0, 5, 0, 10, 0, 25, 0];
        }
        else
        {
            throw new InvalidOperationException("Input value is not valid.");
        }

        return new ReadOnlyCollection<int>(result);
    }
}
