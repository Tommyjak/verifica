using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tommaso_Mortara_Verifica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            List<Studente> studenti = new List<Studente>();
            Studente tommi = new Studente("Tommaso", "Mortara", 16, "F");
            for (int i =0; i<10; i++)
            {
                int j = rnd.Next(10);
                tommi.voti.Add(j);
            }
            studenti.Add(tommi);
            listBox1.Items.Add(studenti);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            string description = studenti[i].describe();
            textBox1.Text = description;
        }


    }
}
