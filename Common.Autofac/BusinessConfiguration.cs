using Autofac;
using Business.Logic;
using Business.Logic.ReferenciaWeb;
using Common.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Autofac
{
    public static class BusinessConfiguration
    {
        public static ICalculadoraBusiness GetCalculadoraBusiness()
        {
            var typeConnection = Configuracion.ReadValueFromAppConfig("TypeConnectionService");
            var builder = new ContainerBuilder();
            builder.Register<Service1Client>(
              (c, p) =>
              {
                  return new Service1Client(typeConnection);
              });
            builder.RegisterType<CalculadoraService>();
            builder.RegisterType<CalculadoraBusiness>().As<ICalculadoraBusiness>();
            var container = builder.Build();
            container.Resolve<Service1Client>(new NamedParameter("connectionService", typeConnection));
            return container.Resolve<ICalculadoraBusiness>();
        }
    }
}
