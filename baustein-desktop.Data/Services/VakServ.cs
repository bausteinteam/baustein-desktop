using baustein_desktop.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baustein_desktop.Data.Services
{
    public class VakServ : IVakRepo
    {
        DB_Entities db = new DB_Entities();

        public bool DeleteVak(vak vak)
        {
            var selecedVak = GetVakById(vak.ID);
            db.vak.Remove(selecedVak);
            db.SaveChanges();
            return true;
        }

        public List<vak> GetAllVaks()
        {
            return db.vak.Where(x => x.sichtbar == true).ToList();
        }

        public vak GetVakById(int id)
        {
            return db.vak.Find(id);
        }
    }
}
