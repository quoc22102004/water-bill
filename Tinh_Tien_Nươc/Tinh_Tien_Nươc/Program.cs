using System;
using System.Runtime.InteropServices;




class program
{
    static void Main()
    {
        string tenKhachHang;
        string loaiKhachHang;
        int chiSoNuocThangTruoc;
        int chiSoNuocThangNay;
        double gianuoc;
        double vat =0.1;
        double moitruong =0.1;
        double tienNuoc = 0;

        Console.Write("Nhap ten khach hang: ");
        tenKhachHang = Console.ReadLine();
        Console.Write("So nuoc thang truoc: ");
        chiSoNuocThangTruoc = int.Parse(Console.ReadLine());
        Console.Write("So nuoc thang nay: ");
        chiSoNuocThangNay = int.Parse(Console.ReadLine());
        Console.Write("Nhap loai khach hang: ");
        loaiKhachHang = Console.ReadLine();

        int luongNuocTieuThu = chiSoNuocThangNay - chiSoNuocThangTruoc;

        switch (loaiKhachHang.ToLower())
        {
            case "hogiadinh":
                if (luongNuocTieuThu <= 10)
                {
                    gianuoc = ( luongNuocTieuThu  * 5.973) ;
                }
                else if (luongNuocTieuThu <= 20)
                {
                    gianuoc = (luongNuocTieuThu * 5.973 + (luongNuocTieuThu - 10) * 7.052);
                }
                else if (luongNuocTieuThu <= 30)
                {
                    gianuoc = ((luongNuocTieuThu * 5.973) + (luongNuocTieuThu - 10 * 7.052)+(luongNuocTieuThu-20) * 8.699);
                }
                else
                {
                    gianuoc = ((luongNuocTieuThu * 5.973) + (luongNuocTieuThu - 10 * 7.052) + (luongNuocTieuThu * 8.699) + (luongNuocTieuThu - 30) * 15.929);
                }

                tienNuoc += vat * gianuoc + moitruong * gianuoc;
                break;

            case "co quan hanh chinh":
                tienNuoc = luongNuocTieuThu * 9.955;
                tienNuoc += vat * tienNuoc + moitruong * tienNuoc;
                break;

            case "don vi san xuat":
                tienNuoc = luongNuocTieuThu * 11.615;
                tienNuoc += vat * tienNuoc + moitruong * tienNuoc;
                break;

            case "dich vu kinh doanh":
                tienNuoc = luongNuocTieuThu * 22.068;
                tienNuoc += vat * tienNuoc + moitruong * tienNuoc;
                break;

            default:
                Console.WriteLine("Loai khach hang khong hop le.");
                return;
        }

        Console.WriteLine("So tien nuoc la " + tienNuoc);
        Console.WriteLine("Ten khach hang: " + tenKhachHang);
        Console.WriteLine("So nuoc thang truoc: " + chiSoNuocThangTruoc);
        Console.WriteLine("So nuoc thang nay: " + chiSoNuocThangNay);
        Console.WriteLine("Luong nuoc tieu thu: " + luongNuocTieuThu);
        Console.ReadKey();
    }
}
