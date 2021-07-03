using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOIEnergy.Services
{
    public interface ICostService
    {
        decimal Cost(string smartMeterId);
    }
}
