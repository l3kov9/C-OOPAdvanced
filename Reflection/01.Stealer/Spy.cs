using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace _01.Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string className, params string[] fieldNames)
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Class under investigation: {className}");
            Type classType = Type.GetType($"_01.Stealer.{className}");
            FieldInfo[] fields = classType.GetFields(BindingFlags.Instance
                | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

            var classInstance = Activator.CreateInstance(classType, new object[] { });

            foreach (var field in fields)
            {
                if (fieldNames.Any(x => x == field.Name))
                {
                    sb.AppendLine($"{field.Name} - {field.GetValue(classInstance)}");
                }
            }

            return sb.ToString().Trim();
        }

        public string AnalyzeAcessModifiers(string className)
        {
            var classType = Type.GetType($"_01.Stealer.{className}");
            var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            var methods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            var sb = new StringBuilder();

            foreach (var field in fields)
            {
                if (field.IsPublic)
                {
                    sb.AppendLine($"{field.Name} must be private!");
                }
            }
            foreach (var method in methods)
            {
                if (method.IsPrivate)
                {
                    sb.AppendLine($"{method.Name} have to be public!");
                }
            }

            return sb.ToString().Trim();
        }

        public string RevealPrivateMethods(string className)
        {
            var classType = Type.GetType($"_01.Stealer.{className}");
            var privateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic)
                .Where(x => x.IsPrivate);
            var sb = new StringBuilder();
            sb.AppendLine($"All Private Methods of Class: {className}");
            sb.AppendLine($"Base class: {classType.BaseType.Name}");
            foreach (var method in privateMethods)
            {
                sb.AppendLine(method.Name);
            }
            return sb.ToString().Trim();
        }

        public string CollectGettersAndSetters(string className)
        {
            var classType = Type.GetType($"_01.Stealer.{className}");
            var getMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static).Where(x => x.Name.Contains("get"));
            var setMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic
                | BindingFlags.Static).Where(x => x.Name.Contains("set"));

            var sb = new StringBuilder();
            foreach (var getMethod in getMethods)
            {
                sb.AppendLine($"{getMethod.Name} will return {getMethod.ReturnType}");
            }

            foreach (var setMethod in setMethods)
            {
                sb.AppendLine($"{setMethod.Name} will set field of {setMethod.GetParameters().First().ParameterType}");
            }

            return sb.ToString().Trim();
        }
    }
}
