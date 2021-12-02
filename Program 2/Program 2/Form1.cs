//Grading ID: K9982
//Due Date: 10/16/2019
//Class Section:CIS-199-02
//Program 2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcBtn_Click(object sender, EventArgs e)
        {
            char name;//name variable
            double hours; //hours variable
            string DATE_1 = "Nov. 4";// date 1 variable
            string DATE_2 = "Nov. 5";//date 2 variable
            string DATE_3 = "Nov. 6";//date 3 variable
            string DATE_4 = "Nov. 7";//date 4 variable
            string DATE_5 = "Nov. 8";//date 5 variable
            string DATE_6 = "Nov. 11";//date 6 variable
            string TIME_1 = "8:30";//time 1 variable
            string TIME_2 = "10:00";//time 2 variable
            string TIME_3 = "11:30";//time 3 variable
            string TIME_4 = "2:00";//time 4 variable
            string TIME_5 = "4:00";//time 5 variable
            const double SENIOR_HRS = 90;// senior hours constant
            const double JUNIOR_HRS = 60;// junior hours constant
            const double SOPHMORE_HRS = 30;// sophmore hours constant

            if (char.TryParse(firstLetterTxt.Text, out name))// tryparse for the char variable
            {
                if(double.TryParse(creditHoursTxt.Text, out hours) && (hours >= 0))// tryparse for the double variable
                {
                    if(hours >= JUNIOR_HRS)//hours greater than or equal to junior hours 
                    {
                        if (hours >= SENIOR_HRS)//hours greater than or equal to senior hours 
                        {
                            dateOutputLbl.Text = DATE_1;//output DATE 1
                        }
                        else
                        {
                            dateOutputLbl.Text = DATE_2;//outputs date 2
                        }

                        if(name <= 'D')// letters  D or before D
                        {
                            timeOutputLbl.Text = TIME_3;//outputs time 3
                        }
                        else if (name <= 'I')//letters I or before I
                        {
                            timeOutputLbl.Text = TIME_4;//outputs time 4
                        }
                        else if (name <= 'O')// letters O or before O
                        {
                            timeOutputLbl.Text = TIME_5;// outputs Time 5
                        }
                        else if (name <= 'S')// letters S or before S
                        {
                            timeOutputLbl.Text = TIME_1;//outputs time 1
                        }
                        else
                        {
                            timeOutputLbl.Text = TIME_2;//outputs time 2
                        }







                    }
                    else
                    {
                        if (hours >= SOPHMORE_HRS)//hours greater than or equal to sophmore hours 
                        {
                            if(name > 'C' && name < 'O')// letters aftrer C and before O
                            {
                                dateOutputLbl.Text = DATE_4;// outputs date 4
                            }
                            else
                            {
                                dateOutputLbl.Text = DATE_3;// outputs date 3
                            }

                            
                        }
                        else
                        {
                            if (name > 'C' && name < 'O')// letters aftrer C and before O
                            {
                                dateOutputLbl.Text = DATE_6;//outputs date 6
                            }
                            else
                            {
                                dateOutputLbl.Text = DATE_5;//outputs date 5
                            }
                        }


                        if (name <= 'B')// name is before B or is B
                        {
                            timeOutputLbl.Text = TIME_5;// outputs time 5
                        }
                        else if (name <= 'D')//name is before D or is D
                        {
                            timeOutputLbl.Text = TIME_1;// outputs time 1
                        }
                        else if (name <= 'F')//name is before F or is F
                        {
                            timeOutputLbl.Text = TIME_2;// outputs time 2
                        }
                        else if (name <= 'I')//name is before I or is I
                        {
                            timeOutputLbl.Text = TIME_3;//outputs time 3
                        }
                        else if (name <= 'L')//name is before L or is L
                        {
                            timeOutputLbl.Text = TIME_4;//outputs time 4
                        }
                        else if (name <= 'O')//name is O or before O
                        {
                            timeOutputLbl.Text = TIME_5;//outputs time 5
                        }
                        else if (name <= 'Q')//name is Q or before Q
                        {
                            timeOutputLbl.Text = TIME_1;//outputs time time 1
                        }
                        else if (name <= 'S')//name is S or before S
                        {
                            timeOutputLbl.Text = TIME_2;//outputs time 2 
                        }
                        else if (name <= 'V')//name is V or before V
                        {
                            timeOutputLbl.Text = TIME_3;//outputs time 3
                        }
                        else
                        {
                            timeOutputLbl.Text = TIME_4;//outputs time 4
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter the proper amount of hours");// shows message box
                }
            }
            else
            {
                MessageBox.Show("Enter an upper case letter");//shows message box
            }



        }
    }
    }

