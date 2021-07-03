using JOIEnergy.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JOIEnergy.Controllers
{
    [Route("Cost")]
    public class CostController:Controller
    {
        private ICostService _costService;
        public CostController(ICostService costService)
        {
            this._costService = costService;
        }

        [HttpGet("Cost/{smartMeterId}")]

        public ObjectResult Cost(string smartMeterId)
        {
           return _costService.Cost(smartMeterId);
           // return null;
        }

    }
}
