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
            var login = new LinkLabel()
            {
                
                Text = "Кто вы? ",
                Dock = DockStyle.Fill
            };

          

            var buttonStudent = new Button
            {
               
                Text = "Cтудент",
                Dock = DockStyle.Fill
            };

            

            var buttonTeacher = new Button
            {
                
                Text = "Преподаватель",
                Dock = DockStyle.Fill
            };

            
            var buttonAdministrator = new Button
            {
                
                Text = "Администратор",
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
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(login, 0, 1);
            table.Controls.Add(buttonStudent, 0, 2);
            table.Controls.Add(buttonTeacher, 0, 3);
            table.Controls.Add(buttonAdministrator, 0, 4);
            table.Controls.Add(new Panel(), 0, 5);

            table.Dock = DockStyle.Fill;
            Controls.Add(table);

            

        }


    }
}
