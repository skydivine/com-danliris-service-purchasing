﻿using Com.DanLiris.Service.Purchasing.Lib.ViewModels.MonitoringUnitReceiptAllViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Com.DanLiris.Service.Purchasing.Lib.Interfaces
{
	public interface IMonitoringUnitReceiptAllFacade
	{
		MemoryStream GenerateExcel(string no, string refNo, string roNo, string doNo, string unit, string supplier, DateTime? dateFrom, DateTime? dateTo);
		Tuple<List<MonitoringUnitReceiptAll>, int> GetReport(string no, string refNo, string roNo, string doNo, string unit, string supplier, DateTime? dateFrom, DateTime? dateTo);

	}
}