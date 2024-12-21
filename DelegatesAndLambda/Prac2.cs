namespace DelegatesAndLambda;

public class Prac2
{
    public static Func<int, int> Square = delegate(int number)
    {
        return number * number;
    };
}