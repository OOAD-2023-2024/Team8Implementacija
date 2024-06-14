using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookface.Models;

namespace Bookface.Interfaces
{
    public interface IKorisnikService
    {
        void registrujKorisnika(string username, string email, byte[] image, string password);
        /*
        Korisnik dohvatiKorisnika(Guid korisnikId);
        void obrisiKorisnika(Guid korisnikId);
        string dohvatiKorisnickoImePoId(Guid korisnikId);
        Korisnik dohvatiKorisnikaPoJWT(string jwt);
        Korisnik dohvatiKorisnikaPoKorisnickomImenu(string korisnickoIme);
        void izmijeniKorisnika(string jwt, Guid korisnikId, string email, byte[] image, bool darkTheme, bool notificationOn);
        bool daLiKorisnikPostoji(string email, string korisnickoIme);
        bool daLiJeEmailValidan(string email);
        bool daLiJeSifraValidna(string sifra);
        void pokreniToken(IEnumerable<Korisnik> Korisnik, string jwt, DateTime expiry);
        string prijaviKorisnika(string email, string password);
        void logOut(string jwt);
        IEnumerable<Korisnik> pretraziKorisnika(string korisnickoIme);
        */
    }
}
