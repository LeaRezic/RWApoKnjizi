using RWA_Knjiga_MVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RWA_Knjiga_MVC.Dal.Mock
{
    public static class MockDatabase
    {
        public static List<Bend> Bendovi { get; set; }
        public static List<Album> Albumi { get; set; }
        public static List<Pjesma> Pjesme { get; set; }

        static MockDatabase()
        {
            var b1 = new Bend { Id = 1, Naziv = "The Smiths", GodinaOsnutka = 1981, BrojClanova = 4 };
            var b2 = new Bend { Id = 2, Naziv = "Arcade Fire", GodinaOsnutka = 2001, BrojClanova = 6 };

            var a1 = new Album { Id = 1, Naziv = "The Smiths", GodinaIzdanja = 1984, OsnovnaCijena = 99.99m, BendId = 1, Bend = b1 };
            var a2 = new Album { Id = 2, Naziv = "The Queen is Dead", GodinaIzdanja = 1986, OsnovnaCijena = 99.99m, BendId = 1, Bend = b1 };

            var a3 = new Album { Id = 3, Naziv = "Neon Bible", GodinaIzdanja = 2007, OsnovnaCijena = 99.99m, BendId = 2, Bend = b2 };

            var p1 = new Pjesma { Id = 1, Naziv = "Reel Around the Fountain", RedniBroj = 1, TrajanjeSekundi = 404, Album = a1, AlbumId = 1 };
            var p2 = new Pjesma { Id = 2, Naziv = "Miserable Lie", RedniBroj = 2, TrajanjeSekundi = 321, Album = a1, AlbumId = 1 };
            var p3 = new Pjesma { Id = 3, Naziv = "Pretty Girls Make Graves", RedniBroj = 3, TrajanjeSekundi = 516, Album = a1, AlbumId = 1 };
            var p4 = new Pjesma { Id = 4, Naziv = "The Hand That Rocks the Cradle", RedniBroj = 4, TrajanjeSekundi = 368, Album = a1, AlbumId = 1 };
            var p5 = new Pjesma { Id = 5, Naziv = "Still Ill", RedniBroj = 5, TrajanjeSekundi = 602, Album = a1, AlbumId = 1 };
            var p6 = new Pjesma { Id = 6, Naziv = "Hand in Glove", RedniBroj = 6, TrajanjeSekundi = 258, Album = a1, AlbumId = 1 };
            var p7 = new Pjesma { Id = 7, Naziv = "What Difference Does It Make?", RedniBroj = 7, TrajanjeSekundi = 344, Album = a1, AlbumId = 1 };
            var p8 = new Pjesma { Id = 8, Naziv = "I Don't Owe You Anything", RedniBroj = 8, TrajanjeSekundi = 441, Album = a1, AlbumId = 1 };
            var p9 = new Pjesma { Id = 9, Naziv = "Suffer Little Children", RedniBroj = 9, TrajanjeSekundi = 289, Album = a1, AlbumId = 1 };
            var p10 = new Pjesma { Id = 10, Naziv = "You've Got Everything Now", RedniBroj = 10, TrajanjeSekundi = 375, Album = a1, AlbumId = 1 };

            var p11 = new Pjesma { Id = 11, Naziv = "The Queen Is Dead", RedniBroj = 1, TrajanjeSekundi = 404, Album = a2, AlbumId = 2 };
            var p12 = new Pjesma { Id = 12, Naziv = "Frankly, Mr. Shankly", RedniBroj = 2, TrajanjeSekundi = 321, Album = a2, AlbumId = 2 };
            var p13 = new Pjesma { Id = 13, Naziv = "I Know It's Over", RedniBroj = 3, TrajanjeSekundi = 516, Album = a2, AlbumId = 2 };
            var p14 = new Pjesma { Id = 14, Naziv = "Never Had No One Ever", RedniBroj = 4, TrajanjeSekundi = 368, Album = a2, AlbumId = 2 };
            var p15 = new Pjesma { Id = 15, Naziv = "Cemetry Gates", RedniBroj = 5, TrajanjeSekundi = 602, Album = a2, AlbumId = 2 };
            var p16 = new Pjesma { Id = 16, Naziv = "Bigmouth Strikes Again", RedniBroj = 6, TrajanjeSekundi = 258, Album = a2, AlbumId = 2 };
            var p17 = new Pjesma { Id = 17, Naziv = "The Boy with the Thorn in His Side", RedniBroj = 7, TrajanjeSekundi = 344, Album = a2, AlbumId = 2 };
            var p18 = new Pjesma { Id = 18, Naziv = "Vicar in a Tutu", RedniBroj = 8, TrajanjeSekundi = 441, Album = a2, AlbumId = 2 };
            var p19 = new Pjesma { Id = 19, Naziv = "There Is a Light That Never Goes Out", RedniBroj = 9, TrajanjeSekundi = 289, Album = a2, AlbumId = 2 };
            var p20 = new Pjesma { Id = 20, Naziv = "Some Girls Are Bigger Than Others", RedniBroj = 10, TrajanjeSekundi = 375, Album = a2, AlbumId = 2 };

            var p21 = new Pjesma { Id = 21, Naziv = "Black Mirror", RedniBroj = 1, TrajanjeSekundi = 404, Album = a3, AlbumId = 3 };
            var p22 = new Pjesma { Id = 22, Naziv = "Keep the Car Running", RedniBroj = 2, TrajanjeSekundi = 321, Album = a3, AlbumId = 3 };
            var p23 = new Pjesma { Id = 23, Naziv = "Neon Bible", RedniBroj = 3, TrajanjeSekundi = 516, Album = a3, AlbumId = 3 };
            var p24 = new Pjesma { Id = 24, Naziv = "Intervention", RedniBroj = 4, TrajanjeSekundi = 368, Album = a3, AlbumId = 3 };
            var p25 = new Pjesma { Id = 25, Naziv = "Black Wave/Bad Vibrations", RedniBroj = 5, TrajanjeSekundi = 602, Album = a3, AlbumId = 3 };
            var p26 = new Pjesma { Id = 26, Naziv = "Ocean of Noise", RedniBroj = 6, TrajanjeSekundi = 258, Album = a3, AlbumId = 3 };
            var p27 = new Pjesma { Id = 27, Naziv = "The Well and the Lighthouse", RedniBroj = 7, TrajanjeSekundi = 344, Album = a3, AlbumId = 3 };
            var p28 = new Pjesma { Id = 28, Naziv = "(Antichrist Television Blues)", RedniBroj = 8, TrajanjeSekundi = 441, Album = a3, AlbumId = 3 };
            var p29 = new Pjesma { Id = 29, Naziv = "Windowsill", RedniBroj = 9, TrajanjeSekundi = 289, Album = a3, AlbumId = 3 };
            var p30 = new Pjesma { Id = 30, Naziv = "No Cars Go", RedniBroj = 10, TrajanjeSekundi = 375, Album = a3, AlbumId = 3 };
            var p31 = new Pjesma { Id = 31, Naziv = "My Body Is a Cage", RedniBroj = 11, TrajanjeSekundi = 375, Album = a3, AlbumId = 3 };

            b1.Albumi.Add(a1);
            b1.Albumi.Add(a2);
            b2.Albumi.Add(a3);

            a1.Pjesme.AddRange(new List<Pjesma> { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 });
            a2.Pjesme.AddRange(new List<Pjesma> { p11, p12, p13, p14, p15, p16, p17, p18, p19, p20 });
            a3.Pjesme.AddRange(new List<Pjesma> { p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31 });

            Bendovi = new List<Bend> { b1, b2 };
            Albumi = new List<Album> { a1, a2, a3 };
            Pjesme = new List<Pjesma> { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24, p25, p26, p27, p28, p29, p30, p31 };
        }
    }
}
