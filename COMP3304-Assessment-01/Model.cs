using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace COMP3304_Assessment_01
{
    //This class is responsible for passing through and returning the references from ModelDisplay to ImgCollection and ImgProcessor
    public class Model : IModel
    {
        //DECLARE an IList to hold a list of pathfiles that are returned from the Load method, call it _loadRtn
        IList<String> _loadRtn;

        //DECLARE an Image to hold a scaled Image from the ImgProcessor, call it _scaledImg
        private Image _img, _scaledImg;

        //DECLARE an IImgCollection to hold a reference to an ImgCollection, call it _imgCollection
        private IImgCollection _imgCollection;

        //DECLARE an IImgProcessor to hold a reference to an ImgProcessor, call it _imgProcessor
        private IImgProcessor _imgProcessor;

        //DECLARE a Size to hold a new Size for the Image, call it _newSize
        Size _newSize;

        public Model(IImgCollection imgCollection, IImgProcessor imgProcessor)
        {
            

            //INSTANTIATE _imgProcessor as imgProcessor
            _imgProcessor = imgProcessor;

            //INSTANTIATE _imgCollection as imgCollection
            _imgCollection = imgCollection;

            //INSTANTIATE _newSize as new Size
            _newSize = new Size(0, 0);
        }

        /// <summary>
        /// Load the media items pointed to by 'pathfilenames' into the 'Model'
        /// </summary>
        /// <param name="pathfilenames">a vector of strings; each string containing path/filename for an image file to be loaded</param>
        /// <returns>the unique identifiers of the images that have been loaded</returns>
        public IList<String> load(IList<String> pathfilenames) 
        {
            //INSTANTIATE _loadRtn as a new List
            _loadRtn = new List<String>();

            //LOOP through each String in the pathfilenames
            foreach (String file in pathfilenames)
            {
                //CHECK if ValidateImg(file) id true - the file is not in the dictionairy holding the Images
                if (_imgCollection.ValidateImg(file))
                {
                    //LOAD the Image through ImgProcessor
                    _img = _imgProcessor.LoadImg(file);

                    //ADD the image to the collection usind AddImg method from ImgCollection
                    _imgCollection.AddImg(file, _img);

                    //ADD the path/filename to the list of Images that has been added to the collection
                    _loadRtn.Add(file);
                }
            }
            return _loadRtn;
        }

        /// <summary>
        /// Return a copy of the image specified by 'key', scaled according to the dimentsions of the visual container (ie frame) it will be viewed in.
        /// </summary>
        /// <param name="key">the unique identifier for the image to be returned</param>
        /// <param name="frameWidth">the width (in pixels) of the 'frame' it is to occupy</param>
        /// <param name="frameHeight">the height (in pixles) of the 'frame' it is to occupy</param>
        /// <returns>the Image pointed identified by key</returns>
        public Image getImage(String key, int frameWidth, int frameHeight)
        {
            //INSTANTIATE _newSize.Width as frameWidth
            _newSize.Width = frameWidth;

            //INSTANTIATE _newSize.Height as frameHeight
            _newSize.Height = frameHeight;

            //INSTANTAITE _scaledImg as an resized Image using ResizeImg method from ImgProcessor
            _scaledImg = _imgProcessor.ResizeImg(key, _newSize);

            return _scaledImg;
        }

    }
}
