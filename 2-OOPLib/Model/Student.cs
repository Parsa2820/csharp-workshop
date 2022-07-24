namespace _2_OOPLib.Model;
public class Student
{
    // Fields
    private int _age;

    // Properties
    // Automatically implement getters and setters
    public string LastName { get; set; }
    // Properties can have custom getters and setters
    public int Age 
    {
        get
        {
            // _age is backing field for this property
            return _age;
        }
        set
        {
            // value is the input value
            if (value < 0)
            {
                // Exception
                // No need to specify the exception type in the method signature
                throw new ArgumentException("Age cannot be negative");
            }
            _age = value;
        }
    }
    // Properties get and set also have access modifiers
    public string Email { get; private set; }
    // Aside from getters and setters, properties can have init methods
    // Can be used to initialize properties when the object is created
    public string StudentID { get; init; }

    // Constructors
    public Student(string email)
    {
        Email = email;
    }
}