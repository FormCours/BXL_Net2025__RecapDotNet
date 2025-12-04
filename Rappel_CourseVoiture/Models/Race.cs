namespace Rappel_CourseVoiture.Models
{
    public class Race
    {
        private string _name;
        private int _nbLap;
        private Track _track;
        private List<Participant> _participants;


        public Race(string name, int nbLap, Track track)
        {
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

        public Track Track
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

        public List<Participant> Participants
        {
            get
            {
                return _participants;
            }


        }

        public void DoALap()
        {
            if (_participants.Count == 0)
            {
                throw new Exception("Il faut au moins participant");
            }

            foreach (Participant participant in _participants)
            {
                participant.TakeLap(_track);
            }

        }

        public Participant GetWinner()
        {
            if (_participants.Count == 0)
            {
                throw new Exception("Il faut au moins participant");
            }

            Participant winner = _participants[0];

            foreach (Participant participant in _participants)
            {
                if (winner.GetTotalTime() > participant.GetTotalTime())
                {
                    winner = participant;
                }
            }

            return winner;
        }


        public void AddParticipant(Car car, string identifiant)
        {
            if (_participants.Exists((p) => p.Identifiant == identifiant))
            {

                throw new Exception("id existe deja");
            }

            _participants.Add(new Participant(identifiant, car));
        }

    }
}
