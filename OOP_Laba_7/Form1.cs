using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;

namespace OOP_Laba_7
{
    public partial class Form1 : Form
    {
        UNIVER u = new UNIVER();
        public Form1()
        {
            InitializeComponent();
        }
        //добавить
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Student sdnt = new Student();
                sdnt.familya = fam.Text; fam.Clear();
                sdnt.name = nam.Text; nam.Clear();
                sdnt.otchestvo = otch.Text; otch.Clear();
                sdnt.pol = comboBox1.Text;
                sdnt.BDay = bday.Value;
                if (radioButton1.Checked) sdnt.curs = Convert.ToInt32(radioButton1.Text);
                if (radioButton2.Checked) sdnt.curs = Convert.ToInt32(radioButton2.Text);
                if (radioButton3.Checked) sdnt.curs = Convert.ToInt32(radioButton3.Text);
                if (radioButton4.Checked) sdnt.curs = Convert.ToInt32(radioButton4.Text);
                if (radioButton5.Checked) sdnt.curs = Convert.ToInt32(radioButton5.Text);
                sdnt.special = listBox1.Text;
                sdnt.gruppa = Convert.ToInt32(grup.Text); grup.Clear();
                sdnt.avg_note = Convert.ToDouble(avg_note.Value);
                sdnt.telephon = tel.Text; tel.Clear();
                sdnt.adress.city = city.Text; city.Clear();
                sdnt.adress.index = index.Text; index.Clear();
                sdnt.adress.street = strit.Text; strit.Clear();
                sdnt.adress.flat = flat.Text; flat.Clear();
                sdnt.adress.house = house.Text; house.Clear();
                u.students.Add(sdnt);
                String[] stnt = new String[9];
                stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                stnt[1] = sdnt.pol;
                stnt[2] = sdnt.BDay.ToShortDateString();
                stnt[3] = sdnt.curs.ToString();
                stnt[4] = sdnt.special;
                stnt[5] = sdnt.gruppa.ToString();
                stnt[6] = sdnt.avg_note.ToString();
                stnt[7] = sdnt.telephon;
                stnt[8] = sdnt.adress.ToString();
                inf.Rows.Add(stnt);
            }
            catch(Exception)
            {
                MessageBox.Show("Проверте корректность данных!");

            }
        }
        //запись
        private void button2_Click(object sender, EventArgs e)
        {
            XmlSerializer seril = new XmlSerializer(typeof(UNIVER));
            using (FileStream fs = new FileStream("Univer.xml", FileMode.Create))
            {
                seril.Serialize(fs, u);
                MessageBox.Show("Соранено в xml файле!");
            }
        }
        //чтение
        private void button3_Click(object sender, EventArgs e)
        {
            inf.Rows.Clear();
            XmlSerializer seril = new XmlSerializer(typeof(UNIVER));
            using (FileStream fs = new FileStream("Univer.xml", FileMode.Open))
            {
                u=(UNIVER)seril.Deserialize(fs);
            }
            foreach(Student sdnt in u.students)
            {
                String[] stnt = new String[9];
                stnt[0] = sdnt.familya + " " + sdnt.name + " " + sdnt.otchestvo;
                stnt[1] = sdnt.pol;
                stnt[2] = sdnt.BDay.ToShortDateString();
                stnt[3] = sdnt.curs.ToString();
                stnt[4] = sdnt.special;
                stnt[5] = sdnt.gruppa.ToString();
                stnt[6] = sdnt.avg_note.ToString();
                stnt[7] = sdnt.telephon;
                stnt[8] = sdnt.adress.ToString();
                inf.Rows.Add(stnt);
            }

        }

        private void grup_TextChanged(object sender, EventArgs e)
        {

        }

        private void grup_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void index_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void house_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void flat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar);
        }

        private void fam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void otch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar);
        }

        private void fam_Validating(object sender, CancelEventArgs e)
        {
            if (fam.Text == "") fam.BackColor = Color.Red;
            else fam.BackColor = Color.White;

        }

        private void nam_Validating(object sender, CancelEventArgs e)
        {
            if (nam.Text == "") nam.BackColor = Color.Red;
            else nam.BackColor = Color.White;
        }

        private void otch_Validating(object sender, CancelEventArgs e)
        {
            if (otch.Text == "") otch.BackColor = Color.Red;
            else otch.BackColor = Color.White;
        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (comboBox1.Text != "Мужской"&& comboBox1.Text != "Женский") comboBox1.BackColor = Color.Red;
            else comboBox1.BackColor = Color.White;
        }

        private void grup_Validating(object sender, CancelEventArgs e)
        {
            if (grup.Text == "") grup.BackColor = Color.Red;
            else grup.BackColor = Color.White;
        }

        private void city_Validating(object sender, CancelEventArgs e)
        {
            if (city.Text == "") city.BackColor = Color.Red;
            else city.BackColor = Color.White;
        }

        private void index_Validating(object sender, CancelEventArgs e)
        {
            if (index.Text.Length <5) index.BackColor = Color.Red;
            else index.BackColor = Color.White;
        }

        private void strit_Validating(object sender, CancelEventArgs e)
        {
            if (strit.Text == "") strit.BackColor = Color.Red;
            else strit.BackColor = Color.White;
        }

        private void house_Validating(object sender, CancelEventArgs e)
        {
            if (house.Text == "" || house.Text.Length > 4) house.BackColor = Color.Red;
            else house.BackColor = Color.White;
        }

        private void flat_Validating(object sender, CancelEventArgs e)
        {
            if (flat.Text == ""|| flat.Text.Length>4) flat.BackColor = Color.Red;
            else flat.BackColor = Color.White;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            fam.Focus();
            nam.Focus();
            otch.Focus();
            bday.Focus();
            comboBox1.Focus();
            
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked && !radioButton5.Checked)
            { label5.ForeColor = Color.Red; }
            else label5.ForeColor = Color.Black;
            tel.Focus();
            listBox1.Focus();
            grup.Focus();
            avg_note.Focus();
            tel.Focus();
            city.Focus();
            index.Focus();
            strit.Focus();
            flat.Focus();
            house.Focus();
            button1.Focus();

        }

        private void tel_Validating(object sender, CancelEventArgs e)
        {
            if (tel.Text.Length < 13) tel.BackColor = Color.Red;
            else tel.BackColor = Color.White;
        }

        private void listBox1_Validating(object sender, CancelEventArgs e)
        {
            if (listBox1.Text == "") label6.ForeColor = Color.Red;
            else label6.ForeColor = Color.Black;
        }
    }
}
