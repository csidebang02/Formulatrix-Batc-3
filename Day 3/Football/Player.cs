public interface _Salto
{
	void Salto();
}

public interface _Wing
{
	void Wing();
}
public interface _Heading
{
	void Heading();
}

public class PensiunPemain : _Salto, _Wing
{
	public PensiunPemain()
	{
		Console.WriteLine("wing");
	}
	public void Salto()
	{
		Console.WriteLine("PensiunPemain winger");
	}
	public void Wing()
	{
		Console.WriteLine("PensiunPemain wing...");
	}
	public virtual void Heading()
	{
		Console.WriteLine("PensiunPemain Heading");
	}
}
public class PemainProfesional : PensiunPemain, _Salto, _Wing, _Heading
{
	public PemainProfesional()
	{
		Console.WriteLine("PemainProfesional");
	}
	public new void Salto()
	{
		Console.WriteLine("PemainProfesional Salto");
	}
	public new void Wing()
	{
		Console.WriteLine("PemainProfesional Wing");
	}
	public override void Heading()
	{
		Console.WriteLine("PemainProfesional Heading");
	}
}

