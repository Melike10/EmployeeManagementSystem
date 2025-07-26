using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Context;

namespace EmployeeUI
{
    internal static class Program
    {
        public static Autofac.IContainer Container;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Container = Configure();
            Application.Run(new XtraHome(Container.Resolve<IDepartmentService>(), Container.Resolve<IEmployeeService>(), Container.Resolve<IOffDayService>(), Container.Resolve<IPayrollParameterService>(), Container.Resolve<IPayrollService>()));
        }

        static Autofac.IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<OffDayManager>().As<IOffDayService>();
            builder.RegisterType<EfOffDayDal>().As<IOffDayDal>();

            builder.RegisterType<PayrollParameterManager>().As<IPayrollParameterService>();
            builder.RegisterType<EfPayrollParameterDal>().As<IPayrollParameterDal>();

            builder.RegisterType<PayrollManager>().As<IPayrollService>();
            builder.RegisterType<EfPayrollDal>().As<IPayrollDal>();



            builder.RegisterType<EmployeeDbContext>()
       .AsSelf().InstancePerLifetimeScope();
            builder.RegisterType<XtraHome>();
            return builder.Build();
        }
    }
}
