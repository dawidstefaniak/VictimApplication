using System;
using System.Net.Http;
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
            Mvx.RegisterType(() =>
            {
                var client = "https://deckofcardsapi.com";
                return RestService.For<Services.IApi>(client);
            });
            //TODO
        }
    }
}
