using Bb.ComponentModel;
using Bb.ComponentModel.Attributes;
using Bb.Translations;
using System.Globalization;

namespace Site.Services
{


    /// <summary>
    /// Provides translation services for localized strings.
    /// </summary>
    [ExposeClass(ConstantsCore.Service, ExposedType = typeof(ITranslateService), LifeCycle = IocScopeEnum.Singleton)]
    public class TranslateService : ITranslateService
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="TranslateService"/> class.
        /// </summary>
        public TranslateService(/*TranslateServiceDataAccess dataAccess*/)
        {
            //DataAccess = dataAccess;
        }

        /// <summary>
        /// Translates a key into a localized string using the current UI culture.
        /// </summary>
        /// <param name="key">The key to translate. Must not be null.</param>
        /// <param name="arguments">Optional arguments to format the translated string. Can be null.</param>
        /// <returns>The translated string.</returns>
        /// <remarks>
        /// This method retrieves the localized string for the specified key using the current UI culture and formats it with the provided arguments.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var translatedText = translateService.Translate(new TranslatedKeyLabel("HelloKey"), new TranslatedKeyLabel("WorldKey"));
        /// </code>
        /// </example>
        public string Translate(TranslatedKeyLabel key, params TranslatedKeyLabel[] arguments)
        {
            return Translate(CultureInfo.CurrentUICulture, key, arguments);
        }

        /// <summary>
        /// Gets the available cultures for translation.
        /// </summary>
        /// <value>An array of <see cref="CultureInfo"/> representing the available cultures.</value>
        /// <remarks>
        /// This property provides the list of cultures supported by the translation service.
        /// </remarks>
        public CultureInfo[] AvailableCultures => new CultureInfo[] { Thread.CurrentThread.CurrentUICulture };

        ITranslateContainer ITranslateService.Container { get; set; }

        /// <summary>
        /// Translates a key into a localized string using the specified culture.
        /// </summary>
        /// <param name="culture">The culture to use for translation. Must not be null.</param>
        /// <param name="key">The key to translate. Must not be null.</param>
        /// <param name="arguments">Optional arguments to format the translated string. Can be null.</param>
        /// <returns>The translated string.</returns>
        /// <remarks>
        /// This method retrieves the localized string for the specified key using the given culture and formats it with the provided arguments.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var translatedText = translateService.Translate(new CultureInfo("fr-FR"), new TranslatedKeyLabel("HelloKey"));
        /// </code>
        /// </example>
        public string Translate(CultureInfo culture, TranslatedKeyLabel key, params TranslatedKeyLabel[] arguments)
        {




            //if (!label.IsNotValidKey)
            //{

            //    if (datas == null)
            //        lock (_lock)
            //            if (datas == null)
            //            {
            //                datas = new TranslateContainer(string.Empty);
            //                var d = DataAccess.GetAll().ToList();
            //                datas.Sort(d);
            //            }

            //    TranslateContainerResult r;

            //    if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, culture, 0, out TranslateServiceDataModel result)) != TranslateContainerResult.Resolved)
            //        lock (_lock)
            //            if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, culture, 0, out result)) != TranslateContainerResult.Resolved)
            //                foreach (var item in label.Datas)
            //                {
            //                    var result1 = DataAccess.GetNew(label.Path, label.Key);
            //                    result1.Culture = item.Value.Culture;
            //                    result1.Value = item.Value.Value ?? label.DefaultDisplay;
            //                    var sorted = datas.Sort(result1);
            //                    if (result1.Culture.IetfLanguageTag == culture.IetfLanguageTag)
            //                        result = result1;
            //                }


            //    foreach (var cultureItem in this.AvailableCultures)
            //        if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, cultureItem, 0, out result)) != TranslateContainerResult.Resolved)
            //            lock (_lock)
            //                if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, cultureItem, 0, out result)) != TranslateContainerResult.Resolved)
            //                    foreach (var item in label.Datas)
            //                    {
            //                        var result1 = DataAccess.GetNew(label.Path, label.Key);
            //                        result1.Culture = cultureItem;
            //                        result1.Value = item.Value.Value ?? label.DefaultDisplay;
            //                        var sorted = datas.Sort(result1);
            //                        if (result1.Culture.IetfLanguageTag == culture.IetfLanguageTag)
            //                            result = result1;
            //                    }


            //    if (result != null)
            //        return result.Value;

            //    else
            //    {

            //    }

            //}

            var 



            //if (!label.IsNotValidKey)
            //{

            //    if (datas == null)
            //        lock (_lock)
            //            if (datas == null)
            //            {
            //                datas = new TranslateContainer(string.Empty);
            //                var d = DataAccess.GetAll().ToList();
            //                datas.Sort(d);
            //            }

            //    TranslateContainerResult r;

            //    if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, culture, 0, out TranslateServiceDataModel result)) != TranslateContainerResult.Resolved)
            //        lock (_lock)
            //            if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, culture, 0, out result)) != TranslateContainerResult.Resolved)
            //                foreach (var item in label.Datas)
            //                {
            //                    var result1 = DataAccess.GetNew(label.Path, label.Key);
            //                    result1.Culture = item.Value.Culture;
            //                    result1.Value = item.Value.Value ?? label.DefaultDisplay;
            //                    var sorted = datas.Sort(result1);
            //                    if (result1.Culture.IetfLanguageTag == culture.IetfLanguageTag)
            //                        result = result1;
            //                }


            //    foreach (var cultureItem in this.AvailableCultures)
            //        if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, cultureItem, 0, out result)) != TranslateContainerResult.Resolved)
            //            lock (_lock)
            //                if ((r = datas.Resolve(DataAccess.SplitPath(label.Path), label.Key, cultureItem, 0, out result)) != TranslateContainerResult.Resolved)
            //                    foreach (var item in label.Datas)
            //                    {
            //                        var result1 = DataAccess.GetNew(label.Path, label.Key);
            //                        result1.Culture = cultureItem;
            //                        result1.Value = item.Value.Value ?? label.DefaultDisplay;
            //                        var sorted = datas.Sort(result1);
            //                        if (result1.Culture.IetfLanguageTag == culture.IetfLanguageTag)
            //                            result = result1;
            //                    }


            //    if (result != null)
            //        return result.Value;

            //    else
            //    {

            //    }

            //}

result = key.DefaultDisplay;

            if (arguments != null && arguments.Length > 0)
                result = string.Format(result, arguments.Select(c => this.Translate(c)).ToArray());

            return result;
        }

        //private TranslateContainer datas;
        private readonly object _lock = new object();

    }

}
