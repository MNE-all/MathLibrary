

namespace MathLibrary;
public static class Math
{
    /// <summary>
    /// Площадь круга.
    /// Округляется до 2-х знаков после точки/запятой
    /// </summary>
    /// <param name="r">Радиус</param>
    /// <returns></returns>
    public static double Square(double r)
    {
        return System.Math.Round(System.Math.PI * r * r, 2);
    }
    /// <summary>
    /// Площадь треугольника.
    /// Округляется до 2-х знаков после точки/запятой
    /// </summary>
    /// <param name="a">Первая сторона</param>
    /// <param name="b">Вторая сторона</param>
    /// <param name="c">Третья сторона</param>
    /// <returns></returns>
    public static double Square(double a, double b, double c)
    {
        double p = (a + b + c) / 2;
        return System.Math.Round(System.Math.Sqrt(p * (p - a) * (p - b) * (p - c)), 2);
    }

    /// <summary>
    /// Проверяет является ли треугольник прямоугольным
    /// </summary>
    /// <param name="a">Первая сторона</param>
    /// <param name="b">Вторая сторона</param>
    /// <param name="c">Третья сторона</param>
    /// <returns></returns>
    public static bool isRightTriangle(double a, double b, double c)
    {
        return PythagoreanTheorem(a, b, c) ||
               PythagoreanTheorem(b, c, a) ||
               PythagoreanTheorem(c, b, a) ;
    }

    /// <summary>
    /// Теорема Пифагора для проверки на прямоугольность треугольника
    /// </summary>
    /// <param name="hypotenuse">Гипотенуза</param>
    /// <param name="cathetus_a">Катет А</param>
    /// <param name="cathetus_b">Катет Б</param>
    /// <returns>Если прямоугольный, то True</returns>
    private static bool PythagoreanTheorem(double hypotenuse, double cathetus_a, double cathetus_b)
    {
        return hypotenuse * hypotenuse == cathetus_a * cathetus_a + cathetus_b * cathetus_b;
    }
}