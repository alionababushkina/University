using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Autorization : Form
    {
        public Autorization()
        {
            var login = new Button()
            {
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 30),
                Text = "Кто вы? "
            };

            var boxStudent = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonStudent = new Button
            {
                Location = new Point(0,boxStudent.Bottom),
                Size = new Size(100, 40),
                Text = "Cтудент"
            };

            var boxTeacher = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonTeacher = new Button
            {
                Location = new Point(110, boxTeacher.Bottom),
                Size = new Size(100, 40),
                Text = "Преподаватель"
            };

            var boxAdministrator = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonAdministrator = new Button
            {
                Location = new Point(220, boxAdministrator.Bottom),
                Size = new Size(100, 40),
                Text = "Администратор"
            };

            //SizeChanged += (sender, args) =>
            //{
            //    Size = new Size(ClientSize.Width, 30);
            //    Size = login.Size;

            //}

            Controls.Add(login);
            Controls.Add(boxStudent);
            Controls.Add(buttonStudent);
            Controls.Add(boxTeacher);
            Controls.Add(buttonTeacher);
            Controls.Add(boxAdministrator);
            Controls.Add(buttonAdministrator);


        }


    }
}
