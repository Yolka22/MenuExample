using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace MenuExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void AddTopLevelMenu_Click_1(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = new ToolStripMenuItem(TopLevelMenu.Text);

            // Добавляем пункт меню в главное меню
            menuStrip1.Items.Add(menuItem);
        }

        private void AddSubItem_Click_1(object sender, EventArgs e)
        {
            int index = menuStrip1.Items.IndexOfKey(TopLevelMenu.Text);

            // Если индекс равен -1, значит выбранный пункт меню не найден
            if (index == -1)
            {
                MessageBox.Show("Выбранный пункт меню не найден.");
                return;
            }

            // Получаем выбранный пункт меню
            ToolStripMenuItem menuItem = (ToolStripMenuItem)menuStrip1.Items[index];

            // Создаем новый подпункт меню
            ToolStripMenuItem subMenuItem = new ToolStripMenuItem(SubItem.Text);

            // Добавляем подпункт меню к выбранному пункту меню
            menuItem.DropDownItems.Add(subMenuItem);
        }
    }
}
