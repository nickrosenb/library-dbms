﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace library_dbms.Models
{
    public partial class Asset
    {
        public Asset()
        {
            MaintenanceLog = new HashSet<MaintenanceLog>();
        }

        public int AssetId { get; set; }
        public string Category { get; set; }

        [DisplayName("Barcode Number")]
        public string BarcodeNum { get; set; }
        public string Manufacturer { get; set; }

        [DisplayName("Model Number")]
        public string ModelNum { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        [DisplayName("Status")]
        public string AssetStatus { get; set; }
        [DisplayName("Serial Number")]
        public string SerialNum { get; set; }

        //[Timestamp]
        //public byte[] RowVersion { get; set; }


        [DisplayName("Location")]
        public virtual AssetLocation AssetLocation { get; set; }
        public virtual AssignedToDep AssignedToDep { get; set; }
        public virtual AssignedToEmp AssignedToEmp { get; set; }
        public virtual ICollection<MaintenanceLog> MaintenanceLog { get; set; }
    }

    /// <summary>
    /// hmmmmmmm
    /// </summary>
    public class AssetSearchModel
    {
        public string Barcode { get; set; }
        public string Manufacturer { get; set; }
        public string ModelNum { get; set; }
        public string Name { get; set; }
        public string SerialNum { get; set; }

    }
}
