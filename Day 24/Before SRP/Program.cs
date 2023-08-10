using System;

class Program
{
	static void Main()
	{
		string merk = "Kawasaki";
		string tipe = "Ninja";
		int tahunProduksi = 2015;
		string pemilik = "Christian Sidebang";
		string alamatPemilik = "Semarang";
		
		Console.WriteLine($"Melayani pemeriksaan mesin motor {merk} {tipe}...");
		Console.WriteLine("Pemeriksaan mesin selesai. Tidak ditemukan masalah.");
		
		Console.WriteLine($"Melayani penggantian oli motor {merk} {tipe}...");
		Console.WriteLine("Penggantian oli selesai.");
		
		Console.WriteLine($"Melayani penggantian ban motor {merk} {tipe}...");
		Console.WriteLine("Penggantian ban selesai.");
		
		Console.WriteLine ($"Motor milik {pemilik} ({alamatPemilik}) telah diperbaiki.");
		
		Console.WriteLine("Program Selesai");
		
	}
}