using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JOIEnergy.Domain;
using JOIEnergy.Enums;
using Microsoft.AspNetCore.Mvc;

namespace JOIEnergy.Services
{
    public class CostService : ICostService
    {
        public Dictionary<string, List<ElectricityReading>> MeterAssociatedReadings { get; set; }

        AccountService accountService;
        public CostService(Dictionary<string, List<ElectricityReading>> meterAssociatedReadings)
        {

        }
        public decimal Cost(string smartMeterId)
        {
            if (!String.IsNullOrWhiteSpace(smartMeterId))
            {
                Supplier result = accountService.GetPricePlanIdForSmartMeterId(smartMeterId);
                PricePlan pricePlan;
                //check the priceplan
                //if (smartMeterId.Conta)

                 //calcualte
                 
            }

            throw new NotImplementedException();
        }
    }
}
