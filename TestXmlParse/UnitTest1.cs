namespace TestXmlParse;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string xmlSnip = "<data asdf> <p stuff>this is the stuff between</p> </data>";
        string testResult = "this is the stuff between";
        string result = XmlParse.Parser.Parse("p", xmlSnip);
        Assert.IsTrue(testResult == result);
        Assert.Pass();
    }
}