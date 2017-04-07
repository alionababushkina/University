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
            var login = new LinkLabel()
            {
               
                Text = "Преподаватель ",
                Dock = DockStyle.Fill
            };

            var boxTeacher = new ComboBox()
            {
                
                Text = "ФИО",
                Dock = DockStyle.Fill
            };

           

            var buttonPrint = new Button
            {
               
                Text = "Печать",
                Dock = DockStyle.Fill
            };

           
            var buttonView = new Button
            {
               
                Text = "Просмотр",
                Dock = DockStyle.Fill
            };

            
            var buttonAgo = new Button
            {
                Text = "Назад",
                Dock = DockStyle.Fill
            };

            var table = new TableLayoutPanel();
            table.RowStyles.Clear();
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(login, 0, 1);
            table.Controls.Add(boxTeacher, 0, 2);
            table.Controls.Add(buttonPrint, 0, 3);
            table.Controls.Add(buttonView, 0, 4);
            table.Controls.Add(buttonAgo, 0, 5);
            table.Controls.Add(new Panel(), 0, 6);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);






        }


    }
}
