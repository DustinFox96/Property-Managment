using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface ITenantDao
    {
        IList<TenantWithoutRentedUnit> GetAllTenantWithoutRentedUnit();
       
        public void AssignTenantToAvailableUnit(UnitAndTenant unitAndTenant);

        public void TenantRent(TenantRent tenantRent);
    }
}
