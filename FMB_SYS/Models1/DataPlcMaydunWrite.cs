using System;
using System.Collections.Generic;

#nullable disable

namespace FMB_SYS.Models1
{
    public partial class DataPlcMaydunWrite
    {
        public int Id { get; set; }
        public double? TDauMayNgoai { get; set; }
        public double? TTruc1Ngoai { get; set; }
        public double? TTruc2Ngoai { get; set; }
        public double? TTrucVitNgoai { get; set; }
        public double? TGhDauMayNgoai { get; set; }
        public double? TGhTruc1Ngoai { get; set; }
        public double? TGhTruc2Ngoai { get; set; }
        public double? TGhTrucVitNgoai { get; set; }
        public double? TDungSoiDotDauMayNgoai { get; set; }
        public double? TDungSoiDotTruc1Ngoai { get; set; }
        public double? TDungSoiDotTruc2Ngoai { get; set; }
        public double? TDungSoiDotTrucVitNgoai { get; set; }
        public double? AtmTieuChuanNgoai { get; set; }
        public double? AtmMinNgoai { get; set; }
        public double? AtmMaxNgoai { get; set; }
        public double? AtmSafetyNgoai { get; set; }
        public double? AtmTieuChuanTrong { get; set; }
        public double? AtmMinTrong { get; set; }
        public double? AtmMaxTrong { get; set; }
        public double? AtmSafetyTrong { get; set; }
        public double? TDauMayTrong { get; set; }
        public double? TTruc1Trong { get; set; }
        public double? TTruc2Trong { get; set; }
        public double? TTrucVitTrong { get; set; }
        public double? TGhDauMayTrong { get; set; }
        public double? TGhTruc1Trong { get; set; }
        public double? TGhTruc2Trong { get; set; }
        public double? TGhTrucVitTrong { get; set; }
        public double? TDungSoiDotDauMayTrong { get; set; }
        public double? TDungSoiDotTruc1Trong { get; set; }
        public double? TDungSoiDotTruc2Trong { get; set; }
        public double? TDungSoiDotTrucVitTrong { get; set; }
        public bool? ChangeMaSp { get; set; }
        public double? AtmBeNuocNgoai { get; set; }
        public double? AtmBeNuocTrong { get; set; }
        public bool? Man { get; set; }
        public bool? OnTrucVit1SdNgoai { get; set; }
        public bool? OnTruc1SdNgoai { get; set; }
        public bool? OnTruc2SdNgoai { get; set; }
        public bool? OnDauMaySdNgoai { get; set; }
        public bool? OnTrucVit2SdTrong { get; set; }
        public bool? OnTruc1SdTrong { get; set; }
        public bool? OnTruc2SdTrong { get; set; }
        public bool? OnDauMaySdTrong { get; set; }
        public bool? OnTrucVit1BnNgoai { get; set; }
        public bool? OnTruc1BnNgoai { get; set; }
        public bool? OnTruc2BnNgoai { get; set; }
        public bool? OnDauMayBnNgoai { get; set; }
        public bool? OnTrucVit2BnTrong { get; set; }
        public bool? OnTruc1BnTrong { get; set; }
        public bool? OnTruc2BnTrong { get; set; }
        public bool? OnDauMayBnTrong { get; set; }
        public bool? LocalRemote { get; set; }
        public bool? ChangeRemote { get; set; }
        public bool? Stop { get; set; }
        public bool? Reset { get; set; }
        public bool? LoiServer { get; set; }
        public bool? MicrosopeOk { get; set; }
        public bool? BarcodeOk { get; set; }
        public bool? WriteData { get; set; }
        public bool? Write { get; set; }
        public byte? RunSys { get; set; }
        public bool? Baotri { get; set; }
    }
}
