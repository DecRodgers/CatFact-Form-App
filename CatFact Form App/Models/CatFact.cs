namespace CatFactAPI.Model.CatFact;

public class CatFact() { 
    public string? fact {  get; set; }
    public int length { get; set; }

    public string ReturnFact() 
    {
        return fact;    
    }
    public int ReturnFactLength()
    {
        return length;
    }

}