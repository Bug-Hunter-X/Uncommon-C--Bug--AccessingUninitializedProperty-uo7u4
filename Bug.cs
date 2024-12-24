public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); //Bug: accessing property before initialization
        MyProperty = 10;
    }
}