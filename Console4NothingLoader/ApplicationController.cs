using System;
using System.Reflection;

namespace Console4NothingLoader
{
    public sealed class ApplicationController
    {
        private static readonly Logger Logger = new Logger();
        
        private MethodInfo _onApplicationStartMethod;

        public void Create(Type type)
        {
            Logger.AddLine("called");
            foreach (var methodInfo in type.GetMethods(BindingFlags.Static | BindingFlags.Public |
                                                       BindingFlags.NonPublic))
                if (methodInfo.Name.Equals("OnApplicationStart") && methodInfo.GetParameters().Length == 0)
                    _onApplicationStartMethod = methodInfo;
        }

        public void OnApplicationStart()
        {
            Logger.AddLine("called");
            var methodInfo = _onApplicationStartMethod;
            if (methodInfo == null) return;
            Logger.AddLine(methodInfo.Name);
            methodInfo.Invoke(null, new object[0]);
        }
    }
}