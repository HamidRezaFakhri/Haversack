using Microsoft.EntityFrameworkCore;

[Owned]
public class ConsignmentDimenssion
{
    public decimal Length {get; set;}
    
    public decimal Width {get; set;}

    public decimal Height {get; set;}

    public decimal Weight {get; set;}
}