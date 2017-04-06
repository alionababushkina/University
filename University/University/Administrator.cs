using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Administrator : Form
    {
        public Administrator()
        {
            var login = new LinkLabel()
            {
                Location = new Point(0, 0),
                Size = new Size(ClientSize.Width, 30),
                Text = "Администратор "
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

            var boxChange = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonChange = new Button
            {
                Location = new Point(320, boxChange.Bottom),
                Size = new Size(100, 40),
                Text = "Изменить"
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
            var boxAdd = new TextBox()
            {
                Location = new Point(0, login.Bottom),
                Size = login.Size
            };
            var buttonAdd = new Button
            {
                Location = new Point(520, boxAdd.Bottom),
                Size = new Size(100, 40),
                Text = "Добавить"
            };

            Controls.Add(login);
            Controls.Add(boxFaculty);
            Controls.Add(buttonFaculty);
            Controls.Add(boxDirection);
            Controls.Add(buttonDirection);
            Controls.Add(boxGroup);
            Controls.Add(buttonGroup);
            Controls.Add(boxChange);
            Controls.Add(buttonChange);
            Controls.Add(boxView);
            Controls.Add(buttonView);
            Controls.Add(boxAdd);
            Controls.Add(buttonAdd);

        }
    }
}
        
    
