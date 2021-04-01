using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP3304_Assessment_01
{
    //This class is responsible for the functionality of the user interface
    public partial class ModelDisplay : Form
    {
        //DECLARE a dictionairy to hold Image references, call it _imgRef
        private IDictionary<int, String> _imgRef;

        //DECLARE an Intiger to hold key to referance to the Image that can be loaded next call it _imgRefId
        //DECLARE an Intiger to hold key to referance to the Image that is currently displayed, call it _displayImgId
        //DECLARE an Intiger to hold the Width of the Image Box, call it _frameWidth,
        //DECLARE an Intiger to hold the Height of the Image Box, call it  _frameHeight
        private int _imgRefId, _displayImgId, _frameWidth, _frameHeight;

        //DECLARE an Image to hold an Image to display as ImgBox.Image, call it _img
        private Image _img;

        //DECLARE an IModel to hold a referance to the Model, call it _model
        private IModel _model;

        //DECLARE an IList to hold a list of files from the file dialog, call it _ofdList
        private IList<String> _ofdList;

        //DECLARE an IList to hold a list of files that has been added to the collection from the file dialog, call it _newOfdList
        private IList<String> _newOfdList;

        //DECLARE  a bool to check if the image loader is used for the first time, call it _fistImg;
        private bool _firstImg;

        public ModelDisplay(IModel model)
        {
            //INITIALIZE ModelDisplay
            InitializeComponent();

            //INSTANTIATE _model as model
            _model = model;

            //INSTANTIATE _imgRef as a new Dictionairy
            _imgRef = new Dictionary<int, String>();

            //INSTANTIATE _imgRefID as 0
            _imgRefId = 0;

            //INSTANTIATE _frameWidth as ImgBox.Width
            _frameWidth = ImgBox.Width;

            //INSTANTIATE _frameHeight as ImgBox.Height
            _frameHeight = ImgBox.Height;

            //INSTANTIATE _ofdList as a new List of Strings
            _ofdList = new List<String>();

            //INSTANTIATE _newOfdList as a new List of Strings
            _newOfdList = new List<String>();

            //INSTANTIATE _firstImg as true
            _firstImg = true;
        }

        /// <summary>
        /// Displays an Image from the collection in the Image Box
        /// </summary>
        private void DisplayImg()
        {
            //SET _img as an return Image using the method getImage form model
            _img = _model.getImage(_imgRef[_displayImgId], _frameWidth, _frameHeight);

            //SET the ImageBox.Image as _img
            ImgBox.Image = _img;
        }
        
        /// <summary>
        /// Displays next Image in the Image Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NextImg(object sender, EventArgs e)
        {
            //INCREMENT _displayImgId
            _displayImgId++;

            //CKECK if the _displayImgId is bigger then the id of the last image in the collection
            if (_displayImgId >= _imgRef.Count())
            {
                //SET _displayImgId to the first id in the dictionary - 0
                _displayImgId = 0;
            }
            //DISPLAY the Image
            DisplayImg();
        }


        /// <summary>
        /// Displays previous Image in the Image Box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PreviousImg(object sender, EventArgs e)
        {
            //DECREMENT _displayImgID
            _displayImgId--;

            //CHECK if _displayImgId is less than the first id in the dictionairy - 0
            if (_displayImgId < 0)
            {
                //SET _displayImgId to the last id in the dictionairy 
                _displayImgId = (_imgRef.Count() - 1);
            }
            //DISPLAY the Image
            DisplayImg();
        }
        
        /// <summary>
        /// Loads the files into memory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadImg(object sender, EventArgs e)
        {
            #region Altered code form MSDN, available at: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=net-5.0
            //INSTANTIATE OpenFileDialog openfileDialog as a new OpenFileDialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //CHECK if the file dialog was opened for the first time
                if (_firstImg)
                {
                    //SET Initial Directory to "c:\\"
                    openFileDialog.InitialDirectory = "c:\\";

                    //SET _firstImg to false
                    _firstImg = false;
                }

                //SET the Filter to allow only .bmp, .jpg, .gif and .png files
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

                //SET Filte Index to 1
                openFileDialog.FilterIndex = 1;

                //SET Restore Directory to true - open the last opened directory instead of c:\\
                openFileDialog.RestoreDirectory = true;

                //SET Multiselect to true
                openFileDialog.Multiselect = true;

                //OPEN the file dialog box
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //SET _ofdList to a List of paths/filemanes 
                    _ofdList = openFileDialog.FileNames.ToList();

                    //SET _newOfdList to the return List of files that has been loaded to the collection
                    _newOfdList = _model.load(_ofdList);

                    //GET each String in the _newOfdList
                    foreach (String file in _newOfdList) 
                    {
                        //ADD the path/filenames into the _imgRef Dictionairy using _imgRefId as key
                        _imgRef.Add(_imgRefId, file);

                        //Set the last added key as _displayImgId
                        _displayImgId = _imgRefId;

                        //INCREMENT _imgRefID
                        _imgRefId++;
                    }

                    //DISPLAY the Image that has been loaded last
                    DisplayImg();
                }
            }
            #endregion
        }
    }
}
