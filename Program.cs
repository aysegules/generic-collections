internal partial class Program
{
    public static void Main(string[] args)
    {
        //List <T> class
        // System.Collections.Generic
        // T -> object type
        
        List <int> sayiListesi= new List<int>();
        sayiListesi.Add(15);
        sayiListesi.Add(27);
        sayiListesi.Add(5);
        sayiListesi.Add(12);
        sayiListesi.Add(89);
        sayiListesi.Add(72);

        List<string> renkListesi = new List<string>();
        renkListesi.Add("Mor");
        renkListesi.Add("Mavi");
        renkListesi.Add("Turuncu");
        renkListesi.Add("Yesil");
        renkListesi.Add("Kahverengi");

        //Count
        Console.WriteLine(renkListesi.Count);
        Console.WriteLine(sayiListesi.Count);

        //ForEach ve List.ForEach ile elemanlara erisim
        foreach (var renk in renkListesi)
        {
            Console.WriteLine(renk);
        }
        foreach (var sayi in sayiListesi)
        {
            Console.WriteLine(sayi);
        }

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Listeden eleman cikarme
        sayiListesi.Remove(12);
        renkListesi.Remove("Mavi");

        sayiListesi.RemoveAt(0);
        renkListesi.RemoveAt(0);

        sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
        renkListesi.ForEach(renk => Console.WriteLine(renk));

        //Liste icerisinde arama
        if(sayiListesi.Contains(10))
            Console.WriteLine("10 liste icerisinde bulundu");
        else
            Console.WriteLine("10 liste icerisinde yok");

        //Eleman ile index'e erisim
        Console.WriteLine(renkListesi.BinarySearch("Kahverengi"));

        //Diziyi List'e cevirme
        string[] hayvanlar={"kedi","kopek","kus","maymun"};
        List<string> hayvanListesi=new List<string>(hayvanlar);

        //Liste temizleme
        hayvanListesi.Clear();

        //List icerisinde nesne tutmak
        List<Kullanicilar> kullaniciListesi= new List<Kullanicilar>();

        Kullanicilar kullanici1= new Kullanicilar();
        kullanici1.Isim="Aysegul";
        kullanici1.Soyisim="Eski";
        kullanici1.Yas=20;

        Kullanicilar kullanici2= new Kullanicilar();
        kullanici2.Isim="Sebnem";
        kullanici2.Soyisim="Aslan";
        kullanici2.Yas=27;

        kullaniciListesi.Add(kullanici1);
        kullaniciListesi.Add(kullanici2);

        List<Kullanicilar> yeniListe=new List<Kullanicilar>();

        yeniListe.Add(new Kullanicilar()
        {
           Isim="Deniz",
           Soyisim="Yaman",
           Yas=24
        });

        foreach (var kullanici in kullaniciListesi)
        {
            Console.WriteLine("Kullanici Adi:"+kullanici.Isim);
            Console.WriteLine("Kullanici Soyadi:"+kullanici.Soyisim);
            Console.WriteLine("Kullanici Yasi:"+kullanici.Yas);
        }

        //yeniListe.Clear();
    }    


}

public class Kullanicilar
{
    private string isim;
    private string soyisim;
    private int yas;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Yas { get => yas; set => yas = value; }
}