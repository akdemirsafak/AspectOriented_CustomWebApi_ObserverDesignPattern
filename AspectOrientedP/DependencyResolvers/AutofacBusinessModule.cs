
using AspectOrientedP.Interceptors;
using AspectOrientedP.Services;
using Autofac;
using Autofac.Extras.DynamicProxy;

namespace AspectOrientedP.DependencyResolvers
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<LoggingInterceptor>();
            builder.RegisterType<ExceptionHandlingInterceptor>();
            builder.RegisterType<CustomerService>().As<ICustomerService>()
            .EnableInterfaceInterceptors().InterceptedBy(typeof(LoggingInterceptor))
            .InterceptedBy(typeof(ExceptionHandlingInterceptor));
            base.Load(builder);

            //Aşağıdaki gibi farklı life cycle'lar da vardır .

            // Transient
            //builder.RegisterType<CustomerService>().As<ICustomerService>()
            //    .InstancePerDependency();



            //// Scoped
            // builder.RegisterType<CustomerService>().As<ICustomerService>()
            //     .InstancePerLifetimeScope();


            //// Singleton
            //builder.RegisterType<CustomerService>().As<ICustomerService>()
            //    .SingleInstance();
        }
    }
}