using Bookface.Interfaces;
using Bookface.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Bookface.Controllers
{
    [Route("api")]
    [ApiController]
    [Authorize]
    public class ObjavaController : ControllerBase
    {
        private readonly IObjavaService _objavaService;

        public ObjavaController(IObjavaService objavaService)
        {
            _objavaService = objavaService;
        }

        [HttpPost]
        [Route("/objave/kreiraj")]
        public void kreirajObjavu(Guid korisnikId, byte[] media, string tekst, string tagovi)
        {
            _objavaService.kreirajObjavu(korisnikId,media,tekst,tagovi);
        }

        [HttpPost]
        [Route("/komentar/kreiraj")]
        public void kreirajKomentar(Guid objavaId, Guid korisnikId, string komentarTeskt, byte[] komentarMedia)
        {
            _objavaService.kreirajKomentar(objavaId, korisnikId, komentarTeskt, komentarMedia);
        }

        [HttpPost]
        [Route("/lajk/kreiraj")]
        public void kreirajLajk(Guid korisnikId, Guid objavaId)
        {
            _objavaService.kreirajLajk(korisnikId, objavaId);
        }

        [HttpGet]
        [Route("svepaginated"), AllowAnonymous]
        public IEnumerable<Objava> dohvatiObjave()
        {
            return _objavaService.dohvatiObjave();
        }

        [HttpGet]
        [Route("sve"), AllowAnonymous]
        public IEnumerable<Objava> dohvatiObjave(int paginacija)
        {
            return _objavaService.dohvatiObjave(paginacija);
        }

        [HttpGet]
        [Route("svekorisnik"), AllowAnonymous]
        public IEnumerable<Objava> dohvatiObjaveKorisnika(Guid korisnikId, int paginacija)
        {
            return _objavaService.dohvatiObjaveKorisnika(korisnikId, paginacija);
        }

        [HttpGet]
        [Route("svekorisnikpreporuceno"), AllowAnonymous]
        public IEnumerable<Objava> dohvatiPreporuceneObjave(Guid korisnikId)
        {
            return _objavaService.dohvatiPreporuceneObjave(korisnikId);
        }

        [HttpGet]
        [Route("sve/komentar"), AllowAnonymous]
        public IEnumerable<Komentar> dohvatiKomentare(Guid objavaId, int paginacija)
        {
            return _objavaService.dohvatiKomentare(objavaId, paginacija);
        }

        [HttpGet]
        [Route("objava"), AllowAnonymous]
        public Objava dohvatiObjavu(Guid objavaId)
        {
            return _objavaService.dohvatiObjavu(objavaId);
        }

        [HttpGet]
        [Route("omiljeni"), AllowAnonymous]
        public String vratiOmiljeneTagoveKorisnika(Guid korisnikId)
        {
            return _objavaService.vratiOmiljeneTagoveKorisnika(korisnikId);
        }

        [HttpGet]
        [Route("objava/lajk"), AllowAnonymous]
        public IEnumerable<Lajk> dohvatiLajkove(Guid objavaId)
        {
            return _objavaService.dohvatiLajkove(objavaId);
        }

        [HttpDelete]
        [Route("objava"), AllowAnonymous]
        public void obrisiObjavu(Guid objavaId)
        {
            _objavaService.obrisiObjavu(objavaId);
        }

        [HttpDelete]
        [Route("svojaobjava"), AllowAnonymous]
        public void obrisiSvojuObjavu(Guid objavaId)
        {
            _objavaService.obrisiSvojuObjavu(objavaId);
        }

        [HttpDelete]
        [Route("komentar"), AllowAnonymous]
        public void obrisiKomentar(Guid komentarId)
        {
            _objavaService.obrisiKomentar(komentarId);
        }

        [HttpDelete]
        [Route("lajk"), AllowAnonymous]
        public void obrisiLajk(Guid lajkId)
        {
            _objavaService.obrisiLajk(lajkId);
        }
    }
}
