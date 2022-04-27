public class Profile
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public int? Id { get; set; }
    public Enum? Person { get; set; }
    public int Password { get; set; }
    public int Age { get; set; }




    public void getprofile(string name,string address,int id,Enum person,int password,Profile? profile , int age)
    {
        Name = name;
        Address = address;
        Id = id;
        Person = person;
        Password = password;
        Age = age;


    }
    

        
    
}



