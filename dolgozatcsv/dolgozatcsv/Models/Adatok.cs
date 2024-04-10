using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Adatok
    {
        public int Id { get; set; }
        public string Nev { get; set; }
        public string Kor { get; set; }
        public string Orszag { get; set; }
        public string Szakma { get; set; }
        public string Hobbik { get; set; }
        public Adatok() { }

        public Adatok(string sor)
        {
            string[] t = sor.Split(';');
            Nev = t[0];
            Kor = t[1];
            Orszag = t[2];
            Szakma = t[3];
            Hobbik = t[4];
        }



        public override string? ToString()
        {
            return $"Név: {Nev}, kora: {Kor}, Lakhely: {Orszag}, szakmája: {Szakma}, hobbijai: {Hobbik}";
        }
    }
}

