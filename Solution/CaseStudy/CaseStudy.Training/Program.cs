


// Behavioral(Davranışsal) Design Pattern
// Nesnelerin birbirleri ile ilişkisini düzenleyen desendir.

#region Behavioral

// Design Patterns # Behavioral # Davranissal # Chain of Responsibility # Sorumluluk Zinciri
// Bir amaca yönelik bir dizi işlemi gerçekleştiren nesnelerin birbirinden bağımsız bir şekilde çalışmasını
// Ornek : Resim format cevirme islemlerinin yapilmasi
// ##############################
// using CaseStudy.Training.DesignPatterns.Behavioral.ChainOfResponsibility;
// BehavioralChainOfResponsibility.ChainOfResponsibility();
// ##############################


// Design Patterns # Behavioral # Davranissal # Command # Komut Verme
// Kullanıcı isteklerini gerçekleştiren kod yapısını sarmallayarak nesneler halinde saklanmasını daha sonra da
// Bu isteklerin gerçekleştirilmesini veya geri alınmasını sağlayan tasarım desenidir.
// Ornek : Sepet islemlerinde ürünlerin sepete eklenirken kontrolleri sipariş tamamlanırken alınabilir onayları
// ##############################
// using CaseStudy.Training.DesignPatterns.Behavioral.Command;
// BehavioralCommand.Command();
// ##############################





#endregion




// Structural (Yapısal) Design Patterns
// Birden fazla sınıfın bir işi yerine getirirken nasıl
// davranacağını belirlemek için kullanılan desenlerdir. 

#region Structural

// Design Patterns # Structural # Yapısal # Adapter # Adapte - Uyarlama
// Bir sınıfın arayüzünü istemcinin beklediği arayüze çevirmeye yarar.
// Ornek : Json cevirme islemleri gibi islemleri kodları bozmadan Adapter ile yenisini yazma 
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Adapter;
// StructuralAdapter.JsonAdapter();
// ##############################


// Design Patterns # Structural # Yapısal # Bridge # Köprü
// Bağımsız olarak geliştirilebilir iki yapı elde etmemize yarar.
// Sisteminizde 2 farklı yapı grubu var. Bu grupların farklı farklı gerçekleştirimleri bulunuyor.
// Bu yapıların birbirlerini gerçekleştirim seviyesi bilmesi yerine belli interface(arayüzler)
// üzerinden referanslarını tutarak kullanması, karmaşık hiyerarşik yapıların önüne geçecektir.
// Ornek : Mail ve Sms Gonderme Gibi Sistemlerin Bir biriyle iliskisi
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Bridge;
// StructuralBridge.Bridge();
// ##############################


// Design Patterns # Structural # Yapısal # Composite # Birleştirme - Katlama
// Composite tasarım deseni, nesneleri ağaç yapısına göre düzenleyerek
// Ağaç yapısındaki alt üst ilişkisini kurmaya yarayan bir desendir.
// Composite Birçok parçalardan oluşan anlamına gelmektedir.
// Ornek : Menu ve Rol gibi ast ust iliskilerde kullanılabilir
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Composite;
// StructuralComposite.Composite();
// ##############################


// Design Patterns # Structural # Yapısal # Decorator # Dekorasyon
// Decorator tasarım deseni, nesnelere dinamik olarak yeni sorumluluklar atamamızı sağlayan tasarım desenidir.
// Bildirim yapısı oluşturulduğunu düşünelim Email ve Sms Bildirimlerine Birde Mobil Bildirimi Ekleyebiliriz
// Ornek : Bir Log Sistemi Gelistirdik ve Mevcut Yapıyı Bozmadan Sıkıstırma Ozelligini Eklemek İstiyoruz
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Decorator;
// StructuralDecorator.Decorator();
// ##############################


// Design Patterns # Structural # Yapısal # Facade # Dışgörünüş - Cephe
// Facade tasarım deseni, bir alt sistemdeki arayüzlere bir birleşik arayüz sağlayarak
// Alt sistemin kullanımını daha kolay hale getirmeyi amaçlar.
// Ornek : Kredi Kartı Kara Liste ve Oluşturma islemleri
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Facade;
// StructuralFacade.Facade();
// ##############################


// Design Patterns # Structural # Yapısal # Flyweight # Sinek Ağırlık
// Flyweight tasarım deseni, sık kullanılan nesnelerin bellek yönetimini kontrol etmesi için
// kullanılan bir tasarım desenidir.
// Ornek : 2 Farklı Kutunun Bir kez üretilmesi ve yönetilmesi
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Flyweight;
// StructuralFlyweight.Flyweight();
// ##############################

// Design Patterns # Structural # Yapısal # Proxy # Vekil
// Proxy tasarım deseni, istemcinin orijinal nesneye direkt erişimi yerine bu erişimi nesneyi
// temsil eden proxy (vekil) sınıflar üzerinden gerçekleştirmesini ve bu proxy (vekil)
// sınıfların sunduğu imkanları kullanmasını sağlayan tasarım desenidir.
// Ornek : Veritabanı Kayıt Yapılmadan Once Yapılan Kontroller
// ##############################
// using CaseStudy.Training.DesignPatterns.Structural.Proxy;
// StructuralProxy.Proxy();
// ##############################

#endregion

// Creational (Olusturma) Design Patterns
// Nesnelerin oluşturulmasında ve yönetilmesinde kullanılan bir desendir.
// Bu program akışında hangi nesneye ihtiyaç varsa onu oluşturmada esneklik ve kolaylık sağlar.
#region Creational

// Design Patterns # Creational # Olusturucu # Prototype
// Prototype tasarım deseni, mevcut nesnelerin prototiplerinin oluşturulmasını yani
// nesnelerin kopyalarını elde etmeyi sağlayan bir tasarım desenidir.
// Nesnelerin Kopyalanmasını Sağlayan Yapı
// Shallow Copy ve Deep Copy olmak üzere iki tür nesne kopyalama işlemi mevcuttur.
// Shallow Copy ile nesnelerin bellekteki adresleri kopyalanmaktadır
// Deep Copy ile nesneler birebir kopyalanabilmekte
// Örnek : Bir Entity Kopyalama
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.Prototype;
// CreationalPrototype.PrototypeCreate();
// ##############################

// Design Patterns # Creational # Olusturucu # Builder
// Builder deseni, karmaşık yapıdaki nesnelerin oluşturulmasında istemcinin sadece nesne tipini
// belirterek üretimi gerçekleştirebilmesini sağlamak için kullanılan bir desendir.
// Bu desende istemcinin kullanmak istediği gerçek ürünün birden fazla sunumunun olduğu durumlarda kullanılır.
// Bir Grup İşlemde 
// Ornek : Ders Gruplarının indirimleri , Personellerin Aktiflik Pasiflik Durumları 
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.Builder;
// CreationalBuilder.BuildCreate();
// ##############################

// Design Patterns # Creational # Olusturucu # AbstractFactory
// Abstract Factory Tasarım Deseni Birbirleri ile iliskili Urun Ailesini Olusturmak icin Bir Arayuz Saglar.
// Örnek : Birden Fazla Veritabanı Desteklenmesi İçin Bir Yapının Oluşması
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.AbstractFactory;
// CreationalAbstractFactory.AbstractFactoryCreate();
// ##############################

// Design Patterns # Creational # Olusturucu # Factory
// Factory Tasarım Deseni Birbirleri ile iliskili Nesneleri Olusturmak icin Bir Arayuz Saglar ve Alt 
// Siniflarin Hangi Sinifin Ornegini Olusturacagina Olanak Saglar.
// Örnek : Sms ve Email Gonderimi Gibi islemleri birbirine Baglar
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.Factory;
// CreationalFactory.CreateFactory();
// ##############################

// Design Patterns # Creational # Olusturucu # Singleton
// Bir Sinifin Sadece Bir Ornegi Olmalıdır Ve Bu Ornege Global Bir Erisim Noktasi Saglanmalıdır.
// Ornek : Connection Olusturmada Tek Nesne Uretme
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.Singleton;
// CreationalSingleton.CreateDatabase();
// ##############################

#endregion















// General
// Abstract Kullanımı
// ##############################
// using CaseStudy.Training.AbstractTraining;
// AbstractTraining.AbstractTrainingClient();
// ##############################


// General
// Mssql Database Connection Test
// ##############################
// using CaseStudy.Training.General;
// Console.WriteLine(CaseDbConnect.CaseConnect());
// ##############################


Console.ReadKey();
