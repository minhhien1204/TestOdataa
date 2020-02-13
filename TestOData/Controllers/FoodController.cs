using Microsoft.AspNet.OData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestOData.Models;

namespace TestOData.Controllers
{
    public class FoodController : ODataController
    {
        private readonly DataContext _dbcontext = new DataContext(); //
        [EnableQuery]
        public IQueryable<ChiTietThucAn> Get()
        {
            return _dbcontext.ChiTietThucAns;
        }
        [EnableQuery]
        public SingleResult<ChiTietThucAn> Get([FromODataUri] string key)
        {
            var result = _dbcontext.ChiTietThucAns.Where(x => x.ID == key);
            return SingleResult.Create(result);
        }
    }
}
