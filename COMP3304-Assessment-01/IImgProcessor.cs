using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;

namespace COMP3304_Assessment_01
{
    public interface IImgProcessor
    {
        /// <summary>
        /// Resizes the current image
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="newImgSize"></param>
        /// <returns>Returns a resized Image from ImageProcessor library</returns>
        Image ResizeImg(string filepath, Size newImgSize);

        /// <summary>
        /// Loads the current image
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns> Returns Image from ImageProcessor library</returns>
        Image LoadImg(string filepath);

    }
}
