using System.Web.Mvc;
using Microsoft.Practices.Unity;
using RealSchedule.Domain.Interfaces;
using RealSchedule.Domain.Repositories;
using RealSchedule.Entity.Repositories;
//using RealSchedule.Entity.Repositories;
using RealSchedule.Services;
using Unity.Mvc3;

namespace RealSchedule
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            container.RegisterType<IEventoService, EventoService>();
            container.RegisterType<IEventoRepository, EventoRepository>();
            container.RegisterType<IUsuarioService, UsuarioService>();
            container.RegisterType<IUsuarioRepository, UsuarioRepository>();
            container.RegisterType<IAgendaService, AgendaService>();
            container.RegisterType<IAgendaRepository, AgendaRepository>();

            return container;
        }
    }
}