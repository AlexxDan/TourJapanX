using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.ViewModels;

namespace TourJapanX.Services
{
    public class ServiceIoC
    {
        private IContainer container;

        public ServiceIoC()
        {
            this.RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterType<PerfecturaLugarViewModel>();
            builder.RegisterType<LugarFotoViewModel>();
            builder.RegisterType<LugaresViewModel>();
            builder.RegisterType<UsuarioViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<FavoritosViewModel>();
            

            builder.RegisterType<SessionService>().SingleInstance();

            builder.RegisterType<ServiceApi>();
            this.container = builder.Build();
        }

        public PerfecturaLugarViewModel PerfecturaLugarViewModel
        {
            get
            {
                return this.container.Resolve<PerfecturaLugarViewModel>();
            }
        }

        public LugarFotoViewModel LugarFotoViewModel
        {
            get
            {
                return this.container.Resolve<LugarFotoViewModel>();
            }
        }

        public LugaresViewModel LugaresViewModel
        {
            get
            {
                return this.container.Resolve<LugaresViewModel>();
            }
        }

        public FavoritosViewModel FavoritosViewModel
        {
            get
            {
                return this.container.Resolve<FavoritosViewModel>();
            }
        }

        public LoginViewModel LoginViewModel
        {
            get
            {
                return this.container.Resolve<LoginViewModel>();
            }
        }

        public UsuarioViewModel UsuariosViewModel
        {
            get
            {
                return this.container.Resolve<UsuarioViewModel>();
            }
        }

        public SessionService SessionService
        {
            get
            {
                return this.container.Resolve<SessionService>();
            }
        }

    }
}


          
      
