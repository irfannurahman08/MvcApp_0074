using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApp_0074.Models
{
    interface IPegawaiRepository
    {
        IEnumerable<pegawai> GetAll();
        pegawai GetById(string nip);
        int Update(pegawai emp);
        pegawai Add(pegawai emp);
        void Delete(string nip);
    }
}
