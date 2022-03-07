using Autofac;
using Services;


namespace ChirngauzerSquareGraph
{
  internal static class Program
  {
    private static IContainer _container;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      RegisterTypes();
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(_container.Resolve<MainForm>());
    }
    private static void RegisterTypes()
    {
      var builder = new ContainerBuilder();
      builder.RegisterType<ServicesCharngauzerSquare>().As<ICharngauzerSquare>();
      builder.RegisterType<MainForm>();
      _container = builder.Build();
    }
  }
}