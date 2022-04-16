using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SuperHero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {        
        // Dataya Verileri Girdikten sonra 3.Bölüm olarak Devam Ediyoruz
        private readonly DataContext _context;
        public SuperHeroController(DataContext context )
        {

            _context = context;

        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHeroModel>>> Get()
        {

            return Ok(await _context.superHeroModels.ToListAsync());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHeroModel>> Get(int id)
        {
            var hero = await _context.superHeroModels.FindAsync(id);
            if (hero == null)
                return BadRequest("Hero Not Found");
            return Ok(hero);

        }
        [HttpPost]
        public async Task<ActionResult<List<SuperHeroModel>>> AddHero(SuperHeroModel hero)
        {
            _context.superHeroModels.Add(hero);
            await _context.SaveChangesAsync();
            return Ok(await _context.superHeroModels.ToListAsync());
        }
        [HttpPut]
        public async Task<ActionResult<List<SuperHeroModel>>> UpdateHero(SuperHeroModel request)
        {
            var dbhero = await _context.superHeroModels.FindAsync(request.Id);
            if (dbhero == null)
                return BadRequest("Hero not find");
            dbhero. Name = request.Name;
            dbhero.FirstName = request.FirstName;
            dbhero.LastName = request.LastName;
            dbhero.Place = request.Place;
            await _context.SaveChangesAsync();  
            return Ok(await _context.superHeroModels.ToListAsync());
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<List<SuperHeroModel>>> DeleteHero(int id)
        {
            var dbhero = await _context.superHeroModels.FindAsync(id);
            if (dbhero == null)
                return NotFound("Hero Not Found");
            _context.superHeroModels.Remove(dbhero);
            await _context.SaveChangesAsync();
            return Ok(await _context.superHeroModels.ToListAsync());

        }

    }
}
















////--------------------------------------------------------1.Bölüm---------------------------------------
//public class SuperHeroController : ControllerBase
//{
//    [HttpGet]
//    public async Task<ActionResult<List<SuperHeroModel>>> Get()
//    {
//        var heroes = new List<SuperHeroModel>
//            {
//                new SuperHeroModel{
//                    Id = 1,
//                    Name ="Spider Man",
//                    FirstName="Peter",
//                    LastName="Parker",
//                    Place="Los Angeles"}

//            };
//        return Ok(heroes); //  return NotFound(heroes); swagger görebilirsin
//    }
//}
//}
//}
//--------------------------------------------------------1.Bölüm Sonu--------------------------------------

//--------------------------------------------------------2.Bölüm ------------------------------------------

//private static List<SuperHeroModel> heroes = new List<SuperHeroModel>
//            {
//                new SuperHeroModel{
//                    Id = 1,
//                    Name ="Spider Man",
//                    FirstName="Peter",
//                    LastName="Parker",
//                    Place="Los Angeles"
//                },

//                new SuperHeroModel{
//                    Id = 2,
//                    Name ="Iron Man",
//                    FirstName="Tony",
//                    LastName="Stark",
//                    Place="Long Island"
//                }

//            };

//[HttpGet]
//public async Task<ActionResult<List<SuperHeroModel>>> Get()
//{

//    return Ok(heroes);
//}
//[HttpGet("{id}")]
//public async Task<ActionResult<SuperHeroModel>> Get(int id)
//{
//    var hero = heroes.Find(h => h.Id == id);
//    if (hero == null)
//        return BadRequest("Hero Not Found");
//    return Ok(hero);

//}
//[HttpPost]// Yadıkltan Sonra Swagger kontrol Edelim
//public async Task<ActionResult<List<SuperHeroModel>>> AddHero(SuperHeroModel hero)
//{
//    heroes.Add(hero);
//    return Ok(heroes);
//}
//[HttpPut]
//public async Task<ActionResult<List<SuperHeroModel>>> UpdateHero(SuperHeroModel request)
//{
//    var hero = heroes.Find(h => h.Id == request.Id);
//    if (hero == null)
//        return BadRequest("Hero not find");
//    hero.Name = request.Name;
//    hero.FirstName = request.FirstName;
//    hero.LastName = request.LastName;
//    hero.Place = request.Place;

//    return Ok(heroes);
//}
//[HttpDelete("{id}")]
//public async Task<ActionResult<List<SuperHeroModel>>> DeleteHero(int id)
//{
//    var hero = heroes.Find(h => h.Id == id);
//    if (hero == null)
//        return NotFound("Hero Not Found");
//    heroes.Remove(hero);
//    return Ok(heroes);

//}

//    }
//}

//--------------------------------------------------------2.Bölüm Sonu--------------------------------------

// Burda Şimdi EntityFremawork geçiyoruz yani dataya bağlama kısmı
// Data Diye Bir klasor oluşturup içersine Context klasorumuzu yapcaz. Bu Bizim Data Katmanımız Gibi Dunusunebilir.
