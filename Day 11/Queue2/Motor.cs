public class Motor
{
    public string NomorPolisi { get; set; }
    public string Merk { get; set; }
    public string Tipe { get; set; }

    public Motor(string nomorPolisi, string merk, string tipe)
    {
        NomorPolisi = nomorPolisi;
        Merk = merk;
        Tipe = tipe;
    }

    public override string ToString()
    {
        return $"Motor dengan Nomor Polisi {NomorPolisi}, Merk {Merk}, Tipe {Tipe}";
    }
}
