using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baustein_desktop.Data.Repositories
{
    public interface IVakRepo
    {
        List<vak> GetAllVaks();

        vak GetVakById(int id);

        bool DeleteVak(vak vak);
    }
}
