namespace return_practice_c_.Model;

public class Card
{
    public int Id { get; set; } // Primary key
    public string? Value { get; set; }
    public string? Suit { get; set; }
    
    public override string ToString() => $"{Value} of {Suit}"; // method that overrides the default ToString() method from the base object clas
    /*
     * public override string ToString()
       {
           return $"{Value} of {Suit}";
       }
       
     */
}