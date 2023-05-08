namespace ChallengeApp2
{
    public class Employee
    {
        private List<int> score = new List<int>();
        public Employee(string firstName, string secondName, string age)
        {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Age = age;
        }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Age { get; private set; }
        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int score)
        {
            this.score.Add(score);
                    }
    }
}