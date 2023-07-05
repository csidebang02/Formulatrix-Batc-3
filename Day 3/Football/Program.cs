class Program 
{
	static void Main() 
	{
		PemainProfesional pemain = new PemainProfesional();
		PensiunPemain pelatih = pemain;
		
		pemain.Salto(); //new
		pelatih.Salto();

		pemain.Wing(); //new
		pelatih.Wing();
		
		pemain.Heading(); //override
		pelatih.Heading();
	}
}