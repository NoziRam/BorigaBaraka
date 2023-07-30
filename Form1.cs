using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace BorigaBaraka
{
    public partial class Form1 : Form
    {
        Generation generation = new Generation();
        Conversation conversation = new Conversation();
        List<Present> presents = new List<Present>();
        List<Button> buttons;
        List<Button> buttons2;
        int n = 0;
        int counter = 0;

        public Form1()
        {
            InitializeComponent();

            label1.Text = conversation.GetName();
            AddButtonstoTheList();
        }
        void AddButtonstoTheList()
        {
            buttons = new List<Button>();
            buttons.Add(button1);
            buttons.Add(button2);
            buttons.Add(button3);
            buttons.Add(button4);
            buttons.Add(button5);
            buttons.Add(button6);
            buttons.Add(button7);
            buttons.Add(button8);
            buttons.Add(button9);
            buttons.Add(button10);
            buttons.Add(button11);
            buttons.Add(button12);
            buttons.Add(button13);
            buttons.Add(button14);
            buttons.Add(button15);
            buttons.Add(button16);
            buttons.Add(button17);
            buttons.Add(button18);
            buttons.Add(button19);
            buttons.Add(button20);
            buttons.Add(button21);
            buttons.Add(button22);
            buttons.Add(button23);
            buttons.Add(button24);

            buttons2 = new List<Button>();
            buttons2.Add(b1);
            buttons2.Add(b2);
            buttons2.Add(b3);
            buttons2.Add(b4);
            buttons2.Add(b5);
            buttons2.Add(b6);
            buttons2.Add(b7);
            buttons2.Add(b8);
            buttons2.Add(b9);
            buttons2.Add(b10);
            buttons2.Add(b11);
            buttons2.Add(b12);
            buttons2.Add(b13);
            buttons2.Add(b14);
            buttons2.Add(b15);
            buttons2.Add(b16);
            buttons2.Add(b17);
            buttons2.Add(b18);
            buttons2.Add(b19);
            buttons2.Add(b20);
            buttons2.Add(b21);
            buttons2.Add(b22);
            buttons2.Add(b23);
            buttons2.Add(b24);
        }

        private void btSuhbat_Click(object sender, EventArgs e)
        {
            SuhbatNiBoshlash();
        }

        private void SuhbatNiBoshlash()
        {
            string name = textBoxConversation.Text;
            label1.Text = conversation.SayHello(name);
        }

        void Suhbat()
        {
            var s = conversation.Suhbat();
            label1.Text = s;
            n = Convert.ToInt32(s.Split(' ')[1]);
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Suhbat();
            var generate = new Generation();
            var NList = generate.GetRandom();
            presents = generate.GetPresents(NList);
            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Tag = presents[i].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Image = null;

            var text = button.Tag.ToString();
            foreach (var present in presents)
            {
                if (present.ToString() == text)
                {
                    Button button2 = (from btn in buttons2
                                      where btn.Text == text
                                      select btn).FirstOrDefault();
                    button2.Text =" ";
                }
            }
            CheckForN(text);
        }
       
        
        void CheckForN(string text)
        {

            label1.Text = $"{text} chiqib ketdi";
            counter++;

            if (counter == n)
            {  
                    Thread.Sleep(1500);
                    Suhbat();
                counter = 0;
            }
        }

        private void textBoxConversation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SuhbatNiBoshlash();
            }
        }

        private void button51_Click(object sender, EventArgs e)
        {
            label1.Text = "Uyin tugadi!";
            foreach (var b in buttons)
            {
                b.Enabled = false;
            }
        }
    }
}
