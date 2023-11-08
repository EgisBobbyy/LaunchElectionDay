namespace LaunchElectionDay
{
    public class Election
    {
        public string Year { get; set; }
        public List<Race> Races { get; set; }
        public Election(string year)
        {
            Year = year;
            Races = new List<Race>();
        }

        public void AddRace(Race race)
        {
            Races.Add(race);
        }

        public List<Candidate> AllCandidates()
        {
            var allCandidates = new List<Candidate>();

            foreach (var race in Races)
            {
                foreach (var candidate in race.Candidates)
                {
                    allCandidates.Add(candidate);
                }
            }
            return allCandidates;
        }

        public Dictionary<string, int> VoteCount()
        {
            var voteCounts = new Dictionary<string, int>();

            foreach (var candidate in AllCandidates())
            { 
                voteCounts.Add(candidate.Name, candidate.Votes);
            }
            return voteCounts;
        }
    }
}
