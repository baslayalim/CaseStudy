using CaseStudy.Api.CustomCqrsMediator.Features.Commands.Product.UpdateProdcut;
using CaseStudy.Application.Repositories;
using CaseStudy.Application.RequestParameters;
using CaseStudy.Application.ViewModels.Products;
using CaseStudy.Domain.Entities;
using CaseStudy.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;
using System.Net;

namespace CaseStudy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;
        readonly ILogger<UpdateProductCommandHandler> _logger;

        public ProductsController(
            IProductWriteRepository productWriteRepository,
            IProductReadRepository productReadRepository,
            ILogger<UpdateProductCommandHandler> logger)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _logger = logger;
        }

        [HttpGet]
        public Task<IActionResult> Get()
        {
            _logger.LogInformation("Product Get LogInformation");
            _logger.LogCritical("Product Get LogCritical");
            _logger.LogError("Product Get LogError");
            _logger.LogWarning("Product Get LogWarning");

            return Task.FromResult<IActionResult>(Ok(_productReadRepository.GetAll(false)));

        }

        [HttpGet("Query")]
        public async Task<IActionResult> GetQuery()
        {


            //var x = _productReadRepository.Table.Where(s => s.Product_Description.Contains("f") || s.Name.Equals("16 Test-42")).ToList();


            #region En Temel Basit Bir Sorgulama Nasıl Yapılır?
            #region Method Syntax
            //var product = await _productReadRepository.Table.ToListAsync();
          
            #endregion
            #region Query Syntax
            //var product2 = await (from urun in _productReadRepository.Table
            //                      select urun).ToListAsync();
            #endregion
            #endregion
    
            #region Sorguyu Execute Etmek İçin Ne Yapmamız Gerekmektedir?
            #region ToListAsync 
            #region Method Syntax
            //var product = await context.product.ToListAsync();
            #endregion
            #region Query Syntax
            //var product = await (from urun in context.product
            //select urun).ToListAsync();
            #endregion
            #endregion

            //int urunId = 5;
            //string urunAdi = "2";

            //var product = from urun in context.product
            //              where urun.Id > urunId && urun.UrunAdi.Contains(urunAdi)
            //              select urun;

            //urunId = 200;
            //urunAdi = "4";

            //foreach (Urun urun in product)
            //{
            //    Console.WriteLine(urun.UrunAdi);
            //}

            //await product.ToListAsync();

            #region Foreach

            //foreach (Urun urun in product)
            //{
            //    Console.WriteLine(urun.UrunAdi);
            //}

            #region Deferred Execution(Ertelenmiş Çalışma)
            //IQueryable çalışmalarında ilgili kod yazıldığı noktada tetiklenmez/çalıştırılmaz yani ilgili kod yazıldığı noktada sorguyu generate etmez! Nerede eder? Çalıştırıldığı/execute edildiği noktada tetiklenir! İşte bu durumada ertelenmiş çalışma denir!
            #endregion
            #endregion
            #endregion

            #region IQueryable ve IEnumerable Nedir? Basit Olarak!

            //var productIQ = await (from urun in _productReadRepository.Table
            //                     select urun).ToListAsync();
            //;
            //var CaseStudy = productIQ.Where(s => s.Product_Description.Contains("Ü")).ToList();
            //;
            #region IQueryable
            //Sorguya karşılık gelir.
            //Ef core üzerinden yapılmış olan sorgunun execute edilmemiş halini ifade eder.
            #endregion
            #region IEnumerable
            //Sorgunun çalıştırılıp/execute edilip verilerin in memorye yüklenmiş halini ifade eder.
            #endregion
            #endregion

            #region Çoğul Veri Getiren Sorgulama Fonksiyonları
            #region ToListAsync
            //Üretilen sorguyu execute ettirmemizi sağlayan fonksiyondur.

            #region Method Syntax
            //var product = context.product.ToListAsync();
            #endregion
            #region Query Syntax
            //var product = (from urun in context.product
            //              select urun).ToListAsync();
            //var product = from urun in context.product
            //              select urun;
            //var datas = await product.ToListAsync();
            #endregion
            #endregion

            #region Where
            //Oluşturulan sorguya where şartı eklememizi sağlayan bir fonksiyondur.

            #region Method Syntax
            //var product = await context.product.Where(u => u.Id > 500).ToListAsync();
            //var product = await context.product.Where(u => u.UrunAdi.StartsWith("a")).ToListAsync();
            //Console.WriteLine();
            #endregion
            #region Query Syntax
            //var product = from urun in context.product
            //              where urun.Id > 500 && urun.UrunAdi.EndsWith("7")
            //              select urun;
            //var data = await product.ToListAsync();
            //Console.WriteLine();
            #endregion
            #endregion

            #region OrderBy
            //Sorgu üzerinde sıralama yapmamızı sağlayan bir fonksiyondur. (Ascending)

            #region Method Syntax
            //var product = context.product.Where(u => u.Id > 500 || u.UrunAdi.EndsWith("2")).OrderBy(u => u.UrunAdi);
            #endregion
            #region Query Syntax
            //var product2 = from urun in context.product
            //               where urun.Id > 500 || urun.UrunAdi.StartsWith("2")
            //               orderby urun.UrunAdi
            //               select urun;
            #endregion

            //await product.ToListAsync();
            //await product2.ToListAsync();
            #endregion

            #region ThenBy
            //OrderBy üzerinde yapılan sıralama işlemini farklı kolonlarada uygulamamızı sağlayan bir fonksiyondur. (Ascending) 

            //var product = context.product.Where(u => u.Id > 500 || u.UrunAdi.EndsWith("2")).OrderBy(u => u.UrunAdi).ThenBy(u => u.Fiyat).ThenBy(u => u.Id);

            //await product.ToListAsync();
            #endregion

            #region OrderByDescending
            //Descending olarak sıralama yapmamızı sağlayan bir fonksiyondur.

            #region Method Syntax
            //var product = await context.product.OrderByDescending(u => u.Fiyat).ToListAsync();
            #endregion
            #region Query Syntax
            //var product = await (from urun in context.product
            //                     orderby urun.UrunAdi descending
            //                     select urun).ToListAsync();
            #endregion
            #endregion

            #region ThenByDescending
            //OrderByDescending üzerinde yapılan sıralama işlemini farklı kolonlarada uygulamamızı sağlayan bir fonksiyondur. (Ascending)
            //var product = await context.product.OrderByDescending(u => u.Id).ThenByDescending(u => u.Fiyat).ThenBy(u => u.UrunAdi).ToListAsync();
            #endregion
            #endregion

            #region Tekil Veri Getiren Sorgulama Fonksiyonları
            //Yapılan sorguda sade ve sadece tek bir verinin gelmesi amaçlanıyorsa Single ya da SingleOrDefault fonksiyonları kullanılabilir.
            #region SingleAsync
            //Eğer ki, sorgu neticesinde birden fazla veri geliyorsa ya da hiç gelmiyorsa her iki durumda da exception fırlatır.
            #region Tek Kayıt Geldiğinde
            //var urun = await context.product.SingleAsync(u => u.Id == 55);
            #endregion
            #region Hiç Kayıt Gelmediğinde
            //var urun = await context.product.SingleAsync(u => u.Id == 5555);
            #endregion
            #region Çok Kayıt Geldiğinde
            //var urun = await context.product.SingleAsync(u => u.Id > 55);
            #endregion
            #endregion

            #region SingleOrDefaultAsync
            //Eğer ki, sorgu neticesinde birden fazla veri geliyorsa exception fırlatır, hiç veri gelmiyorsa null döner.
            #region Tek Kayıt Geldiğinde
            //var urun = await context.product.SingleOrDefaultAsync(u => u.Id == 55);
            #endregion
            #region Hiç Kayıt Gelmediğinde
            //var urun = await context.product.SingleOrDefaultAsync(u => u.Id == 5555);
            #endregion
            #region Çok Kayıt Geldiğinde
            //var urun = await context.product.SingleOrDefaultAsync(u => u.Id > 55);
            #endregion
            #endregion

            //Yapılan sorguda tek bir verinin gelmesi amaçlanıyorsa First ya da FirstOrDefault fonksiyonları kullanılabilir.
            #region FirstAsync
            //Sorgu neticesinde elde edilen verilerden ilkini getirir. Eğer ki hiç veri gelmiyorsa hata fırlatır.
            #region Tek Kayıt Geldiğinde
            //var urun = await context.product.FirstAsync(u => u.Id == 55);
            #endregion
            #region Hiç Kayıt Gelmediğinde
            //var urun = await context.product.FirstAsync(u => u.Id == 5555);
            #endregion
            #region Çok Kayıt Geldiğinde
            //var urun = await context.product.FirstAsync(u => u.Id > 55);
            #endregion
            #endregion

            #region FirstOrDefaultAsync
            //Sorgu neticesinde elde edilen verilerden ilkini getirir. Eğer ki hiç veri gelmiyorsa null değerini döndürür.
            #region Tek Kayıt Geldiğinde
            //var urun = await context.product.FirstOrDefaultAsync(u => u.Id == 55);
            #endregion
            #region Hiç Kayıt Gelmediğinde
            //var urun = await context.product.FirstOrDefaultAsync(u => u.Id == 5555);
            #endregion
            #region Çok Kayıt Geldiğinde
            //var urun = await context.product.FirstAsync(u => u.Id > 55);
            #endregion
            #endregion

            #region SingleAsync, SingleOrDefaultAsync, FirstAsync, FirstOrDefaultAsync Karşılaştırması

            #endregion

            #region FindAsync
            //Find fonksiyonu, primary key kolonuna özel hızlı bir şekilde sorgulama yapmamızı sağlayan bir fonksiyondur.
            //Urun urun = await context.product.FirstOrDefaultAsync(u => u.Id == 55);
            //Urun urun = await context.product.FindAsync(55);

            #region Composite Primary key Durumu
            //UrunParca u = await context.UrunParca.FindAsync(2, 5);
            #endregion
            #endregion

            #region FindAsync İle SingleAsync, SingleOrDefaultAsync, FirstAsync, FirstOrDefaultAsync Fonksiyonlarının Karşılaştırması

            #endregion

            #region LastAsync
            //Sorgu neticesinde gelen verilerden en sonuncusunu getirir. Eğer ki hiç veri gelmiyorsa hata fırlatır. OrderBy kullanılması mecburidir.
            //var urun = await context.product.OrderBy(u => u.Fiyat).LastAsync(u => u.Id > 55);
            #endregion

            #region LastOrDefaultAsync
            //Sorgu neticesinde gelen verilerden en sonuncusunu getirir. Eğer ki hiç veri gelmiyorsa null döner. OrderBy kullanılması mecburidir.
            //var urun = await context.product.OrderBy(u => u.Fiyat).LastOrDefaultAsync(u => u.Id > 55);
            #endregion
            #endregion

            #region Diğer Sorgulama Fonksiyonları
            #region CountAsync
            //Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak(int) bizlere bildiren fonksiyondur.
            //var product = (await context.product.ToListAsync()).Count();
            //var product = await context.product.CountAsync();
            #endregion

            #region LongCountAsync
            //Oluşturulan sorgunun execute edilmesi neticesinde kaç adet satırın elde edileceğini sayısal olarak(long) bizlere bildiren fonksiyondur.
            //var product = await context.product.LongCountAsync(u => u.Fiyat > 5000);
            #endregion

            #region AnyAsync
            //Sorgu neticesinde verinin gelip gelmediğini bool türünde dönen fonksiyondur. 
            //var product = await context.product.Where(u => u.UrunAdi.Contains("1")).AnyAsync();
            //var product = await context.product.AnyAsync(u => u.UrunAdi.Contains("1"));
            #endregion

            #region MaxAsync
            //Verilen kolondaki max değeri getirir.
            //var fiyat = await context.product.MaxAsync(u => u.Fiyat);
            #endregion

            #region MinAsync
            //Verilen kolondaki min değeri getirir.
            //var fiyat = await context.product.MinAsync(u => u.Fiyat);
            #endregion

            #region Distinct
            //Sorguda mükerrer kayıtlar varsa bunları tekilleştiren bir işleve sahip fonksiyondur.
            //var product = await context.product.Distinct().ToListAsync();
            #endregion

            #region AllAsync
            //Bir sorgu neticesinde gelen verilerin, verilen şarta uyup uymadığını kontrol etmektedir. Eğer ki tüm veriler şarta uyuyorsa true, uymuyorsa false döndürecektir.
            //var m = await context.product.AllAsync(u => u.Fiyat < 15000);
            //var m = await context.product.AllAsync(u => u.UrunAdi.Contains("a"));
            #endregion

            #region SumAsync
            //Vermiş olduğumuz sayısal proeprtynin toplamını alır.
            //var fiyatToplam = await context.product.SumAsync(u => u.Fiyat);
            #endregion

            #region AverageAsync
            //Vermiş olduğumuz sayısal proeprtynin aritmatik ortalamasını alır.
            //var aritmatikOrtalama = await context.product.AverageAsync(u => u.Fiyat);
            #endregion

            #region Contains
            //Like '%...%' sorgusu oluşturmamızı sağlar.
            //var product = await context.product.Where(u => u.UrunAdi.Contains("7")).ToListAsync();
            #endregion

            #region StartsWith
            //Like '...%' sorgusu oluşturmamızı sağlar.
            //var product = await context.product.Where(u => u.UrunAdi.StartsWith("7")).ToListAsync();
            #endregion

            #region EndsWith
            //Like '%...' sorgusu oluşturmamızı sağlar.
            //var product = await context.product.Where(u => u.UrunAdi.EndsWith("7")).ToListAsync();
            #endregion
            #endregion

            #region Sorgu Sonucu Dönüşüm Fonksiyonları
            //Bu fonksiyonlar ile sorgu neticesinde elde edilen verileri isteğimiz doğrultuusnda farklı türlerde projecsiyon edebiliyoruz.

            #region ToDictionaryAsync
            //Sorgu neticesinde gelecek olan veriyi bir dictioanry olarak elde etmek/tutmak/karşılamak istiyorsak eğer kullanılır!
            //var product = await context.product.ToDictionaryAsync(u => u.UrunAdi, u => u.Fiyat);

            //ToList ile aynı amaca hizmet etmektedir. Yani, oluşturulan sorguyu execute edip neticesini alırlar.
            //ToList : Gelen sorgu neticesini entity türünde bir koleksiyona(List<TEntity>) dönüştürmekteyken,
            //ToDictionary ise : Gelen sorgu neticesini Dictionary türünden bir koleksiyona dönüştürecektir.
            #endregion

            #region ToArrayAsync
            //Oluşturulan sorguyu dizi olarak elde eder.
            //ToList ile muadil amaca hizmet eder. Yani sorguyu execute eder lakin gelen sonucu entity dizisi  olarak elde eder.
            //var product = await context.product.ToArrayAsync();
            #endregion

            #region Select
            //Select fonksiyonunun işlevsel olarak birden fazla davranışı söz konusudur,
            //1. Select fonksiyonu, generate edilecek sorgunun çekilecek kolonlarını ayarlamamızı sağlamaktadır. 

            //var product = await context.product.Select(u => new Urun
            //{
            //    Id = u.Id,
            //    Fiyat = u.Fiyat
            //}).ToListAsync();

            //2. Select fonksiyonu, gelen verileri farklı türlerde karşılamamızı sağlar. T, anonim

            //var product = await context.product.Select(u => new 
            //{
            //    Id = u.Id,
            //    Fiyat = u.Fiyat
            //}).ToListAsync();


            //var product = await context.product.Select(u => new UrunDetay
            //{
            //    Id = u.Id,
            //    Fiyat = u.Fiyat
            //}).ToListAsync();

            #endregion

            #region SelectMany
            //Select ile aynı amaca hizmet eder. Lakin, ilişkisel tablolar neticesinde gelen koleksiyonel verileri de tekilleştirip projeksiyon etmemizi sağlar.

            //var product = await context.product.Include(u => u.Parcalar).SelectMany(u => u.Parcalar, (u, p) => new
            //{
            //    u.Id,
            //    u.Fiyat,
            //    p.ParcaAdi
            //}).ToListAsync();
            #endregion
            #endregion

            #region GroupBy Fonksiyonu
            //Gruplama yapmamızı sağlayan fonksiyondur.
            #region Method Syntax
            //var datas = await context.product.GroupBy(u => u.Fiyat).Select(group => new
            //{
            //    Count = group.Count(),
            //    Fiyat = group.Key
            //}).ToListAsync();
            #endregion
            #region Query Syntax
            //var datas = await(from urun in context.product
            //                  group urun by urun.Fiyat
            //            into @group
            //                  select new
            //                  {
            //                      Fiyat = @group.Key,
            //                      Count = @group.Count()
            //                  }).ToListAsync();
            #endregion
            #endregion

            #region Foreach Fonksiyonu
            //Bir sorgulama fonksiyonu felan değildir!
            //Sorgulama neticesinde elde edilen koleksiyonel veriler üzerinde iterasyonel olarak dönmemizi ve teker teker verileri elde edip işlemler yapabilmemizi sağlayan bir fonksiyondur. foreach döngüsünün metot halidir!

            //foreach (var item in datas)
            //{

            //}
            //datas.ForEach(x =>
            //{

            //});
            #endregion


            return await Task.FromResult<IActionResult>(Ok(_productReadRepository.GetAll(false)));

        }

        [HttpGet("GetPagination")]
        public Task<IActionResult> GetPagination([FromQuery] Pagination pagination)
        {
            var totalCount = _productReadRepository.GetAll(false).Count();
            var products = _productReadRepository.GetAll(false).Skip(pagination.Page * pagination.Size).Take(pagination.Size).Select(p => new
            {
                p.Id,
                p.Name,
                p.Stock,
                p.Price,
                p.CreatedDate,
                p.UpdatedDate,
                p.OrderNumber
            }).OrderBy(x => x.OrderNumber).ToList();

            return Task.FromResult<IActionResult>(Ok(new
            {
                totalCount,
                products
            }));
        }

       
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            return Ok(await _productReadRepository.GetByIdAsync(id, false));
        }


        [HttpPost]
        public async Task<IActionResult> Post(VM_Create_Product model)
        {
            //ModelState.AddModelError("Special Error", "Bad Request");
            //return BadRequest(ModelState);
            if (ModelState.IsValid)
            {
                // Do something with the product (not shown).

            }

            await _productWriteRepository.AddAsync(new()
            {
                Name = model.Name,
                Price = (long)model.Price,
                Stock = model.Stock,
                Product_Description = model.Description
            });
            await _productWriteRepository.SaveAsync();
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(VM_Update_Product model)
        {
            Product product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Stock = model.Stock;
            product.Name = model.Name;
            product.Price = (long)model.Price;
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpGet("TestMiddleWare")]
        public String GetTestMiddleWare()
        {
            _logger.LogInformation("GetTestMiddleWare LogInformation");
            _logger.LogCritical("GetTestMiddleWare LogCritical");
            _logger.LogError("GetTestMiddleWare LogError");
            _logger.LogWarning("GetTestMiddleWare LogWarning");
            //throw new Exception("Test Error");
            return "OK";
        }

    }
}
