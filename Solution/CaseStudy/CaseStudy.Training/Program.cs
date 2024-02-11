using System.Data.SqlClient;

Console.WriteLine("CaseStudy.Training");


string BaglantiAdresi = "Server=GNB028;Database=Deneme;Trusted_Connection=SSPI;Encrypt=false;TrustServerCertificate=true;";
SqlConnection Baglanti = new SqlConnection();
Baglanti.ConnectionString = BaglantiAdresi;
Baglanti.Open();

Console.WriteLine("Baglandı ...");

Console.ReadKey();
