namespace TrainingPOO.CompositionAndAggregation.Domains
{
    public class MotherBoard:IBroke
    {
        public bool Works { get; set; } = true;
        public void Broke()
        {
            this.Works = false;
        }
    }
}