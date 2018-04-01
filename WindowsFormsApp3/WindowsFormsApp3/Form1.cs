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
    public partial class bas : Form
    {
        public int Count = 1;

        Button select = new Button();
        Button headline = new Button();
        Button first = new Button();
        Button second = new Button();
        Button third = new Button();
        Button forth = new Button();
        public bas()
        {
            InitializeComponent();
            addSalonToComboBox();




            //HEADLINE (CHOOSE MOVIE)
            headline.Top = 10;
            //headline.Width = 120;
            headline.FlatStyle = FlatStyle.Flat;
            headline.FlatAppearance.BorderSize = 3;
            headline.BackColor = Color.Gray;
            headline.Text = ("Choose Movie");
            Controls.Add(headline);
            headline.AutoSize = true;
            headline.Left = this.Width / 2 - headline.Width / 2;

            // SELECT (SELECT MOVIE BUTTON)
            select.Top = 450;
            select.FlatStyle = FlatStyle.Flat;
            select.FlatAppearance.BorderSize = 3;
            select.BackColor = Color.Gray;
            select.Text = "Select Movie";
            select.AutoSize = true;
            Controls.Add(select);
            select.Left = this.Width / 2 - select.Width / 2;
            select.Click += new EventHandler(OpenNewWindow);

            // FIRST INFO 
            first.Top = 300;
            first.FlatStyle = FlatStyle.Flat;
            first.FlatAppearance.BorderSize = 1;
            first.BackColor = Color.Yellow;
            first.Text = "WARCRAFT  2017 \n Duration: 150 minutes";
            Controls.Add(first);
            first.AutoSize = true;
            first.Left = firstPicture.Width / 2 - 35;

            //SECOND INFO   
            second.Top = 300;
            second.FlatStyle = FlatStyle.Flat;
            second.FlatAppearance.BorderSize = 1;
            second.BackColor = Color.Yellow;
            second.Text = "JURASSIC WORLD  2017 \n Duration: 120 minutes";
            Controls.Add(second);
            second.AutoSize = true;
            second.Left = 215;

            //THIRD INFO
            third.Top = 300;
            third.FlatStyle = FlatStyle.Flat;
            third.FlatAppearance.BorderSize = 1;
            third.BackColor = Color.Yellow;
            third.Text = "TOMB RAIDER 2017 \n Duration: 112 minutes";
            Controls.Add(third);
            third.AutoSize = true;
            third.Left = 412;

            //FORTH INFO
            forth.Top = 300;
            forth.FlatStyle = FlatStyle.Flat;
            forth.FlatAppearance.BorderSize = 1;
            forth.BackColor = Color.Yellow;
            forth.Text = "SKYSCRAPER 2017 \n Duration: 200 minutes";
            Controls.Add(forth);
            forth.AutoSize = true;
            forth.Left = 600;

            // COMBO BOXES FOR HALL and SEANCE
            chooseHall.Text = "CHOOSE HALL";
            Controls.Add(chooseHall);
            chooseSeance.Text = "CHOOSE SEANCE";
            Controls.Add(chooseSeance);


        }

        public void addSalonToComboBox()
        {
           
           
            foreach (string item in Hall.Salonlar)
            {
                Hall.ID = Count;
                Count++;
                chooseHall.Items.Add(Hall.ID + ":" + item);
            }
        }

        public void OpenNewWindow(object obj, EventArgs e)
        {

            if (chooseHall.SelectedItem.ToString() == "1:Nar Mobile")
            {
                Seats sts = new Seats();
                sts.narMobile();
            }
            else if (chooseHall.SelectedItem.ToString()=="2:VIP")
            {
                Seats sts = new Seats();
                sts.VIP();
            }
            else if (chooseHall.SelectedItem.ToString() == "3:Sevgililer")
            {
                Seats sts = new Seats();
               // sts.Sevgililer();
            }
            else
            {

                Seats sts = new Seats();
                sts.ErgenZali();
            }



            var newWindow = new Seats();
                newWindow.Show();
            
            
            //}
            //else if (chooseHall.ID==2)
            //{
            //    var newWindow2 = new Seats();
            //    newWindow2.Show();
            //}
            //else if (chooseHall.ID == 3)
            //{
            //    var newWindow3 = new Seats();
            //    newWindow3.Show();
            //}
            //else
            //{
            //    var newWindow4 = new Seats();
            //    newWindow4.Show();

            //}






            MessageBox.Show("Test");
         
        }


    }
}
