using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace School_Inventory
{
    class inventorycs
    {
        private string v1;
        private string v2;
        private string v3;
        private string v4;
        private bool showCheckBox;
        private string v5;
        private string v6;
        private string v7;

        public string Nama { get; set; }
        public string Kondisi { set; get; }
        public string Keterangan { set; get; }
        public string Jumlah { set; get; }
        public string ID_Jenis { set; get; }
        public DateTime Tanggal_Registrasi { set; get; }
        public string ID_Ruang { set; get; }
        public string Kode_Inventaris { set; get; }
        public string ID_Petugas { set; get; }

        public inventorycs(string nama, string kondisi, string keterangan, string jumlah, string iD_Jenis, DateTime tanggal_Registrasi, string iD_Ruang, string kode_Inventaris, string iD_Petugas)
        {
            Nama = nama;
            Kondisi = kondisi;
            Keterangan = keterangan;
            Jumlah = jumlah;
            ID_Jenis = iD_Jenis;
            Tanggal_Registrasi = tanggal_Registrasi;
            ID_Ruang = iD_Ruang;
            Kode_Inventaris = kode_Inventaris;
            ID_Petugas = iD_Petugas;
        }

        public inventorycs(string v1, string v2, string v3, string v4, bool showCheckBox, string v5, string v6, string v7)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.v4 = v4;
            this.showCheckBox = showCheckBox;
            this.v5 = v5;
            this.v6 = v6;
            this.v7 = v7;
        }
    }
}
