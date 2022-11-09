using RESTful_Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using RESTful_Service.Models;
using System.Net.Http;

namespace RESTful_Service.Controllers
{
    public class WebServiceController : ApiController
    {
        private StringsRepository _repository;
        public WebServiceController()
        {
            _repository = new StringsRepository();
        }

        public Strings[] Get() => _repository.GetAllStrings();

        public HttpResponseMessage Post(Strings strings)
        {
            System.Threading.Thread.Sleep(200);
            strings._stringConcat = strings.StringsConcat();
            strings._stringReplay = strings.StringsReplay();
            _repository.SaveStrings(strings);
            var response = Request.CreateResponse(System.Net.HttpStatusCode.Created, strings);
            return response;
        }
    }
}