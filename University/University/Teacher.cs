using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Teacher : Form
    {
        public Teacher()
        {
            var login = new ComboBox()
            {
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 30),
                Text = "ФИО"
            };

            var boxPrint = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonPrint = new Button
            {
                Location = new Point(0, boxPrint.Bottom),
                Size = new Size(100, 40),
                Text = "Печать"
            };

            var boxView = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonView = new Button
            {
                Location = new Point(110, boxView.Bottom),
                Size = new Size(100, 40),
                Text = "Просмотр"
            };

            var boxAgo = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonAgo = new Button
            {
                Location = new Point(220, boxAgo.Bottom),
                Size = new Size(100, 40),
                Text = "Назад"
            };

            

            //SizeChanged += (sender, args) =>
            //{
            //    Size = new Size(ClientSize.Width, 30);
            //    Size = login.Size;

            //}

            Controls.Add(login);
            Controls.Add(boxPrint);
            Controls.Add(buttonPrint);
            Controls.Add(boxView);
            Controls.Add(buttonView);
            Controls.Add(boxAgo);
            Controls.Add(buttonAgo);
            



        }


    }
}
