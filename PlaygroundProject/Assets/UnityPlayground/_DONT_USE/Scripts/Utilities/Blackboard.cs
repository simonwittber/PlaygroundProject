using System.Collections.Generic;

public static class Blackboard
{
    static Dictionary<string, int> integers = new Dictionary<string, int>();

    public static int GetValue(string name)
    {
        int value = 0;
        integers.TryGetValue(name, out value);
        return value;
    }

    public static int SetValue(string name, int value)
    {
        integers[name] = value;
        return value;
    }

    public static int Add(string name, int amount) => SetValue(name, GetValue(name) + amount);
    public static int Sub(string name, int amount) => SetValue(name, GetValue(name) - amount);
    public static int Mul(string name, int amount) => SetValue(name, GetValue(name) * amount);
    public static int Div(string name, int amount) => SetValue(name, GetValue(name) / amount);
    public static bool IsLessThan(string name, int value) => GetValue(name) < value;
    public static bool IsLessThanOrEqual(string name, int value) => GetValue(name) <= value;
    public static bool IsGreaterThan(string name, int value) => GetValue(name) > value;
    public static bool IsGreaterThanOrEqual(string name, int value) => GetValue(name) >= value;
    public static bool IsEqual(string name, int value) => GetValue(name) == value;
    public static bool IsNotEqual(string name, int value) => GetValue(name) != value;
}

