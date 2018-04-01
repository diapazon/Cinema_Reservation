using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Seats : Form
    {
        public List<Button> seatList = new List<Button>();
        Button Kreslo = new Button();
       public  int TopPos = 0;
       public int LeftPos = 0;
       public int  yerler= 10;
       
       public  int Row = 4;
       public int Column = 8;
       public int Count = 1;
        public int count1 = 1;

        public Seats()
        {
           
                InitializeComponent();

            narMobile();
            VIP();
            Sevgililer();
            ErgenZali();


        }

        public void narMobile()
        {
            for (int i = 1; i < Row; i++)
            {
                TopPos += 70;
                LeftPos = 0;

                for (int j = 1; j <= Column; j++)
                {
                    Button Kreslo = new Button();
                    Kreslo.Width = 60;
                    Kreslo.Height = 40;
                    Kreslo.ForeColor = Color.White;
                    Kreslo.Text = Count.ToString();
                    Kreslo.FlatStyle = FlatStyle.Flat;
                    Kreslo.FlatAppearance.BorderSize = 3;
                    Kreslo.FlatAppearance.BorderColor = Color.Gray;
                    Kreslo.BackColor = Color.Black;
                    Kreslo.Top = TopPos; ;
                    Kreslo.Left = LeftPos;


                    Kreslo.Click += new EventHandler(ChangeColor);

                    Controls.Add(Kreslo);
                    LeftPos += 70;
                    TopPos += 0;
                    Count++;

                }
            }
        }

        public void ErgenZali()
        {

            for (int i = 0; i < yerler * 2; i++)
            {
                yerler -= 2;
                LeftPos = (60 * i);


                for (int j = 0; j < yerler; j++)
                {

                    Button Kreslo = new Button();
                    Kreslo.Width = 50;
                    Kreslo.Height = 50;
                    Kreslo.FlatAppearance.BorderSize = 1;
                    Kreslo.FlatStyle = FlatStyle.Flat;
                    Kreslo.Text = Count.ToString();

                    Kreslo.BackColor = Color.Tomato;
                    Kreslo.Top = TopPos;
                    Kreslo.Left = LeftPos;
                    Controls.Add(Kreslo);
                    LeftPos += 60;

                    Count++;
                }
                LeftPos = 0;
                TopPos += 60;
            }


        }

        public void VIP()
        {
            for (int i = 1; i <= 4; i++)
            {


                Button Kreslo = new Button();
                Kreslo.Width = 50;
                Kreslo.Height = 100;
                Kreslo.FlatAppearance.BorderSize = 1;
                Kreslo.FlatStyle = FlatStyle.Flat;
                Kreslo.Text = count1.ToString();

                Kreslo.BackColor = Color.Green;
                Kreslo.Top = TopPos;
                Kreslo.Left = LeftPos;
                Controls.Add(Kreslo);
                LeftPos += 60;
               ++ count1;

                Button Stol = new Button();
                Stol.Width = 50;
                Stol.Height = 20;
                Stol.FlatAppearance.BorderSize = 1;
                Stol.FlatStyle = FlatStyle.Flat;
                Stol.BackColor = Color.Black;
                Stol.Top = Kreslo.Top + 120;
                Stol.Left = Kreslo.Left;
                Controls.Add(Stol);
            }
        }


        public void Sevgililer()
        {
            for (int i = 0; i < Column - 2; i++)
            {
                for (int j = 0; j < Row-2; j++)
                {


                    Button Kreslo = new Button();
                    Kreslo.Width = 30;
                    Kreslo.Height = 50;
                    Kreslo.FlatAppearance.BorderSize = 1;
                    Kreslo.FlatStyle = FlatStyle.Flat;
                    Kreslo.Text = Count.ToString();

                    Kreslo.BackColor = Color.Yellow;
                    Kreslo.Top = TopPos;
                    Kreslo.Left = LeftPos;
                    Controls.Add(Kreslo);
                    LeftPos += 60;

                    Count++;
                }
                LeftPos = 0;
                TopPos += 60;
            }
        }
        
        private void ChangeColor(object sender, EventArgs e)
        {

            Button duyme = sender as Button;
            duyme.BackColor = Color.Red;
            seatList.Add(duyme);
         //   textBox1.Text = "";
            duyme.Enabled = false;
        //    foreach (Button item in seatList)
        //    {
        //        box.Text += item.Text + ",";
        //    }

            Label direction = new Label();
            direction.Text = "Your Seats";
            direction.Left = 300;
            direction.Top = 300;
            direction.Width = 100;
            Controls.Add(direction);

            TextBox print = new TextBox();//////////////////////////////////////
            TextBox box = sender as TextBox;
            print.Width = 100;
            print.Left = 300;
            print.Top = 350;
            foreach (var item in seatList)
            {
                print.Text = item.Text;
            }
          

            Controls.Add(print);





        }

     
    }
   
}
