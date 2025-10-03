// <copyright file="Class1.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

// <summary>
// This file contains the Class1 implementation for the MyApp project.
// </summary>

// <author>Your Name</author>
// <created>October 3, 2025</created>
namespace MyApp;

/// <summary>
/// Represents a simple class with basic input/output functionality.
/// This class stores an integer value and provides methods to set and retrieve it.
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
    /// Retrieves the previously stored input value.
    /// </summary>
    /// <returns>The integer value that was last set via Function1, or 0 if never set.</returns>
    public int Function2()
    {
        return this.input;
    }
}
