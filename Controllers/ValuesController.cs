using MvcApp_0074.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MvcApp_0074.Controllers
{
    public class PegawaiController : ApiController
    {
        IPegawaiRepository repository = new PegawaiModel();

        // GET api/values
        public IEnumerable<pegawai> Get()
        {
            return repository.GetAll();
        }

        // GET api/values/5
        public pegawai Get(string id)
        {
            pegawai p = repository.GetById(id);
            return p;
        }

        // POST api/values
        public void PostPegawai(pegawai p)
        {
            repository.Add(p);
        }

        // PUT api/values/5
        public void PutPegawai(pegawai p)
        {
            if (repository.Update(p) == 0)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
        }

        // DELETE api/values/5
        public void Delete(string id)
        {
            repository.Delete(id);
        }
    }
}