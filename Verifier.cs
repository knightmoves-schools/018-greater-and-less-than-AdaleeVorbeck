namespace knightmoves;
public class Verifier
{
    // Add your code here
    public string OldEnough(int age)
    {
        // age over 17 is considered "old enough"
        if (age > 17)
        {
            return "old enough";
        }
        return string.Empty;
    }

    public string UnderAge(int age)
    {
        // age under 18 is "under age"
        if (age < 18)
        {
            return "under age";
        }
        return string.Empty;
    }

    public string LegalSpeed(int speed)
    {
        // legal speed is 50 or less
        if (speed <= 50)
        {
            return "legal speed";
        }
        return string.Empty;
    }

    public string IsGoldenYears(int age)
    {
        // golden years starts at age 65
        if (age >= 65)
        {
            return "golden years";
        }
        return string.Empty;
    }
}

