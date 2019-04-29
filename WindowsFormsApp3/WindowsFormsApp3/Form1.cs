using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        int[] score = new int[] { 1, 1, 1 };
        string result = "";
        int turaPlayer = -1;
        public struct player
        {
            public int x;
            public int y;
        }
        player p1;
        player p2;
        player p3;
       
        public Form1()
        {
            
            InitializeComponent();
            p1.x = 512;
            p1.y = 126;
            p2.x = 512;
            p2.y = 102;
            p3.x = 512;
            p3.y = 153;
            BackColor = Color.SandyBrown;
            startGame();
           //LoadClient();
            //LoadServer();

        }
        //label1
        public void startGame()
        {
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            pictureBox5.Visible = false;
            label4.Visible = false;
            pictureBox9.Visible = false;
            pictureBox13.Visible = false;
            pictureBox14.Visible = false;

            pictureBox2.Location = new Point(p1.x,p1.y);
            pictureBox6.Location = new Point(p2.x, p2.y);
            pictureBox7.Location = new Point(p3.x,p3.y);
            playersTurn();
        }
        public void playersTurn()
        {
            turaPlayer += 1;
            if (turaPlayer==3)
            {
                turaPlayer = 0;
            }
          
            if(score[turaPlayer] >=0 && score[turaPlayer] <70)
            {
                Random f = new Random();
                int q = f.Next(0, 11);
                int z = f.Next(0, 11);
                string content = "";
                int value = f.Next(0, 2);
                switch (value)
                {
                    case 0:
                        
                        label1.Text = Convert.ToString(q) + "+" + Convert.ToString(z);
                       
                        result = Convert.ToString(q + z);
                        break;
                    case 1:
                        if (q > z)
                        {
                            
                            label1.Text = content = Convert.ToString(q) + "-" + Convert.ToString(z);

                            result = Convert.ToString(q - z);
                        }
                        else
                        {
                           
                            label1.Text = Convert.ToString(z) + "-" + Convert.ToString(q);

                            result = Convert.ToString(z-q);
                        }
                        break;
                    default:
                        break;

                }
                
                
            }
            



        }
        int maxHighscore = 0;
        long t = 1000000;
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            t -= 1;
            if(score[0]>maxHighscore)
            {
                pictureBox9.Visible = true;
                pictureBox13.Visible = false;
                pictureBox14.Visible = false;
                maxHighscore = score[0];
                label3.Text = Convert.ToString(maxHighscore);
            }
            if (score[1] > maxHighscore)
            {
                maxHighscore = score[1];
                pictureBox9.Visible = false;
                pictureBox13.Visible = true;
                pictureBox14.Visible = false;
                label3.Text = Convert.ToString(maxHighscore);
            }
            if (score[2] > maxHighscore)
            {
                maxHighscore = score[2];
                pictureBox9.Visible = false;
                pictureBox13.Visible = false;
                pictureBox14.Visible = true;
                label3.Text = Convert.ToString(maxHighscore);
            }
            pictureBox4.Visible = false;
            if(score[0] > 79)
            {
                pictureBox4.Visible = true;
                label4.Text = label4.Text + " 1";
                timer1.Enabled = false;
            }
            if (score[1] > 79)
            {
                pictureBox4.Visible = true;
                label4.Text = label4.Text + " 2";
                timer1.Enabled = false;
            }
            if (score[2] > 79)
            {
                pictureBox4.Visible = true;
                label4.Text = label4.Text + " 3";
                timer1.Enabled = false;
            }
        }
     
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text==result)
                {
                    pictureBox5.Visible = true;
                    timer3.Interval = 1000;
                    timer3.Start();
                    MovePlayer();
                   
                }
                else
                {
                    pictureBox3.Visible = true;
                    timer2.Interval = 1000;
                    timer2.Start();
                    playersTurn();

                }
                textBox1.Text = "";
                //label1.Text = "";
            }
           
        }
        
        public void MovePlayer()
        {
            int i;
            
            if(turaPlayer==0)
            {
                i = score[turaPlayer];
                
                    if (i <= 11 && i >= 1)
                        p1.x += 91;
                    if (i >= 12 && i <= 18)
                        p1.y += 90;
                   
                    if (i > 18 && i <= 27)
                        p1.x -= 91;
                    if (i > 27 && i <= 33)
                        p1.y -= 90;
                    if (i > 33 && i <= 41)
                        p1.x += 91;
                    if (i > 41 && i <= 46)
                        p1.y += 90;
                    if (i > 46 && i <= 53)
                        p1.x -= 91;
                    if (i > 53 && i <= 56)
                        p1.y -= 90;
                    if (i > 57 && i <= 63)
                        p1.x += 91;
                    if (i > 63 && i <= 66)
                        p1.y += 90;
                    if (i > 66 && i <= 71)
                        p1.x -= 91;
                    if (i > 71 && i <= 73)
                        p1.y -= 90;
                    if (i > 73 && i <= 76)
                        p1.x += 91;
                    pictureBox2.Location = new Point(p1.x, p1.y);
                score[0] += 1;
                

            }
            else if(turaPlayer==1)
            {
                i = score[turaPlayer];

                if (i <= 11 && i >= 1)
                    p2.x += 91;
                if (i >= 12 && i <= 18)
                    p2.y += 90;

                if (i > 18 && i <= 27)
                    p2.x -= 91;
                if (i > 27 && i <= 33)
                    p2.y -= 90;
                if (i > 33 && i <= 41)
                    p2.x += 91;
                if (i > 41 && i <= 46)
                    p2.y += 90;
                if (i > 46 && i <= 53)
                    p2.x -= 91;
                if (i > 53 && i <= 56)
                    p2.y -= 90;
                if (i > 57 && i <= 63)
                    p2.x += 91;
                if (i > 63 && i <= 66)
                    p2.y += 90;
                if (i > 66 && i <= 71)
                    p2.x -= 91;
                if (i > 71 && i <= 73)
                    p2.y -= 90;
                if (i > 73 && i <= 76)
                    p2.x += 91;
                pictureBox6.Location = new Point(p2.x, p2.y);
                score[1] += 1;
              
            }
            else if(turaPlayer==2)
            {
                i = score[turaPlayer];

                if (i <= 11 && i >= 1)
                    p3.x += 91;
                if (i >= 12 && i <= 18)
                    p3.y += 90;

                if (i > 18 && i <= 27)
                    p3.x -= 91;
                if (i > 27 && i <= 33)
                    p3.y -= 90;
                if (i > 33 && i <= 41)
                    p3.x += 91;
                if (i > 41 && i <= 46)
                    p3.y += 90;
                if (i > 46 && i <= 53)
                    p3.x -= 91;
                if (i > 53 && i <= 56)
                    p3.y -= 90;
                if (i > 57 && i <= 63)
                    p3.x += 91;
                if (i > 63 && i <= 66)
                    p3.y += 90;
                if (i > 66 && i <= 71)
                    p3.x -= 91;
                if (i > 71 && i <= 73)
                    p3.y -= 90;
                if (i > 73 && i <= 76)
                    p3.x += 91;
                pictureBox7.Location = new Point(p3.x, p3.y);
                score[2] += 1;
               
            }
           // LoadClient();
            playersTurn();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox3.Visible = false;
            timer2.Stop();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox5.Visible = false;
            timer3.Stop();
        }
        
        const int PORT_NO = 5000;
        const string SERVER_IP = "127.0.0.1";
        static TcpClient client = new TcpClient(SERVER_IP, PORT_NO);
        static NetworkStream nwStream = client.GetStream();
        private void LoadClient()
        {
            //---create a TCPClient object at the IP and port no.---
                //---send the text---
                byte[] send1 = convertinttobyte(p1.x);
                nwStream.Write(send1, 0, send1.Length);

                byte[] send2 = convertinttobyte(p1.y);
                nwStream.Write(send2, 0, send2.Length);

                byte[] send3 = convertinttobyte(p2.x);
                nwStream.Write(send3, 0, send3.Length);

                byte[] send4 = convertinttobyte(p2.y);
                nwStream.Write(send4, 0, send4.Length);
                byte[] send5 = convertinttobyte(p3.x);
                nwStream.Write(send5, 0, send5.Length);
                byte[] send6 = convertinttobyte(p3.y);
                nwStream.Write(send6, 0, send6.Length);
                byte[] send7 = convertinttobyte(turaPlayer);
                nwStream.Write(send7, 0, send7.Length);
                byte[] send8 = convertinttobyte(score[0]);
                nwStream.Write(send8, 0, send8.Length);
                byte[] send9 = convertinttobyte(score[1]);
                nwStream.Write(send9, 0, send9.Length);
                byte[] send10 = convertinttobyte(score[2]);
                nwStream.Write(send10, 0, send10.Length);

                byte[] buffer = new byte[client.ReceiveBufferSize];
               

                byte[] buffer2 = new byte[client.ReceiveBufferSize];
                

                byte[] buffer3 = new byte[client.ReceiveBufferSize];
               


                byte[] buffer4 = new byte[client.ReceiveBufferSize];
              

                byte[] buffer5 = new byte[client.ReceiveBufferSize];
                

                byte[] buffer6 = new byte[client.ReceiveBufferSize];
               

                byte[] buffer7 = new byte[client.ReceiveBufferSize];
                

                byte[] buffer8 = new byte[client.ReceiveBufferSize];
               

                byte[] buffer9 = new byte[client.ReceiveBufferSize];
                

                byte[] buffer10 = new byte[client.ReceiveBufferSize];
               

                p1.x = converbyetoint(buffer);
                p1.y = converbyetoint(buffer2);
                p2.x = converbyetoint(buffer3);
                p2.y = converbyetoint(buffer4);
                p3.x = converbyetoint(buffer5);
                p3.y = converbyetoint(buffer6);
                turaPlayer= converbyetoint(buffer7);
                score[0] = converbyetoint(buffer8);
                score[1] = converbyetoint(buffer9);
                score[2] = converbyetoint(buffer10);
            

        }
        public int converbyetoint(byte[] x)
        {
            if(BitConverter.IsLittleEndian)
                    Array.Reverse(x);

            int i = BitConverter.ToInt32(x, 0);
            return i;
        }
        public byte[] convertinttobyte(int x)
        {
            byte[] intBytes = BitConverter.GetBytes(x);
            Array.Reverse(intBytes);
            byte[] result = intBytes;
            return result;
        }
    }
}
