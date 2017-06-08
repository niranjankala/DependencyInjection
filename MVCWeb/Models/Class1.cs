using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWeb.Models
{
    public interface ITenantStore
    {
        void Initialize();
        Tenant GetTenant(string tenant);
        IEnumerable<string> GetTenantNames();
        void SaveTenant(Tenant tenant);
    }

    public class Tenant
    {
    }

    public interface ITenantStoreLogo
    {
        void UploadLogo(string tenant, byte[] logo);
    }
    public class TenantStore : ITenantStore, ITenantStoreLogo
    {

        public TenantStore()
        {

        }

        public Tenant GetTenant(string tenant)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetTenantNames()
        {
            throw new NotImplementedException();
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public void SaveTenant(Tenant tenant)
        {
            throw new NotImplementedException();
        }
    }
}