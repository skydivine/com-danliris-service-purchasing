﻿namespace Com.DanLiris.Service.Purchasing.Lib.Facades.VBRequestPOExternal
{
    public class IncomeTaxDto
    {
        public IncomeTaxDto(string incomeTaxId, string incomeTaxName, string incomeTaxRate)
        {
            int.TryParse(incomeTaxId, out var id);
            Id = id;

            double.TryParse(incomeTaxRate, out var rate);
            Rate = rate;

            Name = incomeTaxName;
        }

        public int Id { get; private set; }
        public double Rate { get; private set; }
        public string Name { get; private set; }
    }
}