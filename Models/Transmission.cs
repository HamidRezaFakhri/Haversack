using System;
using System.Collections.Generic;

public class Transmission
{
    public long Id {get; set;}

    public DateTime SendDate {get; set;}

    public long SourceLocationId {get; set;}
    
    public Location SourceLocation {get; set;}

    public DateTime ReceiveDate {get; set;}

    public long DestinationLocationId {get; set;}
    
    public Location DestinationLocation {get; set;}

    public IEnumerable<TransmissionConsignment> TransmissionConsignments {get; set;}

    public IEnumerable<TransmissionDelivery> TransmissionDeliveries {get; set;}

    public IEnumerable<TransmissionPayment> TransmissionPayments {get; set;}

    public string Description {get; set;}
}