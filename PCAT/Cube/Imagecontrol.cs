﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;


namespace FiveElementsIntTest.Cube
{
    class Imagecontrol
    {
        public Imagecontrol()
        {

        }
       
        public Image GetImage(int _width, int _Height)
        {
            Image image = new Image();
            image.Width = _width;
            image.Height = _Height;
        //    image.Stretch = System.Windows.Media.Stretch.Fill;
            return image;
        }



    }

}
