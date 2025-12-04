namespace Rappel_CourseVoiture.Models
{
    public class Race
    {
        private string _name;
        private int _nbLap;
        private Track _track;
        private List<Participant> _participants;


        public Race(string name, int nbLap, Track track) {
            _name = name;
            _nbLap = nbLap;
            _track = track;
            _participants = new List<Participant>();
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public int NbLap
        {
            get
            {
                return _nbLap;
            }

            set
            {
                _nbLap = value;
            }
        }

        internal Track Track
        {
            get
            {
                return _track;
            }

            set
            {
                _track = value;
            }
        }

        internal List<Participant> Participants
        {
            get
            {
                return _participants;
            }

            set
            {
                _participants = value;
            }
        }
 
    }
}
