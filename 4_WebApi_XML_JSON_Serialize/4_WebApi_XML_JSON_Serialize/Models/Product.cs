using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace _4_WebApi_XML_JSON_Serialize.Models

/*

 DataContractSerializer özellikleri

/// Eğer default da DataContact attibute'unu kullanmasaydık zaten DataContractSerializer sınıfı ile aşağıdaki kurallara göre serilize işlemi otomatik olarak gerçekleştirilecekti. [DataContract] sayesinde sadece bu işlemi daha kontrollü yapmış oluyoruz.
/// 
/// defaultta tüm açılmış read/write hakkında sahip propertyler public olduğu sürece dışarı çıkabilir.
/// private vaya protected üyeler serilize olmaz
/// eğer bir property'nin serilize olmasını istemiyorsak IgnoreDataMember  attribute kullanabiliriz.
/// Read-Only property serilize olmaz
/// sınıf ve üyelerin dışarı çıkıştaki xml semalarını değiştiremeyiz
/// default xml seması kullanır namespace ayarı yapılmaz


   DataContract Attribute özellikleri

   property veya fieldlar default da serilize olmaz.
   serilize olması için  [DataMember] kullanılır.
   read-only property serilize olmaz
   private veya protected üyeleri [DataMember] attribute ile serilize edebiliriz.
   Name parameter ile XML de serilize ettiğimiz sınıfın ismini değiştirebiliriz.
   Name parameter özelliliği ile dışarı çıkardığımız üyelerin isimlerini değiştirebiliriz.
   XMl şemasını Namespace ayarı yapabiliriz.
*/
{
    [DataContract(Name = "ÜrünServisi",Namespace = "www.test.com/Urunler")]
    public class Product
    {
        public int Id { get; set; }


        [DataMember(Name = "ürün_adi")] //Sadece DataMember yazan üyeler dışarı çıkabilir.
        public string ProductName { get; set; }


        [DataMember(Name = "stok_miktari")]
        public int Stock { get; set; }


        [DataMember(Name = "fiyat")]
        public decimal Price { get; set; }

        private int MinimumSiparis { get; set; }

    }
}