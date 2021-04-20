using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bb.Sdk.Net.Mails.Configurations
{



    /// <summary>
    /// CultureEnum extenstion
    /// </summary>
    public static class CultureExtenstion
    {


        /// <summary>
        /// To the culture.
        /// </summary>
        /// <param name="self">The self.</param>
        /// <returns></returns>
        public static CultureInfo ToCulture(this CultureEnum self)
        {
            var member = typeof(CultureEnum).GetField(self.ToString());
            CultureAttribute attr = Attribute.GetCustomAttribute(member, typeof(CultureAttribute)) as CultureAttribute;
            return attr.Culture;
        }

    }


    /// <summary>
    /// enum contains the cultures list
    /// </summary>
    public enum CultureEnum
    {


        /// <summary>
        /// Invariant Language (Invariant Country)
        /// </summary>
        [Culture("")]
        None,

        /// <summary>
        /// Afrikaans
        /// </summary>
        [Culture("af")]
        Afrikaans,

        /// <summary>
        /// Afrikaans (South Africa)
        /// </summary>
        [Culture("af-ZA")]
        AfrikaansSouthAfrica,

        /// <summary>
        /// Amharic
        /// </summary>
        [Culture("am")]
        Amharic,

        /// <summary>
        /// Amharic (Ethiopia)
        /// </summary>
        [Culture("am-ET")]
        AmharicEthiopia,

        /// <summary>
        /// Arabic
        /// </summary>
        [Culture("ar")]
        Arabic,

        /// <summary>
        /// Arabic (U.A.E.)
        /// </summary>
        [Culture("ar-AE")]
        ArabicU_A_E_,

        /// <summary>
        /// Arabic (Bahrain)
        /// </summary>
        [Culture("ar-BH")]
        ArabicBahrain,

        /// <summary>
        /// Arabic (Algeria)
        /// </summary>
        [Culture("ar-DZ")]
        ArabicAlgeria,

        /// <summary>
        /// Arabic (Egypt)
        /// </summary>
        [Culture("ar-EG")]
        ArabicEgypt,

        /// <summary>
        /// Arabic (Iraq)
        /// </summary>
        [Culture("ar-IQ")]
        ArabicIraq,

        /// <summary>
        /// Arabic (Jordan)
        /// </summary>
        [Culture("ar-JO")]
        ArabicJordan,

        /// <summary>
        /// Arabic (Kuwait)
        /// </summary>
        [Culture("ar-KW")]
        ArabicKuwait,

        /// <summary>
        /// Arabic (Lebanon)
        /// </summary>
        [Culture("ar-LB")]
        ArabicLebanon,

        /// <summary>
        /// Arabic (Libya)
        /// </summary>
        [Culture("ar-LY")]
        ArabicLibya,

        /// <summary>
        /// Arabic (Morocco)
        /// </summary>
        [Culture("ar-MA")]
        ArabicMorocco,

        /// <summary>
        /// Arabic (Oman)
        /// </summary>
        [Culture("ar-OM")]
        ArabicOman,

        /// <summary>
        /// Arabic (Qatar)
        /// </summary>
        [Culture("ar-QA")]
        ArabicQatar,

        /// <summary>
        /// Arabic (Saudi Arabia)
        /// </summary>
        [Culture("ar-SA")]
        ArabicSaudiArabia,

        /// <summary>
        /// Arabic (Syria)
        /// </summary>
        [Culture("ar-SY")]
        ArabicSyria,

        /// <summary>
        /// Arabic (Tunisia)
        /// </summary>
        [Culture("ar-TN")]
        ArabicTunisia,

        /// <summary>
        /// Arabic (Yemen)
        /// </summary>
        [Culture("ar-YE")]
        ArabicYemen,

        /// <summary>
        /// Mapudungun
        /// </summary>
        [Culture("arn")]
        Mapudungun,

        /// <summary>
        /// Mapudungun (Chile)
        /// </summary>
        [Culture("arn-CL")]
        MapudungunChile,

        /// <summary>
        /// Assamese
        /// </summary>
        [Culture("as")]
        Assamese,

        /// <summary>
        /// Assamese (India)
        /// </summary>
        [Culture("as-IN")]
        AssameseIndia,

        /// <summary>
        /// Azerbaijani
        /// </summary>
        [Culture("az")]
        Azerbaijani,

        /// <summary>
        /// Azerbaijani (Cyrillic)
        /// </summary>
        [Culture("az-Cyrl")]
        AzerbaijaniCyrillic,

        /// <summary>
        /// Azerbaijani (Cyrillic, Azerbaijan)
        /// </summary>
        [Culture("az-Cyrl-AZ")]
        AzerbaijaniCyrillic_Azerbaijan,

        /// <summary>
        /// Azerbaijani (Latin)
        /// </summary>
        [Culture("az-Latn")]
        AzerbaijaniLatin,

        /// <summary>
        /// Azerbaijani (Latin, Azerbaijan)
        /// </summary>
        [Culture("az-Latn-AZ")]
        AzerbaijaniLatin_Azerbaijan,

        /// <summary>
        /// Bashkir
        /// </summary>
        [Culture("ba")]
        Bashkir,

        /// <summary>
        /// Bashkir (Russia)
        /// </summary>
        [Culture("ba-RU")]
        BashkirRussia,

        /// <summary>
        /// Belarusian
        /// </summary>
        [Culture("be")]
        Belarusian,

        /// <summary>
        /// Belarusian (Belarus)
        /// </summary>
        [Culture("be-BY")]
        BelarusianBelarus,

        /// <summary>
        /// Bulgarian
        /// </summary>
        [Culture("bg")]
        Bulgarian,

        /// <summary>
        /// Bulgarian (Bulgaria)
        /// </summary>
        [Culture("bg-BG")]
        BulgarianBulgaria,

        /// <summary>
        /// Bangla
        /// </summary>
        [Culture("bn")]
        Bangla,

        /// <summary>
        /// Bangla (Bangladesh)
        /// </summary>
        [Culture("bn-BD")]
        BanglaBangladesh,

        /// <summary>
        /// Bangla (India)
        /// </summary>
        [Culture("bn-IN")]
        BanglaIndia,

        /// <summary>
        /// Tibetan
        /// </summary>
        [Culture("bo")]
        Tibetan,

        /// <summary>
        /// Tibetan (China)
        /// </summary>
        [Culture("bo-CN")]
        TibetanChina,

        /// <summary>
        /// Breton
        /// </summary>
        [Culture("br")]
        Breton,

        /// <summary>
        /// Breton (France)
        /// </summary>
        [Culture("br-FR")]
        BretonFrance,

        /// <summary>
        /// Bosnian
        /// </summary>
        [Culture("bs")]
        Bosnian,

        /// <summary>
        /// Bosnian (Cyrillic)
        /// </summary>
        [Culture("bs-Cyrl")]
        BosnianCyrillic,

        /// <summary>
        /// Bosnian (Cyrillic, Bosnia and Herzegovina)
        /// </summary>
        [Culture("bs-Cyrl-BA")]
        BosnianCyrillic_BosniaandHerzegovina,

        /// <summary>
        /// Bosnian (Latin)
        /// </summary>
        [Culture("bs-Latn")]
        BosnianLatin,

        /// <summary>
        /// Bosnian (Latin, Bosnia and Herzegovina)
        /// </summary>
        [Culture("bs-Latn-BA")]
        BosnianLatin_BosniaandHerzegovina,

        /// <summary>
        /// Catalan
        /// </summary>
        [Culture("ca")]
        Catalan,

        /// <summary>
        /// Catalan (Catalan)
        /// </summary>
        [Culture("ca-ES")]
        CatalanCatalan,

        /// <summary>
        /// Valencian (Spain)
        /// </summary>
        [Culture("ca-ES-valencia")]
        ValencianSpain,

        /// <summary>
        /// Cherokee
        /// </summary>
        [Culture("chr")]
        Cherokee,

        /// <summary>
        /// Cherokee (Cherokee)
        /// </summary>
        [Culture("chr-Cher-US")]
        CherokeeCherokee,

        /// <summary>
        /// Corsican
        /// </summary>
        [Culture("co")]
        Corsican,

        /// <summary>
        /// Corsican (France)
        /// </summary>
        [Culture("co-FR")]
        CorsicanFrance,

        /// <summary>
        /// Czech
        /// </summary>
        [Culture("cs")]
        Czech,

        /// <summary>
        /// Czech (Czech Republic)
        /// </summary>
        [Culture("cs-CZ")]
        CzechCzechRepublic,

        /// <summary>
        /// Welsh
        /// </summary>
        [Culture("cy")]
        Welsh,

        /// <summary>
        /// Welsh (United Kingdom)
        /// </summary>
        [Culture("cy-GB")]
        WelshUnitedKingdom,

        /// <summary>
        /// Danish
        /// </summary>
        [Culture("da")]
        Danish,

        /// <summary>
        /// Danish (Denmark)
        /// </summary>
        [Culture("da-DK")]
        DanishDenmark,

        /// <summary>
        /// German
        /// </summary>
        [Culture("de")]
        German,

        /// <summary>
        /// German (Austria)
        /// </summary>
        [Culture("de-AT")]
        GermanAustria,

        /// <summary>
        /// German (Switzerland)
        /// </summary>
        [Culture("de-CH")]
        GermanSwitzerland,

        /// <summary>
        /// German (Germany)
        /// </summary>
        [Culture("de-DE")]
        GermanGermany,

        /// <summary>
        /// German (Liechtenstein)
        /// </summary>
        [Culture("de-LI")]
        GermanLiechtenstein,

        /// <summary>
        /// German (Luxembourg)
        /// </summary>
        [Culture("de-LU")]
        GermanLuxembourg,

        /// <summary>
        /// Lower Sorbian
        /// </summary>
        [Culture("dsb")]
        LowerSorbian,

        /// <summary>
        /// Lower Sorbian (Germany)
        /// </summary>
        [Culture("dsb-DE")]
        LowerSorbianGermany,

        /// <summary>
        /// Divehi
        /// </summary>
        [Culture("dv")]
        Divehi,

        /// <summary>
        /// Divehi (Maldives)
        /// </summary>
        [Culture("dv-MV")]
        DivehiMaldives,

        /// <summary>
        /// Greek
        /// </summary>
        [Culture("el")]
        Greek,

        /// <summary>
        /// Greek (Greece)
        /// </summary>
        [Culture("el-GR")]
        GreekGreece,

        /// <summary>
        /// English
        /// </summary>
        [Culture("en")]
        English,

        /// <summary>
        /// English (Caribbean)
        /// </summary>
        [Culture("en-029")]
        EnglishCaribbean,

        /// <summary>
        /// English (Australia)
        /// </summary>
        [Culture("en-AU")]
        EnglishAustralia,

        /// <summary>
        /// English (Belize)
        /// </summary>
        [Culture("en-BZ")]
        EnglishBelize,

        /// <summary>
        /// English (Canada)
        /// </summary>
        [Culture("en-CA")]
        EnglishCanada,

        /// <summary>
        /// English (United Kingdom)
        /// </summary>
        [Culture("en-GB")]
        EnglishUnitedKingdom,

        /// <summary>
        /// English (Hong Kong)
        /// </summary>
        [Culture("en-HK")]
        EnglishHongKong,

        /// <summary>
        /// English (Ireland)
        /// </summary>
        [Culture("en-IE")]
        EnglishIreland,

        /// <summary>
        /// English (India)
        /// </summary>
        [Culture("en-IN")]
        EnglishIndia,

        /// <summary>
        /// English (Jamaica)
        /// </summary>
        [Culture("en-JM")]
        EnglishJamaica,

        /// <summary>
        /// English (Malaysia)
        /// </summary>
        [Culture("en-MY")]
        EnglishMalaysia,

        /// <summary>
        /// English (New Zealand)
        /// </summary>
        [Culture("en-NZ")]
        EnglishNewZealand,

        /// <summary>
        /// English (Philippines)
        /// </summary>
        [Culture("en-PH")]
        EnglishPhilippines,

        /// <summary>
        /// English (Singapore)
        /// </summary>
        [Culture("en-SG")]
        EnglishSingapore,

        /// <summary>
        /// English (Trinidad and Tobago)
        /// </summary>
        [Culture("en-TT")]
        EnglishTrinidadandTobago,

        /// <summary>
        /// English (United States)
        /// </summary>
        [Culture("en-US")]
        EnglishUnitedStates,

        /// <summary>
        /// English (South Africa)
        /// </summary>
        [Culture("en-ZA")]
        EnglishSouthAfrica,

        /// <summary>
        /// English (Zimbabwe)
        /// </summary>
        [Culture("en-ZW")]
        EnglishZimbabwe,

        /// <summary>
        /// Spanish
        /// </summary>
        [Culture("es")]
        Spanish,

        /// <summary>
        /// Spanish (Latin America)
        /// </summary>
        [Culture("es-419")]
        SpanishLatinAmerica,

        /// <summary>
        /// Spanish (Argentina)
        /// </summary>
        [Culture("es-AR")]
        SpanishArgentina,

        /// <summary>
        /// Spanish (Bolivia)
        /// </summary>
        [Culture("es-BO")]
        SpanishBolivia,

        /// <summary>
        /// Spanish (Chile)
        /// </summary>
        [Culture("es-CL")]
        SpanishChile,

        /// <summary>
        /// Spanish (Colombia)
        /// </summary>
        [Culture("es-CO")]
        SpanishColombia,

        /// <summary>
        /// Spanish (Costa Rica)
        /// </summary>
        [Culture("es-CR")]
        SpanishCostaRica,

        /// <summary>
        /// Spanish (Dominican Republic)
        /// </summary>
        [Culture("es-DO")]
        SpanishDominicanRepublic,

        /// <summary>
        /// Spanish (Ecuador)
        /// </summary>
        [Culture("es-EC")]
        SpanishEcuador,

        /// <summary>
        /// Spanish (Spain, International Sort)
        /// </summary>
        [Culture("es-ES")]
        SpanishSpain_InternationalSort,

        /// <summary>
        /// Spanish (Guatemala)
        /// </summary>
        [Culture("es-GT")]
        SpanishGuatemala,

        /// <summary>
        /// Spanish (Honduras)
        /// </summary>
        [Culture("es-HN")]
        SpanishHonduras,

        /// <summary>
        /// Spanish (Mexico)
        /// </summary>
        [Culture("es-MX")]
        SpanishMexico,

        /// <summary>
        /// Spanish (Nicaragua)
        /// </summary>
        [Culture("es-NI")]
        SpanishNicaragua,

        /// <summary>
        /// Spanish (Panama)
        /// </summary>
        [Culture("es-PA")]
        SpanishPanama,

        /// <summary>
        /// Spanish (Peru)
        /// </summary>
        [Culture("es-PE")]
        SpanishPeru,

        /// <summary>
        /// Spanish (Puerto Rico)
        /// </summary>
        [Culture("es-PR")]
        SpanishPuertoRico,

        /// <summary>
        /// Spanish (Paraguay)
        /// </summary>
        [Culture("es-PY")]
        SpanishParaguay,

        /// <summary>
        /// Spanish (El Salvador)
        /// </summary>
        [Culture("es-SV")]
        SpanishElSalvador,

        /// <summary>
        /// Spanish (United States)
        /// </summary>
        [Culture("es-US")]
        SpanishUnitedStates,

        /// <summary>
        /// Spanish (Uruguay)
        /// </summary>
        [Culture("es-UY")]
        SpanishUruguay,

        /// <summary>
        /// Spanish (Bolivarian Republic of Venezuela)
        /// </summary>
        [Culture("es-VE")]
        SpanishBolivarianRepublicofVenezuela,

        /// <summary>
        /// Estonian
        /// </summary>
        [Culture("et")]
        Estonian,

        /// <summary>
        /// Estonian (Estonia)
        /// </summary>
        [Culture("et-EE")]
        EstonianEstonia,

        /// <summary>
        /// Basque
        /// </summary>
        [Culture("eu")]
        Basque,

        /// <summary>
        /// Basque (Basque)
        /// </summary>
        [Culture("eu-ES")]
        BasqueBasque,

        /// <summary>
        /// Persian
        /// </summary>
        [Culture("fa")]
        Persian,

        /// <summary>
        /// Fulah
        /// </summary>
        [Culture("ff")]
        Fulah,

        /// <summary>
        /// Fulah
        /// </summary>
        [Culture("ff-Latn")]
        Fulah_Latin,

        /// <summary>
        /// Fulah (Latin, Senegal)
        /// </summary>
        [Culture("ff-Latn-SN")]
        FulahLatin_Senegal,

        /// <summary>
        /// Finnish
        /// </summary>
        [Culture("fi")]
        Finnish,

        /// <summary>
        /// Finnish (Finland)
        /// </summary>
        [Culture("fi-FI")]
        FinnishFinland,

        /// <summary>
        /// Filipino
        /// </summary>
        [Culture("fil")]
        Filipino,

        /// <summary>
        /// Filipino (Philippines)
        /// </summary>
        [Culture("fil-PH")]
        FilipinoPhilippines,

        /// <summary>
        /// Faroese
        /// </summary>
        [Culture("fo")]
        Faroese,

        /// <summary>
        /// Faroese (Faroe Islands)
        /// </summary>
        [Culture("fo-FO")]
        FaroeseFaroeIslands,

        /// <summary>
        /// French
        /// </summary>
        [Culture("fr")]
        French,

        /// <summary>
        /// French (Belgium)
        /// </summary>
        [Culture("fr-BE")]
        FrenchBelgium,

        /// <summary>
        /// French (Canada)
        /// </summary>
        [Culture("fr-CA")]
        FrenchCanada,

        /// <summary>
        /// French (Congo [DRC])
        /// </summary>
        [Culture("fr-CD")]
        FrenchCongoDRC,

        /// <summary>
        /// French (Switzerland)
        /// </summary>
        [Culture("fr-CH")]
        FrenchSwitzerland,

        /// <summary>
        /// French (Ivory Coast)
        /// </summary>
        [Culture("fr-CI")]
        FrenchIvoryCoast,

        /// <summary>
        /// French (Cameroon)
        /// </summary>
        [Culture("fr-CM")]
        FrenchCameroon,

        /// <summary>
        /// French (France)
        /// </summary>
        [Culture("fr-FR")]
        FrenchFrance,

        /// <summary>
        /// French (Haiti)
        /// </summary>
        [Culture("fr-HT")]
        FrenchHaiti,

        /// <summary>
        /// French (Luxembourg)
        /// </summary>
        [Culture("fr-LU")]
        FrenchLuxembourg,

        /// <summary>
        /// French (Morocco)
        /// </summary>
        [Culture("fr-MA")]
        FrenchMorocco,

        /// <summary>
        /// French (Monaco)
        /// </summary>
        [Culture("fr-MC")]
        FrenchMonaco,

        /// <summary>
        /// French (Mali)
        /// </summary>
        [Culture("fr-ML")]
        FrenchMali,

        /// <summary>
        /// French (Réunion)
        /// </summary>
        [Culture("fr-RE")]
        FrenchRéunion,

        /// <summary>
        /// French (Senegal)
        /// </summary>
        [Culture("fr-SN")]
        FrenchSenegal,

        /// <summary>
        /// Frisian
        /// </summary>
        [Culture("fy")]
        Frisian,

        /// <summary>
        /// Frisian (Netherlands)
        /// </summary>
        [Culture("fy-NL")]
        FrisianNetherlands,

        /// <summary>
        /// Irish
        /// </summary>
        [Culture("ga")]
        Irish,

        /// <summary>
        /// Irish (Ireland)
        /// </summary>
        [Culture("ga-IE")]
        IrishIreland,

        /// <summary>
        /// Scottish Gaelic
        /// </summary>
        [Culture("gd")]
        ScottishGaelic,

        /// <summary>
        /// Scottish Gaelic (United Kingdom)
        /// </summary>
        [Culture("gd-GB")]
        ScottishGaelicUnitedKingdom,

        /// <summary>
        /// Galician
        /// </summary>
        [Culture("gl")]
        Galician,

        /// <summary>
        /// Galician (Galician)
        /// </summary>
        [Culture("gl-ES")]
        GalicianGalician,

        /// <summary>
        /// Guarani
        /// </summary>
        [Culture("gn")]
        Guarani,

        /// <summary>
        /// Guarani (Paraguay)
        /// </summary>
        [Culture("gn-PY")]
        GuaraniParaguay,

        /// <summary>
        /// Alsatian
        /// </summary>
        [Culture("gsw")]
        Alsatian,

        /// <summary>
        /// Alsatian (France)
        /// </summary>
        [Culture("gsw-FR")]
        AlsatianFrance,

        /// <summary>
        /// Gujarati
        /// </summary>
        [Culture("gu")]
        Gujarati,

        /// <summary>
        /// Gujarati (India)
        /// </summary>
        [Culture("gu-IN")]
        GujaratiIndia,

        /// <summary>
        /// Hausa
        /// </summary>
        [Culture("ha")]
        Hausa,

        /// <summary>
        /// Hausa (Latin)
        /// </summary>
        [Culture("ha-Latn")]
        HausaLatin,

        /// <summary>
        /// Hausa (Latin, Nigeria)
        /// </summary>
        [Culture("ha-Latn-NG")]
        HausaLatin_Nigeria,

        /// <summary>
        /// Hawaiian
        /// </summary>
        [Culture("haw")]
        Hawaiian,

        /// <summary>
        /// Hawaiian (United States)
        /// </summary>
        [Culture("haw-US")]
        HawaiianUnitedStates,

        /// <summary>
        /// Hebrew
        /// </summary>
        [Culture("he")]
        Hebrew,

        /// <summary>
        /// Hebrew (Israel)
        /// </summary>
        [Culture("he-IL")]
        HebrewIsrael,

        /// <summary>
        /// Hindi
        /// </summary>
        [Culture("hi")]
        Hindi,

        /// <summary>
        /// Hindi (India)
        /// </summary>
        [Culture("hi-IN")]
        HindiIndia,

        /// <summary>
        /// Croatian
        /// </summary>
        [Culture("hr")]
        Croatian,

        /// <summary>
        /// Croatian (Latin, Bosnia and Herzegovina)
        /// </summary>
        [Culture("hr-BA")]
        CroatianLatin_BosniaandHerzegovina,

        /// <summary>
        /// Croatian (Croatia)
        /// </summary>
        [Culture("hr-HR")]
        CroatianCroatia,

        /// <summary>
        /// Upper Sorbian
        /// </summary>
        [Culture("hsb")]
        UpperSorbian,

        /// <summary>
        /// Upper Sorbian (Germany)
        /// </summary>
        [Culture("hsb-DE")]
        UpperSorbianGermany,

        /// <summary>
        /// Hungarian
        /// </summary>
        [Culture("hu")]
        Hungarian,

        /// <summary>
        /// Hungarian (Hungary)
        /// </summary>
        [Culture("hu-HU")]
        HungarianHungary,

        /// <summary>
        /// Armenian
        /// </summary>
        [Culture("hy")]
        Armenian,

        /// <summary>
        /// Armenian (Armenia)
        /// </summary>
        [Culture("hy-AM")]
        ArmenianArmenia,

        /// <summary>
        /// Indonesian
        /// </summary>
        [Culture("id")]
        Indonesian,

        /// <summary>
        /// Indonesian (Indonesia)
        /// </summary>
        [Culture("id-ID")]
        IndonesianIndonesia,

        /// <summary>
        /// Igbo
        /// </summary>
        [Culture("ig")]
        Igbo,

        /// <summary>
        /// Igbo (Nigeria)
        /// </summary>
        [Culture("ig-NG")]
        IgboNigeria,

        /// <summary>
        /// Yi
        /// </summary>
        [Culture("ii")]
        Yi,

        /// <summary>
        /// Yi (China)
        /// </summary>
        [Culture("ii-CN")]
        YiChina,

        /// <summary>
        /// Icelandic
        /// </summary>
        [Culture("is")]
        Icelandic,

        /// <summary>
        /// Icelandic (Iceland)
        /// </summary>
        [Culture("is-IS")]
        IcelandicIceland,

        /// <summary>
        /// Italian
        /// </summary>
        [Culture("it")]
        Italian,

        /// <summary>
        /// Italian (Switzerland)
        /// </summary>
        [Culture("it-CH")]
        ItalianSwitzerland,

        /// <summary>
        /// Italian (Italy)
        /// </summary>
        [Culture("it-IT")]
        ItalianItaly,

        /// <summary>
        /// Inuktitut
        /// </summary>
        [Culture("iu")]
        Inuktitut,

        /// <summary>
        /// Inuktitut (Syllabics)
        /// </summary>
        [Culture("iu-Cans")]
        InuktitutSyllabics,

        /// <summary>
        /// Inuktitut (Syllabics, Canada)
        /// </summary>
        [Culture("iu-Cans-CA")]
        InuktitutSyllabics_Canada,

        /// <summary>
        /// Inuktitut (Latin)
        /// </summary>
        [Culture("iu-Latn")]
        InuktitutLatin,

        /// <summary>
        /// Inuktitut (Latin, Canada)
        /// </summary>
        [Culture("iu-Latn-CA")]
        InuktitutLatin_Canada,

        /// <summary>
        /// Japanese
        /// </summary>
        [Culture("ja")]
        Japanese,

        /// <summary>
        /// Japanese (Japan)
        /// </summary>
        [Culture("ja-JP")]
        JapaneseJapan,

        /// <summary>
        /// Javanese
        /// </summary>
        [Culture("jv")]
        Javanese,

        /// <summary>
        /// Javanese
        /// </summary>
        [Culture("jv-Latn")]
        Javanese_Latin,

        /// <summary>
        /// Javanese (Indonesia)
        /// </summary>
        [Culture("jv-Latn-ID")]
        JavaneseIndonesia,

        /// <summary>
        /// Georgian
        /// </summary>
        [Culture("ka")]
        Georgian,

        /// <summary>
        /// Georgian (Georgia)
        /// </summary>
        [Culture("ka-GE")]
        GeorgianGeorgia,

        /// <summary>
        /// Kazakh
        /// </summary>
        [Culture("kk")]
        Kazakh,

        /// <summary>
        /// Kazakh (Kazakhstan)
        /// </summary>
        [Culture("kk-KZ")]
        KazakhKazakhstan,

        /// <summary>
        /// Greenlandic
        /// </summary>
        [Culture("kl")]
        Greenlandic,

        /// <summary>
        /// Greenlandic (Greenland)
        /// </summary>
        [Culture("kl-GL")]
        GreenlandicGreenland,

        /// <summary>
        /// Khmer
        /// </summary>
        [Culture("km")]
        Khmer,

        /// <summary>
        /// Khmer (Cambodia)
        /// </summary>
        [Culture("km-KH")]
        KhmerCambodia,

        /// <summary>
        /// Kannada
        /// </summary>
        [Culture("kn")]
        Kannada,

        /// <summary>
        /// Kannada (India)
        /// </summary>
        [Culture("kn-IN")]
        KannadaIndia,

        /// <summary>
        /// Korean
        /// </summary>
        [Culture("ko")]
        Korean,

        /// <summary>
        /// Korean (Korea)
        /// </summary>
        [Culture("ko-KR")]
        KoreanKorea,

        /// <summary>
        /// Konkani
        /// </summary>
        [Culture("kok")]
        Konkani,

        /// <summary>
        /// Konkani (India)
        /// </summary>
        [Culture("kok-IN")]
        KonkaniIndia,

        /// <summary>
        /// Central Kurdish
        /// </summary>
        [Culture("ku")]
        CentralKurdish,

        /// <summary>
        /// Central Kurdish
        /// </summary>
        [Culture("ku-Arab")]
        CentralKurdish_Arab,

        /// <summary>
        /// Central Kurdish (Iraq)
        /// </summary>
        [Culture("ku-Arab-IQ")]
        CentralKurdishIraq,

        /// <summary>
        /// Kyrgyz
        /// </summary>
        [Culture("ky")]
        Kyrgyz,

        /// <summary>
        /// Kyrgyz (Kyrgyzstan)
        /// </summary>
        [Culture("ky-KG")]
        KyrgyzKyrgyzstan,

        /// <summary>
        /// Luxembourgish
        /// </summary>
        [Culture("lb")]
        Luxembourgish,

        /// <summary>
        /// Luxembourgish (Luxembourg)
        /// </summary>
        [Culture("lb-LU")]
        LuxembourgishLuxembourg,

        /// <summary>
        /// Lao
        /// </summary>
        [Culture("lo")]
        Lao,

        /// <summary>
        /// Lao (Lao PDR)
        /// </summary>
        [Culture("lo-LA")]
        LaoLaoPDR,

        /// <summary>
        /// Lithuanian
        /// </summary>
        [Culture("lt")]
        Lithuanian,

        /// <summary>
        /// Lithuanian (Lithuania)
        /// </summary>
        [Culture("lt-LT")]
        LithuanianLithuania,

        /// <summary>
        /// Latvian
        /// </summary>
        [Culture("lv")]
        Latvian,

        /// <summary>
        /// Latvian (Latvia)
        /// </summary>
        [Culture("lv-LV")]
        LatvianLatvia,

        /// <summary>
        /// Malagasy
        /// </summary>
        [Culture("mg")]
        Malagasy,

        /// <summary>
        /// Malagasy (Madagascar)
        /// </summary>
        [Culture("mg-MG")]
        MalagasyMadagascar,

        /// <summary>
        /// Maori
        /// </summary>
        [Culture("mi")]
        Maori,

        /// <summary>
        /// Maori (New Zealand)
        /// </summary>
        [Culture("mi-NZ")]
        MaoriNewZealand,

        /// <summary>
        /// Macedonian (Former Yugoslav Republic of Macedonia)
        /// </summary>
        [Culture("mk")]
        MacedonianFormerYugoslavRepublicofMacedonia,

        /// <summary>
        /// Malayalam
        /// </summary>
        [Culture("ml")]
        Malayalam,

        /// <summary>
        /// Malayalam (India)
        /// </summary>
        [Culture("ml-IN")]
        MalayalamIndia,

        /// <summary>
        /// Mongolian
        /// </summary>
        [Culture("mn")]
        Mongolian,

        /// <summary>
        /// Mongolian (Cyrillic)
        /// </summary>
        [Culture("mn-Cyrl")]
        MongolianCyrillic,

        /// <summary>
        /// Mongolian (Cyrillic, Mongolia)
        /// </summary>
        [Culture("mn-MN")]
        MongolianCyrillic_Mongolia,

        /// <summary>
        /// Mongolian (Traditional Mongolian)
        /// </summary>
        [Culture("mn-Mong")]
        MongolianTraditionalMongolian,

        /// <summary>
        /// Mongolian (Traditional Mongolian, China)
        /// </summary>
        [Culture("mn-Mong-CN")]
        MongolianTraditionalMongolian_China,

        /// <summary>
        /// Mongolian (Traditional Mongolian, Mongolia)
        /// </summary>
        [Culture("mn-Mong-MN")]
        MongolianTraditionalMongolian_Mongolia,

        /// <summary>
        /// Mohawk
        /// </summary>
        [Culture("moh")]
        Mohawk,

        /// <summary>
        /// Mohawk (Mohawk)
        /// </summary>
        [Culture("moh-CA")]
        MohawkMohawk,

        /// <summary>
        /// Marathi
        /// </summary>
        [Culture("mr")]
        Marathi,

        /// <summary>
        /// Marathi (India)
        /// </summary>
        [Culture("mr-IN")]
        MarathiIndia,

        /// <summary>
        /// Malay
        /// </summary>
        [Culture("ms")]
        Malay,

        /// <summary>
        /// Malay (Brunei Darussalam)
        /// </summary>
        [Culture("ms-BN")]
        MalayBruneiDarussalam,

        /// <summary>
        /// Malay (Malaysia)
        /// </summary>
        [Culture("ms-MY")]
        MalayMalaysia,

        /// <summary>
        /// Maltese
        /// </summary>
        [Culture("mt")]
        Maltese,

        /// <summary>
        /// Maltese (Malta)
        /// </summary>
        [Culture("mt-MT")]
        MalteseMalta,

        /// <summary>
        /// Burmese
        /// </summary>
        [Culture("my")]
        Burmese,

        /// <summary>
        /// Burmese (Myanmar)
        /// </summary>
        [Culture("my-MM")]
        BurmeseMyanmar,

        /// <summary>
        /// Norwegian (Bokmål)
        /// </summary>
        [Culture("nb")]
        NorwegianBokmål,

        /// <summary>
        /// Norwegian, Bokmål (Norway)
        /// </summary>
        [Culture("nb-NO")]
        Norwegian_BokmålNorway,

        /// <summary>
        /// Nepali
        /// </summary>
        [Culture("ne")]
        Nepali,

        /// <summary>
        /// Nepali (India)
        /// </summary>
        [Culture("ne-IN")]
        NepaliIndia,

        /// <summary>
        /// Nepali (Nepal)
        /// </summary>
        [Culture("ne-NP")]
        NepaliNepal,

        /// <summary>
        /// Dutch
        /// </summary>
        [Culture("nl")]
        Dutch,

        /// <summary>
        /// Dutch (Belgium)
        /// </summary>
        [Culture("nl-BE")]
        DutchBelgium,

        /// <summary>
        /// Dutch (Netherlands)
        /// </summary>
        [Culture("nl-NL")]
        DutchNetherlands,

        /// <summary>
        /// Norwegian (Nynorsk)
        /// </summary>
        [Culture("nn")]
        NorwegianNynorsk,

        /// <summary>
        /// Norwegian, Nynorsk (Norway)
        /// </summary>
        [Culture("nn-NO")]
        Norwegian_NynorskNorway,

        /// <summary>
        /// Norwegian
        /// </summary>
        [Culture("no")]
        Norwegian,

        /// <summary>
        /// N'ko
        /// </summary>
        [Culture("nqo")]
        N_ko,

        /// <summary>
        /// N'ko (Guinea)
        /// </summary>
        [Culture("nqo-GN")]
        N_koGuinea,

        /// <summary>
        /// Sesotho sa Leboa
        /// </summary>
        [Culture("nso")]
        SesothosaLeboa,

        /// <summary>
        /// Sesotho sa Leboa (South Africa)
        /// </summary>
        [Culture("nso-ZA")]
        SesothosaLeboaSouthAfrica,

        /// <summary>
        /// Occitan
        /// </summary>
        [Culture("oc")]
        Occitan,

        /// <summary>
        /// Occitan (France)
        /// </summary>
        [Culture("oc-FR")]
        OccitanFrance,

        /// <summary>
        /// Oromo
        /// </summary>
        [Culture("om")]
        Oromo,

        /// <summary>
        /// Oromo (Ethiopia)
        /// </summary>
        [Culture("om-ET")]
        OromoEthiopia,

        /// <summary>
        /// Odia
        /// </summary>
        [Culture("or")]
        Odia,

        /// <summary>
        /// Odia (India)
        /// </summary>
        [Culture("or-IN")]
        OdiaIndia,

        /// <summary>
        /// Punjabi
        /// </summary>
        [Culture("pa")]
        Punjabi,

        /// <summary>
        /// Punjabi
        /// </summary>
        [Culture("pa-Arab")]
        Punjabi_Arabe,

        /// <summary>
        /// Punjabi (Pakistan)
        /// </summary>
        [Culture("pa-Arab-PK")]
        PunjabiPakistan,

        /// <summary>
        /// Punjabi (India)
        /// </summary>
        [Culture("pa-IN")]
        PunjabiIndia,

        /// <summary>
        /// Polish
        /// </summary>
        [Culture("pl")]
        Polish,

        /// <summary>
        /// Polish (Poland)
        /// </summary>
        [Culture("pl-PL")]
        PolishPoland,

        /// <summary>
        /// Dari
        /// </summary>
        [Culture("prs")]
        Dari,

        /// <summary>
        /// Dari (Afghanistan)
        /// </summary>
        [Culture("prs-AF")]
        DariAfghanistan,

        /// <summary>
        /// Pashto
        /// </summary>
        [Culture("ps")]
        Pashto,

        /// <summary>
        /// Pashto (Afghanistan)
        /// </summary>
        [Culture("ps-AF")]
        PashtoAfghanistan,

        /// <summary>
        /// Portuguese
        /// </summary>
        [Culture("pt")]
        Portuguese,

        /// <summary>
        /// Portuguese (Angola)
        /// </summary>
        [Culture("pt-AO")]
        PortugueseAngola,

        /// <summary>
        /// Portuguese (Brazil)
        /// </summary>
        [Culture("pt-BR")]
        PortugueseBrazil,

        /// <summary>
        /// Portuguese (Portugal)
        /// </summary>
        [Culture("pt-PT")]
        PortuguesePortugal,

        /// <summary>
        /// K'iche'
        /// </summary>
        [Culture("qut")]
        K_iche,

        /// <summary>
        /// K'iche' (Guatemala)
        /// </summary>
        [Culture("qut-GT")]
        K_iche_Guatemala,

        /// <summary>
        /// Quechua
        /// </summary>
        [Culture("quz")]
        Quechua,

        /// <summary>
        /// Quechua (Bolivia)
        /// </summary>
        [Culture("quz-BO")]
        QuechuaBolivia,

        /// <summary>
        /// Quichua (Ecuador)
        /// </summary>
        [Culture("quz-EC")]
        QuichuaEcuador,

        /// <summary>
        /// Quechua (Peru)
        /// </summary>
        [Culture("quz-PE")]
        QuechuaPeru,

        /// <summary>
        /// Romansh
        /// </summary>
        [Culture("rm")]
        Romansh,

        /// <summary>
        /// Romansh (Switzerland)
        /// </summary>
        [Culture("rm-CH")]
        RomanshSwitzerland,

        /// <summary>
        /// Romanian
        /// </summary>
        [Culture("ro")]
        Romanian,

        /// <summary>
        /// Romanian (Moldova)
        /// </summary>
        [Culture("ro-MD")]
        RomanianMoldova,

        /// <summary>
        /// Romanian (Romania)
        /// </summary>
        [Culture("ro-RO")]
        RomanianRomania,

        /// <summary>
        /// Russian
        /// </summary>
        [Culture("ru")]
        Russian,

        /// <summary>
        /// Russian (Russia)
        /// </summary>
        [Culture("ru-RU")]
        RussianRussia,

        /// <summary>
        /// Kinyarwanda
        /// </summary>
        [Culture("rw")]
        Kinyarwanda,

        /// <summary>
        /// Kinyarwanda (Rwanda)
        /// </summary>
        [Culture("rw-RW")]
        KinyarwandaRwanda,

        /// <summary>
        /// Sanskrit
        /// </summary>
        [Culture("sa")]
        Sanskrit,

        /// <summary>
        /// Sanskrit (India)
        /// </summary>
        [Culture("sa-IN")]
        SanskritIndia,

        /// <summary>
        /// Sakha
        /// </summary>
        [Culture("sah")]
        Sakha,

        /// <summary>
        /// Sakha (Russia)
        /// </summary>
        [Culture("sah-RU")]
        SakhaRussia,

        /// <summary>
        /// Sindhi
        /// </summary>
        [Culture("sd")]
        Sindhi,

        /// <summary>
        /// Sindhi
        /// </summary>
        [Culture("sd-Arab")]
        Sindhi_Arabe,

        /// <summary>
        /// Sindhi (Pakistan)
        /// </summary>
        [Culture("sd-Arab-PK")]
        SindhiPakistan,

        /// <summary>
        /// Sami (Northern)
        /// </summary>
        [Culture("se")]
        SamiNorthern,

        /// <summary>
        /// Sami, Northern (Finland)
        /// </summary>
        [Culture("se-FI")]
        Sami_NorthernFinland,

        /// <summary>
        /// Sami, Northern (Norway)
        /// </summary>
        [Culture("se-NO")]
        Sami_NorthernNorway,

        /// <summary>
        /// Sami, Northern (Sweden)
        /// </summary>
        [Culture("se-SE")]
        Sami_NorthernSweden,

        /// <summary>
        /// Sinhala
        /// </summary>
        [Culture("si")]
        Sinhala,

        /// <summary>
        /// Sinhala (Sri Lanka)
        /// </summary>
        [Culture("si-LK")]
        SinhalaSriLanka,

        /// <summary>
        /// Slovak
        /// </summary>
        [Culture("sk")]
        Slovak,

        /// <summary>
        /// Slovak (Slovakia)
        /// </summary>
        [Culture("sk-SK")]
        SlovakSlovakia,

        /// <summary>
        /// Slovenian
        /// </summary>
        [Culture("sl")]
        Slovenian,

        /// <summary>
        /// Slovenian (Slovenia)
        /// </summary>
        [Culture("sl-SI")]
        SlovenianSlovenia,

        /// <summary>
        /// Sami (Southern)
        /// </summary>
        [Culture("sma")]
        SamiSouthern,

        /// <summary>
        /// Sami, Southern (Norway)
        /// </summary>
        [Culture("sma-NO")]
        Sami_SouthernNorway,

        /// <summary>
        /// Sami, Southern (Sweden)
        /// </summary>
        [Culture("sma-SE")]
        Sami_SouthernSweden,

        /// <summary>
        /// Sami (Lule)
        /// </summary>
        [Culture("smj")]
        SamiLule,

        /// <summary>
        /// Sami, Lule (Norway)
        /// </summary>
        [Culture("smj-NO")]
        Sami_LuleNorway,

        /// <summary>
        /// Sami, Lule (Sweden)
        /// </summary>
        [Culture("smj-SE")]
        Sami_LuleSweden,

        /// <summary>
        /// Sami (Inari)
        /// </summary>
        [Culture("smn")]
        SamiInari,

        /// <summary>
        /// Sami, Inari (Finland)
        /// </summary>
        [Culture("smn-FI")]
        Sami_InariFinland,

        /// <summary>
        /// Sami (Skolt)
        /// </summary>
        [Culture("sms")]
        SamiSkolt,

        /// <summary>
        /// Sami, Skolt (Finland)
        /// </summary>
        [Culture("sms-FI")]
        Sami_SkoltFinland,

        /// <summary>
        /// Shona
        /// </summary>
        [Culture("sn")]
        Shona,

        /// <summary>
        /// Shona (Latin)
        /// </summary>
        [Culture("sn-Latn")]
        ShonaLatin,

        /// <summary>
        /// Shona (Latin, Zimbabwe)
        /// </summary>
        [Culture("sn-Latn-ZW")]
        ShonaLatin_Zimbabwe,

        /// <summary>
        /// Somali
        /// </summary>
        [Culture("so")]
        Somali,

        /// <summary>
        /// Somali (Somalia)
        /// </summary>
        [Culture("so-SO")]
        SomaliSomalia,

        /// <summary>
        /// Albanian
        /// </summary>
        [Culture("sq")]
        Albanian,

        /// <summary>
        /// Albanian (Albania)
        /// </summary>
        [Culture("sq-AL")]
        AlbanianAlbania,

        /// <summary>
        /// Serbian
        /// </summary>
        [Culture("sr")]
        Serbian,

        /// <summary>
        /// Serbian (Cyrillic)
        /// </summary>
        [Culture("sr-Cyrl")]
        SerbianCyrillic,

        /// <summary>
        /// Serbian (Cyrillic, Bosnia and Herzegovina)
        /// </summary>
        [Culture("sr-Cyrl-BA")]
        SerbianCyrillic_BosniaandHerzegovina,

        /// <summary>
        /// Serbian (Cyrillic, Serbia and Montenegro (Former))
        /// </summary>
        [Culture("sr-Cyrl-CS")]
        SerbianCyrillic_SerbiaandMontenegroFormer,

        /// <summary>
        /// Serbian (Cyrillic, Montenegro)
        /// </summary>
        [Culture("sr-Cyrl-ME")]
        SerbianCyrillic_Montenegro,

        /// <summary>
        /// Serbian (Cyrillic, Serbia)
        /// </summary>
        [Culture("sr-Cyrl-RS")]
        SerbianCyrillic_Serbia,

        /// <summary>
        /// Serbian (Latin)
        /// </summary>
        [Culture("sr-Latn")]
        SerbianLatin,

        /// <summary>
        /// Serbian (Latin, Bosnia and Herzegovina)
        /// </summary>
        [Culture("sr-Latn-BA")]
        SerbianLatin_BosniaandHerzegovina,

        /// <summary>
        /// Serbian (Latin, Serbia and Montenegro (Former))
        /// </summary>
        [Culture("sr-Latn-CS")]
        SerbianLatin_SerbiaandMontenegroFormer,

        /// <summary>
        /// Serbian (Latin, Montenegro)
        /// </summary>
        [Culture("sr-Latn-ME")]
        SerbianLatin_Montenegro,

        /// <summary>
        /// Serbian (Latin, Serbia)
        /// </summary>
        [Culture("sr-Latn-RS")]
        SerbianLatin_Serbia,

        /// <summary>
        /// Southern Sotho
        /// </summary>
        [Culture("st")]
        SouthernSotho,

        /// <summary>
        /// Southern Sotho (South Africa)
        /// </summary>
        [Culture("st-ZA")]
        SouthernSothoSouthAfrica,

        /// <summary>
        /// Swedish
        /// </summary>
        [Culture("sv")]
        Swedish,

        /// <summary>
        /// Swedish (Finland)
        /// </summary>
        [Culture("sv-FI")]
        SwedishFinland,

        /// <summary>
        /// Swedish (Sweden)
        /// </summary>
        [Culture("sv-SE")]
        SwedishSweden,

        /// <summary>
        /// Kiswahili
        /// </summary>
        [Culture("sw")]
        Kiswahili,

        /// <summary>
        /// Kiswahili (Kenya)
        /// </summary>
        [Culture("sw-KE")]
        KiswahiliKenya,

        /// <summary>
        /// Syriac
        /// </summary>
        [Culture("syr")]
        Syriac,

        /// <summary>
        /// Syriac (Syria)
        /// </summary>
        [Culture("syr-SY")]
        SyriacSyria,

        /// <summary>
        /// Tamil
        /// </summary>
        [Culture("ta")]
        Tamil,

        /// <summary>
        /// Tamil (India)
        /// </summary>
        [Culture("ta-IN")]
        TamilIndia,

        /// <summary>
        /// Tamil (Sri Lanka)
        /// </summary>
        [Culture("ta-LK")]
        TamilSriLanka,

        /// <summary>
        /// Telugu
        /// </summary>
        [Culture("te")]
        Telugu,

        /// <summary>
        /// Telugu (India)
        /// </summary>
        [Culture("te-IN")]
        TeluguIndia,

        /// <summary>
        /// Tajik
        /// </summary>
        [Culture("tg")]
        Tajik,

        /// <summary>
        /// Tajik (Cyrillic)
        /// </summary>
        [Culture("tg-Cyrl")]
        TajikCyrillic,

        /// <summary>
        /// Tajik (Cyrillic, Tajikistan)
        /// </summary>
        [Culture("tg-Cyrl-TJ")]
        TajikCyrillic_Tajikistan,

        /// <summary>
        /// Thai
        /// </summary>
        [Culture("th")]
        Thai,

        /// <summary>
        /// Thai (Thailand)
        /// </summary>
        [Culture("th-TH")]
        ThaiThailand,

        /// <summary>
        /// Tigrinya
        /// </summary>
        [Culture("ti")]
        Tigrinya,

        /// <summary>
        /// Tigrinya (Eritrea)
        /// </summary>
        [Culture("ti-ER")]
        TigrinyaEritrea,

        /// <summary>
        /// Tigrinya (Ethiopia)
        /// </summary>
        [Culture("ti-ET")]
        TigrinyaEthiopia,

        /// <summary>
        /// Turkmen
        /// </summary>
        [Culture("tk")]
        Turkmen,

        /// <summary>
        /// Turkmen (Turkmenistan)
        /// </summary>
        [Culture("tk-TM")]
        TurkmenTurkmenistan,

        /// <summary>
        /// Setswana
        /// </summary>
        [Culture("tn")]
        Setswana,

        /// <summary>
        /// Setswana (Botswana)
        /// </summary>
        [Culture("tn-BW")]
        SetswanaBotswana,

        /// <summary>
        /// Setswana (South Africa)
        /// </summary>
        [Culture("tn-ZA")]
        SetswanaSouthAfrica,

        /// <summary>
        /// Turkish
        /// </summary>
        [Culture("tr")]
        Turkish,

        /// <summary>
        /// Turkish (Turkey)
        /// </summary>
        [Culture("tr-TR")]
        TurkishTurkey,

        /// <summary>
        /// Tsonga
        /// </summary>
        [Culture("ts")]
        Tsonga,

        /// <summary>
        /// Tsonga (South Africa)
        /// </summary>
        [Culture("ts-ZA")]
        TsongaSouthAfrica,

        /// <summary>
        /// Tatar
        /// </summary>
        [Culture("tt")]
        Tatar,

        /// <summary>
        /// Tatar (Russia)
        /// </summary>
        [Culture("tt-RU")]
        TatarRussia,

        /// <summary>
        /// Tamazight
        /// </summary>
        [Culture("tzm")]
        Tamazight,

        /// <summary>
        /// Central Atlas Tamazight (Latin)
        /// </summary>
        [Culture("tzm-Latn")]
        CentralAtlasTamazightLatin,

        /// <summary>
        /// Central Atlas Tamazight (Latin, Algeria)
        /// </summary>
        [Culture("tzm-Latn-DZ")]
        CentralAtlasTamazightLatin_Algeria,

        /// <summary>
        /// Central Atlas Tamazight (Tifinagh)
        /// </summary>
        [Culture("tzm-Tfng")]
        CentralAtlasTamazightTifinagh,

        /// <summary>
        /// Central Atlas Tamazight (Tifinagh, Morocco)
        /// </summary>
        [Culture("tzm-Tfng-MA")]
        CentralAtlasTamazightTifinagh_Morocco,

        /// <summary>
        /// Uyghur
        /// </summary>
        [Culture("ug")]
        Uyghur,

        /// <summary>
        /// Uyghur (China)
        /// </summary>
        [Culture("ug-CN")]
        UyghurChina,

        /// <summary>
        /// Ukrainian
        /// </summary>
        [Culture("uk")]
        Ukrainian,

        /// <summary>
        /// Ukrainian (Ukraine)
        /// </summary>
        [Culture("uk-UA")]
        UkrainianUkraine,

        /// <summary>
        /// Urdu
        /// </summary>
        [Culture("ur")]
        Urdu,

        /// <summary>
        /// Urdu (India)
        /// </summary>
        [Culture("ur-IN")]
        UrduIndia,

        /// <summary>
        /// Urdu (Pakistan)
        /// </summary>
        [Culture("ur-PK")]
        UrduPakistan,

        /// <summary>
        /// Uzbek
        /// </summary>
        [Culture("uz")]
        Uzbek,

        /// <summary>
        /// Uzbek (Cyrillic)
        /// </summary>
        [Culture("uz-Cyrl")]
        UzbekCyrillic,

        /// <summary>
        /// Uzbek (Cyrillic, Uzbekistan)
        /// </summary>
        [Culture("uz-Cyrl-UZ")]
        UzbekCyrillic_Uzbekistan,

        /// <summary>
        /// Uzbek (Latin)
        /// </summary>
        [Culture("uz-Latn")]
        UzbekLatin,

        /// <summary>
        /// Uzbek (Latin, Uzbekistan)
        /// </summary>
        [Culture("uz-Latn-UZ")]
        UzbekLatin_Uzbekistan,

        /// <summary>
        /// Vietnamese
        /// </summary>
        [Culture("vi")]
        Vietnamese,

        /// <summary>
        /// Vietnamese (Vietnam)
        /// </summary>
        [Culture("vi-VN")]
        VietnameseVietnam,

        /// <summary>
        /// Wolof
        /// </summary>
        [Culture("wo")]
        Wolof,

        /// <summary>
        /// Wolof (Senegal)
        /// </summary>
        [Culture("wo-SN")]
        WolofSenegal,

        /// <summary>
        /// isiXhosa
        /// </summary>
        [Culture("xh")]
        isiXhosa,

        /// <summary>
        /// isiXhosa (South Africa)
        /// </summary>
        [Culture("xh-ZA")]
        isiXhosaSouthAfrica,

        /// <summary>
        /// Yoruba
        /// </summary>
        [Culture("yo")]
        Yoruba,

        /// <summary>
        /// Yoruba (Nigeria)
        /// </summary>
        [Culture("yo-NG")]
        YorubaNigeria,

        /// <summary>
        /// Standard Morrocan Tamazight
        /// </summary>
        [Culture("zgh")]
        StandardMorrocanTamazight,

        /// <summary>
        /// Standard Morrocan Tamazight (Tifinagh)
        /// </summary>
        [Culture("zgh-Tfng")]
        StandardMorrocanTamazightTifinagh,

        /// <summary>
        /// Standard Morrocan Tamazight (Tifinagh, Morocco)
        /// </summary>
        [Culture("zgh-Tfng-MA")]
        StandardMorrocanTamazightTifinagh_Morocco,

        /// <summary>
        /// Chinese
        /// </summary>
        [Culture("zh")]
        Chinese,

        /// <summary>
        /// Chinese (Simplified, China)
        /// </summary>
        [Culture("zh-CN")]
        ChineseSimplified_China,

        /// <summary>
        /// Chinese (Simplified)
        /// </summary>
        [Culture("zh-Hans")]
        ChineseSimplified,

        /// <summary>
        /// Chinese (Traditional)
        /// </summary>
        [Culture("zh-Hant")]
        ChineseTraditional,

        /// <summary>
        /// Chinese (Traditional, Hong Kong SAR)
        /// </summary>
        [Culture("zh-HK")]
        ChineseTraditional_HongKongSAR,

        /// <summary>
        /// Chinese (Traditional, Macao SAR)
        /// </summary>
        [Culture("zh-MO")]
        ChineseTraditional_MacaoSAR,

        /// <summary>
        /// Chinese (Simplified, Singapore)
        /// </summary>
        [Culture("zh-SG")]
        ChineseSimplified_Singapore,

        /// <summary>
        /// Chinese (Traditional, Taiwan)
        /// </summary>
        [Culture("zh-TW")]
        ChineseTraditional_Taiwan,

        /// <summary>
        /// isiZulu
        /// </summary>
        [Culture("zu")]
        isiZulu,

        /// <summary>
        /// isiZulu (South Africa)
        /// </summary>
        [Culture("zu-ZA")]
        isiZuluSouthAfrica,

        /// <summary>
        /// Chinese (Simplified) Legacy
        /// </summary>
        [Culture("zh-Hans")]
        ChineseSimplifiedLegacy,

        /// <summary>
        /// Chinese (Traditional) Legacy
        /// </summary>
        [Culture("zh-Hant")]
        ChineseTraditionalLegacy,


    }

}