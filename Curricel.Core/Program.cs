namespace DefaultNamespace;

public class Program
{
    public void Main()
    {
        Console.WriteLine("Curricel.Core is starting");

        Console.WriteLine("Starting tests");

        # Testing functions
        
        # Starting services
        startOllama();
        extractPDF();
        
        ConnectDB();
        
        
        # testing databse indexing and adding content
        addTopic();
        addConcept();
        addCourse();

        
        
    }
}