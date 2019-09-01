using System;

public class TransmissionDelivery
{
    public long Id {get; set;}

    public Transmission Transmission {get; set;}
    
    public long TransmissionId {get; set;}

    public DateTime DeliveryDate {get; set;}

    public DeliveryType DeliveryType {get; set;}
    
    public long DeliveryPersonId {get; set;}

    public Person DeliveryPerson {get; set;} 

    public string Description {get; set;}
}