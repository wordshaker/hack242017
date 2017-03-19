namespace TheSeeker.ViewModel
{
    public class ChallengeViewModel
    {
        public string Number { get; set; }

        public ChallengeViewModel(string number)
        {
            this.Number = number;
        }
    }
}