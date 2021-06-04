using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Caesar_cipher
{
    public partial class Form1 : Form
    {
        FileStream file = new FileStream("message.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
        char[] chars = new char[]{' ','!','"','#','$','%','&','\'','(',')','*','+',',','-','.','/','0',
            '1','2','3','4','5','6','7','8','9',':',';','<','=','>','?','@','A','Ą','B','C','Ć','D','E',
            'Ę','F','G','H','I','J','K','L','Ł','M','N','Ń','O','Ó','P','Q','R','S','Ś','T','U','V','W',
            'X','Y','Z','Ź','Ż','[','/',']','^','_','`','a','ą','b','c','ć','d','e','ę','f','g','h','i',
            'j','k','l','ł','m','n','ń','o','ó','p','q','r','s','ś','t','u','v','w','x','y','z','ź','ż',
            '{','|','}','~'}; //ASCII code combined with Polish diacritized letters
        int key;
        string message = "";
        char[] messagechar;
        char[] result;

        public Form1()
        {
            InitializeComponent();
            //draw a key
            Random r = new Random();
            tBKey.Text = Convert.ToString(r.Next(int.MinValue, int.MaxValue));
        }

        private void Btngo_Click(object sender, EventArgs e)
        {
            //the key cannot be empty!!!
            if (tBKey.Text == "") tBKey.Text = "0";
            key = Convert.ToInt32(tBKey.Text);
            //transforming the key value to range from 0 to the number of chars minus 1
            while (key<0 || key > chars.Length - 1)
            {
                if (key < 0) key += chars.Length;
                else if (key > chars.Length - 1) key %= chars.Length;
            }
            //loading the message from the text field and saving it to a file
            if (rBText.Checked == true)
            {
                message = tBText.Text;
                StreamWriter sw = new StreamWriter(file);
                sw.WriteLine(message);
                sw.Close();
            }
            //loading a message from a file and saving it to the text field
            else if (rBFile.Checked == true)
            {
                StreamReader sr = new StreamReader(file);
                message = sr.ReadLine();
                sr.Close();
                tBText.Text = message;
            }
            //the beginning of the algorithm
            messagechar = message.ToCharArray();
            result = new char[messagechar.Length];
            for (int j = 0; j < messagechar.Length; j++)
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (messagechar[j] == chars[i])
                    {
                        int x = i;
                        int c;
                        if (rBE.Checked == true) //for encryption
                        {
                            //securing the key on a chars array
                            if (((x + key) >= 0) & ((x + key) <= (chars.Length - 1)))
                            {
                                c = x + key;
                                result[j] = chars[c];
                            }
                            else if ((x + key) < 0)
                            {
                                c = x + key + chars.Length;
                                result[j] = chars[c];
                            }
                            else if ((x + key) > (chars.Length - 1))
                            {
                                c = x + key - chars.Length;
                                result[j] = chars[c];
                            }
                        }else if (rBD.Checked == true) //for decryption
                        {
                            //securing the key on a chars array
                            if (((x - key) >= 0) & ((x - key) <= (chars.Length - 1)))
                            {
                                c = x - key;
                                result[j] = chars[c];
                            }
                            else if ((x - key) < 0)
                            {
                                c = x - key + chars.Length;
                                result[j] = chars[c];
                            }
                            else if ((x - key) > (chars.Length - 1))
                            {
                                c = x - key - chars.Length;
                                result[j] = chars[c];
                            }
                        }
                    }
                }
            }
            //message encryption or decryption
            for (int i = 0; i < messagechar.Length; i++)
            {
                tBMessage.Text += Convert.ToString(result[i]);
            }
            //protection against the next operation
            gBOperation.Enabled = false;
            gBSource.Enabled = false;
            gBKey.Enabled = false;
            tBText.Enabled = false;
        }

        //draw a key
        private void Btndraw_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            tBKey.Text = Convert.ToString(r.Next(int.MinValue, int.MaxValue));
        }

        ////select a message input method
        private void SelectSource(object sender, EventArgs e)
        {
            if (rBText.Checked == true) tBText.Enabled = true;
            else if (rBFile.Checked == true) tBText.Enabled = false;
        }

        //display the selected operation as the button text
        private void SelectOperation(object sender, EventArgs e)
        {
            if (rBE.Checked == true) btngo.Text = rBE.Text;
            else if (rBD.Checked == true) btngo.Text = rBD.Text;
        }
    }
}
