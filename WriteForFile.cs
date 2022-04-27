internal interface IWriteForFile
{

    void Action()
    {
        string? rep;
        Console.WriteLine("please select condition");
        Console.WriteLine("1-Individual");
        Console.WriteLine("2-legal");
        int action = Convert.ToInt32(Console.ReadLine());

        switch (action)
        {
            case 1:
                {
                    Console.WriteLine("please enter an repository");
                    rep = Console.ReadLine();
                    SaveIndividual(rep);
                    break;
                }
                case 2:
                {
                    Console.WriteLine("please enter an repository");
                    rep = Console.ReadLine();
                    SaveLegal(rep);
                    break;
                }
        }
    }

    void SaveLegal(string? rep);
    void SaveIndividual(string? rep);

    void SaveIndividual(string? rep,Profile profile)
    {
        
        if (File.Exists(rep))
        {
            Console.WriteLine("File Existis");
        }
        else
        {
            FileStream Individual = new FileStream(rep , FileMode.OpenOrCreate, FileAccess.Read);
            File.AppendAllLines(rep , profile.ToString());
        }

    }




    void SaveLegal(string? rep,Profile profile)
    {
        if (!File.Exists(rep))
        {
            Console.WriteLine("File Existis");
            Action();
        }
        else
        {

            FileStream Legal = new FileStream(rep, FileMode.OpenOrCreate, FileAccess.Read);
            //File.AppendAllLines(rep, profile?.ToString());

        }        

    }


    void checkaction(string? rep)
    {
        if(string.IsNullOrEmpty(rep))
        {
            Console.WriteLine("your selected repository is not exist or empty");
            Console.WriteLine("please try again");
            Action();
        }
    }
}

