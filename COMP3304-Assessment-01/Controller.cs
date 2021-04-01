using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace COMP3304_Assessment_01
{
    //This class is responsible for running the program
    public class Controller
    {
        public Controller()
        {
            //DECLARE and instantiale an IFactory<IImgColelction> as a new Factory<IImgCollection>, call it _imgColelctionFactory
            IFactory<IImgCollection> _imgColelctionFactory = new Factory<IImgCollection>();

            //DECLARE and instantiale an IImgColelction as a new IImgCollection by using the method Create<> in Factory, call it _imgCollection
            IImgCollection _imgCollection = _imgColelctionFactory.Create<ImgCollection>();

            //DECLARE and instantiale an IFactory<IImgProcessor> as a new Factory<IImgProcessor>(), call it _imgProcessorFactory
            IFactory<IImgProcessor> _imgProcessorFactory = new Factory<IImgProcessor>();

            //DECLARE and instantiale an IImgProcessor as a new IImgProcessor by using the method Create<> in Factory, call it _imgProcessor
            IImgProcessor _imgProcessor = _imgProcessorFactory.Create<ImgProcessor>();

            //DECLARE and instantiale an IModel as a new Model, call it _model
            IModel _model = new Model(_imgCollection, _imgProcessor);

            //RUN the Application initializing new ModelDisplay
            Application.Run(new ModelDisplay(_model));
        }
    }
}
