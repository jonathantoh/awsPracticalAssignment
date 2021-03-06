﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;

namespace FLYTA
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IWsProgramCatalog" in both code and config file together.
    [ServiceContract]
    public interface IWsProgramCatalog
    {
        [OperationContract]
        DataSet GetPrograms();

        [OperationContract]
        DataSet GetAllAvailableOSEP();

        [OperationContract]
        int IncreaseRegisteredSeats(int Id);
    }
}
