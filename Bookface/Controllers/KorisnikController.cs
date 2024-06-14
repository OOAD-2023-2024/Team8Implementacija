using Bookface.Services;
using Bookface.Interfaces;
using Bookface.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Bookface.Controllers
{
    [Route("api")]
    [ApiController]
    [Authorize]
    public class KorisnikController : ControllerBase
    {

        private readonly IKorisnikService _korisnikService;

        public KorisnikController(IKorisnikService userService)
        {
            _korisnikService = userService;
        }

        
        [HttpPost]
        [Route("korisnik/registracija"), AllowAnonymous]
        public void registrujKorisnika(string username, string email, string password, byte[] image)
        {
            if (username == null || string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine(username + " ili " + email + "nisu definisani");
                throw new Exception("Invalid request parameters");
            }
            _korisnikService.registrujKorisnika(username, email, image, password);
        }
        /*
        [HttpPost]
        [Route("korisnik/dodaj"), AllowAnonymous]
        public void KreirajKorisnika(Korisnik user)
        {
            if (user == null || string.IsNullOrWhiteSpace(user.email))
            {
                Console.WriteLine(user.email + " " + user.sifraSalt.ToString);
                throw new Exception("Invalid request parameters");
            }
            if (string.IsNullOrWhiteSpace(user.email))
            {
                Console.WriteLine(user.email + " " + user.sifraSalt.ToString);
                throw new Exception("Invalid request parameters");
            }

            _korisnikService.kreirajNovogKorisnika(user.naziv, user.email);
        }

        [HttpGet("korisnik/{korisnikId}"), AllowAnonymous]
        public IEnumerable<Korisnik> dohvatiKorisnika(Guid korisnikId)
        {
            return _korisnikService.dohvatiKorisnika(korisnikId);
        }

        [HttpGet]
        [Route("korisnik/imePoId"), AllowAnonymous]
        public string dohvatiKorisnickoImePoId(Guid korisnikId)
        {
            return _korisnikService.dohvatiKorisnickoImePoId(korisnikId);
        }

        [HttpGet]
        [Route("korisnik/poJWT"), AllowAnonymous]
        public IEnumerable<Korisnik> dohvatiKorisnikaPoJWT(string jwt)
        {
            return _korisnikService.dohvatiKorisnikaPoJWT(jwt);
        }

        [HttpDelete("korisnik/{korisnikId}"), AllowAnonymous]
        public void obrisiKorisnika(Guid korisnikId)
        {
            _korisnikService.obrisiKorisnika(korisnikId);
        }

        [HttpGet]
        [Route("korisnik/poKorisnickomImenu"), AllowAnonymous]
        public IEnumerable<Korisnik> dohvatiKorisnikaPoKorisnickomImenu(string korisnickoIme)
        {
            return _korisnikService.dohvatiKorisnikaPoKorisnickomImenu(korisnickoIme);
        }

        [HttpPut("korisnik/{korisnikId}"), AllowAnonymous]
        public void izmijeniKorisnika(string jwt, Guid korisnikId, string email, byte[] image, bool darkTheme, bool notificationOn)
        {
            _korisnikService.izmijeniKorisnika(jwt, korisnikId, email, image, darkTheme, notificationOn);
        }

        

        [HttpGet]
        [Route("korisnik/postoji"), AllowAnonymous]
        public bool registrujKorisnika(string email, string korisnickoIme)
        {
            return _korisnikService.daLiKorisnikPostoji(email, korisnickoIme);
        }

        [HttpPost]
        [Route("korisnik/prijavi"), AllowAnonymous]
        public string prijaviKorisnika(string email, string password)
        {
            return _korisnikService.prijaviKorisnika(email, password);
        }

        [HttpPut]
        [Route("korisnik/logOut"), AllowAnonymous]
        public void logOut(string jwt)
        {
             _korisnikService.logOut(jwt);
        }
        */

    }
}
