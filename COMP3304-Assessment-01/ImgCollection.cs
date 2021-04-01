using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ImageProcessor;
using System.Drawing;
using System.IO;

namespace COMP3304_Assessment_01
{
    //This class is responsible for adding the images to the collection
    public class ImgCollection : IImgCollection
    {
        //DECLARE a dictionary to hold the images, call it _imgCollection
        private IDictionary<String, Image> _imgCollection;

        //DECLARE a bool to validate images, call it _imgValid
        private bool _imgValid;

        public ImgCollection() 
        {
            //INSTANTIATE _imgCollection as a dictionairy
            _imgCollection = new Dictionary<String, Image>();

            //INSTANTIATE _imgValid as false
            _imgValid = false;
        }

        #region IMPLEMENTATION of IImgCollection
 
        /// <summary>
        /// Add's an image to the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="img"></param>
        public void AddImg(String key, Image img)
        {
            //ADD key and img to the dictionairy _imgCollection
            _imgCollection.Add(key, img);
        }


        /// <summary>
        /// Checks if the image key(filepath) already exists in the dictionairy, which ensures that no duplicates are added
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Returns true or false </returns>
        public bool ValidateImg(String key)
        {
            //IF the key does not exist in the dictionairy set _imgValid to true
            if (!_imgCollection.ContainsKey(key))
            {
                _imgValid = true;
            }
            //IF the key already exists withing the dictionairy set _imgValid to false
            else 
            {
                _imgValid = false;            
            }

            return _imgValid;
        }
        #endregion
    }
}
