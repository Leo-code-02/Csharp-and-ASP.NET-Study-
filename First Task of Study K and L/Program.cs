namespace Classes_and_Objects_K_and_L
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MotorReservas motor = new MotorReservas();
            motor.IniciarMotor();


            Habitacion habitacion = new Habitacion(10, 2550.0);

            HabitacionVIP vip = new HabitacionVIP(20);

            habitacion.Reservar();

            vip.MostrarBeneficios();

        }
    }
}
