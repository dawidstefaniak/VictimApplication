using System;
using System.Net.Http;
using Acr.UserDialogs;
using MvvmCross.Platform;
using MvvmCross.Platform.IoC;
using MvvmCross.Platform.Platform;
using Refit;

namespace VictimApplication.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterNavigationServiceAppStart<ViewModels.LoginViewModel>();

        }
        public App()
        {
            //API
            Mvx.RegisterType(() =>
            {
                var client = "http://localhost:63082";
                return RestService.For<Services.IApi>(client);
            });
            //UserDialogs
            Mvx.RegisterSingleton<IUserDialogs>(() => UserDialogs.Instance);
        }
    }
}
