﻿// Copyright (c) 2018 Jakub Guc
// See https://github.com/jguc/JPK_VAT2.CSharpClasses for reference and examples

using System;
using System.Collections.Generic;

namespace JGuc.Legislation.PL.JPK
{
    [Obsolete("Since 2018-01-01", true)]
    public class JPK_VAT_2_v_1_0
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/", IsNullable = false)]
        public partial class JPK
        {

            public TNaglowek Naglowek { get; set; }
            public JPKPodmiot1 Podmiot1 { get; set; }
            [System.Xml.Serialization.XmlElementAttribute("SprzedazWiersz")]
            public List<JPKSprzedazWiersz> SprzedazWiersz { get; set; }
            public JPKSprzedazCtrl SprzedazCtrl { get; set; }
            [System.Xml.Serialization.XmlElementAttribute("ZakupWiersz")]
            public List<JPKZakupWiersz> ZakupWiersz { get; set; }
            public JPKZakupCtrl ZakupCtrl { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class TNaglowek
        {

            public TNaglowekKodFormularza KodFormularza { get; set; }
            public sbyte WariantFormularza { get; set; }
            public sbyte CelZlozenia { get; set; }
            public System.DateTime DataWytworzeniaJPK { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataOd { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataDo { get; set; }
            public currCode_Type DomyslnyKodWaluty { get; set; }
            public TKodUS KodUrzedu { get; set; }

            public TNaglowek()
            {
                this.KodFormularza = new TNaglowekKodFormularza();
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class TNaglowekKodFormularza
        {

            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string kodSystemowy { get; set; }
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string wersjaSchemy { get; set; }
            [System.Xml.Serialization.XmlTextAttribute()]
            public TKodFormularza Value { get; set; }

            public TNaglowekKodFormularza()
            {
                this.kodSystemowy = "JPK_VAT (2)";
                this.wersjaSchemy = "1-0";
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public enum TKodFormularza
        {

            /// <remarks/>
            JPK_VAT,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class TAdresJPK
        {

            public TKodKraju KodKraju { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Wojewodztwo { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Powiat { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Gmina { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Ulica { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string NrDomu { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string NrLokalu { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Miejscowosc { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string KodPocztowy { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Poczta { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/")]
        public enum TKodKraju
        {

            /// <remarks/>
            AF,

            /// <remarks/>
            AX,

            /// <remarks/>
            AL,

            /// <remarks/>
            DZ,

            /// <remarks/>
            AD,

            /// <remarks/>
            AO,

            /// <remarks/>
            AI,

            /// <remarks/>
            AQ,

            /// <remarks/>
            AG,

            /// <remarks/>
            AN,

            /// <remarks/>
            SA,

            /// <remarks/>
            AR,

            /// <remarks/>
            AM,

            /// <remarks/>
            AW,

            /// <remarks/>
            AU,

            /// <remarks/>
            AT,

            /// <remarks/>
            AZ,

            /// <remarks/>
            BS,

            /// <remarks/>
            BH,

            /// <remarks/>
            BD,

            /// <remarks/>
            BB,

            /// <remarks/>
            BE,

            /// <remarks/>
            BZ,

            /// <remarks/>
            BJ,

            /// <remarks/>
            BM,

            /// <remarks/>
            BT,

            /// <remarks/>
            BY,

            /// <remarks/>
            BO,

            /// <remarks/>
            BA,

            /// <remarks/>
            BW,

            /// <remarks/>
            BR,

            /// <remarks/>
            BN,

            /// <remarks/>
            IO,

            /// <remarks/>
            BG,

            /// <remarks/>
            BF,

            /// <remarks/>
            BI,

            /// <remarks/>
            XC,

            /// <remarks/>
            CL,

            /// <remarks/>
            CN,

            /// <remarks/>
            HR,

            /// <remarks/>
            CY,

            /// <remarks/>
            TD,

            /// <remarks/>
            ME,

            /// <remarks/>
            DK,

            /// <remarks/>
            DM,

            /// <remarks/>
            DO,

            /// <remarks/>
            DJ,

            /// <remarks/>
            EG,

            /// <remarks/>
            EC,

            /// <remarks/>
            ER,

            /// <remarks/>
            EE,

            /// <remarks/>
            ET,

            /// <remarks/>
            FK,

            /// <remarks/>
            FJ,

            /// <remarks/>
            PH,

            /// <remarks/>
            FI,

            /// <remarks/>
            FR,

            /// <remarks/>
            TF,

            /// <remarks/>
            GA,

            /// <remarks/>
            GM,

            /// <remarks/>
            GH,

            /// <remarks/>
            GI,

            /// <remarks/>
            GR,

            /// <remarks/>
            GD,

            /// <remarks/>
            GL,

            /// <remarks/>
            GE,

            /// <remarks/>
            GU,

            /// <remarks/>
            GG,

            /// <remarks/>
            GY,

            /// <remarks/>
            GF,

            /// <remarks/>
            GP,

            /// <remarks/>
            GT,

            /// <remarks/>
            GN,

            /// <remarks/>
            GQ,

            /// <remarks/>
            GW,

            /// <remarks/>
            HT,

            /// <remarks/>
            ES,

            /// <remarks/>
            HN,

            /// <remarks/>
            HK,

            /// <remarks/>
            IN,

            /// <remarks/>
            ID,

            /// <remarks/>
            IQ,

            /// <remarks/>
            IR,

            /// <remarks/>
            IE,

            /// <remarks/>
            IS,

            /// <remarks/>
            IL,

            /// <remarks/>
            JM,

            /// <remarks/>
            JP,

            /// <remarks/>
            YE,

            /// <remarks/>
            JE,

            /// <remarks/>
            JO,

            /// <remarks/>
            KY,

            /// <remarks/>
            KH,

            /// <remarks/>
            CM,

            /// <remarks/>
            CA,

            /// <remarks/>
            QA,

            /// <remarks/>
            KZ,

            /// <remarks/>
            KE,

            /// <remarks/>
            KG,

            /// <remarks/>
            KI,

            /// <remarks/>
            CO,

            /// <remarks/>
            KM,

            /// <remarks/>
            CG,

            /// <remarks/>
            CD,

            /// <remarks/>
            KP,

            /// <remarks/>
            XK,

            /// <remarks/>
            CR,

            /// <remarks/>
            CU,

            /// <remarks/>
            KW,

            /// <remarks/>
            LA,

            /// <remarks/>
            LS,

            /// <remarks/>
            LB,

            /// <remarks/>
            LR,

            /// <remarks/>
            LY,

            /// <remarks/>
            LI,

            /// <remarks/>
            LT,

            /// <remarks/>
            LV,

            /// <remarks/>
            LU,

            /// <remarks/>
            MK,

            /// <remarks/>
            MG,

            /// <remarks/>
            YT,

            /// <remarks/>
            MO,

            /// <remarks/>
            MW,

            /// <remarks/>
            MV,

            /// <remarks/>
            MY,

            /// <remarks/>
            ML,

            /// <remarks/>
            MT,

            /// <remarks/>
            MP,

            /// <remarks/>
            MA,

            /// <remarks/>
            MQ,

            /// <remarks/>
            MR,

            /// <remarks/>
            MU,

            /// <remarks/>
            MX,

            /// <remarks/>
            XL,

            /// <remarks/>
            FM,

            /// <remarks/>
            UM,

            /// <remarks/>
            MD,

            /// <remarks/>
            MC,

            /// <remarks/>
            MN,

            /// <remarks/>
            MS,

            /// <remarks/>
            MZ,

            /// <remarks/>
            MM,

            /// <remarks/>
            NA,

            /// <remarks/>
            NR,

            /// <remarks/>
            NP,

            /// <remarks/>
            NL,

            /// <remarks/>
            DE,

            /// <remarks/>
            NE,

            /// <remarks/>
            NG,

            /// <remarks/>
            NI,

            /// <remarks/>
            NU,

            /// <remarks/>
            NF,

            /// <remarks/>
            NO,

            /// <remarks/>
            NC,

            /// <remarks/>
            NZ,

            /// <remarks/>
            PS,

            /// <remarks/>
            OM,

            /// <remarks/>
            PK,

            /// <remarks/>
            PW,

            /// <remarks/>
            PA,

            /// <remarks/>
            PG,

            /// <remarks/>
            PY,

            /// <remarks/>
            PE,

            /// <remarks/>
            PN,

            /// <remarks/>
            PF,

            /// <remarks/>
            PL,

            /// <remarks/>
            GS,

            /// <remarks/>
            PT,

            /// <remarks/>
            PR,

            /// <remarks/>
            CF,

            /// <remarks/>
            CZ,

            /// <remarks/>
            KR,

            /// <remarks/>
            ZA,

            /// <remarks/>
            RE,

            /// <remarks/>
            RU,

            /// <remarks/>
            RO,

            /// <remarks/>
            RW,

            /// <remarks/>
            EH,

            /// <remarks/>
            BL,

            /// <remarks/>
            KN,

            /// <remarks/>
            LC,

            /// <remarks/>
            MF,

            /// <remarks/>
            VC,

            /// <remarks/>
            SV,

            /// <remarks/>
            WS,

            /// <remarks/>
            AS,

            /// <remarks/>
            SM,

            /// <remarks/>
            SN,

            /// <remarks/>
            RS,

            /// <remarks/>
            SC,

            /// <remarks/>
            SL,

            /// <remarks/>
            SG,

            /// <remarks/>
            SK,

            /// <remarks/>
            SI,

            /// <remarks/>
            SO,

            /// <remarks/>
            LK,

            /// <remarks/>
            PM,

            /// <remarks/>
            US,

            /// <remarks/>
            SZ,

            /// <remarks/>
            SD,

            /// <remarks/>
            SR,

            /// <remarks/>
            SJ,

            /// <remarks/>
            SH,

            /// <remarks/>
            SY,

            /// <remarks/>
            CH,

            /// <remarks/>
            SE,

            /// <remarks/>
            TJ,

            /// <remarks/>
            TH,

            /// <remarks/>
            TW,

            /// <remarks/>
            TZ,

            /// <remarks/>
            TG,

            /// <remarks/>
            TK,

            /// <remarks/>
            TO,

            /// <remarks/>
            TT,

            /// <remarks/>
            TN,

            /// <remarks/>
            TR,

            /// <remarks/>
            TM,

            /// <remarks/>
            TV,

            /// <remarks/>
            UG,

            /// <remarks/>
            UA,

            /// <remarks/>
            UY,

            /// <remarks/>
            UZ,

            /// <remarks/>
            VU,

            /// <remarks/>
            WF,

            /// <remarks/>
            VA,

            /// <remarks/>
            HU,

            /// <remarks/>
            VE,

            /// <remarks/>
            GB,

            /// <remarks/>
            VN,

            /// <remarks/>
            IT,

            /// <remarks/>
            TL,

            /// <remarks/>
            CI,

            /// <remarks/>
            BV,

            /// <remarks/>
            CX,

            /// <remarks/>
            IM,

            /// <remarks/>
            CK,

            /// <remarks/>
            VI,

            /// <remarks/>
            VG,

            /// <remarks/>
            HM,

            /// <remarks/>
            CC,

            /// <remarks/>
            MH,

            /// <remarks/>
            FO,

            /// <remarks/>
            SB,

            /// <remarks/>
            ST,

            /// <remarks/>
            TC,

            /// <remarks/>
            ZM,

            /// <remarks/>
            CV,

            /// <remarks/>
            ZW,

            /// <remarks/>
            AE,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/")]
        public partial class TIdentyfikatorOsobyNiefizycznej
        {

            public string NIP { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string PelnaNazwa { get; set; }
            public string REGON { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2013/05/23/eD/KodyCECHKRAJOW/")]
        public enum currCode_Type
        {

            /// <remarks/>
            AED,

            /// <remarks/>
            AFN,

            /// <remarks/>
            ALL,

            /// <remarks/>
            AMD,

            /// <remarks/>
            ANG,

            /// <remarks/>
            AOA,

            /// <remarks/>
            ARS,

            /// <remarks/>
            AUD,

            /// <remarks/>
            AWG,

            /// <remarks/>
            AZN,

            /// <remarks/>
            BAM,

            /// <remarks/>
            BBD,

            /// <remarks/>
            BDT,

            /// <remarks/>
            BGN,

            /// <remarks/>
            BHD,

            /// <remarks/>
            BIF,

            /// <remarks/>
            BMD,

            /// <remarks/>
            BND,

            /// <remarks/>
            BOB,

            /// <remarks/>
            BOV,

            /// <remarks/>
            BRL,

            /// <remarks/>
            BSD,

            /// <remarks/>
            BTN,

            /// <remarks/>
            BWP,

            /// <remarks/>
            BYR,

            /// <remarks/>
            BZD,

            /// <remarks/>
            CAD,

            /// <remarks/>
            CDF,

            /// <remarks/>
            CHF,

            /// <remarks/>
            CLF,

            /// <remarks/>
            CLP,

            /// <remarks/>
            CNY,

            /// <remarks/>
            COP,

            /// <remarks/>
            COU,

            /// <remarks/>
            CRC,

            /// <remarks/>
            CUC,

            /// <remarks/>
            CUP,

            /// <remarks/>
            CVE,

            /// <remarks/>
            CZK,

            /// <remarks/>
            DJF,

            /// <remarks/>
            DKK,

            /// <remarks/>
            DOP,

            /// <remarks/>
            DZD,

            /// <remarks/>
            EEK,

            /// <remarks/>
            EGP,

            /// <remarks/>
            ERN,

            /// <remarks/>
            ETB,

            /// <remarks/>
            EUR,

            /// <remarks/>
            FJD,

            /// <remarks/>
            FKP,

            /// <remarks/>
            GBP,

            /// <remarks/>
            GEL,

            /// <remarks/>
            GHS,

            /// <remarks/>
            GIP,

            /// <remarks/>
            GMD,

            /// <remarks/>
            GNF,

            /// <remarks/>
            GTQ,

            /// <remarks/>
            GWP,

            /// <remarks/>
            GYD,

            /// <remarks/>
            HKD,

            /// <remarks/>
            HNL,

            /// <remarks/>
            HRK,

            /// <remarks/>
            HTG,

            /// <remarks/>
            HUF,

            /// <remarks/>
            IDR,

            /// <remarks/>
            ILS,

            /// <remarks/>
            INR,

            /// <remarks/>
            IQD,

            /// <remarks/>
            IRR,

            /// <remarks/>
            ISK,

            /// <remarks/>
            JMD,

            /// <remarks/>
            JOD,

            /// <remarks/>
            JPY,

            /// <remarks/>
            KES,

            /// <remarks/>
            KGS,

            /// <remarks/>
            KHR,

            /// <remarks/>
            KMF,

            /// <remarks/>
            KPW,

            /// <remarks/>
            KRW,

            /// <remarks/>
            KWD,

            /// <remarks/>
            KYD,

            /// <remarks/>
            KZT,

            /// <remarks/>
            LAK,

            /// <remarks/>
            LBP,

            /// <remarks/>
            LKR,

            /// <remarks/>
            LRD,

            /// <remarks/>
            LSL,

            /// <remarks/>
            LTL,

            /// <remarks/>
            LVL,

            /// <remarks/>
            LYD,

            /// <remarks/>
            MAD,

            /// <remarks/>
            MDL,

            /// <remarks/>
            MGA,

            /// <remarks/>
            MKD,

            /// <remarks/>
            MMK,

            /// <remarks/>
            MNT,

            /// <remarks/>
            MOP,

            /// <remarks/>
            MRO,

            /// <remarks/>
            MUR,

            /// <remarks/>
            MVR,

            /// <remarks/>
            MWK,

            /// <remarks/>
            MXN,

            /// <remarks/>
            MXV,

            /// <remarks/>
            MYR,

            /// <remarks/>
            MZN,

            /// <remarks/>
            NAD,

            /// <remarks/>
            NGN,

            /// <remarks/>
            NIO,

            /// <remarks/>
            NOK,

            /// <remarks/>
            NPR,

            /// <remarks/>
            NZD,

            /// <remarks/>
            OMR,

            /// <remarks/>
            PAB,

            /// <remarks/>
            PEN,

            /// <remarks/>
            PGK,

            /// <remarks/>
            PHP,

            /// <remarks/>
            PKR,

            /// <remarks/>
            PLN,

            /// <remarks/>
            PYG,

            /// <remarks/>
            QAR,

            /// <remarks/>
            RON,

            /// <remarks/>
            RSD,

            /// <remarks/>
            RUB,

            /// <remarks/>
            RWF,

            /// <remarks/>
            SAR,

            /// <remarks/>
            SBD,

            /// <remarks/>
            SCR,

            /// <remarks/>
            SDG,

            /// <remarks/>
            SEK,

            /// <remarks/>
            SGD,

            /// <remarks/>
            SHP,

            /// <remarks/>
            SLL,

            /// <remarks/>
            SOS,

            /// <remarks/>
            SRD,

            /// <remarks/>
            STD,

            /// <remarks/>
            SVC,

            /// <remarks/>
            SYP,

            /// <remarks/>
            SZL,

            /// <remarks/>
            THB,

            /// <remarks/>
            TJS,

            /// <remarks/>
            TMT,

            /// <remarks/>
            TND,

            /// <remarks/>
            TOP,

            /// <remarks/>
            TRY,

            /// <remarks/>
            TTD,

            /// <remarks/>
            TVD,

            /// <remarks/>
            TWD,

            /// <remarks/>
            TZS,

            /// <remarks/>
            UAH,

            /// <remarks/>
            UGX,

            /// <remarks/>
            USD,

            /// <remarks/>
            UYU,

            /// <remarks/>
            UZS,

            /// <remarks/>
            VEF,

            /// <remarks/>
            VND,

            /// <remarks/>
            VUV,

            /// <remarks/>
            WST,

            /// <remarks/>
            XAF,

            /// <remarks/>
            XCD,

            /// <remarks/>
            XOF,

            /// <remarks/>
            XPD,

            /// <remarks/>
            XPF,

            /// <remarks/>
            YER,

            /// <remarks/>
            ZAR,

            /// <remarks/>
            ZMK,

            /// <remarks/>
            ZWL,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/")]
        public enum TKodUS
        {

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0202")]
            Item0202,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0203")]
            Item0203,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0204")]
            Item0204,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0205")]
            Item0205,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0206")]
            Item0206,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0207")]
            Item0207,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0208")]
            Item0208,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0209")]
            Item0209,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0210")]
            Item0210,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0211")]
            Item0211,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0212")]
            Item0212,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0213")]
            Item0213,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0214")]
            Item0214,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0215")]
            Item0215,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0216")]
            Item0216,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0217")]
            Item0217,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0218")]
            Item0218,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0219")]
            Item0219,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0220")]
            Item0220,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0221")]
            Item0221,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0222")]
            Item0222,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0223")]
            Item0223,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0224")]
            Item0224,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0225")]
            Item0225,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0226")]
            Item0226,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0227")]
            Item0227,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0228")]
            Item0228,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0229")]
            Item0229,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0230")]
            Item0230,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0231")]
            Item0231,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0232")]
            Item0232,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0233")]
            Item0233,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0234")]
            Item0234,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0271")]
            Item0271,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0402")]
            Item0402,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0403")]
            Item0403,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0404")]
            Item0404,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0405")]
            Item0405,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0406")]
            Item0406,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0407")]
            Item0407,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0408")]
            Item0408,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0409")]
            Item0409,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0410")]
            Item0410,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0411")]
            Item0411,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0412")]
            Item0412,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0413")]
            Item0413,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0414")]
            Item0414,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0415")]
            Item0415,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0416")]
            Item0416,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0417")]
            Item0417,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0418")]
            Item0418,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0419")]
            Item0419,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0420")]
            Item0420,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0421")]
            Item0421,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0422")]
            Item0422,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0423")]
            Item0423,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0471")]
            Item0471,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0602")]
            Item0602,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0603")]
            Item0603,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0604")]
            Item0604,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0605")]
            Item0605,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0606")]
            Item0606,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0607")]
            Item0607,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0608")]
            Item0608,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0609")]
            Item0609,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0610")]
            Item0610,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0611")]
            Item0611,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0612")]
            Item0612,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0613")]
            Item0613,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0614")]
            Item0614,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0615")]
            Item0615,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0616")]
            Item0616,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0617")]
            Item0617,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0618")]
            Item0618,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0619")]
            Item0619,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0620")]
            Item0620,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0621")]
            Item0621,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0622")]
            Item0622,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0671")]
            Item0671,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0802")]
            Item0802,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0803")]
            Item0803,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0804")]
            Item0804,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0805")]
            Item0805,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0806")]
            Item0806,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0807")]
            Item0807,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0808")]
            Item0808,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0809")]
            Item0809,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0810")]
            Item0810,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0811")]
            Item0811,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0812")]
            Item0812,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0813")]
            Item0813,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0814")]
            Item0814,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("0871")]
            Item0871,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1002")]
            Item1002,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1003")]
            Item1003,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1004")]
            Item1004,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1005")]
            Item1005,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1006")]
            Item1006,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1007")]
            Item1007,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1008")]
            Item1008,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1009")]
            Item1009,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1010")]
            Item1010,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1011")]
            Item1011,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1012")]
            Item1012,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1013")]
            Item1013,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1014")]
            Item1014,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1015")]
            Item1015,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1016")]
            Item1016,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1017")]
            Item1017,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1018")]
            Item1018,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1019")]
            Item1019,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1020")]
            Item1020,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1021")]
            Item1021,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1022")]
            Item1022,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1023")]
            Item1023,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1024")]
            Item1024,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1025")]
            Item1025,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1026")]
            Item1026,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1027")]
            Item1027,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1028")]
            Item1028,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1029")]
            Item1029,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1071")]
            Item1071,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1202")]
            Item1202,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1203")]
            Item1203,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1204")]
            Item1204,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1205")]
            Item1205,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1206")]
            Item1206,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1207")]
            Item1207,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1208")]
            Item1208,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1209")]
            Item1209,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1210")]
            Item1210,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1211")]
            Item1211,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1212")]
            Item1212,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1213")]
            Item1213,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1214")]
            Item1214,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1215")]
            Item1215,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1216")]
            Item1216,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1217")]
            Item1217,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1218")]
            Item1218,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1219")]
            Item1219,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1220")]
            Item1220,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1221")]
            Item1221,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1222")]
            Item1222,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1223")]
            Item1223,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1224")]
            Item1224,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1225")]
            Item1225,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1226")]
            Item1226,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1227")]
            Item1227,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1228")]
            Item1228,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1271")]
            Item1271,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1402")]
            Item1402,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1403")]
            Item1403,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1404")]
            Item1404,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1405")]
            Item1405,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1406")]
            Item1406,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1407")]
            Item1407,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1408")]
            Item1408,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1409")]
            Item1409,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1410")]
            Item1410,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1411")]
            Item1411,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1412")]
            Item1412,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1413")]
            Item1413,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1414")]
            Item1414,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1415")]
            Item1415,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1416")]
            Item1416,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1417")]
            Item1417,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1418")]
            Item1418,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1419")]
            Item1419,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1420")]
            Item1420,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1421")]
            Item1421,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1422")]
            Item1422,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1423")]
            Item1423,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1424")]
            Item1424,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1425")]
            Item1425,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1426")]
            Item1426,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1427")]
            Item1427,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1428")]
            Item1428,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1429")]
            Item1429,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1430")]
            Item1430,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1431")]
            Item1431,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1432")]
            Item1432,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1433")]
            Item1433,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1434")]
            Item1434,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1435")]
            Item1435,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1436")]
            Item1436,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1437")]
            Item1437,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1438")]
            Item1438,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1439")]
            Item1439,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1440")]
            Item1440,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1441")]
            Item1441,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1442")]
            Item1442,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1443")]
            Item1443,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1444")]
            Item1444,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1445")]
            Item1445,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1446")]
            Item1446,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1447")]
            Item1447,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1448")]
            Item1448,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1449")]
            Item1449,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1471")]
            Item1471,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1472")]
            Item1472,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1473")]
            Item1473,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1602")]
            Item1602,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1603")]
            Item1603,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1604")]
            Item1604,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1605")]
            Item1605,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1606")]
            Item1606,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1607")]
            Item1607,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1608")]
            Item1608,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1609")]
            Item1609,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1610")]
            Item1610,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1611")]
            Item1611,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1612")]
            Item1612,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1613")]
            Item1613,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1671")]
            Item1671,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1802")]
            Item1802,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1803")]
            Item1803,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1804")]
            Item1804,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1805")]
            Item1805,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1806")]
            Item1806,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1807")]
            Item1807,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1808")]
            Item1808,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1809")]
            Item1809,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1810")]
            Item1810,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1811")]
            Item1811,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1812")]
            Item1812,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1813")]
            Item1813,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1814")]
            Item1814,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1815")]
            Item1815,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1816")]
            Item1816,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1817")]
            Item1817,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1818")]
            Item1818,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1819")]
            Item1819,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1820")]
            Item1820,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1821")]
            Item1821,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1822")]
            Item1822,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1823")]
            Item1823,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("1871")]
            Item1871,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2002")]
            Item2002,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2003")]
            Item2003,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2004")]
            Item2004,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2005")]
            Item2005,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2006")]
            Item2006,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2007")]
            Item2007,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2008")]
            Item2008,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2009")]
            Item2009,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2010")]
            Item2010,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2011")]
            Item2011,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2012")]
            Item2012,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2013")]
            Item2013,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2014")]
            Item2014,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2015")]
            Item2015,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2071")]
            Item2071,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2202")]
            Item2202,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2203")]
            Item2203,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2204")]
            Item2204,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2205")]
            Item2205,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2206")]
            Item2206,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2207")]
            Item2207,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2208")]
            Item2208,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2209")]
            Item2209,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2210")]
            Item2210,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2211")]
            Item2211,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2212")]
            Item2212,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2213")]
            Item2213,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2214")]
            Item2214,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2215")]
            Item2215,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2216")]
            Item2216,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2217")]
            Item2217,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2218")]
            Item2218,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2219")]
            Item2219,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2220")]
            Item2220,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2221")]
            Item2221,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2271")]
            Item2271,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2402")]
            Item2402,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2403")]
            Item2403,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2404")]
            Item2404,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2405")]
            Item2405,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2406")]
            Item2406,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2407")]
            Item2407,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2408")]
            Item2408,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2409")]
            Item2409,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2410")]
            Item2410,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2411")]
            Item2411,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2412")]
            Item2412,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2413")]
            Item2413,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2414")]
            Item2414,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2415")]
            Item2415,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2416")]
            Item2416,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2417")]
            Item2417,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2418")]
            Item2418,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2419")]
            Item2419,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2420")]
            Item2420,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2421")]
            Item2421,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2422")]
            Item2422,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2423")]
            Item2423,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2424")]
            Item2424,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2425")]
            Item2425,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2426")]
            Item2426,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2427")]
            Item2427,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2428")]
            Item2428,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2429")]
            Item2429,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2430")]
            Item2430,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2431")]
            Item2431,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2432")]
            Item2432,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2433")]
            Item2433,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2434")]
            Item2434,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2435")]
            Item2435,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2436")]
            Item2436,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2471")]
            Item2471,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2472")]
            Item2472,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2602")]
            Item2602,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2603")]
            Item2603,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2604")]
            Item2604,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2605")]
            Item2605,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2606")]
            Item2606,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2607")]
            Item2607,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2608")]
            Item2608,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2609")]
            Item2609,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2610")]
            Item2610,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2611")]
            Item2611,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2612")]
            Item2612,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2613")]
            Item2613,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2614")]
            Item2614,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2615")]
            Item2615,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2671")]
            Item2671,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2802")]
            Item2802,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2803")]
            Item2803,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2804")]
            Item2804,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2805")]
            Item2805,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2806")]
            Item2806,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2807")]
            Item2807,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2808")]
            Item2808,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2809")]
            Item2809,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2810")]
            Item2810,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2811")]
            Item2811,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2812")]
            Item2812,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2813")]
            Item2813,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2814")]
            Item2814,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2815")]
            Item2815,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2816")]
            Item2816,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("2871")]
            Item2871,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3002")]
            Item3002,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3003")]
            Item3003,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3004")]
            Item3004,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3005")]
            Item3005,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3006")]
            Item3006,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3007")]
            Item3007,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3008")]
            Item3008,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3009")]
            Item3009,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3010")]
            Item3010,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3011")]
            Item3011,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3012")]
            Item3012,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3013")]
            Item3013,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3014")]
            Item3014,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3015")]
            Item3015,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3016")]
            Item3016,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3017")]
            Item3017,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3018")]
            Item3018,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3019")]
            Item3019,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3020")]
            Item3020,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3021")]
            Item3021,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3022")]
            Item3022,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3023")]
            Item3023,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3025")]
            Item3025,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3026")]
            Item3026,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3027")]
            Item3027,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3028")]
            Item3028,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3029")]
            Item3029,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3030")]
            Item3030,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3031")]
            Item3031,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3032")]
            Item3032,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3033")]
            Item3033,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3034")]
            Item3034,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3035")]
            Item3035,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3036")]
            Item3036,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3037")]
            Item3037,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3038")]
            Item3038,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3039")]
            Item3039,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3071")]
            Item3071,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3072")]
            Item3072,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3202")]
            Item3202,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3203")]
            Item3203,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3204")]
            Item3204,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3205")]
            Item3205,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3206")]
            Item3206,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3207")]
            Item3207,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3208")]
            Item3208,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3209")]
            Item3209,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3210")]
            Item3210,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3211")]
            Item3211,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3212")]
            Item3212,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3213")]
            Item3213,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3214")]
            Item3214,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3215")]
            Item3215,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3216")]
            Item3216,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3217")]
            Item3217,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3218")]
            Item3218,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3219")]
            Item3219,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3220")]
            Item3220,

            /// <remarks/>
            [System.Xml.Serialization.XmlEnumAttribute("3271")]
            Item3271,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class JPKPodmiot1
        {

            public TIdentyfikatorOsobyNiefizycznej IdentyfikatorPodmiotu { get; set; }
            public TAdresJPK AdresPodmiotu { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class JPKSprzedazWiersz
        {

            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LpSprzedazy { get; set; }
            public string NrKontrahenta { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string NazwaKontrahenta { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string AdresKontrahenta { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string DowodSprzedazy { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataWystawienia { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataSprzedazy { get; set; }
            public decimal K_10 { get; set; }
            public decimal K_11 { get; set; }
            public decimal K_12 { get; set; }
            public decimal K_13 { get; set; }
            public decimal K_14 { get; set; }
            public decimal K_15 { get; set; }
            public decimal K_16 { get; set; }
            public decimal K_17 { get; set; }
            public decimal K_18 { get; set; }
            public decimal K_19 { get; set; }
            public decimal K_20 { get; set; }
            public decimal K_21 { get; set; }
            public decimal K_22 { get; set; }
            public decimal K_23 { get; set; }
            public decimal K_24 { get; set; }
            public decimal K_25 { get; set; }
            public decimal K_26 { get; set; }
            public decimal K_27 { get; set; }
            public decimal K_28 { get; set; }
            public decimal K_29 { get; set; }
            public decimal K_30 { get; set; }
            public decimal K_31 { get; set; }
            public decimal K_32 { get; set; }
            public decimal K_33 { get; set; }
            public decimal K_34 { get; set; }
            public decimal K_35 { get; set; }
            public decimal K_36 { get; set; }
            public decimal K_37 { get; set; }
            public decimal K_38 { get; set; }
            public decimal K_39 { get; set; }
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string typ { get; set; }

            public JPKSprzedazWiersz()
            {
                this.typ = "G";
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class JPKSprzedazCtrl
        {

            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LiczbaWierszySprzedazy { get; set; }
            public decimal PodatekNalezny { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class JPKZakupWiersz
        {

            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LpZakupu { get; set; }
            public string NrDostawcy { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string NazwaDostawcy { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string AdresDostawcy { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string DowodZakupu { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataZakupu { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataWplywu { get; set; }
            public decimal K_43 { get; set; }
            public decimal K_44 { get; set; }
            public decimal K_45 { get; set; }
            public decimal K_46 { get; set; }
            public decimal K_47 { get; set; }
            public decimal K_48 { get; set; }
            public decimal K_49 { get; set; }
            public decimal K_50 { get; set; }
            [System.Xml.Serialization.XmlAttributeAttribute()]
            public string typ { get; set; }

            public JPKZakupWiersz()
            {
                this.typ = "G";
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1586.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2016/10/26/10261/")]
        public partial class JPKZakupCtrl
        {

            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LiczbaWierszyZakupow { get; set; }
            public decimal PodatekNaliczony { get; set; }
        }
    }
}