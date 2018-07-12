﻿using Com.DanLiris.Service.Purchasing.Lib.Facades.Expedition;
using Com.DanLiris.Service.Purchasing.Lib.Models.Expedition;
using Com.DanLiris.Service.Purchasing.Lib.ViewModels.Expedition;
using Com.DanLiris.Service.Purchasing.Test.DataUtils.ExpeditionDataUtil;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.DanLiris.Service.Purchasing.Test.DataUtils.PPHBankExpenditureNoteDataUtil
{
    public class PPHBankExpenditureNoteDataUtil
    {
        private readonly PPHBankExpenditureNoteFacade Facade;
        private readonly PurchasingDocumentAcceptanceDataUtil pdaDataUtil;
        public PPHBankExpenditureNoteDataUtil(PPHBankExpenditureNoteFacade Facade, PurchasingDocumentAcceptanceDataUtil pdaDataUtil)
        {
            this.Facade = Facade;
            this.pdaDataUtil = pdaDataUtil;
        }

        public PPHBankExpenditureNoteItem GetItemNewData()
        {
            PurchasingDocumentExpedition purchasingDocumentExpedition = Task.Run(() => this.pdaDataUtil.GetCashierTestData()).Result;

            return new PPHBankExpenditureNoteItem()
            {
                Id = 0,
                PurchasingDocumentExpeditionId = purchasingDocumentExpedition.Id,
                UnitPaymentOrderNo = purchasingDocumentExpedition.UnitPaymentOrderNo,
            };
        }

        public PPHBankExpenditureNote GetNewData()
        {
            PurchasingDocumentExpedition purchasingDocumentExpedition1 = Task.Run(() => this.pdaDataUtil.GetCashierTestData()).Result;
            PurchasingDocumentExpedition purchasingDocumentExpedition2 = Task.Run(() => this.pdaDataUtil.GetCashierTestData()).Result;
            
            List<PPHBankExpenditureNoteItem> Items = new List<PPHBankExpenditureNoteItem>()
            {
                new PPHBankExpenditureNoteItem()
                {
                    PurchasingDocumentExpeditionId = purchasingDocumentExpedition1.Id,
                    UnitPaymentOrderNo = purchasingDocumentExpedition1.UnitPaymentOrderNo,
                },
                new PPHBankExpenditureNoteItem()
                {
                    PurchasingDocumentExpeditionId = purchasingDocumentExpedition2.Id,
                    UnitPaymentOrderNo = purchasingDocumentExpedition2.UnitPaymentOrderNo,
                }
            };

            PPHBankExpenditureNote TestData = new PPHBankExpenditureNote()
            {
                Date = DateTimeOffset.UtcNow,
                BankAccountNumber = "100020003000",
                BankAccountName = "BankAccountName",
                BankCode = "BankCode",
                BankId = "BankId",
                BankName = "BankName",
                BGNo = "BGNo",
                IncomeTaxId = "IncomeTaxId",
                IncomeTaxName = "IncomeTaxName",
                IncomeTaxRate = 2,
                Items = Items,
                No = "No",
                TotalDPP = 1100000,
                TotalIncomeTax = 100000,
                Currency = "IDR"
            };

            return TestData;
        }

        public async Task<PPHBankExpenditureNote> GetTestData()
        {
            PPHBankExpenditureNote model = GetNewData();
            await Facade.Create(model, "Unit Test");
            return await Facade.ReadById(model.Id);
        }
    }
}
