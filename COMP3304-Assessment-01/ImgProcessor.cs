using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;

namespace COMP3304_Assessment_01
{
    //This class is responsible for processignt he images by using the ImageProcessor librery
    public class ImgProcessor : IImgProcessor
    {
        //DECLARE ImageFactory and call it _imgFactory
        private ImageFactory _imgFactory; 

        public ImgProcessor()
        {
            //INSTANTIATE _imgFactory as new ImageFactory
            _imgFactory = new ImageFactory();
        }

        #region IMPLEMENTATION of IImgProcessor

        /// <summary>
        /// Resizes the current image
        /// </summary>
        /// <param name="filepath"></param>
        /// <param name="newImgSize"></param>
        /// <returns>Returns a resized Image from ImageProcessor library</returns>
        public Image ResizeImg(string filepath, Size newImgSize)
        {
            //LOAD the image from the filepath
            _imgFactory.Load(filepath);

            //RESIZE the image to a newImgSize using the Constrain method, which allows to keep the original ratio
            _imgFactory.Constrain(newImgSize);

            return _imgFactory.Image;
        }

        /// <summary>
        /// Loads the current image
        /// </summary>
        /// <param name="filepath"></param>
        /// <returns> Returns Image from ImageProcessor library</returns>
        public Image LoadImg(string filepath)
        {
            //LOAD the image from the filepath
            _imgFactory.Load(filepath);
            return _imgFactory.Image;
        }
        #endregion
    }
}
