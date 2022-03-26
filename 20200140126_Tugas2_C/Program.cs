using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace _20200140126_Tugas2_C
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=LAPTOP-951J28VL\\FEBRIYANTIAZAHRA;database=Toko_Kue;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Kue (Id_Kue, Nama_Kue, Harga) values('001', 'Brownis', '30000')"
                    + "insert into Kue (Id_Kue, Nama_Kue, Harga) values('002', 'Lapis Legit', '50000')"
                    + "insert into Kue (Id_Kue, Nama_Kue, Harga) values('003', 'Klepon', '10000')"
                    + "insert into Kue (Id_Kue, Nama_Kue, Harga) values('004', 'Panada', '5000')"
                    + "insert into Kue (Id_Kue, Nama_Kue, Harga) values('005', 'Nagasari', '5000')"

                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Jenis_Kel) values('k001', 'Nirina', 'P')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Jenis_Kel) values('k002', 'Miftah', 'L')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Jenis_Kel) values('k003', 'Ria', 'P')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Jenis_Kel) values('k004', 'Dania', 'P')"
                    + "insert into Kasir (Id_Kasir, Nama_Kasir, Jenis_Kel) values('k005', 'Fauzi', 'L')"

                    + "insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kel, Alamat) values('p001', 'Viona', 'P', 'Jakarta')"
                    + "insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kel, Alamat) values('p002', 'Rina', 'P', 'Bekasi')"
                    + "insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kel, Alamat) values('p003', 'Raihan', 'L', 'Bantul')"
                    + "insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kel, Alamat) values('p004', 'Mika', 'P', 'Sleman')"
                    + "insert into Pembeli (Id_Pembeli, Nama_Pembeli, Jenis_Kel, Alamat) values('p005', 'Dandi', 'L', 'Tangerang')"

                    + "insert into Detail_Transaksi (Id_Detail, Id_Kue, Subtotal, Bayar, Kembalian) values('d001', '001', '30000', '50000', '20000')"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Kue, Subtotal, Bayar, Kembalian) values('d002', '002', '150000', '200000', '50000')"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Kue, Subtotal, Bayar, Kembalian) values('d003', '003', '20000', '50000', '30000')"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Kue, Subtotal, Bayar, Kembalian) values('d004', '001', '60000', '100000', '40000')"
                    + "insert into Detail_Transaksi (Id_Detail, Id_Kue, Subtotal, Bayar, Kembalian) values('d005', '005', '15000', '50000', '35000')"

                    + "insert into Transaksi (Id_Transaksi, Id_Kue, Id_Kasir, Id_Pembeli, Id_Detail, Tgl_Transaksi, Jam_Transaksi) values('t001', '002', 'k003', 'p002', 'd001', '17 Maret 2022', '19:15:05')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kue, Id_Kasir, Id_Pembeli, Id_Detail, Tgl_Transaksi, Jam_Transaksi) values('t002', '001', 'k005', 'p001', 'd002', '14 Maret 2022', '10:13:20')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kue, Id_Kasir, Id_Pembeli, Id_Detail, Tgl_Transaksi, Jam_Transaksi) values('t003', '004', 'k002', 'p005', 'd003', '21 Maret 2022', '15:08:15')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kue, Id_Kasir, Id_Pembeli, Id_Detail, Tgl_Transaksi, Jam_Transaksi) values('t004', '005', 'k001', 'p003', 'd004', '23 Maret 2022', '21:05:17')"
                    + "insert into Transaksi (Id_Transaksi, Id_Kue, Id_Kasir, Id_Pembeli, Id_Detail, Tgl_Transaksi, Jam_Transaksi) values('t005', '003', 'k004', 'p004', 'd005', '21 Maret 2022', '20:15:09')"

                    , con);
                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
