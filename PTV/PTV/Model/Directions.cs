using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTV.Model
{
    public class Directions
    {
        public static Dictionary<int, string> _directionName = new Dictionary<int, string>();

        public static string getDirectionNameByID(int direction_id)
        {
            return _directionName[direction_id];
        }

        public Directions()
        {
            _directionName.Add(1, "Flinders Street (City)");
            _directionName.Add(2, "Craigieburn");
            _directionName.Add(3, "Belgrave");
            _directionName.Add(4, "Cranbourne");
            _directionName.Add(5, "Frankston");
            _directionName.Add(6, "Glen Waverley");
            _directionName.Add(7, "Hurstbridge");
            _directionName.Add(8, "Lilydale");
            _directionName.Add(9, "Mernda");
            _directionName.Add(10, "Pakenham");
            _directionName.Add(11, "Sandringham");
            _directionName.Add(12, "Stony Point");
            _directionName.Add(13, "Sunbury");
            _directionName.Add(14, "Upfield");
            _directionName.Add(15, "Werribee");
            _directionName.Add(16, "Williamstown");
        }
    }
}
