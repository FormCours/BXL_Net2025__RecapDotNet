namespace Rappel_CourseVoiture.Models
{
    public class Race
    {
        private string _name;
        private int _nbLap;
        private int _currentLap;
        private Track _track;
        private List<Participant> _participants;


        public Race(string name, int nbLap, Track track)
        {
            _name = name;
            _nbLap = nbLap;
            _track = track;
            _participants = new List<Participant>();
            CurrentLap = 0;
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

        public int CurrentLap
        {
            get
            {

                return _currentLap;
            }

           private set
            {
                _currentLap = value;
            }
        }

        public List<ParticipantStats> DoALap()
        {
            if (_participants.Count == 0)
            {
                throw new Exception("Il faut au moins un participant");
            }

            if (CurrentLap > _nbLap)
            {
                throw new Exception("Nombre de tours maximum atteint");
            }
            
            List<ParticipantStats> racerstat = new List<ParticipantStats>();

            foreach (Participant participant in _participants)
            {
                double timeLap = participant.TakeLap(_track);
                racerstat.Add(new ParticipantStats(participant, timeLap));
            }
            _currentLap++;

            return racerstat;

        }

        public Participant GetWinner()
        {
            if (_participants.Count == 0)
            {
                throw new Exception("Il faut au moins un participant");
            }

            if(_currentLap<_nbLap) {
                throw new Exception("La course n'est pas terminée");
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
