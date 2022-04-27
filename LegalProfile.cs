public class LegalProfile : Profile , IWriteForFile
{
    public DateTime? RCD { get; set; }  //registeration company datetime
    public int? LIOC { get; set; }  //the lastest income of the company
    public Enum? Taxation { get; set; }
    public int Age { get; set; }



    public void getlegalProfile(DateTime rcd,int lioc,Enum taxation, int age)
    {
        RCD = rcd;
        Taxation = taxation;
        LIOC = lioc;
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