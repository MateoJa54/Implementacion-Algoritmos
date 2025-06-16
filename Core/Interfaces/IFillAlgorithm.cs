using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementaciónAlgoritmos.Core.Interfaces
{
    public interface IFillAlgorithm
    {
        // Compute fill from seed, boundary tester
        IEnumerable<ImplementaciónAlgoritmos.Core.Models.Pixel> ComputeFill(
            System.Drawing.Point seed,
            System.Func<System.Drawing.Point, bool> isBoundary);
    }
}
