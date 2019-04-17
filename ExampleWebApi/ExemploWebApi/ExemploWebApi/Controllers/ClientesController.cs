using ExemploWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploWebApi.Controllers
{
    public class ClientesController : ApiController
    {
        private static List<Cliente> clientes = new List<Cliente>();

        //[HttpGet] if you are using the name equals the method you want like GET, POST, PUT, DELETE, you don't need specify the method you want
        public List<Cliente> Get()
        {
            
            return clientes;
        }
        public void Post(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.Add(new Cliente(nome));
            }
            
        }

        public void Delete(string nome)
        {
            if (!string.IsNullOrEmpty(nome))
            {
                clientes.RemoveAt(clientes.IndexOf(clientes.First(x=>x.Nome.Equals(nome))));
            }
        }

        public void Put(string nome, string newname)
        {
            if (!string.IsNullOrEmpty(nome)&& !string.IsNullOrEmpty(newname))
            {
                var cl = clientes.Where(x => x.Nome.ToLower().Equals(nome.ToLower())).First();
                cl.Nome = newname;
            }
        }
    }
}
