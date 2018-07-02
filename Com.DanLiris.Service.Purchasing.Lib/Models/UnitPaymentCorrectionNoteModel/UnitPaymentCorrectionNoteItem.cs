﻿using Com.DanLiris.Service.Purchasing.Lib.Utilities;
using Com.Moonlay.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace Com.DanLiris.Service.Purchasing.Lib.Models.UnitPaymentCorrectionNoteModel
{
    public class UnitPaymentCorrectionNoteItem : StandardEntity<long>
    {
        
        public long UPODetailId { get; set; }
        public string URNNo { get; set; }
        public string EPONo { get; set; }
        public long PRId { get; set; }
        public string PRNo { get; set; }
        public long PRDetailId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public long Quantity { get; set; }
        public string UomId { get; set; }
        public string UomUnit { get; set; }
        public long PricePerDealUnitBefore { get; set; }
        public long PricePerDealUnitAfter { get; set; }
        public long PriceTotalBefore { get; set; }
        public long PriceTotalAfter { get; set; }
        public string CurrencyId { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyRate { get; set; }
        public virtual long UPCId { get; set; }
        [ForeignKey("UPCId")]
        public virtual UnitPaymentCorrectionNote UnitPaymentCorrectionNote { get; set; }

    }
}
