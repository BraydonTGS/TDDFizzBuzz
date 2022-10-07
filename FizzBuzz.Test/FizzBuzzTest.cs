namespace FizzBuzz.Test;

public class FizzBuzzTest
{
    [Theory]
    [InlineData(3, "fizz")]
    [InlineData(5, "buzz")]
    [InlineData(15, "fizzbuzz")]
    [InlineData(8, "Number is not divistible by 3 or by 5")]

    public void FizzBuzz_FizzBuzzSolution_ReturnString(int num1, string expected)
    {
        // Arrange //
        var fizz = new FizzBuzzer();
        // Act //
        var actual = fizz.FizzBuzzSolution(num1);
        // Assert //
        Assert.Equal(expected, actual);
    }
}
