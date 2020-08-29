using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string readList = File.ReadAllText(UserSetting.ListFullNamePass);
                string[] ToDoList = readList.Split('\t');
                int ListNum = ToDoList.Length;

                if (ListNum == 1)
                {
                    ToDo1.Text = ToDoList[0];
                }
                else if (ListNum == 2)
                {
                    ToDo1.Text = ToDoList[0];
                    ToDo2.Text = ToDoList[1];
                }
                else if (ListNum == 3)
                {
                    ToDo1.Text = ToDoList[0];
                    ToDo2.Text = ToDoList[1];
                    ToDo3.Text = ToDoList[2];
                }

            }
            catch (Exception ex)
            {
                ToDo1.Text = ex.ToString();
            }

        }

        private void Form1_Closed(object sender, EventArgs e)
        {
            String list = ToDo1.Text + "\t" + ToDo2.Text + "\t" + ToDo3.Text;
            File.WriteAllText(UserSetting.ListFullNamePass, list);
        }

    }
}
