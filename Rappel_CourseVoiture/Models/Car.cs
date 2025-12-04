namespace Rappel_CourseVoiture.Models
{
    public class Car
    {
        private string _model;
        private string _brand;
        private double _vitMin;
        private double _vitMax;

        public Car( string model, string brand,double vitMin, double vitMax )
        {
            _model = model;
            _brand = brand;
            _vitMin = vitMin;
            _vitMax = vitMax;
        }

        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                _model = value;
            }
        }

        public string Brand
        {
            get
            {
                return _brand;
            }

            set
            {
                _brand = value;
            }
        }

        public double VitMin
        {
            get
            {
                return _vitMin;
            }

            set
            {
                _vitMin = value;
            }
        }

        public double VitMax
        {
            get
            {
                return _vitMax;
            }

            set
            {
                _vitMax = value;
            }
        }
    }
}
