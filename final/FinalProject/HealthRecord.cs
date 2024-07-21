public class HealthRecord
{
    public DateTime VisitDate { get; set; }
    public string Treatment { get; set; }
    public string Vaccinations { get; set; }
    public string HealthMetrics { get; set; }

    public HealthRecord(DateTime visitDate, string treatment, string vaccinations, string healthMetrics)
    {
        VisitDate = visitDate;
        Treatment = treatment;
        Vaccinations = vaccinations;
        HealthMetrics = healthMetrics;
    }

    public string GetDetails()
    {
        return $"Visit Date: {VisitDate}, Treatment: {Treatment}, Vaccinations: {Vaccinations}, Health Metrics: {HealthMetrics}";
    }
}