public class Location
{
    public long Id {get; set;}
    
    public string Name {get; set;}
    
    public LocationType LocationType {get; set;}

    public byte LocationTypeId {get; set;}

    public long ParentLocationId {get; set;}

    public Location ParentLocation {get; set;}
}