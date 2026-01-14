namespace Models;

public class Validator
{
    public bool IsValidUsername(string value)
    {
        if(value.Length > 2)
        {
            return true;
        }
        else
        {
            Console.WriteLine("ERROR: Username must 3 symbol long at least!");
            return false;
        };
    }
    public bool IsValidPassword(string value)
    {
        bool IsValid = true;

        // Condition 1: minimum 8 symbols long
        bool IsCorrectLength = value.Length >= 8;
        if(!IsCorrectLength)
        {
            Console.WriteLine("ERROR: Password must 8 symbol long at least!");
            IsValid = false;
            return IsValid;
        };

        // Condition 2: contain minimum 1 number, 1 symbol, 1 different case
        bool IsContainsSymbol = false;
        bool IsContainsLower = false;
        bool IsContainsUpper = false;
        string RequiredSymbols = "-.*$&%^_#@";
        string LowerAlphabet = "abcdefghijklmnopqrstuvwxyz";
        string UpperAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        foreach(char character in value)
        {
            foreach(char symbol in RequiredSymbols)
            {
                if(character == symbol)
                {
                    IsContainsSymbol = true;
                    break;
                };
            };

            foreach(char LowLetter in LowerAlphabet)
            {
                if(character == LowLetter)
                {
                    IsContainsLower = true;
                    break;
                };
            };

            foreach(char UpLetter in UpperAlphabet)
            {
                if(character == UpLetter)
                {
                    IsContainsUpper = true;
                    break;
                };
            };
        };

        if(!IsContainsSymbol)
        {
            Console.WriteLine("ERROR: Password must contains at least 1 symbol!");
            IsValid = false;
        };
        if(!IsContainsLower)
        {
            Console.WriteLine("ERROR: Password must contains at least 1 lowercase letter");
            IsValid = false;
        };
        if(!IsContainsUpper)
        {
            Console.WriteLine("ERROR: Password must contains at least 1 uppercase letter!");
            IsValid = false;
        };

        return IsValid;
    }
    public bool IsValidFirstname(string value)
    {
        if(value.Length > 2)
        {
            return true;
        }
        else
        {
            Console.WriteLine("ERROR: Firstname must 3 symbol long at least!");
            return false;
        };
    }
    public bool IsValidLastname(string value)
    {
        if(value.Length > 2)
        {
            return true;
        }
        else
        {
            Console.WriteLine("ERROR: Lastname must 3 symbol long at least!");
            return false;
        };
    }
    public bool IsValidBirthdate(string value)
    {
        bool IsValidBirthday = true;

        if(value.Length < 8 || value.Length > 10)
        {
            IsValidBirthday = false;
            Console.WriteLine("ERROR: Valid format is YYYY-MM-DD. Example: 1995-05-15.");
            return IsValidBirthday;
        };

        // >=1970 && YYYY-MM-DD
        string[] DateArray = value.Split("-");
        if(DateArray[0].Length != 4 || int.Parse(DateArray[0]) < 1970)
        {
            Console.WriteLine("ERROR: Birthdate's year is invalid!");
            IsValidBirthday = false;
            return IsValidBirthday;
        };
        if(DateArray[1].Length < 1 || DateArray[1].Length > 2 || int.Parse(DateArray[1]) > 12 || int.Parse(DateArray[1]) < 1)
        {
            Console.WriteLine("ERROR: Birthdate's month is invalid!");
            IsValidBirthday = false;
            return IsValidBirthday;
        };
        if(DateArray[2].Length < 1 || DateArray[2].Length > 2 || int.Parse(DateArray[2]) > 31 || int.Parse(DateArray[2]) < 1)
        {
            Console.WriteLine("ERROR: Birthdate's day is invalid!");
            IsValidBirthday = false;
            return IsValidBirthday;
        };

        return IsValidBirthday;
    }
    public bool IsValidAge(int value)
    {
        // >0
        if(value > 0)
        {
            return true;
        }
        else
        {
            Console.WriteLine("ERROR: Age can't be equal to or lower than 0!");
            return false;
        };
    }
};
