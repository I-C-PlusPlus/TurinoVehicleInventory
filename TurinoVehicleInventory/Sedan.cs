using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurinoVehicleInventory
{
    public class Sedan:Vehicle
    {
        private int _wheels = 4;
        public override int Wheels
        {
            get
            { return _wheels; }
        }

        public override int MaxPassengers
        {
            get
            {
                return 5;
            }
        }

        public override string GetDescription()
        {
            return $"Sedan License Plate :{LicensePlate} VIN: {VIN} Wheels:{_wheels} " +
                $"Passengers: { MaxPassengers}.";
        }
        public override string ToString()
        {
            return $"Sedan License Plate :{LicensePlate} VIN: {VIN}";
        }

    }
}
