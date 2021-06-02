using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using TourJapanX.ViewModels;

namespace TourJapanX.Services
{
    public class ServiceIoC
    {
        IContainer container;

        public ServiceIoC()
        {
            this.RegisterDependencies();
        }

        private void RegisterDependencies()
        {
            ContainerBuilder builder = new ContainerBuilder();

            builder.RegisterType<UsuarioViewModel>();
            builder.RegisterType<LoginViewModel>();
            builder.RegisterType<FavoritosViewModel>();

            builder.RegisterType<ServiceApi>();
            builder.RegisterType<SessionService>().SingleInstance();
            this.container = builder.Build();
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
