using System;
using System.Linq;

namespace Validators;

public static class SimpleValidationExtensions
{
    /// <summary>
    /// Validate multiple conditions 
    /// </summary>
    /// <param name="this"></param>
    /// <param name="predicates"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static bool Validate<T>(
        this T @this,
        params Func<T, bool>[] predicates)
    {
        return predicates.All(x => x(@this));
    }
}