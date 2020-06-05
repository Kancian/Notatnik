using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notatnik.Logic
{
    public interface INote
    {
        string Tytul();
        string Tekst();
        DateTime DataStworzenia();
    }
}
