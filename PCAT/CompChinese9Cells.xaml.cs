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

namespace FiveElementsIntTest
{
    /// <summary>
    /// CompChinese9Cells.xaml 的互動邏輯
    /// </summary>
    public partial class CompChinese9Cells : UserControl
    {
        public int mSelectableCount = 2;
        public List<Label> mCharaLabels;
        public List<int> mSelectedOrder;
        public Page mPage;

        private string mQuest = "";
        private string mCharSelected = "";

        public delegate void ConfirmFunc(object obj);
        public ConfirmFunc mfConfirm;

        public CompChinese9Cells(Page page)
        {
            InitializeComponent();

            mPage = page;

            mCharaLabels = new List<Label>();
            mCharaLabels.Add(label1);
            mCharaLabels.Add(label2);
            mCharaLabels.Add(label3);
            mCharaLabels.Add(label4);
            mCharaLabels.Add(label5);
            mCharaLabels.Add(label6);
            mCharaLabels.Add(label7);
            mCharaLabels.Add(label8);
            mCharaLabels.Add(label9);

            for (int i = 0; i < mCharaLabels.Count; i++)
            {
                mCharaLabels[i].MouseUp += new MouseButtonEventHandler(CompChinese9Cells_MouseUp);
            }

            mSelectedOrder = new List<int>();
        }

        public void SetCharas(String[] charas)
        {
            for (int i = 0; i < mCharaLabels.Count; i++)
            {
                mCharaLabels[i].Content = charas[i];
            }
        }

        public string GetCharas()
        {
            string retval = "";
            for (int i = 0; i < mSelectedOrder.Count; i++)
            {
                retval += mCharaLabels[mSelectedOrder[i]].Content;
            }
            return retval;
        }

        private void refreshText()
        {
            mCharSelected = "";

            for (int j = 0; j < mSelectedOrder.Count; j++)
            {
                mCharSelected += mCharaLabels[mSelectedOrder[j]].Content;
            }

            amLabelQuest.Content = mQuest + " - " + mCharSelected;
        }

        public void SetQuest(String quest)
        {
            mQuest = quest;
            refreshText();
        }

        public void SetAnswerText(String text)
        {
            mCharSelected = text;
        }

        void CompChinese9Cells_MouseUp(object sender, MouseButtonEventArgs e)
        {
            if (mSelectedOrder.Count < mSelectableCount)
            {
                for(int i = 0; i < mCharaLabels.Count; i++)
                {
                    if (mCharaLabels[i].Equals(sender))
                    {
                        mSelectedOrder.Add(i);
                        mCharaLabels[i].BorderBrush = new SolidColorBrush(Color.FromRgb(255, 157, 11));
                        break;
                    }
                }

                refreshText();
            }
        }

        public void ClearSelection()
        {
            mSelectedOrder.Clear();
            for (int i = 0; i < mCharaLabels.Count; i++)
            {
                mCharaLabels[i].BorderBrush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            }
        }

        private void amLabelBtnClear_MouseUp(object sender, MouseButtonEventArgs e)
        {
            ClearSelection();
            refreshText();
        }

        private void amLabelBtnConfirm_MouseUp(object sender, MouseButtonEventArgs e)
        {
            mfConfirm(this);
        }
    }
}
