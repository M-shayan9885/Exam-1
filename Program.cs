List<Profile?> people = new List<Profile?>();
List<LegalProfile> peopleLegal = new List<LegalProfile>();
LegalProfile? legalprofile = null;
Profile? profile = null;
int ID,password;

Console.WriteLine();

Console.WriteLine("please register or log in");
Console.WriteLine("1-Register");
Console.WriteLine("2-Login");
int action = Convert.ToInt32(Console.ReadLine());

switch (action)
{
    case 1:
        {
            Console.WriteLine("please select an character");
            Console.WriteLine("1-Legal");
            Console.WriteLine("2-Individual");

            Console.WriteLine();
            int action1 = Convert.ToInt32(Console.ReadLine());
            switch(action1)
            {
                case 1:
                    {
                        Register(profile);
                        break;
                    }
                case 2:
                    {
                        Register(legalprofile);
                        break;
                    }
            }
            break;
        }
    case 2:
        {
            Login();
            break;
        }
}


void Register(Profile profile)
{
    if (profile == null)
    {
        profile = new Profile();
        Console.WriteLine("enter a name");
        profile.Name = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("enter an Id");
        profile.Id =Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("enter an address");
        profile.Address = Console.ReadLine();
        Console.WriteLine("please enter your password");
        profile.Password = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("please enter your age");
        profile.Age = Convert.ToInt32(Console.ReadLine());
        
    }
    else
    {
        Login();
    }
}

void Login()
{
    Console.WriteLine();
    Console.WriteLine("please enter an ID");
    ID = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("please enter your password");
    password = Convert.ToInt32(Console.ReadLine());

    if(password == 0)
    {
        Console.WriteLine("invaluad password");
        Console.WriteLine("try again");
        Login();
    }
    else
    {
        Login();
    }

    foreach (Profile profile in people)
    {
        if (ID == null)
        {
            Console.WriteLine("incorect id");
            Console.WriteLine("try again");
        }
        else if (ID == profile.Id)
        {
            Console.WriteLine("you in");
        }
        else if(password == null)
        {
            Console.WriteLine("incorect password");
            Console.WriteLine("try again");
        }
        else
        {
            Console.WriteLine("you in");
        }
    }
}

void check(Profile profile, IndividualProfile individual,LegalProfile legal)
{
    if (profile.Name == null)
    {
        Console.WriteLine("unaccepted");
        Console.WriteLine("please try again");
        Register(profile);
    }
    else if (!string.IsNullOrEmpty(individual.LastName))
    {
        Console.WriteLine("unaccepted");
        Console.WriteLine("try again");
        Register(individual);
    }
    else if (legal.LIOC == null)
    {
        Console.WriteLine("unaccepted");
        Console.WriteLine("try again");
        Register(legal);
    }
    else if (profile.Address == null)
    {
        Console.WriteLine("unaccepted");
        Console.WriteLine("please try again");
        Register(profile);
    }
    else
    {
        if (DateTime.TryParse(profile.Address, out DateTime date))
        {
            Console.WriteLine("please reenter datetime");
        }
        else
        {
            Register(profile);
        }
    }

}


void checkregistration(LegalProfile legal)
{
    void age(int age,DateTime RCD)
    {
        var datetoday = DateTime.Today;
        var Age = datetoday - RCD;
        if (RCD.Date > datetoday.AddYears(-age)) age--;
    }
}




void sen(Profile profile,LegalProfile legal,IndividualProfile individualProfile)
{
   

}



void convert()
{
    var con = Convert.ToDouble(profile.Age);
    var vert = Convert.ToChar(profile.Address);

}