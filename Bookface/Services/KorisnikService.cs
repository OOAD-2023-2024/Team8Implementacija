using Bookface.Interfaces;
using Bookface.Models;
using Bookface.Models.Enums;
using System.Security.Cryptography;

namespace Bookface.Services

{
    public class KorisnikService : IKorisnikService
    {
        private readonly BookfaceAppDBContext _dbContext;

        public KorisnikService(BookfaceAppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void registrujKorisnika(string username, string email, byte[] image, string password)
        {
            if (!DoesUserExist(email, username)) throw new Exception("User already exists");

            if (!IsValidEmail(email)) throw new Exception("Invalid email address");

            if (!IsValidPassword(password)) throw new Exception("Invalid password");

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);

            Korisnik korisnik = new Korisnik
            {
                naziv = username,
                email = email,
                sifraSalt = passwordSalt,
                sifraHash = passwordHash,
                korisnikId = Guid.NewGuid(),
                slikaProfila = image,
                tipKorisnika = TipKorisnika.Korisnik



            };
            _dbContext.Korisnik.Add(korisnik);
            _dbContext.SaveChanges();
        }
        public bool DoesUserExist(string email, string username)
        {
            var emailCheck = _dbContext.Korisnik.FirstOrDefault(x => x.email == email);
            var userCheck = _dbContext.Korisnik.FirstOrDefault(x => x.naziv == username);
            return (emailCheck == null && userCheck == null);
        }
        public bool IsValidEmail(string email)
        {
            try
            {
                var address = new System.Net.Mail.MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public bool IsValidPassword(string password)
        {
            return password.Length >= 5;
        }

        private static void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            var hmac = new HMACSHA512();

            passwordSalt = hmac.Key;
            passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

        }

    }
}
