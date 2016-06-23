using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonSlaying
{
    public class Die
    {
        Random random;
        public int NumberOfSides {get; set;}

        /// <summary>
        /// Constructs a 6-sided Die.
        /// </summary>
        public Die() // an alt. to what is below. Put " : this(6) " on this line and it will do the same thing.
        {
            random = new Random();
            NumberOfSides = 6;
        }

        /// <summary>
        /// Constructs a Die with the specified number of sides.
        /// </summary>
        /// <param name="numberOfSides">The number of sides on the Die</param>
        public Die(int numberOfSides)
        {
            // TODO
            NumberOfSides = numberOfSides;
            random = new Random();

        }

        /// <summary>
        /// Rolls the die.
        /// </summary>
        /// <returns>A random number between 1 and <see cref="NumberOfSides"/></returns>
        public int Roll()
        {
            // TODO
            return 1;
        }
    }
}
