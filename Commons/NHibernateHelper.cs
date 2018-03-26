using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace Placement_Application
{
    class NHibernateHelper
    {
        private static ISessionFactory sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (sessionFactory == null)
                {
                    var configuration = new Configuration();
                    configuration.Configure();
                    configuration.AddAssembly(typeof(Entity_Staff).Assembly);
                    sessionFactory = configuration.BuildSessionFactory();
                }
                return sessionFactory;
            }
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }

        public static IStatelessSession OpenStatelessSession()
        {
            return SessionFactory.OpenStatelessSession();
        }

        public static NHibernate.Persister.Entity.AbstractEntityPersister getMetaData<T>()
        {
            return sessionFactory.GetClassMetadata(typeof(T))
                as NHibernate.Persister.Entity.AbstractEntityPersister;
        }
    }
}
