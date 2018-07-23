namespace TrainingPOO.CompositionAndAggregation.Domains
{
    public class HardDriver:IBroke
    {
        public bool Works { get; set; } = true;
        public void Broke()
        {
            this.Works = false;
        }
    }
}