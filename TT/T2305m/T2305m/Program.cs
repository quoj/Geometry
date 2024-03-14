using System;

namespace GeometryExample
{
    class Cylinder
    {
        private double BanKinh { get; }
        private double ChieuCao { get; }

        public Cylinder(double banKinh, double chieuCao)
        {
            BanKinh = banKinh;
            ChieuCao = chieuCao;
        }

        public void Process()
        {
            double DienTichDay = BanKinh * BanKinh * Math.PI;
            double DienTichXungQuanh = 2 * Math.PI * BanKinh * ChieuCao;
            double DienTichToanBo = 2 * Math.PI * BanKinh * (ChieuCao + BanKinh);
            double TheTich = Math.PI * BanKinh * BanKinh * ChieuCao;

            Console.WriteLine("Dac diem cua Hinh tru");
            Console.WriteLine($"Ban kinh: {BanKinh}. Chieu cao: {ChieuCao}");
            Console.WriteLine($"Dien tich day: {DienTichDay}");
            Console.WriteLine($"Dien tich xung quanh: {DienTichXungQuanh} Tong dien tich: {DienTichToanBo}");
            Console.WriteLine($"The tich: {TheTich}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap cac kich thuoc cua hinh tru");
            Console.Write("Ban kinh: ");
            double banKinh = Convert.ToDouble(Console.ReadLine());
            Console.Write("Chieu cao: ");
            double chieuCao = Convert.ToDouble(Console.ReadLine());

            Cylinder hinhTru = new Cylinder(banKinh, chieuCao);
            hinhTru.Process();
        }
    }
}
