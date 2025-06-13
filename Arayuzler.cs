using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracKiralamaVeTakip
{


    public interface IKiralik
    {
        double GunlukUcret { get; set; }
        double KiraHesapla(DateTime baslangic, DateTime bitis);
    }

    public interface IAracOzellikleri
    {
        string Marka { get; set; }
        string Model { get; set; }
        int Yil { get; set; }
    }

    public abstract class Arac : IKiralik, IAracOzellikleri
    {
        public string AraçTürü {  get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public string Plaka { get; set; }
        public double GunlukUcret { get; set; }

        public abstract double KiraHesapla(DateTime baslangic, DateTime bitis);


        public override string ToString()
        {
            
            return $"{Marka} {Model} ({Yil}) - Plaka: {Plaka} - {AraçTürü} - {GunlukUcret}";
        }
    }

    public class Sedan : Arac
    {
        public override double KiraHesapla(DateTime baslangic, DateTime bitis)
        {
            int gün = (bitis - baslangic).Days;
            if (gün <= 0)
                gün = 1;
            return gün * GunlukUcret;
        }
    }

    public class SUV : Arac
    {
        public override double KiraHesapla(DateTime baslangic, DateTime bitis)
        {
            int gün = (bitis - baslangic).Days;
            if (gün <= 0)
                gün = 1;
            return gün * GunlukUcret * 1.1 ;
        }
    }

    public class Kamyonet : Arac
    {
        public override double KiraHesapla(DateTime baslangic, DateTime bitis)
        {
            int gün = (bitis - baslangic).Days;
            if (gün <= 0)
                gün = 1;
            return gün *  GunlukUcret * 1.2 ;
        }
    }
    public class Musteri
    {
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }

        public override string ToString() => $"{AdSoyad} - Tel:{Telefon} - Eposta:{Email}";
    }
    public class KiraSozlesmesi
    {
        public int Id { get; set; }
        public Arac KiralananArac { get; set; }
        public Musteri Musteri { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public double ToplamTutar => KiralananArac.KiraHesapla(BaslangicTarihi, BitisTarihi);

        public override string ToString()
        {
            return $"Sözleşme: {Musteri} - {KiralananArac} - {BaslangicTarihi.ToShortDateString()} ~ {BitisTarihi.ToShortDateString()} | Tutar: {ToplamTutar} TL";
        }
    }
    public class Raporlama
    {
        public static Arac EnCokKiralananArac(List<KiraSozlesmesi> sozlesmeler)
        {
            return sozlesmeler
                .GroupBy(s => s.KiralananArac.Plaka)
                .OrderByDescending(g => g.Count())
                .Select(g => g.First().KiralananArac)
                .FirstOrDefault();
        }

        public static List<KiraSozlesmesi> AktifKiralamalar(List<KiraSozlesmesi> sozlesmeler)
        {
            DateTime now = DateTime.Now;
            return sozlesmeler.Where(s => s.BaslangicTarihi <= now && s.BitisTarihi >= now).ToList();
        }
        public static List<KiraSozlesmesi> RezerveKiralamalar(List<KiraSozlesmesi> sozlesmeler)
        {
            DateTime now = DateTime.Now;
            return sozlesmeler.Where(s => s.BaslangicTarihi >= now && s.BitisTarihi >= now).ToList();
        }
        public static List<KiraSozlesmesi> GeçmişKiralamalar(List<KiraSozlesmesi> sozlesmeler)
        {
            DateTime now = DateTime.Now;
            return sozlesmeler.Where(s => s.BaslangicTarihi <= now && s.BitisTarihi <= now).ToList();
        }
    }
}
