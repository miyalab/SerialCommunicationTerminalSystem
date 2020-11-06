/*
 * Serial Communication Terminal System(SCTS)
 * 
 * Copyright (c) 2020 K.Miyauchi
 * This software is released under the MIT LICENSE
 * http://opensource.org/licenses/mit-license.php
 * 
 * File    : CopyrightForm.cs
 * Author  : K.Miyauchi
 * 
 * version : 1.00
 */

//--------------------------------------
// パッケージ
//--------------------------------------
using System;
using System.Windows.Forms;

//-----------------------------------------------------------------------------------
// Serial Communication Terminal System
//-----------------------------------------------------------------------------------
namespace SerialCommunicationTerminalSystem
{
    //-------------------------------------------------------------------------------
    // Copyright Form
    //-------------------------------------------------------------------------------
    public partial class CopyrigthForm : Form
    {
        public CopyrigthForm()
        {
            InitializeComponent();
        }

        //---------------------------------------------------------------------------
        // 「OK」ボタンクリック時処理
        //---------------------------------------------------------------------------
        private void buttonApply_Click(object sender, EventArgs e)
        {
            // フォームを閉じる
            this.Close();
        }
    }
}

//-----------------------------------------------------------------------------------
// end of file
//-----------------------------------------------------------------------------------
