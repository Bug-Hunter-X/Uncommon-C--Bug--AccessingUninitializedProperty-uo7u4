public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize the property

    public void MyMethod()
    {
        //Now MyProperty is initialized to 0 before being printed to the console
        Console.WriteLine(MyProperty);
        MyProperty = 10;
    }
}