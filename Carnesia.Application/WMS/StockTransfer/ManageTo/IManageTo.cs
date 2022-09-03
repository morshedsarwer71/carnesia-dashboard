using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.ManageTO;
using Carnesia.Domain.WMS.OutScan;
using Carnesia.Domain.WMS.ReceiveTo;
using Carnesia.Domain.WMS.UpdateTO;

namespace Carnesia.Application.WMS.StockTransfer.ManageTo
{
	public interface IManageTo
	{
		Task<List<ManageToDTO>> GetAllManageTo();
		Task<OutUIDScanDTO> GetOutScan(string picklistID, string uid);
		Task GeneratePicklistID(string trnCode);
		Task<ReceiveToDTO> ReceiveToByToid(string toid);
		Task<ReceiveToDTO> ReceiveToByUID(string toid, string uid);
		Task CancelPicklist(string pickList);
		Task<List<NewOutScanProductDTO>> GetProductsByPickList(string picklistID);
		Task<bool> ConfirmPickList(string picklistID);
		Task<UpdateTODTO> GetToDetails(string toid);
		Task<bool> DeleteToProducts(DeleteToProductsDTO products);
		Task<bool> UpdateToProductQuantity(string toid, int qty, int id);
		Task<string> Acknowledgement(string toid);
	}
}
