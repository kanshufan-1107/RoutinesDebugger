using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionCodeGenerator
{
    static class CodeGen
    {
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        const string FileTemplate = "using System;\r\nusing System.Reflection;\r\n\r\nnamespace SilverfishWrapper\r\n{\r\n%content%}\r\n";
        public static string Generate(Type t)
        {
            var fieldsStr = ParseFields(t);
            var propertiesStr = ParseProperties(t);
            var methodsStr = ParseMethods(t);
            var classBegin = $"public class {t.Name}\r\n{{\r\npublic object Inst;\r\npublic static Type Type;\r\n\r\npublic {t.Name}(object inst)\r\n{{\r\nthis.Inst = inst;\r\n}}\r\n";
            classBegin += "const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;\r\n";
            var classEnd = "}\r\n";
            return FileTemplate.Replace("%content%", classBegin + fieldsStr + propertiesStr + methodsStr + classEnd);
        }

        static string ParseFields(Type t)
        {
            var fields = t.GetFields(AllFlags);
            var result = "";
            foreach (var field in fields)
            {
                var name = field.FieldType.Name;
                result += "public ";
                if (field.IsStatic)
                {
                    result += "static ";
                }
                var typeName = "";
                if (field.FieldType == typeof(string))
                {
                    typeName = "string";
                }
                else if (field.FieldType.IsValueType)
                {
                    if (field.FieldType.IsEnum)
                        typeName = field.FieldType.Name;
                    else if (field.FieldType.Assembly == t.Assembly)
                        typeName = "object";
                    else
                        typeName = field.FieldType.Namespace + "." + field.FieldType.Name;
                }
                else
                {
                    typeName = "object";
                }
                result += $"{typeName} ";
                result += field.Name;
                result += "\r\n{\r\n";
                if (field.IsStatic)
                {
                    result += $"get\r\n{{\r\nreturn ({typeName})Type.GetField(\"{field.Name}\", AllFlags).GetValue(null);\r\n}}\r\n";
                    result += $"set\r\n{{\r\nType.GetField(\"{field.Name}\", AllFlags).SetValue(null, value);\r\n}}\r\n";
                }
                else
                {
                    result += $"get\r\n{{\r\nreturn ({typeName})Type.GetField(\"{field.Name}\", AllFlags).GetValue(Inst);\r\n}}\r\n";
                    result += $"set\r\n{{\r\nType.GetField(\"{field.Name}\", AllFlags).SetValue(Inst, value);\r\n}}\r\n";
                }
                result += "}\r\n\r\n";
            }
            return result;
        }

        static string ParseProperties(Type t)
        {
            var properties = t.GetProperties(AllFlags);
            var result = "";
            foreach (var property in properties)
            {
                var name = property.PropertyType.Name;
                var get = property.GetGetMethod(true);
                var set = property.GetSetMethod(true);
                var isStatic = get != null ? get.IsStatic : set != null ? set.IsStatic : false;
                result += "public ";
                if (isStatic)
                {
                    result += "static ";
                }
                var typeName = "";
                if (property.PropertyType == typeof(string))
                {
                    typeName = "string";
                }
                else if (property.PropertyType.IsValueType)
                {
                    if (property.PropertyType.IsEnum)
                        typeName = property.PropertyType.Name;
                    else if (property.PropertyType.Assembly == t.Assembly)
                        typeName = "object";
                    else
                        typeName = property.PropertyType.Namespace + "." + property.PropertyType.Name;
                }
                else
                {
                    typeName = "object";
                }
                result += $"{typeName} ";
                result += property.Name;
                result += "\r\n{\r\n";
                if (isStatic)
                {
                    if (get != null)
                        result += $"get\r\n{{\r\nreturn ({typeName})Type.GetProperty(\"{property.Name}\", AllFlags).GetValue(null);\r\n}}\r\n";
                    if (set != null)
                        result += $"set\r\n{{\r\nType.GetProperty(\"{property.Name}\", AllFlags).SetValue(null, value);\r\n}}\r\n";
                }
                else
                {
                    result += $"get\r\n{{\r\nreturn ({typeName})Type.GetProperty(\"{property.Name}\", AllFlags).GetValue(Inst);\r\n}}\r\n";
                    result += $"set\r\n{{\r\nType.GetProperty(\"{property.Name}\", AllFlags).SetValue(Inst, value);\r\n}}\r\n";
                }
                result += "}\r\n\r\n";
            }
            return result;
        }

        static string ParseMethods(Type t)
        {
            var methods = t.GetMethods(AllFlags);
            var result = "";
            foreach (var method in methods)
            {
                //泛型方法实现太麻烦，需要再说
                if (method.IsGenericMethod || method.IsSpecialName)
                    continue;
                var name = method.Name;
                var retType = method.ReturnType;
                var paras = method.GetParameters();
                var isGeneric = false;
                foreach (var param in paras)
                {
                    if (param.ParameterType.IsGenericType)
                    {
                        isGeneric = true;
                        break;
                    }    
                }
                if (isGeneric)
                    continue;
                result += "public ";
                if (method.IsStatic)
                {
                    result += "static ";
                }
                var retTypeName = "";
                if (retType == typeof(void))
                {
                    retTypeName = "void";
                }
                else if (retType == typeof(string))
                {
                    retTypeName = "string";
                }
                else if (retType.IsValueType)
                {
                    if (retType.IsEnum)
                        retTypeName = retType.Name;
                    else if (retType.Assembly == t.Assembly)
                        retTypeName = "object";
                    else
                        retTypeName = retType.Namespace + "." + retType.Name;
                }
                else
                {
                    retTypeName = "object";
                }
                result += $"{retTypeName} {method.Name}(";
                if (paras.Length > 0)
                {
                    result += string.Join(", ", paras.Select(param =>
                    {
                        var typeName = "";
                        if (param.ParameterType == typeof(string))
                        {
                            typeName = "string";
                        }
                        else if (param.ParameterType.IsValueType)
                        {
                            if (param.ParameterType.IsEnum)
                                typeName = param.ParameterType.Name;
                            else if (param.ParameterType.Assembly == t.Assembly)
                                typeName = "object";
                            else
                                typeName = param.ParameterType.Namespace + "." + param.ParameterType.Name;
                        }
                        else
                        {
                            typeName = "object";
                        }
                        return $"{typeName} {param.Name}";
                    }));
                }

                result += ")\r\n{\r\n";
                result += $"var sigs = new Type[{paras.Length}];\r\n";
                if (paras.Length > 0)
                {
                    for (int i = 0; i < paras.Length; i++)
                    {
                        var param = paras[i];
                        if (param.ParameterType.Assembly == t.Assembly)
                        {
                            result += $"sigs[{i}] = Type.Assembly.GetType(\"{paras[i].ParameterType.FullName}\");\r\n";
                        }
                        else
                            result += $"sigs[{i}] = typeof({paras[i].ParameterType.FullName});\r\n";
                    }
                }
                if (method.IsStatic)
                {
                    if (retTypeName == "void")
                        result += $"Type.GetMethod(\"{method.Name}\", AllFlags, null, sigs, null).Invoke(null, new object[] {{ ";
                    else
                        result += $"return ({retTypeName})Type.GetMethod(\"{method.Name}\", AllFlags, null, sigs, null).Invoke(null, new object[] {{ ";
                }
                else
                {
                    if (retTypeName == "void")
                        result += $"Type.GetMethod(\"{method.Name}\", AllFlags, null, sigs, null).Invoke(Inst, new object[] {{ ";
                    else
                        result += $"return ({retTypeName})Type.GetMethod(\"{method.Name}\", AllFlags, null, sigs, null).Invoke(Inst, new object[] {{ ";
                }
                if (paras.Length > 0)
                {
                    result += string.Join(", ", paras.Select(param => param.Name));
                }
                result += " });\r\n}\r\n\r\n";
            }
            return result;
        }
    }
}
