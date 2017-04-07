using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Add : Form
    {
        public Add()
        {
            var login = new LinkLabel()
            {
                
                Text = "Группа ПИ-201 ",
                Dock = DockStyle.Fill
            };

            var boxSubject = new ComboBox()
            {
              
                Text = "Дициплина",
                Dock = DockStyle.Fill
            };

            var boxViewClasses = new ComboBox()
            {
                
                Text = "Вид занятия",
                Dock = DockStyle.Fill
            };

            var boxTeacher = new ComboBox()
            {
                
                Text = "Преподаватель",
                Dock = DockStyle.Fill
            };

            var boxClassroom = new ComboBox()
            {
               
                Text = "Аудитория",
                Dock = DockStyle.Fill
            };

            var boxTime = new ComboBox()
            {
                Text = "Время",
                Dock = DockStyle.Fill
            };

            var boxDate = new ComboBox()
            {
                Location = new Point(0, 0),
                Size = login.Size,
                Text = "Дата"
            };

            
            var buttonAdd = new Button
            {
               
                Text = "Добавить",
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
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(login, 0, 1);
            table.Controls.Add(boxSubject, 0, 2);
            table.Controls.Add(boxViewClasses, 0, 3);
            table.Controls.Add(boxTeacher, 0, 4);
            table.Controls.Add(boxClassroom, 0, 5);
            table.Controls.Add(boxTime, 0, 6);
            table.Controls.Add(buttonAgo, 0, 7);
            table.Controls.Add(buttonAdd, 0, 8);
            table.Controls.Add(new Panel(), 0, 9);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);
            Controls.Add(boxDate);


        }
    }
}
