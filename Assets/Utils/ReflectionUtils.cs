using System.Reflection;
using System.Linq;

namespace MKCL.Reflection
{
    public static class ReflectionUtils
    {
        public static System.Type[] GetInheritedClasses(System.Type MyType)
        {
            return Assembly.GetAssembly(MyType).GetTypes().Where(t => t.IsSubclassOf(MyType)).ToArray();
        }
    }
}