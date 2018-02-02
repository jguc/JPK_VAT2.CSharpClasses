# JPK VAT2 C# Classes

JPK files are Polish equivalent of [Standard Audit File for Tax (SAF-T)](https://en.wikipedia.org/wiki/SAF-T).
It is regulated by [Ministry of Finance](http://www.mf.gov.pl) and required that entrapenurers from self-employed to large companies send jpk xml files, which can be done using official "Klient JPK" application.

This repository contains ready to use c# classes that will allow you to generate valid xml files that were validated with [official XSD files from Polish Ministry of Finance](http://www.mf.gov.pl/in/kontrola-skarbowa/dzialalnosc/jednolity-plik-kontrolny/-/asset_publisher/2NoO/content/struktury-jpk). File schemes change from time to time so be sure to check for the lates updates on offcial site.

### Remember to use corresponding namespaces

```cs
    // Example for JPK VAT2 v3 scheme v.1-1
    
    var nameSpaces = new XmlSerializerNamespaces();
    nameSpaces.Add("", "http://jpk.mf.gov.pl/wzor/2017/11/13/1113/");
    nameSpaces.Add("etd", "http://crd.gov.pl/xml/schematy/dziedzinowe/mf/2016/01/25/eD/DefinicjeTypy/");

    var jpkSerializer = new XmlSerializer(typeof(JPK_VAT_2_v_3_0.JPK));

    using (var xmlStream = new MemoryStream())
    {
        xmlStream.Seek(0, SeekOrigin.Begin);
        jpkSerializer.Serialize(xmlStream, jpkVat, nameSpaces);
        
        [...]
    }
```

### See also
>> PL : [https://pl.wikipedia.org/wiki/Jednolity_Plik_Kontrolny](https://pl.wikipedia.org/wiki/Jednolity_Plik_Kontrolny)
>> PL : [http://www.finanse.mf.gov.pl/web/wp/pp/jpk/jpk_vat-ogolnie](http://www.finanse.mf.gov.pl/web/wp/pp/jpk/jpk_vat-ogolnie)
>> PL : [http://www.finanse.mf.gov.pl/pp/jpk/klient-jpk](http://www.finanse.mf.gov.pl/pp/jpk/klient-jpk)