using _2_OOPLib;
using _2_OOPLib.OtherTypes;
// alias
using MyStudent = _2_OOPLib.Model.Student;

var c = new Class1();
c.Method1();

var s = new MyStudent("john@gmail.com")
{
    LastName = "Doe",
    Age = 20,
    StudentID = "12345",
};
