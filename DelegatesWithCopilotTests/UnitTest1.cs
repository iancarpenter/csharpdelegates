using DelegatesWithCopilot;

namespace DelegatesWithCopilotTests;

public class Tests
{
    private StringWriter stringWriter;

    [SetUp]
    public void SetUp()
    {
        stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
    }

    [TearDown]
    public void TearDown()
    {
        stringWriter.Dispose();
    }

    

    [Test]
    public void TestPrintNumber()
    {
        Program.PrintNumber(100000);
        Assert.That(stringWriter.ToString(), Is.EqualTo("Number: 100000\r\n"));
    }

    [Test]
    public void TestPrintMoney()
    {
        Program.PrintMoney(10000);
        Assert.That(stringWriter.ToString(), Is.EqualTo("Money: £10,000.00\r\n"));
    }

}    