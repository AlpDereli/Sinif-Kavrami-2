// See https://aka.ms/new-console-template for more information
Calisan calisan1 = new Calisan();
calisan1.ad = "Alp";
calisan1.soyad = "Dereli";
calisan1.no = 32413;
calisan1.departman = "Insan kaynaklari";

calisan1.calisanbilgileri();

Calisan calisan2 = new Calisan();
calisan2.ad = "Yusuf Emre";
calisan2.soyad = "Coban";
calisan2.no = 313131;
calisan2.departman = "Satin alim";

calisan2.calisanbilgileri();

Calisan calisan3 = new Calisan("Ali Hamza", "Coban", 21413, "İse alim");
calisan3.calisanbilgileri();

Calisan calisan4 = new Calisan("Cem", "Dereli");
calisan4.calisanbilgileri();
class Calisan
{
    public string ad;
    public string soyad;
    public int no;
    public string departman;

    public Calisan(string AD, string SOYAD, int NO, string DEPARTMAN)
    {
        this.ad = AD;
        this.soyad = SOYAD;
        this.no = NO;
        this.departman = DEPARTMAN;
    }
    public Calisan() { }

    public Calisan(string AD, string SOYAD)
    {
        this.ad = AD;
        this.soyad = SOYAD;
    }

    public void calisanbilgileri()
    {
        Console.WriteLine("Adi: " + ad);
        Console.WriteLine("Soyadi: " + soyad);
        Console.WriteLine("No: " + no);
        Console.WriteLine("Departmani: " + departman);
    }



}
