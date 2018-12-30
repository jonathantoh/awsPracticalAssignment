using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using FLYTA.DAL;

namespace FLYTA.BLL
{
    public class BllProgramCatalog
    {
        public DataSet GetPrograms()
        {
            DalPrograms dataLayerPrograms;

            dataLayerPrograms = new DalPrograms();
            return dataLayerPrograms.GetAll();
        }
    }
}