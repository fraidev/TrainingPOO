namespace TrainingPOO.Polymorphism
{
    public class Vehicle
    {
        public double Velocity { get; set; }
        public double Passengers { get; set; }

        public void setVelocity(double velocity)
        {
            this.Velocity = velocity;
        }
        
        public void setPassengers(double passengers)
        {
            this.Passengers = passengers;
        }
    }
}