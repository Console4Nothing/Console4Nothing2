using System;
using System.Reflection;

namespace Console4NothingLoader
{
    public sealed class ApplicationController
    {
        private MethodInfo _onApplicationStartMethod;

        public void Create(Type type)
        {
            foreach (var methodInfo in type.GetMethods(BindingFlags.Static | BindingFlags.Public |
                                                       BindingFlags.NonPublic))
                if (methodInfo.Name.Equals("OnApplicationStart") && methodInfo.GetParameters().Length == 0)
                    _onApplicationStartMethod = methodInfo;
        }

        public void OnApplicationStart()
        {
            var methodInfo = _onApplicationStartMethod;
            if (methodInfo == null) return;
            methodInfo.Invoke(null, new object[0]);
        }
    }
}