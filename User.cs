using System;

class User
{
    private string adSoyad;
    private int yas;

    public string Email { get; set; }

    //Getter ve Setter metotları
    public string GetAdSoyad()
    {
        return adSoyad;
    }

    public void SetAdSoyad(string deger)
    {
        adSoyad = deger;
    }

    public int GetYas()
    {
        return yas;
    }

    public void SetYas(int deger)
    {
        if (deger >= 0) //Negatif yaş olmaması için kontrol
        {
            yas = deger;
        }
        else
        {
            Console.WriteLine("Geçersiz yaş değeri girdiniz.");
        }
    }

    //Bilgileri gösteren metod
    public void BilgileriGoster()
    {
        Console.WriteLine("Ad Soyad: " + adSoyad);
        Console.WriteLine("Yaş: " + yas);
        Console.WriteLine("Email: " + Email);
    }
}

class Program
{
    static void Main(string[] args)
    {
        User kullanici = new User();
        kullanici.SetAdSoyad("Ali Veli");
        kullanici.SetYas(25);
        kullanici.Email = "ali.veli@gmail.com";

        kullanici.BilgileriGoster();
    }
}
