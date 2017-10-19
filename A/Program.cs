using System;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

public class Program
{
  public static void Main(string[] args)
  {
    try
    {        
      new ArgumentException(); // https://github.com/dotnet/corefx/issues/23608
      
      var serviceCollection = new ServiceCollection();
      
      var containerBuilder = new ContainerBuilder();

      containerBuilder.Populate(serviceCollection);

      var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "B.dll");

      var assembly = Assembly.LoadFrom(path);

      containerBuilder.RegisterAssemblyModules(assembly);

      var container = containerBuilder.Build();
      var serviceProvider = new AutofacServiceProvider(container);
    }
    catch (System.Exception ex)
    {        
      Console.WriteLine(ex);
      throw;
    }
  }
}
