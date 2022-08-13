using FluentAssertions;
using Xunit;

namespace Validators.Tests;

public class SimpleValidationExtensionsTests
{
    [Theory]
    [InlineData("Alysha", true)]
    [InlineData("", false)]
    public void Validate_Multiple_Conditions_At_Once(string userName, bool expected)
    {
        //Act
        var isValid = userName.Validate(
            u => !string.IsNullOrWhiteSpace(u),
            u => u.Length > 3,
            u => !u.Contains("Bieber"));

        //Assert
        isValid.Should().Be(expected);
    }

    [Theory]
    [InlineData("Amanda", true)]
    [InlineData("", false)]
    public void Validate_One_Condition_Only(string userName, bool expected)
    {
        //Act
        var isValid = userName.Validate(
            u => !string.IsNullOrWhiteSpace(u));

        //Assert
        isValid.Should().Be(expected);
    }
}