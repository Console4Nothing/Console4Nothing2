using System;
using System.Reflection;

namespace Console4NothingLoader
{
    public sealed class ApplicationController
    {
        private static Logger _logger = new Logger();
        
        private MethodInfo _onApplicationStartMethod;

        public void Create(Type type)
        {
            _logger.AddLine("called");
            foreach (var methodInfo in type.GetMethods(BindingFlags.Static | BindingFlags.Public |
                                                       BindingFlags.NonPublic))
                if (methodInfo.Name.Equals("OnApplicationStart") && methodInfo.GetParameters().Length == 0)
                    _onApplicationStartMethod = methodInfo;
        }

        public void OnApplicationStart()
        {
            _logger.AddLine("called");
            var methodInfo = _onApplicationStartMethod;
            if (methodInfo == null) return;
            _logger.AddLine(methodInfo.Name);
            methodInfo.Invoke(null, new object[0]);
        }
    }
}