
Vatandas vatandas1 = new Vatandas();
vatandas1.Ad = "E";
SelamVer();

static void SelamVer()
{
    Console.WriteLine("Selam");
}
public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }
}