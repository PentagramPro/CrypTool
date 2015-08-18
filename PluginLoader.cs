using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CrypTool
{
  public class PluginLoader<T>
  {
    public List<T> Plugins; 

    public PluginLoader()
    {
      LoadAssemblies(AssemblyDirectory);
    }
    public PluginLoader(string path)
    {
      LoadAssemblies(path);
    }

    void LoadAssemblies(string path)
    {
      string[] dllFileNames = null;

      dllFileNames = Directory.GetFiles(path, "*.dll");
      ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Length);
      foreach (string dllFile in dllFileNames)
      {
        
        AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
        Assembly assembly = Assembly.Load(an);
        assemblies.Add(assembly);
      }

      Type pluginType = typeof(T);
      ICollection<Type> pluginTypes = new List<Type>();
      foreach (Assembly assembly in assemblies)
      {
        if (assembly == null) continue;
        Type[] types = assembly.GetTypes();
        foreach (Type type in types)
        {
          if (type.IsInterface || type.IsAbstract)
            continue;

          if (type.GetInterface(pluginType.FullName) != null)
          {
            pluginTypes.Add(type);
          }
        }
      }

      Plugins = new List<T>(pluginTypes.Count);
      foreach (Type type in pluginTypes)
      {
        T plugin = (T)Activator.CreateInstance(type);
        Plugins.Add(plugin);
      }
    }

    public static string AssemblyDirectory
    {
      get
      {
        string codeBase = Assembly.GetExecutingAssembly().CodeBase;
        UriBuilder uri = new UriBuilder(codeBase);
        string path = Uri.UnescapeDataString(uri.Path);
        return Path.GetDirectoryName(path);
      }
    }
  }
}
