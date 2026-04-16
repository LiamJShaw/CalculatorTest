# Programming Challenge

This challenge is designed to exercise a number of programming skills which are relevant to the technology we use at Renaissance Global. The aim is to demonstrate as many skills you can. If you need to make any assumptions about the implementation it would be best to document them in the code. Please aim to only spend approximately 90 minutes on this.        

## Interface

```csharp
public interface ISimpleCalculator
{
  int Add(int start, int amount);
  int Subtract(int start, int amount);
}
```

## Requirements

### Visual Studio

1. Create an empty solution called CalculatorTest.
2. Create a class library containing the interface above.
3. Create a C# class to realize the interface as a C# class and implement the methods.

### C#

4. Create unit tests to confirm the functionality performs as expected.

### Web

5. Create a simple web service that provides access to the calculator implementation.
6. Create a Web App using Angular or a suitable alternative to provide a user-friendly interface to invoke the Calculator operations.
7. Ensure the Calculator operations are performed in a modal popup which has a header and a footer.
8. Ensure the web app can work on a variety of screen sizes and devices.
9. (Optional) Add functionality on the main web app page to be able to restyle the look and feel of the modal popup.
