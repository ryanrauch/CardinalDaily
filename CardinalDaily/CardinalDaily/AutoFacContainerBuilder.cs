using Autofac;
using CardinalDaily.Services;
using CardinalDaily.Services.Interfaces;
using CardinalDaily.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CardinalDaily
{
    public static class AutoFacContainerBuilder
    {
        public static IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterType<InitialViewModel>().SingleInstance();
            //containerBuilder.RegisterType<WeekViewModel>();

            //containerBuilder.RegisterType<UnAuthenticatedRequestService>().As<IRequestService>().SingleInstance();
            //containerBuilder.RegisterType<BlobStorageService>().As<IBlobStorageService>().SingleInstance();
            containerBuilder.RegisterType<SinglePageNavigationService>().As<INavigationService>().SingleInstance();
            containerBuilder.RegisterType<SecureStorageService>().As<ISecureStorageService>().SingleInstance();

            //containerBuilder.RegisterInstance(DependencyService.Get<IWatchSessionManager>()).AsImplementedInterfaces().SingleInstance();
            //containerBuilder.RegisterInstance(DependencyService.Get<INFCReader>()).AsImplementedInterfaces().SingleInstance();
            return containerBuilder.Build();
        }
    }
}
