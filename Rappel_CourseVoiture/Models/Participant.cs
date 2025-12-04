namespace Rappel_CourseVoiture.Models
{
    public class Participant
    {

        private string _identifiant;
        private Car _car;
        private List<double> _lapTimes;

        public Participant(string identifiant, Car car)
        {
            _identifiant = identifiant;
            _car = car;
            _lapTimes = [];
        }

        public string Identifiant
        {
            get
            {
                return _identifiant;
            }

            set
            {
                _identifiant = value;
            }
        }

        public Car Car
        {
            get
            {
                return _car;
            }

            set
            {
                _car = value;
            }
        }

        public List<double> LapTimes
        {
            get
            {
                return _lapTimes;
            }

            set
            {
                _lapTimes = value;
            }
        }
  
    }
}
