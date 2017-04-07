using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace University
{
    class Change : Form
    {
        public Change()
        {
            var login = new LinkLabel()
            {
               
                Text = "Группа ПИ-201 ",
                Dock = DockStyle.Fill
            };

            var boxDate = new MonthCalendar()
            {
                
                Text = "Дата",
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

            
            var buttonAgo = new Button
            {
               
                Text = "Назад",
                Dock = DockStyle.Fill
            };

           
            var buttonDelete = new Button
            {
               
                Text = "Удалить",
                Dock = DockStyle.Fill
            };

            
            var buttonSave = new Button
            {
               
                Text = "Сохранить",
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
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            table.Controls.Add(new Panel(), 0, 0);
            table.Controls.Add(login, 0, 1);
            table.Controls.Add(boxDate, 0, 2);
            table.Controls.Add(boxSubject, 0, 3);
            table.Controls.Add(boxViewClasses, 0, 4);
            table.Controls.Add(boxTeacher, 0, 5);
            table.Controls.Add(boxClassroom, 0, 6);
            table.Controls.Add(boxTime, 0, 7);
            table.Controls.Add(buttonAgo, 0, 8);
            table.Controls.Add(buttonDelete, 0, 9);
            table.Controls.Add(buttonSave, 0, 10);
            table.Controls.Add(new Panel(), 0, 11);


            table.Dock = DockStyle.Fill;
            Controls.Add(table);

        }
    }
}
