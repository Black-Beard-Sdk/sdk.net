
//using Bb.ComponentModel.Attributes;
//using Bb.ComponentModel;
//using Bb.Loaders.SiteExtensions;
//using System.IO;

//namespace Bb.Services
//{


//    public interface IConnector
//    {

//        public bool CanConnect(IConnector item);

//    }

//    public interface IConnector<T> : IConnector
//    {

//    }

//    public interface IConnectorService<T> : IConnector<T>
//    {
//        void Connect(IConnectorAddon<T> femmel);
//    }

//    public interface IConnectorAddon<T> : IConnector<T>
//    {
//        void Connect(IConnectorService<T> male);

//    }



//    public abstract class Connector : IConnector
//    {

//        public abstract bool CanConnect(IConnector item);

//    }

//    public abstract class Connector<T> : Connector, IConnector<T>
//    {

//    }

//    public abstract class ConnectorService<T> : Connector<T>, IConnectorService<T>
//    {

//        public override bool CanConnect(IConnector item)
//        {
//            if (item is IConnectorAddon<T>)
//                return true;
//            return false;
//        }

//        public abstract void Connect(IConnectorAddon<T> femmel);

//    }

//    public abstract class ConnectorAddon<T> : Connector<T>, IConnectorAddon<T>
//    {

//        public override bool CanConnect(IConnector item)
//        {
//            if (item is IConnectorService<T>)
//                return true;
//            return false;
//        }

//        public abstract void Connect(IConnectorService<T> femmel);

//    }


//    public class ConnectorMatcher
//    {

//        public static ConnectorMatcher<T> Search<T>(params string[] paths)
//        {
//            var search = new ConnectorMatcher<T>();
//            search.Search(paths);
//            return search;
//        }

//    }

//    public class ConnectorMatcher<T>
//    {

//        public List<Type> Services { get; private set; }
        
//        public List<Type> Complements { get; private set; }

//        public void Search(params string[] paths)
//        {

//            // Load all assemblies that implement IConnector
//            var configPaths = ConfigurationFolder.GetPaths();
//            var file = Assemblies.Resolve("ExposedAssemblyRepositories.json", configPaths);
//            // Ensure all required assemblies are loaded
//            var assemblies = new AddonsResolver(paths)
//                .With(file)
//                .WithReference(typeof(IConnector))
//                .SearchAssemblies()
//                .ToList()
//                ;
//            assemblies.EnsureIsLoaded();
        
//            // Match
//            var types = TypeDiscovery.Instance.GetTypesAssignableFrom(typeof(IConnector<T>)).ToList();

//            Services = types.Where(c => c.IsAssignableFrom(typeof(IConnectorService<T>))).ToList();
            
//            Complements = types.Where(c => c.IsAssignableFrom(typeof(IConnectorAddon<T>))).ToList();


//        }

//        public void Match(IServiceProvider provider)
//        {
//            foreach (var service in Services)
//            {
//                var serviceInstance = (IConnectorService<T>)Activator.CreateInstance(service);
//                foreach (var complement in Complements)
//                {
//                    var complementInstance = (IConnectorAddon<T>)Activator.CreateInstance(complement);
//                    if (serviceInstance.CanConnect(complementInstance))
//                    {
//                        serviceInstance.Connect(complementInstance);
//                    }
//                }
//            }
//        }


//    }


//}

