using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FLYTA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WsProgramCatalog" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WsProgramCatalog.svc or WsProgramCatalog.svc.cs at the Solution Explorer and start debugging.
    public class WsProgramCatalog : IWsProgramCatalog
    {
        public DataSet GetPrograms()
        {
            FLYTA.BLL.BllProgramCatalog bizLayerBooks;
            bizLayerBooks = new FLYTA.BLL.BllProgramCatalog();
            return bizLayerBooks.GetPrograms();
        }
    }
}
