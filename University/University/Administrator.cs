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
               
                Text = "Администратор ",
                Dock = DockStyle.Fill
            };

            

            var buttonFaculty = new Button
            {
                
                Text = "Факультет",
                Dock = DockStyle.Fill
            };

           

            var buttonDirection = new Button
            {
                
                Text = "Направление",
                Dock = DockStyle.Fill
            };

           
            var buttonGroup = new Button
            {
               
                Text = "Группа",
                Dock = DockStyle.Fill
            };

          
            var buttonChange = new Button
            {
                
                Text = "Изменить",
                Dock = DockStyle.Fill
            };

           
            var buttonView = new Button
            {
               
                Text = "Просмотр",
                Dock = DockStyle.Fill
            };
          
            var buttonAdd = new Button
            {
               
                Text = "Добавить",
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
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(login, 0, 1);
            table.Controls.Add(buttonFaculty, 0, 2);
            table.Controls.Add(buttonDirection, 0, 3);
            table.Controls.Add(buttonGroup, 0, 4);
            table.Controls.Add(buttonChange, 0, 5);
            table.Controls.Add(buttonView, 0, 6);
            table.Controls.Add(buttonAdd, 0, 7);
            table.Controls.Add(new Panel(), 0, 8);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);

        }
    }
}
        
    
