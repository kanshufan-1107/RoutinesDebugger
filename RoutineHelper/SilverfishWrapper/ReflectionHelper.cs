using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SilverfishWrapper
{
    static class ReflectionHelper
    {
        const BindingFlags AllFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static;
        public static T ReflectionGetFieldValue<T>(this object obj, string name)
        {
            return (T)obj.GetType().GetField(name, AllFlags).GetValue(obj);
        }

        public static T ReflectionCall<T>(this object obj, string name, params object[] parameters)
        {
            return (T)obj.GetType().GetMethod(name, AllFlags, null, parameters.Select(x=>x.GetType()).ToArray(), null).Invoke(obj, parameters);
        }
    }
}
