using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MonterrosaDC2AllForOneAPI.Models;

namespace MonterrosaDC2AllForOneAPI.Services
{
    public class MadLibServices
    {
        public string MadLib(MadLibInput madLibInput)
        {
            return $"{madLibInput.VictimName} was in the middle of {madLibInput.TaskName} when suddenly their bitter rival, {madLibInput.RivalName}, appeared with {madLibInput.AnimalCount} {madLibInput.AnimalDescription} attack {madLibInput.Animal}. Luckily you arrived just in time with your trusty {madLibInput.Item}. You unleashed your special move— {madLibInput.SpecialMoveName}, which obliterated all enemies within {madLibInput.RangeNumber} {madLibInput.UnitOfDistance}. With {madLibInput.RivalName} defeated, the day has been saved! Now, {madLibInput.VictimName} can get back to {madLibInput.TaskName} in peace.";
        }
    }
}