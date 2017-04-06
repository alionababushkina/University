using System;
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
            var login = new Button()
            {
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 30),
                Text = "Cтудент "
            };

            var boxStudent = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonStudent = new Button
            {
                Location = new Point(0, boxStudent.Bottom),
                Size = new Size(100, 40),
                Text = "Факультет"
            };

            var boxStudent_1 = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };

            var buttonTeacher = new Button
            {
                Location = new Point(110, boxStudent_1.Bottom),
                Size = new Size(100, 40),
                Text = "Направление"
            };

            var boxStudent_2 = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonAdministrator = new Button
            {
                Location = new Point(220, boxStudent_2.Bottom),
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

            //SizeChanged += (sender, args) =>
            //{
            //    Size = new Size(ClientSize.Width, 30);
            //    Size = login.Size;

            //}

            Controls.Add(login);
            Controls.Add(boxStudent);
            Controls.Add(buttonStudent);
            Controls.Add(boxStudent_1);
            Controls.Add(buttonTeacher);
            Controls.Add(boxStudent_2);
            Controls.Add(buttonAdministrator);
            Controls.Add(boxAgo);
            Controls.Add(buttonAgo);
            Controls.Add(boxView);
            Controls.Add(buttonView);



        }


    }
}

    

