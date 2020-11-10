using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Console4NothingLoader
{
    public static class Loader
    {
        private static Logger _logger = new Logger();
        
        private static ApplicationController Controller { get; set; }

        internal static void Load(byte[] assembly)
        {
            _logger.AddLine("called");
            foreach (var type in GetLoadableTypes(Assembly.Load(assembly)))
            {
                _logger.AddLine($"checking type {type.FullName}");
                if ("Main".Equals(type.Name))
                {
                    _logger.AddLine("was Main");
                    try
                    {
                        _logger.AddLine("trying to execute");
                        Controller = new ApplicationController();
                        _logger.AddLine("constructed application controller");
                        Controller.Create(type);
                        _logger.AddLine("created application controller with type");
                        Controller.OnApplicationStart();
                        _logger.AddLine("application ended");
                    }
                    catch (Exception e)
                    {
                        _logger.AddLine("error while trying to execute type");
                        _logger.AddLine(e.ToString());
                        Console.WriteLine(e);
                    }
                }
            }
        }

        private static IEnumerable<Type> GetLoadableTypes(Assembly assembly)
        {
            _logger.AddLine("called");
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            _logger.AddLine("wasn't null");
            IEnumerable<Type> result;
            try
            {
                _logger.AddLine("trying to get types");
                result = assembly.GetTypes();
                _logger.AddLine("got types");
            }
            catch (ReflectionTypeLoadException ex)
            {
                var str = "An error occured while getting types from assembly ";
                var name = assembly.GetName().Name;
                var str2 = ". Returning types from error.\n";
                var ex2 = ex;
                _logger.AddLine(str + name + str2 + ex2);
                Console.WriteLine(str + name + str2 + ex2);
                result = from t in ex.Types
                    where t != null
                    select t;
            }

            return result;
        }
    }
}