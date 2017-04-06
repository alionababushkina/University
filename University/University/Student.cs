﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Student : Form
    {
        public Student()
        {
            var login = new LinkLabel()
            {
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 30),
                Text = "Cтудент "
            };

            var boxFaculty = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonFaculty = new Button
            {
                Location = new Point(0, boxFaculty.Bottom),
                Size = new Size(100, 40),
                Text = "Факультет"
            };

            var boxDirection = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonDirection = new Button
            {
                Location = new Point(110, boxDirection.Bottom),
                Size = new Size(100, 40),
                Text = "Направление"
            };

            var boxGroup = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonGroup = new Button
            {
                Location = new Point(220, boxGroup.Bottom),
                Size = new Size(100, 40),
                Text = "Группа"
            };

            var boxAgo = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonAgo = new Button
            {
                Location = new Point(320, boxAgo.Bottom),
                Size = new Size(100, 40),
                Text = "Назад"
            };

            var boxView = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonView = new Button
            {
                Location = new Point(420, boxView.Bottom),
                Size = new Size(100, 40),
                Text = "Просмотр"
            };
            

            Controls.Add(login);
            Controls.Add(boxFaculty);
            Controls.Add(buttonFaculty);
            Controls.Add(boxDirection);
            Controls.Add(buttonDirection);
            Controls.Add(boxGroup);
            Controls.Add(buttonGroup);
            Controls.Add(boxAgo);
            Controls.Add(buttonAgo);
            Controls.Add(boxView);
            Controls.Add(buttonView);
         


        }


    }
}

    

