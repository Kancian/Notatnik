using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notatnik.Logic
{
    public static class DB
    {
        public static void DodajDoBazy(string ty, string te)
        {
            using (NotatnikDB context = new NotatnikDB())
            {
                context.Notatkis.Add(new Notatki
                {
                    tytul = ty,
                    tekst = te,
                    data = DateTime.Now,
                });
                context.SaveChanges();
            }
        }
        public static List<Notatki> PobierzNotatki()
        {
            List<Notatki> n = new List<Notatki> { };
            using (var context = new NotatnikDB())
            {
                foreach (var notka in context.Notatkis)
                {
                    n.Add(notka);
                }
            }
            return n;
        }
    }
}
