using _01.Stealer;
using System;

public class Startup
{
    public static void Main()
    {
        var spy = new Spy();
        var stealingInfo = spy.StealFieldInfo("Hacker", "username", "password");
        Console.WriteLine(stealingInfo + Environment.NewLine + new string('*', 50));
        var analyzeHacker = spy.AnalyzeAcessModifiers("Hacker");
        Console.WriteLine(analyzeHacker + Environment.NewLine + new string('*', 50));
        var privateMethodsInfo = spy.RevealPrivateMethods("Hacker");
        Console.WriteLine(privateMethodsInfo + Environment.NewLine + new string('*', 50));
        var gettersAndSetters = spy.CollectGettersAndSetters("Hacker");
        Console.WriteLine(gettersAndSetters + Environment.NewLine + new string('*', 50));
    }
}