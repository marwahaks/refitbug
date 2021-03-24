using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefitBug.RestFolder
{
    interface IWoofClient
    {
        [Refit.Get("/woof.json")]
        Task<WoofResponseObject> GetDawg();
    }
}
