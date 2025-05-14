namespace csv_learning;

//Define a public class named Currency
public class Currency
{
    //Property to store the currency code
    public string? Code { get; set; }
    
    //Property to store the exchange rate 
    public double Rate { get; set; }
    
    //Override the default ToString method so we can print Currency objects
    public override string ToString()
    {
        //This will return a string like: USD = 1.0
        return $"{Code} = {Rate}";
    }
    
    
}