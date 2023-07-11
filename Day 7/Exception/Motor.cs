public class Motor
{
    public string NomorPolisi { get; }
    public string Merk { get; }
    public string TahunProduksi { get; }

    public Motor(string nomorPolisi, string merk, string tahunProduksi)
    {
        NomorPolisi = nomorPolisi;
        Merk = merk;
        TahunProduksi = tahunProduksi;
    }
}
