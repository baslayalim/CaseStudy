﻿


// Structural (Yapısal) Design Patterns
// Birden fazla sınıfın bir işi yerine getirirken nasıl
// davranacağını belirlemek için kullanılan desenlerdir. 




// Behavioral(Davranışsal) Design Pattern
// Nesnelerin birbirleri ile ilişkisini düzenleyen desendir.



// Creational (Yaratımsal) Design Patterns
// Nesnelerin oluşturulmasında ve yönetilmesinde kullanılan bir desendir.
// Bu program akışında hangi nesneye ihtiyaç varsa onu oluşturmada esneklik ve kolaylık sağlar.
#region Creational

// Design Patterns # Creational # Olusturucu # Prototype
// Prototype tasarım deseni, mevcut nesnelerin prototiplerinin oluşturulmasını yani
// nesnelerin kopyalarını elde etmeyi sağlayan bir tasarım desenidir.
// Nesnelerin Kopyalanmasını Sağlayan Yapı
// ##############################
// using CaseStudy.Training.DesignPatterns.Creational.Prototype;
// CreationalPrototype.PrototypeCreate();
// ##############################

// Design Patterns # Creational # Olusturucu # Builder
// Builder deseni, karmaşık yapıdaki nesnelerin oluşturulmasında istemcinin sadece nesne tipini
// belirterek üretimi gerçekleştirebilmesini sağlamak için kullanılan bir desendir.
// Bu desende istemcinin kullanmak istediği gerçek ürünün birden fazla sunumunun olduğu durumlarda kullanılır.
// Bir Grup İşlemde 
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
