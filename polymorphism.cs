internal interface polymorphism
{
    void age(int age)
    {
        Console.WriteLine("please enter your birthday");
        DateTime BD = Convert.ToDateTime(Console.ReadLine());
        var datetoday = DateTime.Today;
        var Age = datetoday - BD;
        if (BD.Date > datetoday.AddYears(-age)) age--;
    }

}
