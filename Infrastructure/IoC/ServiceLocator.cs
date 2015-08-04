using ActionImplimentations.ActionsImplements;
using Domain.Domain;
using InterfaceActions;
using Ninject;

namespace Infrastructure.IoC
{
    internal static class ServiceLocator
    {
        private static readonly IKernel Kernel = new StandardKernel();

        public static void RegisterAll()
        {
            Kernel.Bind<INotifycation<Book>>().To<SmsNotifier>();
            Kernel.Bind<IWriteEventLog>().To<EventWriteToFile>();
        }

        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }
    }
}