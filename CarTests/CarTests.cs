namespace CarTests;
using Car;

[TestClass]
public class CarTests
{
    //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
    [TestMethod]
    public void EmptyTest() {
        Assert.AreEqual(10, 10, .001);
    }
    //TODO: constructor sets gasTankLevel properly
    Car testCar;
    [TestInitialize]
    public void CreateCarObject()
    {
        testCar = new("Mazda", "3", 15, 30.00);
    }
    [TestMethod]
    public void TestInitialGasTankLevel() 
    {
        Assert.AreEqual(15, testCar.GasTankLevel, .001);
    }
    //TODO: gasTankLevel is accurate after driving within tank range
    [TestMethod]
    public void TestGasTankLevelAfterDriving()
    {
        testCar.Drive(60);
        Assert.AreEqual(13, testCar.GasTankLevel, .001);
    }
    //TODO: gasTankLevel is accurate after attempting to drive past tank range
    [TestMethod]
    public void TestGasTankAfterExceedingTankRange()
    {
        testCar.Drive(500);
        Assert.AreEqual(0, testCar.GasTankLevel, .001);
    }
    //TODO: can't have more gas than tank size, expect an exception
    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestGasOverfillException()
    {
        testCar.AddGas(5);
        Assert.Fail("Shouldn't get here, car cannot have more gas in tank than the size of the tank");
    }
}