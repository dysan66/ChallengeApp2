namespace ChallengeApp2.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            //arrange
            var employee = new Employee("Adam", "Kowalski", "30");
            employee.AddScore(2);
            employee.AddScore(6);

            //act
            var result = employee.Result;

            //assert
            Assert.AreEqual(8, result);
        }
    }
}