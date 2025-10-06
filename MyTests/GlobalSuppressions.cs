// <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1600:Elements should be documented", Justification = "Test code does not require XML documentation", Scope = "namespaceanddescendants", Target = "~N:MyTests")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "Test files do not require file headers", Scope = "namespaceanddescendants", Target = "~N:MyTests")]
[assembly: SuppressMessage("Performance", "CA1812:Avoid uninstantiated internal classes", Justification = "Test classes are instantiated by the NUnit framework", Scope = "type", Target = "~T:MyTests.UnitTest1")]
