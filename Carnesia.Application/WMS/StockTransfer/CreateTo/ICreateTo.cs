using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carnesia.Domain.WMS.TO.POCO;
using Microsoft.AspNetCore.Components.Forms;

namespace Carnesia.Application.WMS.StockTransfer.CreateTo
{
	public interface ICreateTo
	{
		Task<GetProductCreateToPoco> GetProduct(int source, int destination, string sku);
		Task<List<CreateToProductPoco>> GetBulkProducts(int source, int destination, InputFileChangeEventArgs e);
		Task<GetProductCreateToPoco> NewTo(NewToPoco to);
	}
}
