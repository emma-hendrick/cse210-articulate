using System;


namespace Unit02.Game
{
    // TODO: Implement the Die class as follows...
    // 1) Add the class declaration. Use the following class comment.

    class Die
    {
        /// <summary>
        /// A small cube with a different number of spots on each of its six sides.
        /// 
        /// The responsibility of Die is to keep track of its currently rolled value and the points its
        /// worth.
        /// </summary> 

        public int points;
        public int value;

    // 2) Create the class constructor. Use the following method comment.

        public Die() { 
        /// <summary>
        /// Constructs a new instance of Die.
        /// </summary>

            Roll();

        }
    
    // 3) Create the Roll() method. Use the following method comment.
        
        public void Roll() {
        /// <summary>
        /// Generates a new random value and calculates the points for the die. Fives are 
        /// worth 50 points, ones are worth 100 points, everything else is worth 0 points.
        /// </summary>

        Random rnd = new Random();
        value = rnd.Next(1, 7);

        points = (value == 1) ? 100 : (value == 5) ? 50: 0;

        }

    }   
}