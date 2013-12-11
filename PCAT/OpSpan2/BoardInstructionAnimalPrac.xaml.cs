﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FiveElementsIntTest.OpSpan2
{
    /// <summary>
    /// BoardInstructionAnimalPrac.xaml 的互動邏輯
    /// </summary>
    public partial class BoardInstructionAnimalPrac : UserControl
    {
        public BasePage mBasePage;
        public BoardInstructionAnimalPrac(BasePage bp)
        {
            InitializeComponent();
            mBasePage = bp;
        }

        private void label3_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mBasePage.ShowBoardAnimal(null);//show the first of the animal paractise
        }
    }
}
