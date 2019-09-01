
using System.Collections.Generic;

public class ConsignmentType
{
    public int Id {get; set;}

    public string Name {get; set;}

    public bool NeedsToControl {get; set;}

    public IEnumerable<ConsignmentCondition> ConsignmentConditions {get; set;}

    public string Description {get; set;}
}