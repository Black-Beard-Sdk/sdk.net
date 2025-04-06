using Bb.Interfaces;
using Bb.Services;

namespace Bb
{

    public class GlobalSettings
    {


        public static Func<IRestClientFactory?> CreateFactory { get; set; } = () => new RestClientFactory(GlobalSettings.OptionFactory);



        public static IRestClientFactory? UrlClientFactory
        {
            get
            {
                if (_factory == null)
                    _factory = CreateFactory();
                return _factory;
            }
            set
            {
                _factory = value;
                _ioptionFactory = null;
            }
        }

        public static IOptionClientFactory? OptionFactory
        {
            get
            {
                if (_ioptionFactory == null)
                    _ioptionFactory = new OptionClientFactory((IServiceProvider)null);
                return _ioptionFactory;
            }
            set
            {
                _ioptionFactory = value;
                _factory = null;
            }
        }


        private static IOptionClientFactory _ioptionFactory;
        private static IRestClientFactory _factory;

    }
}
