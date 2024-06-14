using Bookface.Models;

namespace Bookface.Interfaces
{
    public interface IObjavaService
    {
        void kreirajObjavu(Guid korisnikId, byte[] media, string tekst, string tagovi);
        void kreirajKomentar(Guid objavaId, Guid korisnikId, string komentarTeskt, byte[] komentarMedia);
        void kreirajLajk(Guid korisnikId, Guid objavaId);
        IEnumerable<Objava> dohvatiObjave(int paginacija);
        IEnumerable<Objava> dohvatiObjave();
        IEnumerable<Objava> dohvatiObjaveKorisnika(Guid korisnikId, int paginacija);
        IEnumerable<Objava> dohvatiPreporuceneObjave(Guid korisnikId);
        IEnumerable<Komentar> dohvatiKomentare(Guid objavaId, int paginacija);
        string vratiOmiljeneTagoveKorisnika(Guid korisnikId);
        Objava dohvatiObjavu(Guid objavaId);
        IEnumerable<Lajk> dohvatiLajkove(Guid objavaId);
        void obrisiObjavu(Guid objavaId);
        void obrisiKomentar(Guid komentarId);
        void obrisiLajk(Guid LajkId);
        void podijeliObjavu(Guid korisnikId, Guid objavaId);
        void obrisiSvojuObjavu(Guid objavaId);
    }
}
