namespace LaunchElectionDay
{
    public class Race
    {
        public string Office {  get; set; }
        public List<Candidate> Candidates { get; set; }
        public Race(string office)
        {
            Office = office;
            Candidates = new List<Candidate>();
        }

        public void RegisterCandidate(Candidate candidate)
        {
            Candidates.Add(candidate);
        }
        
        public bool IsOpen = true;
        {
            if (Race IsOpen = false);
            
        }
    }
}
