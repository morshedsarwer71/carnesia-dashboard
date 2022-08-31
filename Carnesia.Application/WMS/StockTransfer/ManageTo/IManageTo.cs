﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.ManageTO;
using Carnesia.Domain.WMS.OutScan;

namespace Carnesia.Application.WMS.StockTransfer.ManageTo
{
	public interface IManageTo
	{
		Task<List<ManageToDTO>> GetAllManageTo();
		Task<OutUIDScanDTO> GetOutScan(string picklistID, string uid);
		Task GeneratePicklistID(string trnCode);
		Task<OutScanDTO> ReceiveTo(string toid, string uid);
		Task CancelPicklist(string pickList);
		Task<List<NewOutScanProductDTO>> GetProductsByPickList(string picklistID);
		Task<bool> ConfirmPickList(string picklistID);
	}
}
