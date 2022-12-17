using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carnesia.Domain.CMS.ComboProducts
{
    public class ComboListDTO
    {
        public int comboId { get; set; }
        public string comboProductName { get; set; }
        public int productId { get; set; }
        public string sku { get; set; }
        public string comboCode { get; set; }
        public decimal regularPrice { get; set; }
        public decimal comboPrice { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public bool isApproved { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string startTime { get; set; }
        public string endTime { get; set; }
        public string base64Attch { get; set; }
		public string createdBy { get; set; }
		public string updatedBy { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string bcType { get; set; }
		public string bcCode { get; set; }
		public bool ShowDetailsStore { get; set; }
		public bool ShowDetailsProduct { get; set; }
		public List<ComboProductDTO> products { get; set; }
		public List<ComboStoreListDTO> stores { get; set; }
    }

	public class ComboStoreListDTO
    {
		public int id { get; set; }
		public string storeName { get; set; }
		public int storeId { get; set; }
		public string comboCode { get; set; }
		public DateTime createdAt { get; set; }
		public DateTime updatedAt { get; set; }
		public string createdBy { get; set; }
		public string updatedBy { get; set; }
		public bool isPublish { get; set; }
	}
}
