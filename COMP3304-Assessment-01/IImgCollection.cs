using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COMP3304_Assessment_01
{
    public interface IImgCollection
    {
        /// <summary>
        /// Add's an image to the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="img"></param>
        void AddImg(String key, Image img);


        /// <summary>
        /// Checks if the image key(filepath) already exists in the dictionairy, which ensures that no duplicates are added
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Returns true or false </returns>
        bool ValidateImg(String key);
    }
}
