namespace TrainingPOO.CompositionAndAggregation.Domains
{
    public interface IBroke
    {
        bool Works { get; set; }
        void Broke();
    }
}