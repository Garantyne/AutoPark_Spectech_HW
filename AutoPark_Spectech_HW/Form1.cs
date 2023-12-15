using AutoPark_Spectech_HW.Entity;
using AutoPark_Spectech_HW.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoPark_Spectech_HW
{
    public partial class Form1 : Form
    {
        TechManager manager = new TechManager();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            listBoxTech.Items.Clear();
            manager.AddTech(textBoxName.Text, textBoxType.Text);
            ShowInListBox(manager.TechList);
            
        }

        

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int i = listBoxTech.SelectedIndex;
            if(i != -1)
            {
                listBoxTech.Items.Clear();
                manager.DeleteTech(i);
                ShowInListBox(manager.TechList);
            }
            else
            {
                string str = textBoxName.Text;
                TechAuto t = new TechAuto() { TechName = str ,TechType = textBoxType.Text};
                if (manager.GetTechList().Contains(t))
                {
                    manager.GetTechList().Remove(t);
                    listBoxTech.Items.Clear();
                    ShowInListBox(manager.TechList);
                }

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Вы уверены что хотите выйти?",
                "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if(listBoxTech.SelectedIndex != -1)
            {
                manager.TechList[listBoxTech.SelectedIndex].TechName = textBoxName.Text;
                manager.TechList[listBoxTech.SelectedIndex].TechType = textBoxType.Text;
                listBoxTech.Items.Clear();
                ShowInListBox(manager.TechList);
            }
        }

        private void ShowInListBox(List<TechAuto> tech)
        {
            for (int i = 0; i < tech.Count; i++)
            {
                listBoxTech.Items.Add($"{i + 1}. {manager.GetTechList()[i]}");
            }
        }
    }
}
