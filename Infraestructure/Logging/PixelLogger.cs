using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImplementaciónAlgoritmos.Core.Models;

namespace ImplementaciónAlgoritmos.Infraestructure.Logging
{
    public class PixelLogger
    {
        private readonly List<Pixel> _logged = new List<Pixel>();

        public void Log(Pixel p) => _logged.Add(p);
        public IReadOnlyList<Pixel> GetLogged() => _logged;
        public void Clear() => _logged.Clear();
    }
}
