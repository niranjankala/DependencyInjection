using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCWeb.Controllers
{  
    public class ManagementController : Controller
    {
        private readonly ITenantStore tenantStore;
        public ManagementController(ITenantStore tenantStore)
        {
            this.tenantStore = tenantStore;
        }
        public ActionResult Index()
        {
            var model = new TenantPageViewData<IEnumerable<string>>(this.tenantStore.GetTenantNames())
            {
                Title = "Subscribers"
            };
            return this.View(model);
        }
...
}
}