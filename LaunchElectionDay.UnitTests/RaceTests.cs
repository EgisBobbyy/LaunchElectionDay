namespace LaunchElectionDay.UnitTests
{
    public class RaceTests
    {
        [Fact]
        public void Race_Constructor_WhenInstantiatedSetsProperties()
        {
            var race = new Race("City Council District 10");
            Assert.Equal("City Council District 10", race.Office);
        }
    }
}
