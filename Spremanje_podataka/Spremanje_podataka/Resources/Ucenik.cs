using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spremanje_podataka
{
    class Ucenik
    {
        String ime, prezime, email, razred;

        public Ucenik(string ime, string prezime, string email, string razred)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Email = email;
            this.Razred = razred;
        }

        public string Ime { get => ime; set => ime = value; }
        public string Prezime { get => prezime; set => prezime = value; }
        public string Email { get => email; set => email = value; }
        public string Razred { get => razred; set => razred = value; }

        public string Ispis()
        {
            string ispis = ime + "," + prezime + "," + email + "," + razred + "\r\n";
            return ispis;
        }
    }
}
