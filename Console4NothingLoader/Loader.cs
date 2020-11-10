using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Console4NothingLoader
{
    public static class Loader
    {
        private static ApplicationController Controller { get; set; }

        internal static void Load(byte[] assembly)
        {
            foreach (var type in GetLoadableTypes(Assembly.Load(assembly)))
                if ("Main".Equals(type.Name))
                    try
                    {
                        Controller = new ApplicationController();
                        Controller.Create(type);
                        Controller.OnApplicationStart();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
        }

        private static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            IEnumerable<Type> result;
            try
            {
                result = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException ex)
            {
                var str = "An error occured while getting types from assembly ";
                var name = assembly.GetName().Name;
                var str2 = ". Returning types from error.\n";
                var ex2 = ex;
                Console.WriteLine(str + name + str2 + ex2);
                result = from t in ex.Types
                    where t != null
                    select t;
            }

            return result;
        }
    }
}