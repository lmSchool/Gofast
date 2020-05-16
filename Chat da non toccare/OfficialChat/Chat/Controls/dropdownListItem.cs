﻿namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class dropdownListItem : UserControl
    {
        public string itemName
        {
            get
            {
                return labelItem.Text;
            }
            set
            {
                labelItem.Text = value;
            }
        }
        public Image itemImage
        {
            get
            {
                return pictureboxItem.Image;
            }
            set
            {
                pictureboxItem.Image = value;
            }
        }
        public dropdownListItem()
        {
            InitializeComponent();
        }

        private void dropdownListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(70,70,70);
            labelItem.ForeColor = Color.FromArgb(217, 179, 16);
        }
        private void dropdownListItem_MouseLeave(object sender, EventArgs e)
        {
            labelItem.ForeColor = SystemColors.ControlLightLight;
            this.BackColor = Color.FromArgb(50, 50, 50);
        }
    }
}