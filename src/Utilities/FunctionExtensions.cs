namespace Utilities;

public static class FunctionExtensions
{
    public static TOutput Map<TInput, TOutput>(
        this TInput @this,
        Func<TInput, TOutput> function)
    {
        return function(@this);
    }

    public static T Act<T>(
        this T @this,
        Action<T> act)
    {
        act(@this);
        return @this;
    }
}