

 public class IndividualProfile : Profile , IWriteForFile
 {
     public string? LastName { get; set; }
     public int? PhoneNumber { get; set; }
     public string? Gender { get; set; }
    public string? Job { get; set; }
    public DateTime? BD { get; set; }  //birthday of person time
    public int Age { get; set; }



    public void getindividualprofile(string lastname,int phonenumber,string gender,string job,DateTime bd,int age)
    {
        LastName = lastname;
        PhoneNumber = phonenumber;
        Gender = gender;
        Job = job;
        BD = bd;
        Age = age;
    }

    public void SaveIndividual(string? rep)
    {
        throw new NotImplementedException();
    }

    public void SaveLegal(string? rep)
    {
        throw new NotImplementedException();
    }
}

