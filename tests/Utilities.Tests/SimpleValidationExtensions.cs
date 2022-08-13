using System;
using FluentAssertions;
using Xunit;

namespace Utilities.Tests;

public class FunctionExtensionsTests
{
    [Theory]
    [InlineData(5, 196)]
    public void Arithmetic_Operators_On_A_Number(int number, int expected)
    {
        //Act
        var actual = number
            .Map(num => num + 2)
            .Map(num => num * 2)
            .Map(num => Math.Pow(num, 2));

        //Assert
        actual.Should().Be(expected);
    }
    
    [Theory]
    [InlineData("Hello", "Hello PS, Hope you are well.")]
    public void String_Operators_On_A_String(string input, string expected)
    {
        //Act
        var actual = input
            .Map(s => s + " ")
            .Map(s => s + "PS")
            .Map(s => s + ", ")
            .Map(s => s + "Hope you are well.");

        //Assert
        actual.Should().Be(expected);
    }
}