using System.Collections.Generic;

namespace WOD_2ed
{
    public class Possessions
    {
        public List<Equipment> GearCarried { get; set; }
        public List<Equipment> EquipmentOwned { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<string> Miscellaneneous { get; set; }
        public List<Residence> Residences { get; set; }
    }
}
