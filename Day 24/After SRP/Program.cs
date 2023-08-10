using System;

class Program
{
	static void Main()
	{
		Motor motor = new Motor 
		{
			Merk = "Kawasaki",
			Tipe = "Ninja",
			TahunProduksi = 2015
		};
		Pemilik pemilik = new Pemilik
		{
			Nama = "Christian Sidebang",
			Alamat = "Semarang",		
		};
		
		Perbaikan perbaikan = new Perbaikan();
		Perbaikan. PeriksaMesin(motor);
		Perbaikan. GantiOli(motor);
		Perbaikan. GantiBan(motor);
		
		Console.WriteLine($"Motor milik {pemilik.nama} ({pemilik.Alamat} telah diperbaiki.)");
		Console.WriteLine("Program Selesai");
	}
}