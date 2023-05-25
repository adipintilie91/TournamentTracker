using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    /// <summary>
    /// The Prize class.
    /// </summary>
    public class PrizeModel
    {
        /// <summary>
        /// Place in number format: 1, 2, 3 etc.
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// Place in string format: First place, Second place etc.
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// Fixed amount for the prize.
        /// </summary>
        public decimal PlaceAmount { get; set; }
        /// <summary>
        /// Procent of the prize.
        /// </summary>
        public double PrizePercentage { get; set; }
    }
}