public class TransmissionConsignment
{
    public long Id {get; set;}

    public long TransmissionId {get; set;}

    public Transmission Transmission {get; set;}

    public ConsignmentDimenssion ConsignmentDimenssion {get; set;}

    public int Count {get; set;}

    public bool IncludeInsurance {get; set;}
}