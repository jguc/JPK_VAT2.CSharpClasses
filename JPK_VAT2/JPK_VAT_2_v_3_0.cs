// Copyright (c) 2018 Jakub Guc
// See https://github.com/jguc/JPK_VAT2.CSharpClasses for reference and examples

using System.Collections.Generic;

namespace JGuc.Legislation.PL.JPK
{
    public class JPK_VAT_2_v_3_0
    {
        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/", IsNullable = false)]
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

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        public partial class TNaglowek
        {
            public TNaglowekKodFormularza KodFormularza { get; set; }
            public sbyte WariantFormularza { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string CelZlozenia { get; set; }
            public System.DateTime DataWytworzeniaJPK { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataOd { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
            public System.DateTime DataDo { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string NazwaSystemu { get; set; }

            public TNaglowek()
            {
                this.KodFormularza = new TNaglowekKodFormularza();
                this.CelZlozenia = "0";
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
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
                this.kodSystemowy = "JPK_VAT (3)";
                this.wersjaSchemy = "1-1";
            }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        public enum TKodFormularza
        {
            /// <remarks/>
            JPK_VAT,
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        public partial class JPKPodmiot1
        {
            public string NIP { get; set; }

            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string PelnaNazwa { get; set; }
            [System.Xml.Serialization.XmlElementAttribute(DataType = "token")]
            public string Email { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
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
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        public partial class JPKSprzedazCtrl
        {
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LiczbaWierszySprzedazy { get; set; }
            public decimal PodatekNalezny { get; set; }
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
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
        }

        [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.2102.0")]
        [System.SerializableAttribute()]
        [System.Diagnostics.DebuggerStepThroughAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/")]
        public partial class JPKZakupCtrl
        {
            [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
            public string LiczbaWierszyZakupow { get; set; }
            public decimal PodatekNaliczony { get; set; }
        }
    }
#pragma warning restore
}