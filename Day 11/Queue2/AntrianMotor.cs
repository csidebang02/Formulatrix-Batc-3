using System.Collections.Generic;

public class AntrianMotor
{
    private Queue<Motor> antrian = new Queue<Motor>();

    public int JumlahMotor => antrian.Count;

    public void TambahMotor(Motor motor)
    {
        antrian.Enqueue(motor);
    }

    public Motor AmbilMotorDariDepan()
    {
        if (antrian.Count > 0)
            return antrian.Dequeue();
        else
            return null;
    }

    public Motor LihatMotorDepan()
    {
        if (antrian.Count > 0)
            return antrian.Peek();
        else
            return null;
    }
}