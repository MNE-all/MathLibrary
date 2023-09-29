namespace MathLibraryTest;

public class UnitTestSquare
{
    [Fact]
    public void TestCircleSquare()
    {
        const double result = 10;
        double radius = Math.Sqrt(result / Math.PI);
        
        Assert.Equal(result, MathLibrary.Math.Square(radius));
    }
    
    
    [Fact]
    public void TestTriangleSquare()
    {
        const double result = 7.94;
        const double a = 4, b = 4, c = 6;

        Assert.Equal(result, MathLibrary.Math.Square(a, b, c));
    }
    
    [Fact]
    public void TestIsRightTriangleGreen()
    {
        const bool result = true;
        const double a = 3, b = 4, c = 5;

        Assert.Equal(result, MathLibrary.Math.isRightTriangle(a, b, c));
    }
    
    [Fact]
    public void TestIsRightTriangleRed()
    {
        const bool result = false;
        const double a = 3, b = 4, c = 6;

        Assert.Equal(result, MathLibrary.Math.isRightTriangle(a, b, c));
    }
}