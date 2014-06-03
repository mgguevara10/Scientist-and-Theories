using Scientist.web.Adapters.Adapters;
using Scientist.web.Adapters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Scientist.web.Controllers
{
    public class APITheoryController : ApiController
    {
      ITheoryAdapter _adapter;
        public APITheoryController()
        {
            _adapter = new DataTheoryAdapter();
        }
        public IHttpActionResult Delete(int id)
        {
            _adapter.DeleteTheory(id);
            object nothing = new object();
            return Ok(nothing);
        }
	}
}