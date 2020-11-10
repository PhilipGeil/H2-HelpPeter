using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpPeter
{
    public abstract class Bird
    {
        /// <summary>
        /// Method for setting the location, with a longitude and latitude
        /// </summary>
        /// <param name="longitude"></param>
        /// <param name="latitude"></param>
        public abstract void SetLocation(double longitude, double latitude);
        /// <summary>
        /// Draw the bird
        /// </summary>
        public abstract void Draw();
    }
}
