using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementaciónAlgoritmos.Core.Interfaces
{
    public interface IRenderingAlgorithm
    {
        // Compute pixels from start to end (e.g. line or circle)
        IEnumerable<ImplementaciónAlgoritmos.Core.Models.Pixel> Compute(params object[] parameters);
    }
}
