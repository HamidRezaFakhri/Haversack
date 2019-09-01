using System;
using System.Collections.Generic;

public class Person
{
    public long Id {get; set; }
    
    public string FirstName {get; set; }
    
    public string MiddleName {get; set; }
    
    public string LastName {get; set; }
    
    public string FatherName {get; set; }
    
    public string MotherName {get; set; }
    
    public DateTime BirthDate {get; set; }
    
    public long BirthPlaceId {get; set; }
    
    public Location BirthPlace {get; set; }

    public bool Gender {get; set; }

    public string PassportNumber {get; set; }
    
    public string NationalId {get; set; }

    public IEnumerable<string> CreditCardIds {get; set;}

    public decimal Credit {get; set;}
}