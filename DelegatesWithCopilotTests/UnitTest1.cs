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
        Assert.AreEqual("Number: 100000\r\n", stringWriter.ToString());
    }

    [Test]
    public void TestPrintMoney()
    {
        Program.PrintMoney(10000);
        Assert.AreEqual("Money: £10,000.00\r\n", stringWriter.ToString());
    }

}    