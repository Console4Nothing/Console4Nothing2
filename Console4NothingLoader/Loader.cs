using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Console4NothingLoader
{
    public static class Loader
    {
        private static readonly Logger Logger = new Logger();
        
        private static ApplicationController Controller { get; set; }

        internal static void Load(byte[] assembly)
        {
            Logger.AddLine("called");
            foreach (var type in GetLoadableTypes(Assembly.Load(assembly)))
            {
                Logger.AddLine($"checking type {type.FullName}");
                if ("Main".Equals(type.Name))
                {
                    Logger.AddLine("was Main");
                    try
                    {
                        Logger.AddLine("trying to execute");
                        Controller = new ApplicationController();
                        Logger.AddLine("constructed application controller");
                        Controller.Create(type);
                        Logger.AddLine("created application controller with type");
                        Controller.OnApplicationStart();
                        Logger.AddLine("application ended");
                    }
                    catch (Exception e)
                    {
                        Logger.AddLine("error while trying to execute type");
                        Logger.AddLine(e.ToString());
                        Console.WriteLine(e);
                    }
                }
            }
        }

        private static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
        {
            Logger.AddLine("called");
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            Logger.AddLine("wasn't null");
            IEnumerable<Type> result;
            try
            {
                Logger.AddLine("trying to get types");
                result = assembly.GetTypes();
                Logger.AddLine("got types");
            }
            catch (ReflectionTypeLoadException ex)
            {
                var str = "An error occured while getting types from assembly ";
                var name = assembly.GetName().Name;
                var str2 = ". Returning types from error.\n";
                var ex2 = ex;
                Logger.AddLine(str + name + str2 + ex2);
                Console.WriteLine(str + name + str2 + ex2);
                result = from t in ex.Types
                    where t != null
                    select t;
            }

            return result;
        }
    }
}