namespace ListOfVehicles
{
    class Vehicle
    {
        private string brand = string.Empty;

        public string Model { get; set; }

        public string Brand 
        {
            get
            {
                return brand.ToUpper();
            }

            set
            {
                brand = value;
            }
        }

        public override string ToString()
        {
            return $"{this.Brand} {this.Model}";
        }
    }
}
