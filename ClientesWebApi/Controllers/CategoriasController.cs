using ClientesWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ClientesWebApi.Controllers
{
    public class CategoriasController : ApiController
    {
        private ClienteDBContext context;

        public CategoriasController()
        {
            //instanciamos el contexto que nos permite
            //acceso a los datos
            context = new ClienteDBContext();
        }

        public IEnumerable<Object> get()
        {
            //que me retorne todas las categorias
            return context.Categorias.ToList();
        }

    }
}
