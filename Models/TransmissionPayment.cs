using System;

public class TransmissionPayment
{
    public long Id {get; set;}

    public Transmission Transmission {get; set;}
    
    public long TransmissionId {get; set;}

    public DateTime PaymentDate {get; set;}

    public PaymentType PaymentType {get; set;}
    
    public byte PaymentTypeId {get; set;}
}