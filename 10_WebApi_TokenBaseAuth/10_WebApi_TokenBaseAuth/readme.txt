KONFİGURASYON AYARLARI

1-) Microsoft.AspNet.WebApi.Owin
2-) Microsoft.Owin.Host.SystemWeb
3-) Microsoft.Owin.Security.OAuth

Owin middleware sayesinde sosyal medya hesaplarına entegrasyon yapabiliyoruz. Aynı zamanda authentication ve authorization gibi işlemler owin üzerinden yönetilebiliyor. .Net tarafından KATANA isimli projeyle geliştirilen opensource bir web arayüzüdür. Open Web Interface for .Net (.Net için açık web arayüzü) . Bu tanımlamadaki amaç ise sunucu ve uygulamaları birbirlerinden net çizgilerle ayırmak ve uygulamaları sunuculardan bağımsız hale getirmek.

OWIN tanımladığı standart ile uyumlu geliştirilen web sunucuları, IIS gibi kompleks ve pek çok senaryoyu aynı anda destekleyen sunucuları yerine, geliştiricilerin istediği bileşenleri uygulamaların ihtiyaçları doğrultusunda birleştirdiği ve yalın HTTP’nin hemen üzerinde yer alan ince bir katman olarak düşünülebilir. Sadece geliştirici olarak bizlerin ihtiyacı olan modüllerin yüklenmesi beraberinde önemli bir performans kazanımı getirmekle birlikte, aynı zamanda sunucu yüzeyini küçülterek olası saldırıların sayısını da azaltacaktır.

Microsoft Owin yapısı developer için bir standartlar dizisi belirliyor. Bu standartlar dizisinin yapılma amacı bir web uygulaması ile bir web servisini birbirinden ayırmak yani decoupling işlemini gerçekleştirmek. Decoupling işleminin faydasından kısaca bahsetmemiz gerekirse, decoupling sayesinde uygulamalarımızın web server'a (iis, tomcat, glassfish gibi..) özel yazılmış uygulamalar olmasından ziyade, web server bağımsız ya da portable uygulamalar olmasını sağlamaktayız. Bu sayede bir web uygulaması iis'e bağlı olmadan ya da söz gelimi başka bir sunucu'ya bağlı olmadan çalışabiliyor ve gerektiğinde taşınabiliyor olmalıdır. Hatta ve hatta Owin ile kendi web sunucularınızı (Node.Js'te olduğu gibi) bile yazabilirsiniz. Microsoft Owin yapısının görevi bu decoupling işlemini sağlayan bir ara katman (middleware) sağlamaktır. Bu Middleware, içinde token authentication için, selfHost application yazmak için vs yardımcı sınıflar da bulunduruarak web uygulaması üretim sürecini daha kolay ve verimli hale getirmektedir.

Microsoft.Owin.Host.SystemWeb self hosting yapmayacağımızdan iss üzerinde web api yayınlayacağımızdan dolayı indirdiğimiz dll

Microsoft.Owin.Security.OAuth Open Authentication ile bu protokolü kullanan diğer projelerle entegrasyon yapabilmek için yüklüyoruz. Facebook, Google, Instagram hesap bağlantıları gibi


  En kısa tanımla OAuth, kullanıcıların üyesi oldukları bir site yada platformun şifresini üye oldukları başka bir web sitesi yada platformla paylaşmadan, izin verdiği bilgilere diğer site tarafından ulaşılmasını sağlayan bir kimlik doğrulama protokolüdür.

  Burada protokol kelimesinin altını çizmek istiyorum. Zira OAuth’u bir yazılım yada kütüphane olarak görmek çok yanlıştır.Yani aslında OAuth yukarıda tanımını yaptığımız işlem ile ilgili adımlar ve kurallar bütünüdür. Örneğin HTTP yada FTP birer protokoldür. Bu protokole uyarak yazılmış kütüphaneler ve yazılımlar birbirleriyle iletişime geçebilir. OAuth için de yazılmış hazır kütüphaneler ve yazılımlar mecvuttur.