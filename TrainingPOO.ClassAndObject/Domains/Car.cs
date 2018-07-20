namespace TrainingPOO.ClassAndObject
{
    public class Car
    {
        //attributes
        public string Name { get; set; }
        public int Year { get; set; }
        public int Velocity { get; set; }
        
        //constructor
        public Car(string name)
        {
            this.Name = name;
            this.Year = 2018;
        }

        //methods
        public void Acelerate()
        {
            this.Velocity += 10;
        }
    }
}