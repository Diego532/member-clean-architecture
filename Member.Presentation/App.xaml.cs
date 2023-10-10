using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using Member.ApplicationLayer;
using Member.Infrastructure;

namespace Member.Presentation
{
    //Esta es la congiguracion para que mi aplicacion maneje injeccion de dependencia para mi Clean Architecture 
    public partial class App : Application
    {
       
        public static IHost? AppHost { get; private set; }

        public App()
        {
            //Aqui podemos registrar nuestros servicios.
            // Nuestros servicios son Dependency Injection
            //Lo que estoy haciendo es inyectar mis servicios en mi controlador
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainWindow>();


                    //Como sabe mi inyeccion de dependencia cual Repositorio usar?
                    
                    services.AddTransient<ImemberRepository, Infrastructure.MemberRepositoryTwo>();

                    /* La aplicacion realiza la inyeccion de dependencia con la definicion mas cercana, es decir
                     como mi servicio MemberService tiene una dependencia con el ImemberRepository, primero injecto la 
                    dependencia con AddTransient y despues inyecto el MemberService. Mi framework va a tomar el ImemberRepository
                    el cual fue instanciado mas cerca del Member Service.

                    Debe registrarse en orden.
                     
                     */

                    services.AddTransient<ImemberRepository, Infrastructure.MemberRepository>();
                    services.AddTransient<IMemberServices, MemberService>();

                    

                })
                .Build();
        }


        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            var startupForm = AppHost.Services.GetRequiredService<MainWindow>();
            startupForm.Show();
            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }
}
