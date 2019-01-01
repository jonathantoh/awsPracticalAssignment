using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using NYP.SvcRefFlyTA;

namespace NYP.DAL
{
    public class DalFlyTA
    {
        public DataSet GetPrograms()
        {
            WsProgramCatalogClient FlyTAClient;
            FlyTAClient = new WsProgramCatalogClient();
            return FlyTAClient.GetAllAvailableOSEP();
        }

        public int increaseSeats(int Id)
        {
            WsProgramCatalogClient FlyTAClient;
            FlyTAClient = new WsProgramCatalogClient();
            return FlyTAClient.IncreaseRegisteredSeats(Id);
        }
    }
}