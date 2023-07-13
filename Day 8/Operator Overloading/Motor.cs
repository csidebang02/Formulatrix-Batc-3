namespace BengkelMotorKawasaki
{
    class Motor
    {
        public string Model { get; set; }
        public int Tahun { get; set; }
        public int Harga { get; set; }

        public Motor(string model, int tahun, int harga)
        {
            Model = model;
            Tahun = tahun;
            Harga = harga;
        }

        public static Motor operator +(Motor motor1, Motor motor2)
        {
            if (motor1.Model == motor2.Model && motor1.Tahun == motor2.Tahun)
            {
                int totalHarga = motor1.Harga + motor2.Harga;
                return new Motor(motor1.Model, motor1.Tahun, totalHarga);
            }
            else
            {
                throw new ArgumentException("Motor model and tahun must be the same for addition.");
            }
        }

        public static Motor operator -(Motor motor1, Motor motor2)
        {
            if (motor1.Model == motor2.Model && motor1.Tahun == motor2.Tahun)
            {
                int totalHarga = motor1.Harga - motor2.Harga;
                return new Motor(motor1.Model, motor1.Tahun, totalHarga);
            }
            else
            {
                throw new ArgumentException("Motor model and tahun must be the same for subtraction.");
            }
        }

        public override string ToString()
        {
            return $"Model: {Model}, Tahun: {Tahun}, Harga: {Harga}";
        }
    }
}
