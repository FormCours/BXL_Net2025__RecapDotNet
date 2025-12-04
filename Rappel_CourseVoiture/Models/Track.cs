namespace Rappel_CourseVoiture.Models
{
    public class Track
    {
        private string _name;
        private double _length;

        public Track(string name, double length)
        {
            _name = name;
            _length = length;
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

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }
    }
}
