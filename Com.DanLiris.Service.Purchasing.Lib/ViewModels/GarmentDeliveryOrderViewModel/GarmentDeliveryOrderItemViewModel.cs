﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using Com.DanLiris.Service.Purchasing.Lib.ViewModels.NewIntegrationViewModel;
using System.Collections.Generic;

namespace Com.DanLiris.Service.Purchasing.Lib.ViewModels.GarmentDeliveryOrderViewModel
{
    public class GarmentDeliveryOrderItemViewModel : BaseViewModel
    {
        public PurchaseOrderExternal purchaseOrderExternal { get; set; }
        public List<GarmentDeliveryOrderFulfillmentViewModel> fulfillments { get; set; }
        public string paymentType { get; set; }
        public string paymentMethod { get; set; }
        public int paymentDueDays { get; set; }
        public CurrencyViewModel currency { get; set; }

        public bool useVat { get; set; }
        public bool useIncomeTax { get; set; }

        public IncomeTaxViewModel incomeTax { get; set; }
    }

    public class PurchaseOrderExternal
    {
        public long Id { get; set; }
        public string no { get; set; }
    }
}
