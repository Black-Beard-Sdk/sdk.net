using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    public enum CultureEnum
    {

        [Culture("")]
        [Description("Invariant Language Invariant Country")]
        Invariant_Language_Invariant_Country,

        [Culture("aa")]
        [Description("Afar")]
        Afar,

        [Culture("aa-DJ")]
        [Description("Afar Djibouti")]
        Afar_Djibouti,

        [Culture("aa-ER")]
        [Description("Afar Eritrea")]
        Afar_Eritrea,

        [Culture("aa-ET")]
        [Description("Afar Ethiopia")]
        Afar_Ethiopia,

        [Culture("af")]
        [Description("Afrikaans")]
        Afrikaans,

        [Culture("af-NA")]
        [Description("Afrikaans Namibia")]
        Afrikaans_Namibia,

        [Culture("af-ZA")]
        [Description("Afrikaans South Africa")]
        Afrikaans_South_Africa,

        [Culture("agq")]
        [Description("Aghem")]
        Aghem,

        [Culture("agq-CM")]
        [Description("Aghem Cameroon")]
        Aghem_Cameroon,

        [Culture("ak")]
        [Description("Akan")]
        Akan,

        [Culture("ak-GH")]
        [Description("Akan Ghana")]
        Akan_Ghana,

        [Culture("am")]
        [Description("Amharic")]
        Amharic,

        [Culture("am-ET")]
        [Description("Amharic Ethiopia")]
        Amharic_Ethiopia,

        [Culture("ar")]
        [Description("Arabic")]
        Arabic,

        [Culture("ar-001")]
        [Description("Arabic World")]
        Arabic_World,

        [Culture("ar-AE")]
        [Description("Arabic United Arab Emirates")]
        Arabic_United_Arab_Emirates,

        [Culture("ar-BH")]
        [Description("Arabic Bahrain")]
        Arabic_Bahrain,

        [Culture("ar-DJ")]
        [Description("Arabic Djibouti")]
        Arabic_Djibouti,

        [Culture("ar-DZ")]
        [Description("Arabic Algeria")]
        Arabic_Algeria,

        [Culture("ar-EG")]
        [Description("Arabic Egypt")]
        Arabic_Egypt,

        [Culture("ar-ER")]
        [Description("Arabic Eritrea")]
        Arabic_Eritrea,

        [Culture("ar-IL")]
        [Description("Arabic Israel")]
        Arabic_Israel,

        [Culture("ar-IQ")]
        [Description("Arabic Iraq")]
        Arabic_Iraq,

        [Culture("ar-JO")]
        [Description("Arabic Jordan")]
        Arabic_Jordan,

        [Culture("ar-KM")]
        [Description("Arabic Comoros")]
        Arabic_Comoros,

        [Culture("ar-KW")]
        [Description("Arabic Kuwait")]
        Arabic_Kuwait,

        [Culture("ar-LB")]
        [Description("Arabic Lebanon")]
        Arabic_Lebanon,

        [Culture("ar-LY")]
        [Description("Arabic Libya")]
        Arabic_Libya,

        [Culture("ar-MA")]
        [Description("Arabic Morocco")]
        Arabic_Morocco,

        [Culture("ar-MR")]
        [Description("Arabic Mauritania")]
        Arabic_Mauritania,

        [Culture("ar-OM")]
        [Description("Arabic Oman")]
        Arabic_Oman,

        [Culture("ar-PS")]
        [Description("Arabic Palestinian Authority")]
        Arabic_Palestinian_Authority,

        [Culture("ar-QA")]
        [Description("Arabic Qatar")]
        Arabic_Qatar,

        [Culture("ar-SA")]
        [Description("Arabic Saudi Arabia")]
        Arabic_Saudi_Arabia,

        [Culture("ar-SD")]
        [Description("Arabic Sudan")]
        Arabic_Sudan,

        [Culture("ar-SO")]
        [Description("Arabic Somalia")]
        Arabic_Somalia,

        [Culture("ar-SS")]
        [Description("Arabic South Sudan")]
        Arabic_South_Sudan,

        [Culture("ar-SY")]
        [Description("Arabic Syria")]
        Arabic_Syria,

        [Culture("ar-TD")]
        [Description("Arabic Chad")]
        Arabic_Chad,

        [Culture("ar-TN")]
        [Description("Arabic Tunisia")]
        Arabic_Tunisia,

        [Culture("ar-YE")]
        [Description("Arabic Yemen")]
        Arabic_Yemen,

        [Culture("arn")]
        [Description("Mapuche")]
        Mapuche,

        [Culture("arn-CL")]
        [Description("Mapuche Chile")]
        Mapuche_Chile,

        [Culture("as")]
        [Description("Assamese")]
        Assamese,

        [Culture("as-IN")]
        [Description("Assamese India")]
        Assamese_India,

        [Culture("asa")]
        [Description("Asu")]
        Asu,

        [Culture("asa-TZ")]
        [Description("Asu Tanzania")]
        Asu_Tanzania,

        [Culture("ast")]
        [Description("Asturian")]
        Asturian,

        [Culture("ast-ES")]
        [Description("Asturian Spain")]
        Asturian_Spain,

        [Culture("az")]
        [Description("Azerbaijani")]
        Azerbaijani,

        [Culture("az-Cyrl")]
        [Description("Azerbaijani")]
        Azerbaijani_Cyrl,

        [Culture("az-Cyrl-AZ")]
        [Description("Azerbaijani Cyrillic, Azerbaijan")]
        Azerbaijani_Cyrillic_Azerbaijan,

        [Culture("az-Latn")]
        [Description("Azerbaijani")]
        Azerbaijani_Latn,

        [Culture("az-Latn-AZ")]
        [Description("Azerbaijani Latin, Azerbaijan")]
        Azerbaijani_Latin_Azerbaijan,

        [Culture("ba")]
        [Description("Bashkir")]
        Bashkir,

        [Culture("ba-RU")]
        [Description("Bashkir Russia")]
        Bashkir_Russia,

        [Culture("bas")]
        [Description("Basaa")]
        Basaa,

        [Culture("bas-CM")]
        [Description("Basaa Cameroon")]
        Basaa_Cameroon,

        [Culture("be")]
        [Description("Belarusian")]
        Belarusian,

        [Culture("be-BY")]
        [Description("Belarusian Belarus")]
        Belarusian_Belarus,

        [Culture("bem")]
        [Description("Bemba")]
        Bemba,

        [Culture("bem-ZM")]
        [Description("Bemba Zambia")]
        Bemba_Zambia,

        [Culture("bez")]
        [Description("Bena")]
        Bena,

        [Culture("bez-TZ")]
        [Description("Bena Tanzania")]
        Bena_Tanzania,

        [Culture("bg")]
        [Description("Bulgarian")]
        Bulgarian,

        [Culture("bg-BG")]
        [Description("Bulgarian Bulgaria")]
        Bulgarian_Bulgaria,

        [Culture("bm")]
        [Description("Bamanankan")]
        Bamanankan,

        [Culture("bm-Latn-ML")]
        [Description("Bamanankan Latin, Mali")]
        Bamanankan_Latin_Mali,

        [Culture("bn")]
        [Description("Bangla")]
        Bangla,

        [Culture("bn-BD")]
        [Description("Bangla Bangladesh")]
        Bangla_Bangladesh,

        [Culture("bn-IN")]
        [Description("Bangla India")]
        Bangla_India,

        [Culture("bo")]
        [Description("Tibetan")]
        Tibetan,

        [Culture("bo-CN")]
        [Description("Tibetan China")]
        Tibetan_China,

        [Culture("bo-IN")]
        [Description("Tibetan India")]
        Tibetan_India,

        [Culture("br")]
        [Description("Breton")]
        Breton,

        [Culture("br-FR")]
        [Description("Breton France")]
        Breton_France,

        [Culture("brx")]
        [Description("Bodo")]
        Bodo,

        [Culture("brx-IN")]
        [Description("Bodo India")]
        Bodo_India,

        [Culture("bs")]
        [Description("Bosnian")]
        Bosnian,

        [Culture("bs-Cyrl")]
        [Description("Bosnian")]
        Bosnian_Cyrl,

        [Culture("bs-Cyrl-BA")]
        [Description("Bosnian Cyrillic, Bosnia & Herzegovina")]
        Bosnian_Cyrillic_Bosnia_Herzegovina,

        [Culture("bs-Latn")]
        [Description("Bosnian")]
        Bosnian_Latn,

        [Culture("bs-Latn-BA")]
        [Description("Bosnian Latin, Bosnia & Herzegovina")]
        Bosnian_Latin_Bosnia_Herzegovina,

        [Culture("byn")]
        [Description("Blin")]
        Blin,

        [Culture("byn-ER")]
        [Description("Blin Eritrea")]
        Blin_Eritrea,

        [Culture("ca")]
        [Description("Catalan")]
        Catalan,

        [Culture("ca-AD")]
        [Description("Catalan Andorra")]
        Catalan_Andorra,

        [Culture("ca-ES")]
        [Description("Catalan Spain")]
        Catalan_Spain,

        [Culture("ca-ES-valencia")]
        [Description("Catalan Spain, Valencian")]
        Catalan_Spain_Valencian,

        [Culture("ca-FR")]
        [Description("Catalan France")]
        Catalan_France,

        [Culture("ca-IT")]
        [Description("Catalan Italy")]
        Catalan_Italy,

        [Culture("ccp")]
        [Description("Chakma")]
        Chakma,

        [Culture("ccp-Cakm-BD")]
        [Description("Chakma Chakma, Bangladesh")]
        Chakma_Chakma_Bangladesh,

        [Culture("ccp-Cakm-IN")]
        [Description("Chakma Chakma, India")]
        Chakma_Chakma_India,

        [Culture("ce")]
        [Description("Chechen")]
        Chechen,

        [Culture("ce-RU")]
        [Description("Chechen Russia")]
        Chechen_Russia,

        [Culture("ceb")]
        [Description("Cebuano")]
        Cebuano,

        [Culture("ceb-Latn-PH")]
        [Description("Cebuano Latin, Philippines")]
        Cebuano_Latin_Philippines,

        [Culture("cgg")]
        [Description("Chiga")]
        Chiga,

        [Culture("cgg-UG")]
        [Description("Chiga Uganda")]
        Chiga_Uganda,

        [Culture("chr")]
        [Description("Cherokee")]
        Cherokee,

        [Culture("chr-Cher-US")]
        [Description("Cherokee Cherokee, United States")]
        Cherokee_Cherokee_United_States,

        [Culture("ku")]
        [Description("Kurdish")]
        Kurdish,

        [Culture("ku-Arab-IQ")]
        [Description("Kurdish Arabic, Iraq")]
        Kurdish_Arabic_Iraq,

        [Culture("ku-Arab-IR")]
        [Description("Kurdish Arabic, Iran")]
        Kurdish_Arabic_Iran,

        [Culture("co")]
        [Description("Corsican")]
        Corsican,

        [Culture("co-FR")]
        [Description("Corsican France")]
        Corsican_France,

        [Culture("cs")]
        [Description("Czech")]
        Czech,

        [Culture("cs-CZ")]
        [Description("Czech Czechia")]
        Czech_Czechia,

        [Culture("cu")]
        [Description("Church Slavic")]
        Church_Slavic,

        [Culture("cu-RU")]
        [Description("Church Slavic Russia")]
        Church_Slavic_Russia,

        [Culture("cy")]
        [Description("Welsh")]
        Welsh,

        [Culture("cy-GB")]
        [Description("Welsh United Kingdom")]
        Welsh_United_Kingdom,

        [Culture("da")]
        [Description("Danish")]
        Danish,

        [Culture("da-DK")]
        [Description("Danish Denmark")]
        Danish_Denmark,

        [Culture("da-GL")]
        [Description("Danish Greenland")]
        Danish_Greenland,

        [Culture("dav")]
        [Description("Taita")]
        Taita,

        [Culture("dav-KE")]
        [Description("Taita Kenya")]
        Taita_Kenya,

        [Culture("de")]
        [Description("German")]
        German,

        [Culture("de-AT")]
        [Description("German Austria")]
        German_Austria,

        [Culture("de-BE")]
        [Description("German Belgium")]
        German_Belgium,

        [Culture("de-CH")]
        [Description("German Switzerland")]
        German_Switzerland,

        [Culture("de-DE")]
        [Description("German Germany")]
        German_Germany,

        [Culture("de-IT")]
        [Description("German Italy")]
        German_Italy,

        [Culture("de-LI")]
        [Description("German Liechtenstein")]
        German_Liechtenstein,

        [Culture("de-LU")]
        [Description("German Luxembourg")]
        German_Luxembourg,

        [Culture("dje")]
        [Description("Zarma")]
        Zarma,

        [Culture("dje-NE")]
        [Description("Zarma Niger")]
        Zarma_Niger,

        [Culture("dsb")]
        [Description("Lower Sorbian")]
        Lower_Sorbian,

        [Culture("dsb-DE")]
        [Description("Lower Sorbian Germany")]
        Lower_Sorbian_Germany,

        [Culture("dua")]
        [Description("Duala")]
        Duala,

        [Culture("dua-CM")]
        [Description("Duala Cameroon")]
        Duala_Cameroon,

        [Culture("dv")]
        [Description("Divehi")]
        Divehi,

        [Culture("dv-MV")]
        [Description("Divehi Maldives")]
        Divehi_Maldives,

        [Culture("dyo")]
        [Description("Jola-Fonyi")]
        Jola_Fonyi,

        [Culture("dyo-SN")]
        [Description("Jola-Fonyi Senegal")]
        Jola_Fonyi_Senegal,

        [Culture("dz")]
        [Description("Dzongkha")]
        Dzongkha,

        [Culture("dz-BT")]
        [Description("Dzongkha Bhutan")]
        Dzongkha_Bhutan,

        [Culture("ebu")]
        [Description("Embu")]
        Embu,

        [Culture("ebu-KE")]
        [Description("Embu Kenya")]
        Embu_Kenya,

        [Culture("ee")]
        [Description("Ewe")]
        Ewe,

        [Culture("ee-GH")]
        [Description("Ewe Ghana")]
        Ewe_Ghana,

        [Culture("ee-TG")]
        [Description("Ewe Togo")]
        Ewe_Togo,

        [Culture("el")]
        [Description("Greek")]
        Greek,

        [Culture("el-CY")]
        [Description("Greek Cyprus")]
        Greek_Cyprus,

        [Culture("el-GR")]
        [Description("Greek Greece")]
        Greek_Greece,

        [Culture("en")]
        [Description("English")]
        English,

        [Culture("en-001")]
        [Description("English World")]
        English_World,

        [Culture("en-150")]
        [Description("English Europe")]
        English_Europe,

        [Culture("en-AE")]
        [Description("English United Arab Emirates")]
        English_United_Arab_Emirates,

        [Culture("en-AG")]
        [Description("English Antigua & Barbuda")]
        English_Antigua_Barbuda,

        [Culture("en-AI")]
        [Description("English Anguilla")]
        English_Anguilla,

        [Culture("en-AS")]
        [Description("English American Samoa")]
        English_American_Samoa,

        [Culture("en-AT")]
        [Description("English Austria")]
        English_Austria,

        [Culture("en-AU")]
        [Description("English Australia")]
        English_Australia,

        [Culture("en-BB")]
        [Description("English Barbados")]
        English_Barbados,

        [Culture("en-BE")]
        [Description("English Belgium")]
        English_Belgium,

        [Culture("en-BI")]
        [Description("English Burundi")]
        English_Burundi,

        [Culture("en-BM")]
        [Description("English Bermuda")]
        English_Bermuda,

        [Culture("en-BS")]
        [Description("English Bahamas")]
        English_Bahamas,

        [Culture("en-BW")]
        [Description("English Botswana")]
        English_Botswana,

        [Culture("en-BZ")]
        [Description("English Belize")]
        English_Belize,

        [Culture("en-CA")]
        [Description("English Canada")]
        English_Canada,

        [Culture("en-CC")]
        [Description("English Cocos [Keeling] Islands")]
        English_Cocos_Keeling_Islands,

        [Culture("en-CH")]
        [Description("English Switzerland")]
        English_Switzerland,

        [Culture("en-CK")]
        [Description("English Cook Islands")]
        English_Cook_Islands,

        [Culture("en-CM")]
        [Description("English Cameroon")]
        English_Cameroon,

        [Culture("en-CX")]
        [Description("English Christmas Island")]
        English_Christmas_Island,

        [Culture("en-CY")]
        [Description("English Cyprus")]
        English_Cyprus,

        [Culture("en-DE")]
        [Description("English Germany")]
        English_Germany,

        [Culture("en-DK")]
        [Description("English Denmark")]
        English_Denmark,

        [Culture("en-DM")]
        [Description("English Dominica")]
        English_Dominica,

        [Culture("en-ER")]
        [Description("English Eritrea")]
        English_Eritrea,

        [Culture("en-FI")]
        [Description("English Finland")]
        English_Finland,

        [Culture("en-FJ")]
        [Description("English Fiji")]
        English_Fiji,

        [Culture("en-FK")]
        [Description("English Falkland Islands")]
        English_Falkland_Islands,

        [Culture("en-FM")]
        [Description("English Micronesia")]
        English_Micronesia,

        [Culture("en-GB")]
        [Description("English United Kingdom")]
        English_United_Kingdom,

        [Culture("en-GD")]
        [Description("English Grenada")]
        English_Grenada,

        [Culture("en-GG")]
        [Description("English Guernsey")]
        English_Guernsey,

        [Culture("en-GH")]
        [Description("English Ghana")]
        English_Ghana,

        [Culture("en-GI")]
        [Description("English Gibraltar")]
        English_Gibraltar,

        [Culture("en-GM")]
        [Description("English Gambia")]
        English_Gambia,

        [Culture("en-GU")]
        [Description("English Guam")]
        English_Guam,

        [Culture("en-GY")]
        [Description("English Guyana")]
        English_Guyana,

        [Culture("en-HK")]
        [Description("English Hong Kong SAR")]
        English_Hong_Kong_SAR,

        [Culture("en-IE")]
        [Description("English Ireland")]
        English_Ireland,

        [Culture("en-IL")]
        [Description("English Israel")]
        English_Israel,

        [Culture("en-IM")]
        [Description("English Isle of Man")]
        English_Isle_of_Man,

        [Culture("en-IN")]
        [Description("English India")]
        English_India,

        [Culture("en-IO")]
        [Description("English British Indian Ocean Territory")]
        English_British_Indian_Ocean_Territory,

        [Culture("en-JE")]
        [Description("English Jersey")]
        English_Jersey,

        [Culture("en-JM")]
        [Description("English Jamaica")]
        English_Jamaica,

        [Culture("en-KE")]
        [Description("English Kenya")]
        English_Kenya,

        [Culture("en-KI")]
        [Description("English Kiribati")]
        English_Kiribati,

        [Culture("en-KN")]
        [Description("English St. Kitts & Nevis")]
        English_St_Kitts_Nevis,

        [Culture("en-KY")]
        [Description("English Cayman Islands")]
        English_Cayman_Islands,

        [Culture("en-LC")]
        [Description("English St. Lucia")]
        English_St_Lucia,

        [Culture("en-LR")]
        [Description("English Liberia")]
        English_Liberia,

        [Culture("en-LS")]
        [Description("English Lesotho")]
        English_Lesotho,

        [Culture("en-MG")]
        [Description("English Madagascar")]
        English_Madagascar,

        [Culture("en-MH")]
        [Description("English Marshall Islands")]
        English_Marshall_Islands,

        [Culture("en-MO")]
        [Description("English Macao SAR")]
        English_Macao_SAR,

        [Culture("en-MP")]
        [Description("English Northern Mariana Islands")]
        English_Northern_Mariana_Islands,

        [Culture("en-MS")]
        [Description("English Montserrat")]
        English_Montserrat,

        [Culture("en-MT")]
        [Description("English Malta")]
        English_Malta,

        [Culture("en-MU")]
        [Description("English Mauritius")]
        English_Mauritius,

        [Culture("en-MW")]
        [Description("English Malawi")]
        English_Malawi,

        [Culture("en-MY")]
        [Description("English Malaysia")]
        English_Malaysia,

        [Culture("en-NA")]
        [Description("English Namibia")]
        English_Namibia,

        [Culture("en-NF")]
        [Description("English Norfolk Island")]
        English_Norfolk_Island,

        [Culture("en-NG")]
        [Description("English Nigeria")]
        English_Nigeria,

        [Culture("en-NL")]
        [Description("English Netherlands")]
        English_Netherlands,

        [Culture("en-NR")]
        [Description("English Nauru")]
        English_Nauru,

        [Culture("en-NU")]
        [Description("English Niue")]
        English_Niue,

        [Culture("en-NZ")]
        [Description("English New Zealand")]
        English_New_Zealand,

        [Culture("en-PG")]
        [Description("English Papua New Guinea")]
        English_Papua_New_Guinea,

        [Culture("en-PH")]
        [Description("English Philippines")]
        English_Philippines,

        [Culture("en-PK")]
        [Description("English Pakistan")]
        English_Pakistan,

        [Culture("en-PN")]
        [Description("English Pitcairn Islands")]
        English_Pitcairn_Islands,

        [Culture("en-PR")]
        [Description("English Puerto Rico")]
        English_Puerto_Rico,

        [Culture("en-PW")]
        [Description("English Palau")]
        English_Palau,

        [Culture("en-RW")]
        [Description("English Rwanda")]
        English_Rwanda,

        [Culture("en-SB")]
        [Description("English Solomon Islands")]
        English_Solomon_Islands,

        [Culture("en-SC")]
        [Description("English Seychelles")]
        English_Seychelles,

        [Culture("en-SD")]
        [Description("English Sudan")]
        English_Sudan,

        [Culture("en-SE")]
        [Description("English Sweden")]
        English_Sweden,

        [Culture("en-SG")]
        [Description("English Singapore")]
        English_Singapore,

        [Culture("en-SH")]
        [Description("English St Helena, Ascension, Tristan da Cunha")]
        English_St_Helena_Ascension_Tristan_da_Cunha,

        [Culture("en-SI")]
        [Description("English Slovenia")]
        English_Slovenia,

        [Culture("en-SL")]
        [Description("English Sierra Leone")]
        English_Sierra_Leone,

        [Culture("en-SS")]
        [Description("English South Sudan")]
        English_South_Sudan,

        [Culture("en-SX")]
        [Description("English Sint Maarten")]
        English_Sint_Maarten,

        [Culture("en-SZ")]
        [Description("English Eswatini")]
        English_Eswatini,

        [Culture("en-TC")]
        [Description("English Turks & Caicos Islands")]
        English_Turks_Caicos_Islands,

        [Culture("en-TK")]
        [Description("English Tokelau")]
        English_Tokelau,

        [Culture("en-TO")]
        [Description("English Tonga")]
        English_Tonga,

        [Culture("en-TT")]
        [Description("English Trinidad & Tobago")]
        English_Trinidad_Tobago,

        [Culture("en-TV")]
        [Description("English Tuvalu")]
        English_Tuvalu,

        [Culture("en-TZ")]
        [Description("English Tanzania")]
        English_Tanzania,

        [Culture("en-UG")]
        [Description("English Uganda")]
        English_Uganda,

        [Culture("en-UM")]
        [Description("English U.S. Outlying Islands")]
        English_US_Outlying_Islands,

        [Culture("en-US")]
        [Description("English United States")]
        English_United_States,

        [Culture("en-US-posix")]
        [Description("English United States, Computer")]
        English_United_States_Computer,

        [Culture("en-VC")]
        [Description("English St. Vincent & Grenadines")]
        English_St_Vincent_Grenadines,

        [Culture("en-VG")]
        [Description("English British Virgin Islands")]
        English_British_Virgin_Islands,

        [Culture("en-VI")]
        [Description("English U.S. Virgin Islands")]
        English_US_Virgin_Islands,

        [Culture("en-VU")]
        [Description("English Vanuatu")]
        English_Vanuatu,

        [Culture("en-WS")]
        [Description("English Samoa")]
        English_Samoa,

        [Culture("en-ZA")]
        [Description("English South Africa")]
        English_South_Africa,

        [Culture("en-ZM")]
        [Description("English Zambia")]
        English_Zambia,

        [Culture("en-ZW")]
        [Description("English Zimbabwe")]
        English_Zimbabwe,

        [Culture("eo")]
        [Description("Esperanto")]
        Esperanto,

        [Culture("eo-001")]
        [Description("Esperanto World")]
        Esperanto_World,

        [Culture("es")]
        [Description("Spanish")]
        Spanish,

        [Culture("es-419")]
        [Description("Spanish Latin America")]
        Spanish_Latin_America,

        [Culture("es-AR")]
        [Description("Spanish Argentina")]
        Spanish_Argentina,

        [Culture("es-BO")]
        [Description("Spanish Bolivia")]
        Spanish_Bolivia,

        [Culture("es-BR")]
        [Description("Spanish Brazil")]
        Spanish_Brazil,

        [Culture("es-BZ")]
        [Description("Spanish Belize")]
        Spanish_Belize,

        [Culture("es-CL")]
        [Description("Spanish Chile")]
        Spanish_Chile,

        [Culture("es-CO")]
        [Description("Spanish Colombia")]
        Spanish_Colombia,

        [Culture("es-CR")]
        [Description("Spanish Costa Rica")]
        Spanish_Costa_Rica,

        [Culture("es-CU")]
        [Description("Spanish Cuba")]
        Spanish_Cuba,

        [Culture("es-DO")]
        [Description("Spanish Dominican Republic")]
        Spanish_Dominican_Republic,

        [Culture("es-EC")]
        [Description("Spanish Ecuador")]
        Spanish_Ecuador,

        [Culture("es-ES")]
        [Description("Spanish Spain")]
        Spanish_Spain,

        [Culture("es-GQ")]
        [Description("Spanish Equatorial Guinea")]
        Spanish_Equatorial_Guinea,

        [Culture("es-GT")]
        [Description("Spanish Guatemala")]
        Spanish_Guatemala,

        [Culture("es-HN")]
        [Description("Spanish Honduras")]
        Spanish_Honduras,

        [Culture("es-MX")]
        [Description("Spanish Mexico")]
        Spanish_Mexico,

        [Culture("es-NI")]
        [Description("Spanish Nicaragua")]
        Spanish_Nicaragua,

        [Culture("es-PA")]
        [Description("Spanish Panama")]
        Spanish_Panama,

        [Culture("es-PE")]
        [Description("Spanish Peru")]
        Spanish_Peru,

        [Culture("es-PH")]
        [Description("Spanish Philippines")]
        Spanish_Philippines,

        [Culture("es-PR")]
        [Description("Spanish Puerto Rico")]
        Spanish_Puerto_Rico,

        [Culture("es-PY")]
        [Description("Spanish Paraguay")]
        Spanish_Paraguay,

        [Culture("es-SV")]
        [Description("Spanish El Salvador")]
        Spanish_El_Salvador,

        [Culture("es-US")]
        [Description("Spanish United States")]
        Spanish_United_States,

        [Culture("es-UY")]
        [Description("Spanish Uruguay")]
        Spanish_Uruguay,

        [Culture("es-VE")]
        [Description("Spanish Venezuela")]
        Spanish_Venezuela,

        [Culture("et")]
        [Description("Estonian")]
        Estonian,

        [Culture("et-EE")]
        [Description("Estonian Estonia")]
        Estonian_Estonia,

        [Culture("eu")]
        [Description("Basque")]
        Basque,

        [Culture("eu-ES")]
        [Description("Basque Spain")]
        Basque_Spain,

        [Culture("ewo")]
        [Description("Ewondo")]
        Ewondo,

        [Culture("ewo-CM")]
        [Description("Ewondo Cameroon")]
        Ewondo_Cameroon,

        [Culture("fa")]
        [Description("Persian")]
        Persian,

        [Culture("prs-AF")]
        [Description("prs Afghanistan")]
        prs_Afghanistan,

        [Culture("fa-IR")]
        [Description("Persian Iran")]
        Persian_Iran,

        [Culture("ff")]
        [Description("Fulah")]
        Fulah,

        [Culture("ff-Latn")]
        [Description("Fulah")]
        Fulah_Latn,

        [Culture("ff-Latn-BF")]
        [Description("Fulah Latin, Burkina Faso")]
        Fulah_Latin_Burkina_Faso,

        [Culture("ff-Latn-CM")]
        [Description("Fulah Latin, Cameroon")]
        Fulah_Latin_Cameroon,

        [Culture("ff-Latn-GH")]
        [Description("Fulah Latin, Ghana")]
        Fulah_Latin_Ghana,

        [Culture("ff-Latn-GM")]
        [Description("Fulah Latin, Gambia")]
        Fulah_Latin_Gambia,

        [Culture("ff-Latn-GN")]
        [Description("Fulah Latin, Guinea")]
        Fulah_Latin_Guinea,

        [Culture("ff-Latn-GW")]
        [Description("Fulah Latin, Guinea-Bissau")]
        Fulah_Latin_Guinea_Bissau,

        [Culture("ff-Latn-LR")]
        [Description("Fulah Latin, Liberia")]
        Fulah_Latin_Liberia,

        [Culture("ff-Latn-MR")]
        [Description("Fulah Latin, Mauritania")]
        Fulah_Latin_Mauritania,

        [Culture("ff-Latn-NE")]
        [Description("Fulah Latin, Niger")]
        Fulah_Latin_Niger,

        [Culture("ff-Latn-NG")]
        [Description("Fulah Latin, Nigeria")]
        Fulah_Latin_Nigeria,

        [Culture("ff-Latn-SL")]
        [Description("Fulah Latin, Sierra Leone")]
        Fulah_Latin_Sierra_Leone,

        [Culture("ff-Latn-SN")]
        [Description("Fulah Latin, Senegal")]
        Fulah_Latin_Senegal,

        [Culture("fi")]
        [Description("Finnish")]
        Finnish,

        [Culture("fi-FI")]
        [Description("Finnish Finland")]
        Finnish_Finland,

        [Culture("fil")]
        [Description("Filipino")]
        Filipino,

        [Culture("fil-PH")]
        [Description("Filipino Philippines")]
        Filipino_Philippines,

        [Culture("fo")]
        [Description("Faroese")]
        Faroese,

        [Culture("fo-DK")]
        [Description("Faroese Denmark")]
        Faroese_Denmark,

        [Culture("fo-FO")]
        [Description("Faroese Faroe Islands")]
        Faroese_Faroe_Islands,

        [Culture("fr")]
        [Description("French")]
        French,

        [Culture("fr-BE")]
        [Description("French Belgium")]
        French_Belgium,

        [Culture("fr-BF")]
        [Description("French Burkina Faso")]
        French_Burkina_Faso,

        [Culture("fr-BI")]
        [Description("French Burundi")]
        French_Burundi,

        [Culture("fr-BJ")]
        [Description("French Benin")]
        French_Benin,

        [Culture("fr-BL")]
        [Description("French St. Barthélemy")]
        French_St_Barthélemy,

        [Culture("fr-CA")]
        [Description("French Canada")]
        French_Canada,

        [Culture("fr-CD")]
        [Description("French Congo [DRC]")]
        French_Congo_DRC,

        [Culture("fr-CF")]
        [Description("French Central African Republic")]
        French_Central_African_Republic,

        [Culture("fr-CG")]
        [Description("French Congo")]
        French_Congo,

        [Culture("fr-CH")]
        [Description("French Switzerland")]
        French_Switzerland,

        [Culture("fr-CI")]
        [Description("French Côte d’Ivoire")]
        French_Côte_d_Ivoire,

        [Culture("fr-CM")]
        [Description("French Cameroon")]
        French_Cameroon,

        [Culture("fr-DJ")]
        [Description("French Djibouti")]
        French_Djibouti,

        [Culture("fr-DZ")]
        [Description("French Algeria")]
        French_Algeria,

        [Culture("fr-FR")]
        [Description("French France")]
        French_France,

        [Culture("fr-GA")]
        [Description("French Gabon")]
        French_Gabon,

        [Culture("fr-GF")]
        [Description("French French Guiana")]
        French_French_Guiana,

        [Culture("fr-GN")]
        [Description("French Guinea")]
        French_Guinea,

        [Culture("fr-GP")]
        [Description("French Guadeloupe")]
        French_Guadeloupe,

        [Culture("fr-GQ")]
        [Description("French Equatorial Guinea")]
        French_Equatorial_Guinea,

        [Culture("fr-HT")]
        [Description("French Haiti")]
        French_Haiti,

        [Culture("fr-KM")]
        [Description("French Comoros")]
        French_Comoros,

        [Culture("fr-LU")]
        [Description("French Luxembourg")]
        French_Luxembourg,

        [Culture("fr-MA")]
        [Description("French Morocco")]
        French_Morocco,

        [Culture("fr-MC")]
        [Description("French Monaco")]
        French_Monaco,

        [Culture("fr-MF")]
        [Description("French St. Martin")]
        French_St_Martin,

        [Culture("fr-MG")]
        [Description("French Madagascar")]
        French_Madagascar,

        [Culture("fr-ML")]
        [Description("French Mali")]
        French_Mali,

        [Culture("fr-MQ")]
        [Description("French Martinique")]
        French_Martinique,

        [Culture("fr-MR")]
        [Description("French Mauritania")]
        French_Mauritania,

        [Culture("fr-MU")]
        [Description("French Mauritius")]
        French_Mauritius,

        [Culture("fr-NC")]
        [Description("French New Caledonia")]
        French_New_Caledonia,

        [Culture("fr-NE")]
        [Description("French Niger")]
        French_Niger,

        [Culture("fr-PF")]
        [Description("French French Polynesia")]
        French_French_Polynesia,

        [Culture("fr-PM")]
        [Description("French St. Pierre & Miquelon")]
        French_St_Pierre_Miquelon,

        [Culture("fr-RE")]
        [Description("French Réunion")]
        French_Réunion,

        [Culture("fr-RW")]
        [Description("French Rwanda")]
        French_Rwanda,

        [Culture("fr-SC")]
        [Description("French Seychelles")]
        French_Seychelles,

        [Culture("fr-SN")]
        [Description("French Senegal")]
        French_Senegal,

        [Culture("fr-SY")]
        [Description("French Syria")]
        French_Syria,

        [Culture("fr-TD")]
        [Description("French Chad")]
        French_Chad,

        [Culture("fr-TG")]
        [Description("French Togo")]
        French_Togo,

        [Culture("fr-TN")]
        [Description("French Tunisia")]
        French_Tunisia,

        [Culture("fr-VU")]
        [Description("French Vanuatu")]
        French_Vanuatu,

        [Culture("fr-WF")]
        [Description("French Wallis & Futuna")]
        French_Wallis_Futuna,

        [Culture("fr-YT")]
        [Description("French Mayotte")]
        French_Mayotte,

        [Culture("fur")]
        [Description("Friulian")]
        Friulian,

        [Culture("fur-IT")]
        [Description("Friulian Italy")]
        Friulian_Italy,

        [Culture("fy")]
        [Description("Western Frisian")]
        Western_Frisian,

        [Culture("fy-NL")]
        [Description("Western Frisian Netherlands")]
        Western_Frisian_Netherlands,

        [Culture("ga")]
        [Description("Irish")]
        Irish,

        [Culture("ga-IE")]
        [Description("Irish Ireland")]
        Irish_Ireland,

        [Culture("gd")]
        [Description("Scottish Gaelic")]
        Scottish_Gaelic,

        [Culture("gd-GB")]
        [Description("Scottish Gaelic United Kingdom")]
        Scottish_Gaelic_United_Kingdom,

        [Culture("gl")]
        [Description("Galician")]
        Galician,

        [Culture("gl-ES")]
        [Description("Galician Spain")]
        Galician_Spain,

        [Culture("gn")]
        [Description("Guarani")]
        Guarani,

        [Culture("gn-PY")]
        [Description("Guarani Paraguay")]
        Guarani_Paraguay,

        [Culture("gsw")]
        [Description("Swiss German")]
        Swiss_German,

        [Culture("gsw-CH")]
        [Description("Swiss German Switzerland")]
        Swiss_German_Switzerland,

        [Culture("gsw-FR")]
        [Description("Swiss German France")]
        Swiss_German_France,

        [Culture("gsw-LI")]
        [Description("Swiss German Liechtenstein")]
        Swiss_German_Liechtenstein,

        [Culture("gu")]
        [Description("Gujarati")]
        Gujarati,

        [Culture("gu-IN")]
        [Description("Gujarati India")]
        Gujarati_India,

        [Culture("guz")]
        [Description("Gusii")]
        Gusii,

        [Culture("guz-KE")]
        [Description("Gusii Kenya")]
        Gusii_Kenya,

        [Culture("gv")]
        [Description("Manx")]
        Manx,

        [Culture("gv-IM")]
        [Description("Manx Isle of Man")]
        Manx_Isle_of_Man,

        [Culture("ha")]
        [Description("Hausa")]
        Hausa,

        [Culture("ha-Latn-GH")]
        [Description("Hausa Latin, Ghana")]
        Hausa_Latin_Ghana,

        [Culture("ha-Latn-NE")]
        [Description("Hausa Latin, Niger")]
        Hausa_Latin_Niger,

        [Culture("ha-Latn-NG")]
        [Description("Hausa Latin, Nigeria")]
        Hausa_Latin_Nigeria,

        [Culture("haw")]
        [Description("Hawaiian")]
        Hawaiian,

        [Culture("haw-US")]
        [Description("Hawaiian United States")]
        Hawaiian_United_States,

        [Culture("he")]
        [Description("Hebrew")]
        Hebrew,

        [Culture("he-IL")]
        [Description("Hebrew Israel")]
        Hebrew_Israel,

        [Culture("hi")]
        [Description("Hindi")]
        Hindi,

        [Culture("hi-IN")]
        [Description("Hindi India")]
        Hindi_India,

        [Culture("hr")]
        [Description("Croatian")]
        Croatian,

        [Culture("hr-BA")]
        [Description("Croatian Bosnia & Herzegovina")]
        Croatian_Bosnia_Herzegovina,

        [Culture("hr-HR")]
        [Description("Croatian Croatia")]
        Croatian_Croatia,

        [Culture("hsb")]
        [Description("Upper Sorbian")]
        Upper_Sorbian,

        [Culture("hsb-DE")]
        [Description("Upper Sorbian Germany")]
        Upper_Sorbian_Germany,

        [Culture("hu")]
        [Description("Hungarian")]
        Hungarian,

        [Culture("hu-HU")]
        [Description("Hungarian Hungary")]
        Hungarian_Hungary,

        [Culture("hy")]
        [Description("Armenian")]
        Armenian,

        [Culture("hy-AM")]
        [Description("Armenian Armenia")]
        Armenian_Armenia,

        [Culture("ia")]
        [Description("Interlingua")]
        Interlingua,

        [Culture("ia-001")]
        [Description("Interlingua World")]
        Interlingua_World,

        [Culture("id")]
        [Description("Indonesian")]
        Indonesian,

        [Culture("id-ID")]
        [Description("Indonesian Indonesia")]
        Indonesian_Indonesia,

        [Culture("ig")]
        [Description("Igbo")]
        Igbo,

        [Culture("ig-NG")]
        [Description("Igbo Nigeria")]
        Igbo_Nigeria,

        [Culture("ii")]
        [Description("Yi")]
        Yi,

        [Culture("ii-CN")]
        [Description("Yi China")]
        Yi_China,

        [Culture("is")]
        [Description("Icelandic")]
        Icelandic,

        [Culture("is-IS")]
        [Description("Icelandic Iceland")]
        Icelandic_Iceland,

        [Culture("it")]
        [Description("Italian")]
        Italian,

        [Culture("it-CH")]
        [Description("Italian Switzerland")]
        Italian_Switzerland,

        [Culture("it-IT")]
        [Description("Italian Italy")]
        Italian_Italy,

        [Culture("it-SM")]
        [Description("Italian San Marino")]
        Italian_San_Marino,

        [Culture("it-VA")]
        [Description("Italian Vatican City")]
        Italian_Vatican_City,

        [Culture("iu")]
        [Description("Inuktitut")]
        Inuktitut,

        [Culture("iu-CA")]
        [Description("Inuktitut Canada")]
        Inuktitut_Canada,

        [Culture("iu-Latn")]
        [Description("Inuktitut")]
        Inuktitut_Latn,

        [Culture("iu-Latn-CA")]
        [Description("Inuktitut Latin, Canada")]
        Inuktitut_Latin_Canada,

        [Culture("ja")]
        [Description("Japanese")]
        Japanese,

        [Culture("ja-JP")]
        [Description("Japanese Japan")]
        Japanese_Japan,

        [Culture("jgo")]
        [Description("Ngomba")]
        Ngomba,

        [Culture("jgo-CM")]
        [Description("Ngomba Cameroon")]
        Ngomba_Cameroon,

        [Culture("jmc")]
        [Description("Machame")]
        Machame,

        [Culture("jmc-TZ")]
        [Description("Machame Tanzania")]
        Machame_Tanzania,

        [Culture("jv")]
        [Description("Javanese")]
        Javanese,

        [Culture("jv-Latn-ID")]
        [Description("Javanese Latin, Indonesia")]
        Javanese_Latin_Indonesia,

        [Culture("ka")]
        [Description("Georgian")]
        Georgian,

        [Culture("ka-GE")]
        [Description("Georgian Georgia")]
        Georgian_Georgia,

        [Culture("kab")]
        [Description("Kabyle")]
        Kabyle,

        [Culture("kab-DZ")]
        [Description("Kabyle Algeria")]
        Kabyle_Algeria,

        [Culture("kam")]
        [Description("Kamba")]
        Kamba,

        [Culture("kam-KE")]
        [Description("Kamba Kenya")]
        Kamba_Kenya,

        [Culture("kde")]
        [Description("Makonde")]
        Makonde,

        [Culture("kde-TZ")]
        [Description("Makonde Tanzania")]
        Makonde_Tanzania,

        [Culture("kea")]
        [Description("Kabuverdianu")]
        Kabuverdianu,

        [Culture("kea-CV")]
        [Description("Kabuverdianu Cabo Verde")]
        Kabuverdianu_Cabo_Verde,

        [Culture("khq")]
        [Description("Koyra Chiini")]
        Koyra_Chiini,

        [Culture("khq-ML")]
        [Description("Koyra Chiini Mali")]
        Koyra_Chiini_Mali,

        [Culture("ki")]
        [Description("Kikuyu")]
        Kikuyu,

        [Culture("ki-KE")]
        [Description("Kikuyu Kenya")]
        Kikuyu_Kenya,

        [Culture("kk")]
        [Description("Kazakh")]
        Kazakh,

        [Culture("kk-KZ")]
        [Description("Kazakh Kazakhstan")]
        Kazakh_Kazakhstan,

        [Culture("kkj")]
        [Description("Kako")]
        Kako,

        [Culture("kkj-CM")]
        [Description("Kako Cameroon")]
        Kako_Cameroon,

        [Culture("kl")]
        [Description("Kalaallisut")]
        Kalaallisut,

        [Culture("kl-GL")]
        [Description("Kalaallisut Greenland")]
        Kalaallisut_Greenland,

        [Culture("kln")]
        [Description("Kalenjin")]
        Kalenjin,

        [Culture("kln-KE")]
        [Description("Kalenjin Kenya")]
        Kalenjin_Kenya,

        [Culture("km")]
        [Description("Khmer")]
        Khmer,

        [Culture("km-KH")]
        [Description("Khmer Cambodia")]
        Khmer_Cambodia,

        [Culture("kn")]
        [Description("Kannada")]
        Kannada,

        [Culture("kn-IN")]
        [Description("Kannada India")]
        Kannada_India,

        [Culture("ko")]
        [Description("Korean")]
        Korean,

        [Culture("ko-KP")]
        [Description("Korean North Korea")]
        Korean_North_Korea,

        [Culture("ko-KR")]
        [Description("Korean Korea")]
        Korean_Korea,

        [Culture("kok")]
        [Description("Konkani")]
        Konkani,

        [Culture("kok-IN")]
        [Description("Konkani India")]
        Konkani_India,

        [Culture("ks")]
        [Description("Kashmiri")]
        Kashmiri,

        [Culture("ks-Arab-IN")]
        [Description("Kashmiri Arabic, India")]
        Kashmiri_Arabic_India,

        [Culture("ksb")]
        [Description("Shambala")]
        Shambala,

        [Culture("ksb-TZ")]
        [Description("Shambala Tanzania")]
        Shambala_Tanzania,

        [Culture("ksf")]
        [Description("Bafia")]
        Bafia,

        [Culture("ksf-CM")]
        [Description("Bafia Cameroon")]
        Bafia_Cameroon,

        [Culture("ksh")]
        [Description("Colognian")]
        Colognian,

        [Culture("ksh-DE")]
        [Description("Colognian Germany")]
        Colognian_Germany,

        [Culture("kw")]
        [Description("Cornish")]
        Cornish,

        [Culture("kw-GB")]
        [Description("Cornish United Kingdom")]
        Cornish_United_Kingdom,

        [Culture("ky")]
        [Description("Kyrgyz")]
        Kyrgyz,

        [Culture("ky-KG")]
        [Description("Kyrgyz Kyrgyzstan")]
        Kyrgyz_Kyrgyzstan,

        [Culture("lag")]
        [Description("Langi")]
        Langi,

        [Culture("lag-TZ")]
        [Description("Langi Tanzania")]
        Langi_Tanzania,

        [Culture("lb")]
        [Description("Luxembourgish")]
        Luxembourgish,

        [Culture("lb-LU")]
        [Description("Luxembourgish Luxembourg")]
        Luxembourgish_Luxembourg,

        [Culture("lg")]
        [Description("Ganda")]
        Ganda,

        [Culture("lg-UG")]
        [Description("Ganda Uganda")]
        Ganda_Uganda,

        [Culture("lkt")]
        [Description("Lakota")]
        Lakota,

        [Culture("lkt-US")]
        [Description("Lakota United States")]
        Lakota_United_States,

        [Culture("ln")]
        [Description("Lingala")]
        Lingala,

        [Culture("ln-AO")]
        [Description("Lingala Angola")]
        Lingala_Angola,

        [Culture("ln-CD")]
        [Description("Lingala Congo [DRC]")]
        Lingala_Congo_DRC,

        [Culture("ln-CF")]
        [Description("Lingala Central African Republic")]
        Lingala_Central_African_Republic,

        [Culture("ln-CG")]
        [Description("Lingala Congo")]
        Lingala_Congo,

        [Culture("lo")]
        [Description("Lao")]
        Lao,

        [Culture("lo-LA")]
        [Description("Lao Laos")]
        Lao_Laos,

        [Culture("lrc")]
        [Description("Northern Luri")]
        Northern_Luri,

        [Culture("lrc-IQ")]
        [Description("Northern Luri Iraq")]
        Northern_Luri_Iraq,

        [Culture("lrc-IR")]
        [Description("Northern Luri Iran")]
        Northern_Luri_Iran,

        [Culture("lt")]
        [Description("Lithuanian")]
        Lithuanian,

        [Culture("lt-LT")]
        [Description("Lithuanian Lithuania")]
        Lithuanian_Lithuania,

        [Culture("lu")]
        [Description("Luba-Katanga")]
        Luba_Katanga,

        [Culture("lu-CD")]
        [Description("Luba-Katanga Congo [DRC]")]
        Luba_Katanga_Congo_DRC,

        [Culture("luo")]
        [Description("Luo")]
        Luo,

        [Culture("luo-KE")]
        [Description("Luo Kenya")]
        Luo_Kenya,

        [Culture("luy")]
        [Description("Luyia")]
        Luyia,

        [Culture("luy-KE")]
        [Description("Luyia Kenya")]
        Luyia_Kenya,

        [Culture("lv")]
        [Description("Latvian")]
        Latvian,

        [Culture("lv-LV")]
        [Description("Latvian Latvia")]
        Latvian_Latvia,

        [Culture("mas")]
        [Description("Masai")]
        Masai,

        [Culture("mas-KE")]
        [Description("Masai Kenya")]
        Masai_Kenya,

        [Culture("mas-TZ")]
        [Description("Masai Tanzania")]
        Masai_Tanzania,

        [Culture("mer")]
        [Description("Meru")]
        Meru,

        [Culture("mer-KE")]
        [Description("Meru Kenya")]
        Meru_Kenya,

        [Culture("mfe")]
        [Description("Morisyen")]
        Morisyen,

        [Culture("mfe-MU")]
        [Description("Morisyen Mauritius")]
        Morisyen_Mauritius,

        [Culture("mg")]
        [Description("Malagasy")]
        Malagasy,

        [Culture("mg-MG")]
        [Description("Malagasy Madagascar")]
        Malagasy_Madagascar,

        [Culture("mgh")]
        [Description("Makhuwa-Meetto")]
        Makhuwa_Meetto,

        [Culture("mgh-MZ")]
        [Description("Makhuwa-Meetto Mozambique")]
        Makhuwa_Meetto_Mozambique,

        [Culture("mgo")]
        [Description("Metaʼ")]
        Metaʼ,

        [Culture("mgo-CM")]
        [Description("Metaʼ Cameroon")]
        Metaʼ_Cameroon,

        [Culture("mi")]
        [Description("Maori")]
        Maori,

        [Culture("mi-NZ")]
        [Description("Maori New Zealand")]
        Maori_New_Zealand,

        [Culture("mk")]
        [Description("Macedonian")]
        Macedonian,

        [Culture("mk-MK")]
        [Description("Macedonian North Macedonia")]
        Macedonian_North_Macedonia,

        [Culture("ml")]
        [Description("Malayalam")]
        Malayalam,

        [Culture("ml-IN")]
        [Description("Malayalam India")]
        Malayalam_India,

        [Culture("mn")]
        [Description("Mongolian")]
        Mongolian,

        [Culture("mn-MN")]
        [Description("Mongolian Mongolia")]
        Mongolian_Mongolia,

        [Culture("mn-Mong-CN")]
        [Description("Mongolian Mongolian, China")]
        Mongolian_China,

        [Culture("moh")]
        [Description("Mohawk")]
        Mohawk,

        [Culture("moh-CA")]
        [Description("Mohawk Canada")]
        Mohawk_Canada,

        [Culture("mr")]
        [Description("Marathi")]
        Marathi,

        [Culture("mr-IN")]
        [Description("Marathi India")]
        Marathi_India,

        [Culture("ms")]
        [Description("Malay")]
        Malay,

        [Culture("ms-BN")]
        [Description("Malay Brunei")]
        Malay_Brunei,

        [Culture("ms-MY")]
        [Description("Malay Malaysia")]
        Malay_Malaysia,

        [Culture("ms-SG")]
        [Description("Malay Singapore")]
        Malay_Singapore,

        [Culture("mt")]
        [Description("Maltese")]
        Maltese,

        [Culture("mt-MT")]
        [Description("Maltese Malta")]
        Maltese_Malta,

        [Culture("mua")]
        [Description("Mundang")]
        Mundang,

        [Culture("mua-CM")]
        [Description("Mundang Cameroon")]
        Mundang_Cameroon,

        [Culture("my")]
        [Description("Burmese")]
        Burmese,

        [Culture("my-MM")]
        [Description("Burmese Myanmar")]
        Burmese_Myanmar,

        [Culture("mzn")]
        [Description("Mazanderani")]
        Mazanderani,

        [Culture("mzn-IR")]
        [Description("Mazanderani Iran")]
        Mazanderani_Iran,

        [Culture("naq")]
        [Description("Nama")]
        Nama,

        [Culture("naq-NA")]
        [Description("Nama Namibia")]
        Nama_Namibia,

        [Culture("nb")]
        [Description("Norwegian Bokmål")]
        Norwegian_Bokmål,

        [Culture("nb-NO")]
        [Description("Norwegian Bokmål Norway")]
        Norwegian_Bokmål_Norway,

        [Culture("nb-SJ")]
        [Description("Norwegian Bokmål Svalbard & Jan Mayen")]
        Norwegian_Bokmål_Svalbard_Jan_Mayen,

        [Culture("nd")]
        [Description("North Ndebele")]
        North_Ndebele,

        [Culture("nd-ZW")]
        [Description("North Ndebele Zimbabwe")]
        North_Ndebele_Zimbabwe,

        [Culture("nds")]
        [Description("Low German")]
        Low_German,

        [Culture("nds-DE")]
        [Description("Low German Germany")]
        Low_German_Germany,

        [Culture("nds-NL")]
        [Description("Low German Netherlands")]
        Low_German_Netherlands,

        [Culture("ne")]
        [Description("Nepali")]
        Nepali,

        [Culture("ne-IN")]
        [Description("Nepali India")]
        Nepali_India,

        [Culture("ne-NP")]
        [Description("Nepali Nepal")]
        Nepali_Nepal,

        [Culture("nl")]
        [Description("Dutch")]
        Dutch,

        [Culture("nl-AW")]
        [Description("Dutch Aruba")]
        Dutch_Aruba,

        [Culture("nl-BE")]
        [Description("Dutch Belgium")]
        Dutch_Belgium,

        [Culture("nl-BQ")]
        [Description("Dutch Bonaire, Sint Eustatius and Saba")]
        Dutch_Bonaire_Sint_Eustatius_and_Saba,

        [Culture("nl-CW")]
        [Description("Dutch Curaçao")]
        Dutch_Curaçao,

        [Culture("nl-NL")]
        [Description("Dutch Netherlands")]
        Dutch_Netherlands,

        [Culture("nl-SR")]
        [Description("Dutch Suriname")]
        Dutch_Suriname,

        [Culture("nl-SX")]
        [Description("Dutch Sint Maarten")]
        Dutch_Sint_Maarten,

        [Culture("nmg")]
        [Description("Kwasio")]
        Kwasio,

        [Culture("nmg-CM")]
        [Description("Kwasio Cameroon")]
        Kwasio_Cameroon,

        [Culture("nn")]
        [Description("Norwegian Nynorsk")]
        Norwegian_Nynorsk,

        [Culture("nn-NO")]
        [Description("Norwegian Nynorsk Norway")]
        Norwegian_Nynorsk_Norway,

        [Culture("nnh")]
        [Description("Ngiemboon")]
        Ngiemboon,

        [Culture("nnh-CM")]
        [Description("Ngiemboon Cameroon")]
        Ngiemboon_Cameroon,

        [Culture("nqo")]
        [Description("N’Ko")]
        NKo,

        [Culture("nqo-GN")]
        [Description("N’Ko Guinea")]
        NKo_Guinea,

        [Culture("nr")]
        [Description("South Ndebele")]
        South_Ndebele,

        [Culture("nr-ZA")]
        [Description("South Ndebele South Africa")]
        South_Ndebele_South_Africa,

        [Culture("nso")]
        [Description("Sesotho sa Leboa")]
        Sesotho_sa_Leboa,

        [Culture("nso-ZA")]
        [Description("Sesotho sa Leboa South Africa")]
        Sesotho_sa_Leboa_South_Africa,

        [Culture("nus")]
        [Description("Nuer")]
        Nuer,

        [Culture("nus-SS")]
        [Description("Nuer South Sudan")]
        Nuer_South_Sudan,

        [Culture("nyn")]
        [Description("Nyankole")]
        Nyankole,

        [Culture("nyn-UG")]
        [Description("Nyankole Uganda")]
        Nyankole_Uganda,

        [Culture("oc")]
        [Description("Occitan")]
        Occitan,

        [Culture("oc-FR")]
        [Description("Occitan France")]
        Occitan_France,

        [Culture("om")]
        [Description("Oromo")]
        Oromo,

        [Culture("om-ET")]
        [Description("Oromo Ethiopia")]
        Oromo_Ethiopia,

        [Culture("om-KE")]
        [Description("Oromo Kenya")]
        Oromo_Kenya,

        [Culture("or")]
        [Description("Odia")]
        Odia,

        [Culture("or-IN")]
        [Description("Odia India")]
        Odia_India,

        [Culture("os")]
        [Description("Ossetic")]
        Ossetic,

        [Culture("os-GE")]
        [Description("Ossetic Georgia")]
        Ossetic_Georgia,

        [Culture("os-RU")]
        [Description("Ossetic Russia")]
        Ossetic_Russia,

        [Culture("pa")]
        [Description("Punjabi")]
        Punjabi,

        [Culture("pa-Arab")]
        [Description("Punjabi")]
        Punjabi_Arab,

        [Culture("pa-Arab-PK")]
        [Description("Punjabi Arabic, Pakistan")]
        Punjabi_Arabic_Pakistan,

        [Culture("pa-Guru")]
        [Description("Punjabi")]
        Punjabi_Guru,

        [Culture("pa-IN")]
        [Description("Punjabi India")]
        Punjabi_India,

        [Culture("pl")]
        [Description("Polish")]
        Polish,

        [Culture("pl-PL")]
        [Description("Polish Poland")]
        Polish_Poland,

        [Culture("prg")]
        [Description("Prussian")]
        Prussian,

        [Culture("prg-001")]
        [Description("Prussian World")]
        Prussian_World,

        [Culture("ps")]
        [Description("Pashto")]
        Pashto,

        [Culture("ps-AF")]
        [Description("Pashto Afghanistan")]
        Pashto_Afghanistan,

        [Culture("ps-PK")]
        [Description("Pashto Pakistan")]
        Pashto_Pakistan,

        [Culture("pt")]
        [Description("Portuguese")]
        Portuguese,

        [Culture("pt-AO")]
        [Description("Portuguese Angola")]
        Portuguese_Angola,

        [Culture("pt-BR")]
        [Description("Portuguese Brazil")]
        Portuguese_Brazil,

        [Culture("pt-CH")]
        [Description("Portuguese Switzerland")]
        Portuguese_Switzerland,

        [Culture("pt-CV")]
        [Description("Portuguese Cabo Verde")]
        Portuguese_Cabo_Verde,

        [Culture("pt-GQ")]
        [Description("Portuguese Equatorial Guinea")]
        Portuguese_Equatorial_Guinea,

        [Culture("pt-GW")]
        [Description("Portuguese Guinea-Bissau")]
        Portuguese_Guinea_Bissau,

        [Culture("pt-LU")]
        [Description("Portuguese Luxembourg")]
        Portuguese_Luxembourg,

        [Culture("pt-MO")]
        [Description("Portuguese Macao SAR")]
        Portuguese_Macao_SAR,

        [Culture("pt-MZ")]
        [Description("Portuguese Mozambique")]
        Portuguese_Mozambique,

        [Culture("pt-PT")]
        [Description("Portuguese Portugal")]
        Portuguese_Portugal,

        [Culture("pt-ST")]
        [Description("Portuguese São Tomé & Príncipe")]
        Portuguese_São_Tomé_Príncipe,

        [Culture("pt-TL")]
        [Description("Portuguese Timor-Leste")]
        Portuguese_Timor_Leste,

        [Culture("quz")]
        [Description("quz")]
        quz,

        [Culture("quz-BO")]
        [Description("quz Bolivia")]
        quz_Bolivia,

        [Culture("quz-EC")]
        [Description("quz Ecuador")]
        quz_Ecuador,

        [Culture("quz-PE")]
        [Description("quz Peru")]
        quz_Peru,

        [Culture("quc")]
        [Description("Kʼicheʼ")]
        Kʼicheʼ,

        [Culture("quc-GT")]
        [Description("Kʼicheʼ Guatemala")]
        Kʼicheʼ_Guatemala,

        [Culture("rm")]
        [Description("Romansh")]
        Romansh,

        [Culture("rm-CH")]
        [Description("Romansh Switzerland")]
        Romansh_Switzerland,

        [Culture("rn")]
        [Description("Rundi")]
        Rundi,

        [Culture("rn-BI")]
        [Description("Rundi Burundi")]
        Rundi_Burundi,

        [Culture("ro")]
        [Description("Romanian")]
        Romanian,

        [Culture("ro-MD")]
        [Description("Romanian Moldova")]
        Romanian_Moldova,

        [Culture("ro-RO")]
        [Description("Romanian Romania")]
        Romanian_Romania,

        [Culture("rof")]
        [Description("Rombo")]
        Rombo,

        [Culture("rof-TZ")]
        [Description("Rombo Tanzania")]
        Rombo_Tanzania,

        [Culture("ru")]
        [Description("Russian")]
        Russian,

        [Culture("ru-BY")]
        [Description("Russian Belarus")]
        Russian_Belarus,

        [Culture("ru-KG")]
        [Description("Russian Kyrgyzstan")]
        Russian_Kyrgyzstan,

        [Culture("ru-KZ")]
        [Description("Russian Kazakhstan")]
        Russian_Kazakhstan,

        [Culture("ru-MD")]
        [Description("Russian Moldova")]
        Russian_Moldova,

        [Culture("ru-RU")]
        [Description("Russian Russia")]
        Russian_Russia,

        [Culture("ru-UA")]
        [Description("Russian Ukraine")]
        Russian_Ukraine,

        [Culture("rw")]
        [Description("Kinyarwanda")]
        Kinyarwanda,

        [Culture("rw-RW")]
        [Description("Kinyarwanda Rwanda")]
        Kinyarwanda_Rwanda,

        [Culture("rwk")]
        [Description("Rwa")]
        Rwa,

        [Culture("rwk-TZ")]
        [Description("Rwa Tanzania")]
        Rwa_Tanzania,

        [Culture("sa")]
        [Description("Sanskrit")]
        Sanskrit,

        [Culture("sa-IN")]
        [Description("Sanskrit India")]
        Sanskrit_India,

        [Culture("sah")]
        [Description("Sakha")]
        Sakha,

        [Culture("sah-RU")]
        [Description("Sakha Russia")]
        Sakha_Russia,

        [Culture("saq")]
        [Description("Samburu")]
        Samburu,

        [Culture("saq-KE")]
        [Description("Samburu Kenya")]
        Samburu_Kenya,

        [Culture("sbp")]
        [Description("Sangu")]
        Sangu,

        [Culture("sbp-TZ")]
        [Description("Sangu Tanzania")]
        Sangu_Tanzania,

        [Culture("sd")]
        [Description("Sindhi")]
        Sindhi,

        [Culture("sd-Arab-PK")]
        [Description("Sindhi Arabic, Pakistan")]
        Sindhi_Arabic_Pakistan,

        [Culture("se")]
        [Description("Northern Sami")]
        Northern_Sami,

        [Culture("se-FI")]
        [Description("Northern Sami Finland")]
        Northern_Sami_Finland,

        [Culture("se-NO")]
        [Description("Northern Sami Norway")]
        Northern_Sami_Norway,

        [Culture("se-SE")]
        [Description("Northern Sami Sweden")]
        Northern_Sami_Sweden,

        [Culture("seh")]
        [Description("Sena")]
        Sena,

        [Culture("seh-MZ")]
        [Description("Sena Mozambique")]
        Sena_Mozambique,

        [Culture("ses")]
        [Description("Koyraboro Senni")]
        Koyraboro_Senni,

        [Culture("ses-ML")]
        [Description("Koyraboro Senni Mali")]
        Koyraboro_Senni_Mali,

        [Culture("sg")]
        [Description("Sango")]
        Sango,

        [Culture("sg-CF")]
        [Description("Sango Central African Republic")]
        Sango_Central_African_Republic,

        [Culture("shi")]
        [Description("Tachelhit")]
        Tachelhit,

        [Culture("shi-Latn")]
        [Description("Tachelhit")]
        Tachelhit_Latn,

        [Culture("shi-Latn-MA")]
        [Description("Tachelhit Latin, Morocco")]
        Tachelhit_Latin_Morocco,

        [Culture("shi-Tfng")]
        [Description("Tachelhit")]
        Tachelhit_Tfng,

        [Culture("shi-Tfng-MA")]
        [Description("Tachelhit Tifinagh, Morocco")]
        Tachelhit_Tifinagh_Morocco,

        [Culture("si")]
        [Description("Sinhala")]
        Sinhala,

        [Culture("si-LK")]
        [Description("Sinhala Sri Lanka")]
        Sinhala_Sri_Lanka,

        [Culture("sk")]
        [Description("Slovak")]
        Slovak,

        [Culture("sk-SK")]
        [Description("Slovak Slovakia")]
        Slovak_Slovakia,

        [Culture("sl")]
        [Description("Slovenian")]
        Slovenian,

        [Culture("sl-SI")]
        [Description("Slovenian Slovenia")]
        Slovenian_Slovenia,

        [Culture("sma")]
        [Description("Southern Sami")]
        Southern_Sami,

        [Culture("sma-NO")]
        [Description("Southern Sami Norway")]
        Southern_Sami_Norway,

        [Culture("sma-SE")]
        [Description("Southern Sami Sweden")]
        Southern_Sami_Sweden,

        [Culture("smj")]
        [Description("Lule Sami")]
        Lule_Sami,

        [Culture("smj-NO")]
        [Description("Lule Sami Norway")]
        Lule_Sami_Norway,

        [Culture("smj-SE")]
        [Description("Lule Sami Sweden")]
        Lule_Sami_Sweden,

        [Culture("smn")]
        [Description("Inari Sami")]
        Inari_Sami,

        [Culture("smn-FI")]
        [Description("Inari Sami Finland")]
        Inari_Sami_Finland,

        [Culture("sms")]
        [Description("Skolt Sami")]
        Skolt_Sami,

        [Culture("sms-FI")]
        [Description("Skolt Sami Finland")]
        Skolt_Sami_Finland,

        [Culture("sn")]
        [Description("Shona")]
        Shona,

        [Culture("sn-Latn-ZW")]
        [Description("Shona Latin, Zimbabwe")]
        Shona_Latin_Zimbabwe,

        [Culture("so")]
        [Description("Somali")]
        Somali,

        [Culture("so-DJ")]
        [Description("Somali Djibouti")]
        Somali_Djibouti,

        [Culture("so-ET")]
        [Description("Somali Ethiopia")]
        Somali_Ethiopia,

        [Culture("so-KE")]
        [Description("Somali Kenya")]
        Somali_Kenya,

        [Culture("so-SO")]
        [Description("Somali Somalia")]
        Somali_Somalia,

        [Culture("sq")]
        [Description("Albanian")]
        Albanian,

        [Culture("sq-AL")]
        [Description("Albanian Albania")]
        Albanian_Albania,

        [Culture("sq-MK")]
        [Description("Albanian North Macedonia")]
        Albanian_North_Macedonia,

        [Culture("sq-XK")]
        [Description("Albanian Kosovo")]
        Albanian_Kosovo,

        [Culture("sr")]
        [Description("Serbian")]
        Serbian,

        [Culture("sr-Cyrl")]
        [Description("Serbian")]
        Serbian_Cyrl,

        [Culture("sr-Cyrl-BA")]
        [Description("Serbian Cyrillic, Bosnia & Herzegovina")]
        Serbian_Cyrillic_Bosnia_Herzegovina,

        [Culture("sr-Cyrl-ME")]
        [Description("Serbian Cyrillic, Montenegro")]
        Serbian_Cyrillic_Montenegro,

        [Culture("sr-Cyrl-RS")]
        [Description("Serbian Cyrillic, Serbia")]
        Serbian_Cyrillic_Serbia,

        [Culture("sr-Cyrl-XK")]
        [Description("Serbian Cyrillic, Kosovo")]
        Serbian_Cyrillic_Kosovo,

        [Culture("sr-Latn")]
        [Description("Serbian")]
        Serbian_Latn,

        [Culture("sr-Latn-BA")]
        [Description("Serbian Latin, Bosnia & Herzegovina")]
        Serbian_Latin_Bosnia_Herzegovina,

        [Culture("sr-Latn-ME")]
        [Description("Serbian Latin, Montenegro")]
        Serbian_Latin_Montenegro,

        [Culture("sr-Latn-RS")]
        [Description("Serbian Latin, Serbia")]
        Serbian_Latin_Serbia,

        [Culture("sr-Latn-XK")]
        [Description("Serbian Latin, Kosovo")]
        Serbian_Latin_Kosovo,

        [Culture("ss")]
        [Description("siSwati")]
        siSwati,

        [Culture("ss-SZ")]
        [Description("siSwati Eswatini")]
        siSwati_Eswatini,

        [Culture("ss-ZA")]
        [Description("siSwati South Africa")]
        siSwati_South_Africa,

        [Culture("ssy")]
        [Description("Saho")]
        Saho,

        [Culture("ssy-ER")]
        [Description("Saho Eritrea")]
        Saho_Eritrea,

        [Culture("st")]
        [Description("Sesotho")]
        Sesotho,

        [Culture("st-LS")]
        [Description("Sesotho Lesotho")]
        Sesotho_Lesotho,

        [Culture("st-ZA")]
        [Description("Sesotho South Africa")]
        Sesotho_South_Africa,

        [Culture("sv")]
        [Description("Swedish")]
        Swedish,

        [Culture("sv-AX")]
        [Description("Swedish Åland Islands")]
        Swedish_Åland_Islands,

        [Culture("sv-FI")]
        [Description("Swedish Finland")]
        Swedish_Finland,

        [Culture("sv-SE")]
        [Description("Swedish Sweden")]
        Swedish_Sweden,

        [Culture("sw")]
        [Description("Kiswahili")]
        Kiswahili,

        [Culture("sw-CD")]
        [Description("Kiswahili Congo [DRC]")]
        Kiswahili_Congo_DRC,

        [Culture("sw-KE")]
        [Description("Kiswahili Kenya")]
        Kiswahili_Kenya,

        [Culture("sw-TZ")]
        [Description("Kiswahili Tanzania")]
        Kiswahili_Tanzania,

        [Culture("sw-UG")]
        [Description("Kiswahili Uganda")]
        Kiswahili_Uganda,

        [Culture("syr")]
        [Description("Syriac")]
        Syriac,

        [Culture("syr-SY")]
        [Description("Syriac Syria")]
        Syriac_Syria,

        [Culture("ta")]
        [Description("Tamil")]
        Tamil,

        [Culture("ta-IN")]
        [Description("Tamil India")]
        Tamil_India,

        [Culture("ta-LK")]
        [Description("Tamil Sri Lanka")]
        Tamil_Sri_Lanka,

        [Culture("ta-MY")]
        [Description("Tamil Malaysia")]
        Tamil_Malaysia,

        [Culture("ta-SG")]
        [Description("Tamil Singapore")]
        Tamil_Singapore,

        [Culture("te")]
        [Description("Telugu")]
        Telugu,

        [Culture("te-IN")]
        [Description("Telugu India")]
        Telugu_India,

        [Culture("teo")]
        [Description("Teso")]
        Teso,

        [Culture("teo-KE")]
        [Description("Teso Kenya")]
        Teso_Kenya,

        [Culture("teo-UG")]
        [Description("Teso Uganda")]
        Teso_Uganda,

        [Culture("tg")]
        [Description("Tajik")]
        Tajik,

        [Culture("tg-Cyrl-TJ")]
        [Description("Tajik Cyrillic, Tajikistan")]
        Tajik_Cyrillic_Tajikistan,

        [Culture("th")]
        [Description("Thai")]
        Thai,

        [Culture("th-TH")]
        [Description("Thai Thailand")]
        Thai_Thailand,

        [Culture("ti")]
        [Description("Tigrinya")]
        Tigrinya,

        [Culture("ti-ER")]
        [Description("Tigrinya Eritrea")]
        Tigrinya_Eritrea,

        [Culture("ti-ET")]
        [Description("Tigrinya Ethiopia")]
        Tigrinya_Ethiopia,

        [Culture("tig")]
        [Description("Tigre")]
        Tigre,

        [Culture("tig-ER")]
        [Description("Tigre Eritrea")]
        Tigre_Eritrea,

        [Culture("tk")]
        [Description("Turkmen")]
        Turkmen,

        [Culture("tk-TM")]
        [Description("Turkmen Turkmenistan")]
        Turkmen_Turkmenistan,

        [Culture("tn")]
        [Description("Setswana")]
        Setswana,

        [Culture("tn-BW")]
        [Description("Setswana Botswana")]
        Setswana_Botswana,

        [Culture("tn-ZA")]
        [Description("Setswana South Africa")]
        Setswana_South_Africa,

        [Culture("to")]
        [Description("Tongan")]
        Tongan,

        [Culture("to-TO")]
        [Description("Tongan Tonga")]
        Tongan_Tonga,

        [Culture("tr")]
        [Description("Turkish")]
        Turkish,

        [Culture("tr-CY")]
        [Description("Turkish Cyprus")]
        Turkish_Cyprus,

        [Culture("tr-TR")]
        [Description("Turkish Turkey")]
        Turkish_Turkey,

        [Culture("ts")]
        [Description("Xitsonga")]
        Xitsonga,

        [Culture("ts-ZA")]
        [Description("Xitsonga South Africa")]
        Xitsonga_South_Africa,

        [Culture("tt")]
        [Description("Tatar")]
        Tatar,

        [Culture("tt-RU")]
        [Description("Tatar Russia")]
        Tatar_Russia,

        [Culture("twq")]
        [Description("Tasawaq")]
        Tasawaq,

        [Culture("twq-NE")]
        [Description("Tasawaq Niger")]
        Tasawaq_Niger,

        [Culture("tzm")]
        [Description("Central Atlas Tamazight")]
        Central_Atlas_Tamazight,

        [Culture("tzm-Latn-MA")]
        [Description("Central Atlas Tamazight Latin, Morocco")]
        Central_Atlas_Tamazight_Latin_Morocco,

        [Culture("ug")]
        [Description("Uyghur")]
        Uyghur,

        [Culture("ug-CN")]
        [Description("Uyghur China")]
        Uyghur_China,

        [Culture("uk")]
        [Description("Ukrainian")]
        Ukrainian,

        [Culture("uk-UA")]
        [Description("Ukrainian Ukraine")]
        Ukrainian_Ukraine,

        [Culture("ur")]
        [Description("Urdu")]
        Urdu,

        [Culture("ur-IN")]
        [Description("Urdu India")]
        Urdu_India,

        [Culture("ur-PK")]
        [Description("Urdu Pakistan")]
        Urdu_Pakistan,

        [Culture("uz")]
        [Description("Uzbek")]
        Uzbek,

        [Culture("uz-Arab")]
        [Description("Uzbek")]
        Uzbek_Arab,

        [Culture("uz-Arab-AF")]
        [Description("Uzbek Arabic, Afghanistan")]
        Uzbek_Arabic_Afghanistan,

        [Culture("uz-Cyrl")]
        [Description("Uzbek")]
        Uzbek_Cyrl,

        [Culture("uz-Cyrl-UZ")]
        [Description("Uzbek Cyrillic, Uzbekistan")]
        Uzbek_Cyrillic_Uzbekistan,

        [Culture("uz-Latn")]
        [Description("Uzbek")]
        Uzbek_Latn,

        [Culture("uz-Latn-UZ")]
        [Description("Uzbek Latin, Uzbekistan")]
        Uzbek_Latin_Uzbekistan,

        [Culture("vai")]
        [Description("Vai")]
        Vai,

        [Culture("vai-Latn")]
        [Description("Vai")]
        Vai_Latn,

        [Culture("vai-Latn-LR")]
        [Description("Vai Latin, Liberia")]
        Vai_Latin_Liberia,

        [Culture("vai-Vaii")]
        [Description("Vai")]
        Vai_Vaii,

        [Culture("vai-Vaii-LR")]
        [Description("Vai Vai, Liberia")]
        Vai_Vai_Liberia,

        [Culture("ve")]
        [Description("Venda")]
        Venda,

        [Culture("ve-ZA")]
        [Description("Venda South Africa")]
        Venda_South_Africa,

        [Culture("vi")]
        [Description("Vietnamese")]
        Vietnamese,

        [Culture("vi-VN")]
        [Description("Vietnamese Vietnam")]
        Vietnamese_Vietnam,

        [Culture("vo")]
        [Description("Volapük")]
        Volapük,

        [Culture("vo-001")]
        [Description("Volapük World")]
        Volapük_World,

        [Culture("vun")]
        [Description("Vunjo")]
        Vunjo,

        [Culture("vun-TZ")]
        [Description("Vunjo Tanzania")]
        Vunjo_Tanzania,

        [Culture("wae")]
        [Description("Walser")]
        Walser,

        [Culture("wae-CH")]
        [Description("Walser Switzerland")]
        Walser_Switzerland,

        [Culture("wal")]
        [Description("Wolaytta")]
        Wolaytta,

        [Culture("wal-ET")]
        [Description("Wolaytta Ethiopia")]
        Wolaytta_Ethiopia,

        [Culture("wo")]
        [Description("Wolof")]
        Wolof,

        [Culture("wo-SN")]
        [Description("Wolof Senegal")]
        Wolof_Senegal,

        [Culture("xh")]
        [Description("isiXhosa")]
        isiXhosa,

        [Culture("xh-ZA")]
        [Description("isiXhosa South Africa")]
        isiXhosa_South_Africa,

        [Culture("xog")]
        [Description("Soga")]
        Soga,

        [Culture("xog-UG")]
        [Description("Soga Uganda")]
        Soga_Uganda,

        [Culture("yav")]
        [Description("Yangben")]
        Yangben,

        [Culture("yav-CM")]
        [Description("Yangben Cameroon")]
        Yangben_Cameroon,

        [Culture("yi")]
        [Description("Yiddish")]
        Yiddish,

        [Culture("yi-001")]
        [Description("Yiddish World")]
        Yiddish_World,

        [Culture("yo")]
        [Description("Yoruba")]
        Yoruba,

        [Culture("yo-BJ")]
        [Description("Yoruba Benin")]
        Yoruba_Benin,

        [Culture("yo-NG")]
        [Description("Yoruba Nigeria")]
        Yoruba_Nigeria,

        [Culture("zgh")]
        [Description("Standard Moroccan Tamazight")]
        Standard_Moroccan_Tamazight,

        [Culture("zgh-Tfng-MA")]
        [Description("Standard Moroccan Tamazight Tifinagh, Morocco")]
        Standard_Moroccan_Tamazight_Tifinagh_Morocco,

        [Culture("zh")]
        [Description("Chinese")]
        Chinese,

        [Culture("zh-Hans")]
        [Description("Chinese")]
        Chinese_Hans,

        [Culture("zh-CN")]
        [Description("Chinese China")]
        Chinese_China,

        [Culture("zh-Hans-HK")]
        [Description("Chinese Simplified, Hong Kong SAR")]
        Chinese_Simplified_Hong_Kong_SAR,

        [Culture("zh-Hans-MO")]
        [Description("Chinese Simplified, Macao SAR")]
        Chinese_Simplified_Macao_SAR,

        [Culture("zh-SG")]
        [Description("Chinese Singapore")]
        Chinese_Singapore,

        [Culture("zh-Hant")]
        [Description("Chinese")]
        Chinese_Hant,

        [Culture("zh-HK")]
        [Description("Chinese Hong Kong SAR")]
        Chinese_Hong_Kong_SAR,

        [Culture("zh-MO")]
        [Description("Chinese Macao SAR")]
        Chinese_Macao_SAR,

        [Culture("zh-TW")]
        [Description("Chinese Taiwan")]
        Chinese_Taiwan,

        [Culture("zu")]
        [Description("isiZulu")]
        isiZulu,

        [Culture("zu-ZA")]
        [Description("isiZulu South Africa")]
        isiZulu_South_Africa,

    }

}