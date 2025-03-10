class Program
{
    static void Main(string[] args)
    {

        string? specialChars = "!?.@:";
        bool hasUpper = false, hasLower = false, hasSpecial = false; //Initially, we don’t know if the password has an uppercase letter, lowercase letter, or special character.

        Console.Write("Create your password: ");
        string? newPassword = Console.ReadLine();

        if (newPassword?.Length < 5)
        {
            Console.WriteLine("❌Weak password, please enter at least 5 characters");
            return;
        }

        for (int i = 0; i < newPassword?.Length; i++)

        {
            char character = newPassword[i]; // Get each character at index i 

            if (specialChars.Contains(newPassword[i])) hasSpecial = true;
            if (char.IsLower(character)) hasLower = true;
            if (char.IsUpper(character)) hasUpper = true;

        }

        //Check if all conditions are met 
        if (hasSpecial && hasUpper && hasLower)
        {
            Console.WriteLine("✅ Strong password");
        }
        else
        {
            Console.WriteLine("❌Password must contain at least one uppercase and lower letter, together with at lest one special character");

        }


    }

}
