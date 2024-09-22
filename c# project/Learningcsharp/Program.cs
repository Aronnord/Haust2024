using Learningcsharp;

class Program
{
    static void Main(string[] args)
    {
      
        User u1 = new User("Aron", "Örn");
        
        u1.FirstName = "Aron";
        
        u1.Score = -200;
        
       Console.WriteLine(u1.Score);
       Console.WriteLine(u1.FirstName);
     
    }
    
}