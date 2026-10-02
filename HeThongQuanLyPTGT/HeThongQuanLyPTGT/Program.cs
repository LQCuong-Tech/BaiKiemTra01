using System;
using System.Collections.Generic;
using System.Linq;

namespace LogisticsManagement
{
    // ==========================================
    // A. ABSTRACT CLASS PHUONGTIEN
    // ==========================================
    public abstract class PhuongTien
    {
        private string maPT;
        private string tenHang;
        private int namSanXuat;
        private decimal giaGoc;

        public string MaPT
        {
            get => maPT;
            set => maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value.Trim();
        }

        public string TenHang
        {
            get => tenHang;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên hãng không được để trống.");
                tenHang = value.Trim();
            }
        }

        public int NamSanXuat
        {
            get => namSanXuat;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < 1900 || value > currentYear)
                    throw new ArgumentException("Năm sản xuất không hợp lệ!");
                namSanXuat = value;
            }
        }

        public decimal GiaGoc
        {
            get => giaGoc;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Giá gốc phải lớn hơn 0.");
                giaGoc = value;
            }
        }

        protected PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
        {
            MaPT = maPT;
            TenHang = tenHang;
            NamSanXuat = namSanXuat;
            GiaGoc = giaGoc;
        }

        public abstract decimal TinhGiaLanBanh();

        public virtual string GetInfo()
        {
            return $"[Mã PT: {MaPT}] - Hãng: {TenHang} - NSX: {NamSanXuat} - Giá gốc: {GiaGoc:N0} VNĐ";
        }
    }

    // ==========================================
    // B. CLASS OTO
    // ==========================================
    public class OTo : PhuongTien
    {
        private int soChoNgoi;
        private double dungTichDongCo;

        public int SoChoNgoi
        {
            get => soChoNgoi;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0.");
                soChoNgoi = value;
            }
        }

        public double DungTichDongCo
        {
            get => dungTichDongCo;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tích động cơ phải lớn hơn 0.");
                dungTichDongCo = value;
            }
        }

        public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int soChoNgoi, double dungTichDongCo)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            SoChoNgoi = soChoNgoi;
            DungTichDongCo = dungTichDongCo;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (SoChoNgoi <= 9)
            {
                return GiaGoc + (GiaGoc * 0.12m) + (GiaGoc * 0.30m);
            }
            else
            {
                return GiaGoc + (GiaGoc * 0.10m);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - Ô tô: {SoChoNgoi} chỗ - Động cơ: {DungTichDongCo}L - Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }

    // ==========================================
    // C. CLASS XEMAY
    // ==========================================
    public class XeMay : PhuongTien
    {
        private int dungTichXylanh;

        public int DungTichXylanh
        {
            get => dungTichXylanh;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tích xilanh phải lớn hơn 0 cc.");
                dungTichXylanh = value;
            }
        }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            if (DungTichXylanh < 175)
            {
                return GiaGoc + (GiaGoc * 0.02m);
            }
            else
            {
                return GiaGoc + (GiaGoc * 0.05m);
            }
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} - Xe máy: {DungTichXylanh} cc - Giá lăn bánh: {TinhGiaLanBanh():N0} VNĐ";
        }
    }

    // ==========================================
    // D. CLASS QUANLYPHUONGTIEN
    // ==========================================
    public class QuanLyPhuongTien
    {
        private readonly List<PhuongTien> danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            if (pt != null)
            {
                danhSach.Add(pt);
                Console.WriteLine($"-> [THÀNH CÔNG] Đã thêm phương tiện [{pt.MaPT}] vào danh sách.");
            }
        }

        public void DisplayAll()
        {
            Console.WriteLine("\n--- DANH SÁCH PHƯƠNG TIỆN HIỆN CÓ ---");
            if (!danhSach.Any())
            {
                Console.WriteLine("Danh sách đang trống.");
                return;
            }

            foreach (var pt in danhSach)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (!danhSach.Any()) return null;
            return danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).FirstOrDefault();
        }
    }

    // ==========================================
    // PROGRAM: CHƯƠNG TRÌNH MENU NHẬP TỪ BÀN PHÍM
    // ==========================================
    internal class Program
    {
        private static QuanLyPhuongTien ql = new QuanLyPhuongTien();

        private static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("\n=========================================================");
                Console.WriteLine("       HỆ THỐNG KIỂM THỬ THỦ CÔNG NHẬP TỪ BÀN PHÍM");
                Console.WriteLine("=========================================================");
                Console.WriteLine("1. [TC01] Kiểm tra Validation Năm sản xuất");
                Console.WriteLine("2. [TC02] Tính Giá Lăn Bánh Ô tô (Nhập tham số từ bàn phím)");
                Console.WriteLine("3. [TC03] Tính Giá Lăn Bánh Xe máy (Nhập tham số từ bàn phím)");
                Console.WriteLine("4. [TC04] Kiểm tra Tính Đa Hình & Hiển thị Danh Sách");
                Console.WriteLine("5. [TC05] Tìm Phương Tiện Có Giá Lăn Bánh Cao Nhất");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("=========================================================");
                Console.Write("Chọn chức năng kiểm thử (0-5): ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        TestValidationNamSanXuat();
                        break;
                    case "2":
                        TestTinhGiaLanBanhOTo();
                        break;
                    case "3":
                        TestTinhGiaLanBanhXeMay();
                        break;
                    case "4":
                        ql.DisplayAll();
                        break;
                    case "5":
                        TestFindMax();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng nhập lại!");
                        break;
                }
            }
        }

        // TC01: Kiểm tra ngoại lệ năm sản xuất
        private static void TestValidationNamSanXuat()
        {
            Console.WriteLine("--- [TC01] THỬ NGHIỆM TẠO PHƯƠNG TIỆN VỚI NĂM SẢN XUẤT ---");
            Console.Write("Nhập mã phương tiện: ");
            string ma = Console.ReadLine();
            Console.Write("Nhập năm sản xuất: ");
            int nam = int.Parse(Console.ReadLine());

            try
            {
                var oto = new OTo(ma, "Toyota", nam, 500_000_000m, 5, 2.0);
                ql.AddPhuongTien(oto);
            }
            catch (ArgumentException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[BẮT ĐƯỢC NGOẠI LỆ]: {ex.Message}");
                Console.ResetColor();
            }
        }

        // TC02: Nhập thông tin Ô tô từ bàn phím để tính giá lăn bánh
        private static void TestTinhGiaLanBanhOTo()
        {
            Console.WriteLine("--- [TC02] NHẬP THÔNG TIN Ô TÔ ---");
            try
            {
                Console.Write("Mã phương tiện: ");
                string ma = Console.ReadLine();
                Console.Write("Tên hãng: ");
                string hang = Console.ReadLine();
                Console.Write("Năm sản xuất: ");
                int nam = int.Parse(Console.ReadLine());
                Console.Write("Giá gốc (VNĐ): ");
                decimal giaGoc = decimal.Parse(Console.ReadLine());
                Console.Write("Số chỗ ngồi: ");
                int soCho = int.Parse(Console.ReadLine());
                Console.Write("Dung tích động cơ (L): ");
                double dungTich = double.Parse(Console.ReadLine());

                var oto = new OTo(ma, hang, nam, giaGoc, soCho, dungTich);
                Console.WriteLine($"\n-> Thông tin: {oto.GetInfo()}");

                ql.AddPhuongTien(oto);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập dữ liệu: {ex.Message}");
            }
        }

        // TC03: Nhập thông tin Xe máy từ bàn phím
        private static void TestTinhGiaLanBanhXeMay()
        {
            Console.WriteLine("--- [TC03] NHẬP THÔNG TIN XE MÁY ---");
            try
            {
                Console.Write("Mã phương tiện: ");
                string ma = Console.ReadLine();
                Console.Write("Tên hãng: ");
                string hang = Console.ReadLine();
                Console.Write("Năm sản xuất: ");
                int nam = int.Parse(Console.ReadLine());
                Console.Write("Giá gốc (VNĐ): ");
                decimal giaGoc = decimal.Parse(Console.ReadLine());
                Console.Write("Dung tích xilanh (cc): ");
                int dungTich = int.Parse(Console.ReadLine());

                var xeMay = new XeMay(ma, hang, nam, giaGoc, dungTich);
                Console.WriteLine($"\n-> Thông tin: {xeMay.GetInfo()}");

                ql.AddPhuongTien(xeMay);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Lỗi nhập dữ liệu: {ex.Message}");
            }
        }

        // TC05: Tìm xe có giá lăn bánh cao nhất
        private static void TestFindMax()
        {
            Console.WriteLine("--- [TC05] PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT ---");
            var maxPt = ql.FindMaxGiaLanBanh();
            if (maxPt != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(maxPt.GetInfo());
                Console.ResetColor();
            }
            else
            {
                Console.WriteLine("Danh sách đang trống, hãy thêm phương tiện trước!");
            }
        }
    }
}