namespace _2_OOPLib.OtherTypes
{
    public interface ISomeInterface
    {
        void Method1();
    }

    public abstract class SomeAbstractClass
    {
        public abstract void Method1();
    }

    // Inheritance
    // Reference type
    public class SomeTypes : SomeAbstractClass
    {
        public override void Method1()
        {
            Console.WriteLine("Hello, World!");
        }
    }

    // Value type
    public struct SomeStruct
    {
        public int Value;
    }

    public enum SomeEnum
    {
        Value1,
        Value2,
        Value3
    }

    // Records are immutable reference types
    // Some methods are automatically implemented
    public record SomeRecord(string Value);
}