using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;



namespace FinanceApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Maximum = decimal.MaxValue;
            numericUpDown2.Maximum = decimal.MaxValue;
            numericUpDown3.Maximum = decimal.MaxValue;
            numericUpDown4.Maximum = decimal.MaxValue;
            numericUpDown5.Maximum = decimal.MaxValue;
            numericUpDown6.Maximum = decimal.MaxValue;
            numericUpDown7.Maximum = decimal.MaxValue;
            numericUpDown8.Maximum = decimal.MaxValue;
            numericUpDown9.Maximum = decimal.MaxValue;
            numericUpDown10.Maximum = decimal.MaxValue;
            numericUpDown11.Maximum = decimal.MaxValue;
            numericUpDown12.Maximum = decimal.MaxValue;
            numericUpDown13.Maximum = decimal.MaxValue;
            numericUpDown14.Maximum = decimal.MaxValue;
            numericUpDown15.Maximum = decimal.MaxValue;
            numericUpDown16.Maximum = decimal.MaxValue;
            numericUpDown17.Maximum = decimal.MaxValue;
            numericUpDown18.Maximum = decimal.MaxValue;
            numericUpDown19.Maximum = decimal.MaxValue;
            numericUpDown20.Maximum = decimal.MaxValue;
            numericUpDown21.Maximum = decimal.MaxValue;
            numericUpDown22.Maximum = decimal.MaxValue;
            numericUpDown23.Maximum = decimal.MaxValue;
            numericUpDown24.Maximum = decimal.MaxValue;
            numericUpDown25.Maximum = decimal.MaxValue;
            numericUpDown26.Maximum = decimal.MaxValue;
            numericUpDown27.Maximum = decimal.MaxValue;
            numericUpDown28.Maximum = decimal.MaxValue;
            numericUpDown29.Maximum = decimal.MaxValue;
            numericUpDown30.Maximum = decimal.MaxValue;
            numericUpDown31.Maximum = decimal.MaxValue;
            numericUpDown32.Maximum = decimal.MaxValue;
            numericUpDown33.Maximum = decimal.MaxValue;
            numericUpDown34.Maximum = decimal.MaxValue;
            numericUpDown35.Maximum = decimal.MaxValue;
            numericUpDown36.Maximum = decimal.MaxValue;
            numericUpDown37.Maximum = decimal.MaxValue;
            numericUpDown38.Maximum = decimal.MaxValue;


        }

        public void Main()
        {
            
            decimal payday = 0;
            decimal otherPay1 = numericUpDown8.Value;
            decimal otherPay2 = numericUpDown9.Value;
            decimal otherPay3 = numericUpDown10.Value;


            decimal dates = numericUpDown23.Value;
            decimal alcohol = numericUpDown25.Value;
            decimal drugs = numericUpDown27.Value;
            decimal cigarettes = numericUpDown28.Value;
            decimal coffee = numericUpDown26.Value;
            decimal weekendFunds = numericUpDown24.Value;

            decimal groceries = numericUpDown32.Value;

            decimal breakfast = numericUpDown29.Value;
            decimal lunch = numericUpDown31.Value;
            decimal dinner = numericUpDown33.Value;
            decimal otherFood = numericUpDown34.Value;



            decimal timeline = numericUpDown30.Value;


            decimal checking = numericUpDown11.Value;
            decimal savings = numericUpDown13.Value;
            decimal retirement = numericUpDown14.Value;
            decimal otherAccount = numericUpDown12.Value;


            decimal carLoan = numericUpDown15.Value;
            decimal carLoanInterest = numericUpDown15.Value * ((numericUpDown22.Value / 100) / 12);

            decimal homeLoan = numericUpDown17.Value;
            decimal homeLoanInterest = numericUpDown17.Value * ((numericUpDown20.Value / 100) / 12);

            decimal studentLoan = numericUpDown18.Value;
            decimal studentLoanInterest = numericUpDown18.Value * ((numericUpDown19.Value / 100) / 12);

            decimal creditCard = numericUpDown21.Value;
            decimal creditCardInterest = numericUpDown21.Value * ((numericUpDown16.Value / 100) / 12);

            decimal allotments = numericUpDown36.Value + numericUpDown35.Value + numericUpDown37.Value;


            decimal monthlyBills;

            if (comboBox1.SelectedItem == null)
            {
                payday = 0;
            }
            else if (comboBox1.SelectedItem.ToString() == "Bi-Monthly")
            {
                payday = numericUpDown7.Value * 2;

            }else if (comboBox1.SelectedItem.ToString() == "Monthly")
            {
                payday = numericUpDown7.Value;
            }
            else if (comboBox1.SelectedItem.ToString() == "Weekly")
            {
                payday = numericUpDown7.Value * 4;
            }
            else if (comboBox1.SelectedItem.ToString() == "Daily")
            {
                payday = numericUpDown7.Value * 30;
            }
            else if (comboBox1.SelectedItem.ToString() == "Yearly")
            {
                payday = numericUpDown7.Value / 12;
            }


            if (comboBox2.SelectedItem == null)
            {
                otherPay1 = 0;
            }
            else if (comboBox2.SelectedItem.ToString() == "Bi-Monthly")
            {
                otherPay1 = numericUpDown8.Value * 2;

            }
            else if (comboBox2.SelectedItem.ToString() == "Monthly")
            {
                otherPay1 = numericUpDown8.Value;
            }
            else if (comboBox2.SelectedItem.ToString() == "Weekly")
            {
                otherPay1 = numericUpDown8.Value * 4;
            }
            else if (comboBox2.SelectedItem.ToString() == "Daily")
            {
                otherPay1 = numericUpDown8.Value * 30;
            }
            else if (comboBox2.SelectedItem.ToString() == "Yearly")
            {
                otherPay1 = numericUpDown8.Value / 12;
            }


            if (comboBox3.SelectedItem == null)
            {
                otherPay2 = 0;
            }
            else if (comboBox3.SelectedItem.ToString() == "Bi-Monthly")
            {
                otherPay2 = numericUpDown9.Value * 2;

            }
            else if (comboBox3.SelectedItem.ToString() == "Monthly")
            {
                otherPay2 = numericUpDown9.Value;
            }
            else if (comboBox3.SelectedItem.ToString() == "Weekly")
            {
                otherPay2 = numericUpDown9.Value * 4;
            }
            else if (comboBox3.SelectedItem.ToString() == "Daily")
            {
                otherPay2 = numericUpDown9.Value * 30;
            }
            else if (comboBox3.SelectedItem.ToString() == "Yearly")
            {
                otherPay2 = numericUpDown9.Value / 12;
            }



            if (comboBox4.SelectedItem == null)
            {
                otherPay3 = 0;
            }
            else if (comboBox4.SelectedItem.ToString() == "Bi-Monthly")
            {
                otherPay3 = numericUpDown10.Value * 2;

            }
            else if (comboBox4.SelectedItem.ToString() == "Monthly")
            {
                otherPay3 = numericUpDown10.Value;
            }
            else if (comboBox4.SelectedItem.ToString() == "Weekly")
            {
                otherPay3 = numericUpDown10.Value * 4;
            }
            else if (comboBox4.SelectedItem.ToString() == "Daily")
            {
                otherPay3 = numericUpDown10.Value * 30;
            }
            else if (comboBox4.SelectedItem.ToString() == "Yearly")
            {
                otherPay3 = numericUpDown10.Value / 12;
            }



            if (comboBox9.SelectedItem == null)
            {
                dates = 0;
            }
            else if (comboBox9.SelectedItem.ToString() == "2 Times A Day")
            {
                dates = (numericUpDown23.Value * 30 * 2);

            }
            else if (comboBox9.SelectedItem.ToString() == "3 Times A Day")
            {
                dates = numericUpDown23.Value * 30 * 3;

            }
            else if (comboBox9.SelectedItem.ToString() == "4 Times A Day")
            {
                dates = numericUpDown23.Value * 30 * 4;

            }
            else if (comboBox9.SelectedItem.ToString() == "5 Times A Day")
            {
                dates = numericUpDown23.Value * 30 * 5;

            }
            else if (comboBox9.SelectedItem.ToString() == "6 Times A Day")
            {
                dates = numericUpDown23.Value * 30 * 6;

            }
            else if (comboBox9.SelectedItem.ToString() == "Monthly")
            {
                dates = numericUpDown23.Value;
            }
            else if (comboBox9.SelectedItem.ToString() == "Weekly")
            {
                dates = numericUpDown23.Value * 4;
            }
            else if (comboBox9.SelectedItem.ToString() == "Daily")
            {
                dates = numericUpDown23.Value * 30;
            }
            else if (comboBox9.SelectedItem.ToString() == "2 Times A Month")
            {
                dates = numericUpDown23.Value * 2;
            }
            else if (comboBox9.SelectedItem.ToString() == "3 Times A Month")
            {
                dates = numericUpDown23.Value * 3;
            }

        

            if (comboBox10.SelectedItem == null)
            {
                alcohol = 0;
            }
            else if (comboBox10.SelectedItem.ToString() == "2 Times A Day")
            {
                alcohol = numericUpDown25.Value * 30 * 2;

            }
            else if (comboBox10.SelectedItem.ToString() == "3 Times A Day")
            {
                alcohol = numericUpDown25.Value * 30 * 3;

            }
            else if (comboBox10.SelectedItem.ToString() == "4 Times A Day")
            {
                alcohol = numericUpDown25.Value * 30 * 4;

            }
            else if (comboBox10.SelectedItem.ToString() == "5 Times A Day")
            {
                alcohol = numericUpDown25.Value * 30 * 5;

            }
            else if (comboBox10.SelectedItem.ToString() == "6 Times A Day")
            {
                alcohol = numericUpDown25.Value * 30 * 6;

            }
            else if (comboBox10.SelectedItem.ToString() == "Monthly")
            {
                alcohol = numericUpDown25.Value;
            }
            else if (comboBox10.SelectedItem.ToString() == "Weekly")
            {
                alcohol = numericUpDown25.Value * 4;
            }
            else if (comboBox10.SelectedItem.ToString() == "Daily")
            {
                alcohol = numericUpDown25.Value * 30;
            }
            else if (comboBox10.SelectedItem.ToString() == "2 Times A Month")
            {
                alcohol = numericUpDown25.Value * 2;
            }
            else if (comboBox10.SelectedItem.ToString() == "3 Times A Month")
            {
                alcohol = numericUpDown25.Value * 3;
            }



            if (comboBox11.SelectedItem == null)
            {
                drugs = 0;
            }
            else if (comboBox11.SelectedItem.ToString() == "2 Times A Day")
            {
                drugs = numericUpDown27.Value * 30 * 2;

            }
            else if (comboBox11.SelectedItem.ToString() == "3 Times A Day")
            {
                drugs = numericUpDown27.Value * 30 * 3;

            }
            else if (comboBox11.SelectedItem.ToString() == "4 Times A Day")
            {
                drugs = numericUpDown27.Value * 30 * 4;

            }
            else if (comboBox11.SelectedItem.ToString() == "5 Times A Day")
            {
                drugs = numericUpDown27.Value * 30 * 5;

            }
            else if (comboBox11.SelectedItem.ToString() == "6 Times A Day")
            {
                drugs = numericUpDown27.Value * 30 * 6;

            }
            else if (comboBox11.SelectedItem.ToString() == "Monthly")
            {
                drugs = numericUpDown27.Value;
            }
            else if (comboBox11.SelectedItem.ToString() == "Weekly")
            {
                drugs = numericUpDown27.Value * 4;
            }
            else if (comboBox11.SelectedItem.ToString() == "Daily")
            {
                drugs = numericUpDown27.Value * 30;
            }
            else if (comboBox11.SelectedItem.ToString() == "2 Times A Month")
            {
                drugs = numericUpDown27.Value * 2;
            }
            else if (comboBox11.SelectedItem.ToString() == "3 Times A Month")
            {
                drugs = numericUpDown27.Value * 3;
            }


            if (comboBox12.SelectedItem == null)
            {
                cigarettes = 0;
            }
            else if (comboBox12.SelectedItem.ToString() == "2 Times A Day")
            {
                cigarettes = numericUpDown28.Value * 30 * 2;

            }
            else if (comboBox12.SelectedItem.ToString() == "3 Times A Day")
            {
                cigarettes = numericUpDown28.Value * 30 * 3;

            }
            else if (comboBox12.SelectedItem.ToString() == "4 Times A Day")
            {
                cigarettes = numericUpDown28.Value * 30 * 4;

            }
            else if (comboBox12.SelectedItem.ToString() == "5 Times A Day")
            {
                cigarettes = numericUpDown28.Value * 30 * 5;

            }
            else if (comboBox12.SelectedItem.ToString() == "6 Times A Day")
            {
                cigarettes = numericUpDown28.Value * 30 * 6;

            }
            else if (comboBox12.SelectedItem.ToString() == "Monthly")
            {
                cigarettes = numericUpDown28.Value;
            }
            else if (comboBox12.SelectedItem.ToString() == "Weekly")
            {
                cigarettes = numericUpDown28.Value * 4;
            }
            else if (comboBox12.SelectedItem.ToString() == "Daily")
            {
                cigarettes = numericUpDown28.Value * 30;
            }
            else if (comboBox12.SelectedItem.ToString() == "2 Times A Month")
            {
                cigarettes = numericUpDown28.Value * 2;
            }
            else if (comboBox12.SelectedItem.ToString() == "3 Times A Month")
            {
                cigarettes = numericUpDown28.Value * 3;
            }


            if (comboBox13.SelectedItem == null)
            {
                coffee = 0;
            }
            else if (comboBox13.SelectedItem.ToString() == "2 Times A Day")
            {
                coffee = numericUpDown26.Value * 30 * 2;

            }
            else if (comboBox13.SelectedItem.ToString() == "3 Times A Day")
            {
                coffee = numericUpDown26.Value * 30 * 3;

            }
            else if (comboBox13.SelectedItem.ToString() == "4 Times A Day")
            {
                coffee = numericUpDown26.Value * 30 * 4;

            }
            else if (comboBox13.SelectedItem.ToString() == "5 Times A Day")
            {
                coffee = numericUpDown26.Value * 30 * 5;

            }
            else if (comboBox13.SelectedItem.ToString() == "6 Times A Day")
            {
                coffee = numericUpDown26.Value * 30 * 6;

            }
            else if (comboBox13.SelectedItem.ToString() == "Monthly")
            {
                coffee = numericUpDown26.Value;
            }
            else if (comboBox13.SelectedItem.ToString() == "Weekly")
            {
                coffee = numericUpDown26.Value * 4;
            }
            else if (comboBox13.SelectedItem.ToString() == "Daily")
            {
                coffee = numericUpDown26.Value * 30;
            }
            else if (comboBox13.SelectedItem.ToString() == "2 Times A Month")
            {
                coffee = numericUpDown26.Value * 2;
            }
            else if (comboBox13.SelectedItem.ToString() == "3 Times A Month")
            {
                coffee = numericUpDown26.Value * 3;
            }



            if (comboBox14.SelectedItem == null)
            {
                weekendFunds = 0;
            }
            else if (comboBox14.SelectedItem.ToString() == "2 Times A Day")
            {
                weekendFunds = numericUpDown24.Value * 30 * 2;

            }
            else if (comboBox14.SelectedItem.ToString() == "3 Times A Day")
            {
                weekendFunds = numericUpDown24.Value * 30 * 3;

            }
            else if (comboBox14.SelectedItem.ToString() == "4 Times A Day")
            {
                weekendFunds = numericUpDown24.Value * 30 * 4;

            }
            else if (comboBox14.SelectedItem.ToString() == "5 Times A Day")
            {
                weekendFunds = numericUpDown24.Value * 30 * 5;

            }
            else if (comboBox14.SelectedItem.ToString() == "6 Times A Day")
            {
                weekendFunds = numericUpDown24.Value * 30 * 6;

            }
            else if (comboBox14.SelectedItem.ToString() == "Monthly")
            {
                weekendFunds = numericUpDown24.Value;
            }
            else if (comboBox14.SelectedItem.ToString() == "Weekly")
            {
                weekendFunds = numericUpDown24.Value * 4;
            }
            else if (comboBox14.SelectedItem.ToString() == "Daily")
            {
                weekendFunds = numericUpDown24.Value * 30;
            }
            else if (comboBox14.SelectedItem.ToString() == "2 Times A Month")
            {
                weekendFunds = numericUpDown24.Value * 2;
            }
            else if (comboBox14.SelectedItem.ToString() == "3 Times A Month")
            {
                weekendFunds = numericUpDown24.Value * 3;
            }


            if (comboBox15.SelectedItem == null)
            {
                groceries = 0;
            }
            else if (comboBox15.SelectedItem.ToString() == "Bi-Monthly")
            {
                groceries = numericUpDown32.Value * 2;

            }
            else if (comboBox15.SelectedItem.ToString() == "Monthly")
            {
                groceries = numericUpDown32.Value;
            }
            else if (comboBox15.SelectedItem.ToString() == "Weekly")
            {
                groceries = numericUpDown32.Value * 4;
            }
            else if (comboBox15.SelectedItem.ToString() == "Daily")
            {
                groceries = numericUpDown32.Value * 30;
            }
            else if (comboBox15.SelectedItem.ToString() == "Yearly")
            {
                groceries = numericUpDown32.Value / 12;
            }



            if (comboBox5.SelectedItem == null)
            {
                breakfast = 0;
            }
            else if (comboBox5.SelectedItem.ToString() == "2 Times A Day")
            {
                breakfast = numericUpDown29.Value * 30 * 2;

            }
            else if (comboBox5.SelectedItem.ToString() == "3 Times A Day")
            {
                breakfast = numericUpDown29.Value * 30 * 3;

            }
            else if (comboBox5.SelectedItem.ToString() == "4 Times A Day")
            {
                breakfast = numericUpDown29.Value * 30 * 4;

            }
            else if (comboBox5.SelectedItem.ToString() == "5 Times A Day")
            {
                breakfast = numericUpDown29.Value * 30 * 5;

            }
            else if (comboBox5.SelectedItem.ToString() == "6 Times A Day")
            {
                breakfast = numericUpDown29.Value * 30 * 6;

            }
            else if (comboBox5.SelectedItem.ToString() == "Monthly")
            {
                breakfast = numericUpDown29.Value;
            }
            else if (comboBox5.SelectedItem.ToString() == "Weekly")
            {
                breakfast = numericUpDown29.Value * 4;
            }
            else if (comboBox5.SelectedItem.ToString() == "Daily")
            {
                breakfast = numericUpDown29.Value * 30;
            }
            else if (comboBox5.SelectedItem.ToString() == "2 Times A Month")
            {
                breakfast = numericUpDown29.Value * 2;
            }
            else if (comboBox5.SelectedItem.ToString() == "3 Times A Month")
            {
                breakfast = numericUpDown29.Value * 3;
            }



            if (comboBox6.SelectedItem == null)
            {
                lunch = 0;
            }
            else if (comboBox6.SelectedItem.ToString() == "2 Times A Day")
            {
                lunch = numericUpDown31.Value * 30 * 2;

            }
            else if (comboBox6.SelectedItem.ToString() == "3 Times A Day")
            {
                lunch = numericUpDown31.Value * 30 * 3;

            }
            else if (comboBox6.SelectedItem.ToString() == "4 Times A Day")
            {
                lunch = numericUpDown31.Value * 30 * 4;

            }
            else if (comboBox6.SelectedItem.ToString() == "5 Times A Day")
            {
                lunch = numericUpDown31.Value * 30 * 5;

            }
            else if (comboBox6.SelectedItem.ToString() == "6 Times A Day")
            {
                lunch = numericUpDown31.Value * 30 * 6;

            }
            else if (comboBox6.SelectedItem.ToString() == "Monthly")
            {
                lunch = numericUpDown31.Value;
            }
            else if (comboBox6.SelectedItem.ToString() == "Weekly")
            {
                lunch = numericUpDown31.Value * 4;
            }
            else if (comboBox6.SelectedItem.ToString() == "Daily")
            {
                lunch = numericUpDown31.Value * 30;
            }
            else if (comboBox6.SelectedItem.ToString() == "2 Times A Month")
            {
                lunch = numericUpDown31.Value * 2;
            }
            else if (comboBox6.SelectedItem.ToString() == "3 Times A Month")
            {
                lunch = numericUpDown31.Value * 3;
            }



            if (comboBox7.SelectedItem == null)
            {
                dinner = 0;
            }
            else if (comboBox7.SelectedItem.ToString() == "2 Times A Day")
            {
                dinner = numericUpDown33.Value * 30 * 2;

            }
            else if (comboBox7.SelectedItem.ToString() == "3 Times A Day")
            {
                dinner = numericUpDown33.Value * 30 * 3;

            }
            else if (comboBox7.SelectedItem.ToString() == "4 Times A Day")
            {
                dinner = numericUpDown33.Value * 30 * 4;

            }
            else if (comboBox7.SelectedItem.ToString() == "5 Times A Day")
            {
                dinner = numericUpDown33.Value * 30 * 5;

            }
            else if (comboBox7.SelectedItem.ToString() == "6 Times A Day")
            {
                dinner = numericUpDown33.Value * 30 * 6;

            }
            else if (comboBox7.SelectedItem.ToString() == "Monthly")
            {
                dinner = numericUpDown33.Value;
            }
            else if (comboBox7.SelectedItem.ToString() == "Weekly")
            {
                dinner = numericUpDown33.Value * 4;
            }
            else if (comboBox7.SelectedItem.ToString() == "Daily")
            {
                dinner = numericUpDown33.Value * 30;
            }
            else if (comboBox7.SelectedItem.ToString() == "2 Times A Month")
            {
                dinner = numericUpDown33.Value * 2;
            }
            else if (comboBox7.SelectedItem.ToString() == "3 Times A Month")
            {
                dinner = numericUpDown33.Value * 3;
            }



            if (comboBox8.SelectedItem == null)
            {
                otherFood = 0;
            }
            else if (comboBox8.SelectedItem.ToString() == "2 Times A Day")
            {
                otherFood = numericUpDown34.Value * 30 * 2;

            }
            else if (comboBox8.SelectedItem.ToString() == "3 Times A Day")
            {
                otherFood = numericUpDown34.Value * 30 * 3;

            }
            else if (comboBox8.SelectedItem.ToString() == "4 Times A Day")
            {
                otherFood = numericUpDown34.Value * 30 * 4;

            }
            else if (comboBox8.SelectedItem.ToString() == "5 Times A Day")
            {
                otherFood = numericUpDown34.Value * 30 * 5;

            }
            else if (comboBox8.SelectedItem.ToString() == "6 Times A Day")
            {
                otherFood = numericUpDown34.Value * 30 * 6;

            }
            else if (comboBox8.SelectedItem.ToString() == "Monthly")
            {
                otherFood = numericUpDown34.Value;
            }
            else if (comboBox8.SelectedItem.ToString() == "Weekly")
            {
                otherFood = numericUpDown34.Value * 4;
            }
            else if (comboBox8.SelectedItem.ToString() == "Daily")
            {
                otherFood = numericUpDown34.Value * 30;
            }
            else if (comboBox8.SelectedItem.ToString() == "2 Times A Month")
            {
                otherFood = numericUpDown34.Value * 2;
            }
            else if (comboBox8.SelectedItem.ToString() == "3 Times A Month")
            {
                otherFood = numericUpDown34.Value * 3;
            }


            monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;





            /////Chart Math/////

            this.chart1.Series.Clear();
            this.chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            Series s1 = this.chart1.Series.Add("Checking");
            s1.ChartType = SeriesChartType.Spline;

            Series s2 = this.chart1.Series.Add("Savings");
            s2.ChartType = SeriesChartType.Spline;

            Series s3 = this.chart1.Series.Add("Retirement");
            s3.ChartType = SeriesChartType.Spline;

            Series s4 = this.chart1.Series.Add("Other Account");
            s4.ChartType = SeriesChartType.Spline;

            Series s5 = this.chart1.Series.Add("Car Loan");
            s5.ChartType = SeriesChartType.Spline;

            Series s6 = this.chart1.Series.Add("Home Loan");
            s6.ChartType = SeriesChartType.Spline;

            Series s7 = this.chart1.Series.Add("Student Loan");
            s7.ChartType = SeriesChartType.Spline;

            Series s8 = this.chart1.Series.Add("Credit Card Balance");
            s8.ChartType = SeriesChartType.Spline;


            for (decimal months = 0; months <= timeline; months++)
            {
                if (months == 0)
                {
                    s2.Points.AddXY("Month" + months, savings);
                    textBox1.Text = savings.ToString();
                } else
                {
                    s2.Points.AddXY("Month" + months, savings + numericUpDown36.Value);
                    savings = savings + numericUpDown36.Value;
                    textBox1.Text = savings.ToString();
                }
            }

            for (decimal months = 0; months <= timeline; months++)
            {
                if (months == 0)
                {
                    s3.Points.AddXY("Month" + months, retirement);
                    textBox2.Text = retirement.ToString();
                }
                else
                {

                    s3.Points.AddXY("Month" + months, retirement + numericUpDown35.Value);
                    retirement = retirement + numericUpDown35.Value;
                    textBox2.Text = retirement.ToString();
                }
            }

            for (decimal months = 0; months <= timeline; months++)
            {
                if (months == 0)
                {
                    s4.Points.AddXY("Month" + months, otherAccount);
                    textBox3.Text = otherAccount.ToString();
                }
                else
                { 
                    s4.Points.AddXY("Month" + months, otherAccount + numericUpDown37.Value);
                    otherAccount = otherAccount + numericUpDown37.Value;
                    textBox3.Text = otherAccount.ToString();
                }
                }



            for (decimal months = 0; months <= timeline; months++)
            {
                if (months == 0)
                {

                    s5.Points.AddXY("Month" + months, carLoan);
                    textBox4.Text = carLoan.ToString();
                    carLoan = carLoan + (carLoanInterest - numericUpDown1.Value);

                    s6.Points.AddXY("Month" + months, homeLoan);
                    textBox5.Text = homeLoan.ToString();
                    homeLoan = homeLoan + (homeLoanInterest - numericUpDown38.Value);

                    s7.Points.AddXY("Month" + months, studentLoan);
                    textBox6.Text = studentLoan.ToString();
                    studentLoan = studentLoan + (studentLoanInterest - numericUpDown4.Value);

                    s8.Points.AddXY("Month" + months, creditCard);
                    textBox7.Text = creditCard.ToString();
                    creditCard = creditCard + (creditCardInterest - numericUpDown6.Value);

                    s1.Points.AddXY("Month" + months, checking);
                    textBox8.Text = checking.ToString();
                }
                else
                {
                    if (carLoan < 1 && homeLoan < 1 && studentLoan < 1 && creditCard < 1)
                    {
                        monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;

                        carLoan = 0;
                        s5.Points.AddXY("Month" + months, 0);

                        homeLoan = 0;
                        s6.Points.AddXY("Month" + months, 0);

                        studentLoan = 0;
                        s7.Points.AddXY("Month" + months, 0);

                        creditCard = 0;
                        s8.Points.AddXY("Month" + months, 0);

                        s1.Points.AddXY("Month" + months, checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown4.Value + numericUpDown6.Value + numericUpDown38.Value);
                        checking = checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown4.Value + numericUpDown6.Value + numericUpDown38.Value;

                        textBox4.Text = carLoan.ToString();
                        textBox5.Text = homeLoan.ToString();
                        textBox6.Text = studentLoan.ToString();
                        textBox7.Text = creditCard.ToString();
                        textBox8.Text = checking.ToString();


                    }
                    else if (carLoan < 1 && homeLoan < 1 && studentLoan < 1 && creditCard >= 1)
                    {
                        monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;


                        carLoan = 0;
                        s5.Points.AddXY("Month" + months, 0);

                        homeLoan = 0;
                        s6.Points.AddXY("Month" + months, 0);

                        studentLoan = 0;
                        s7.Points.AddXY("Month" + months, 0);

                        s8.Points.AddXY("Month" + months, creditCard);
                        textBox7.Text = creditCard.ToString();
                        creditCard = creditCard + (creditCardInterest - numericUpDown6.Value);

                        s1.Points.AddXY("Month" + months, checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown4.Value + numericUpDown38.Value);
                        checking = checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown4.Value + numericUpDown38.Value;
                        textBox8.Text = checking.ToString();

                        textBox4.Text = carLoan.ToString();
                        textBox5.Text = homeLoan.ToString();
                        textBox6.Text = studentLoan.ToString();

                    }
                    else if (carLoan < 1 && homeLoan < 1 && studentLoan >= 1 && creditCard >= 1)
                    {
                        monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;


                        carLoan = 0;
                        s5.Points.AddXY("Month" + months, 0);

                        homeLoan = 0;
                        s6.Points.AddXY("Month" + months, 0);

                        s7.Points.AddXY("Month" + months, studentLoan);
                        textBox6.Text = studentLoan.ToString();
                        studentLoan = studentLoan + (studentLoanInterest - numericUpDown4.Value);

                        s8.Points.AddXY("Month" + months, creditCard);
                        textBox7.Text = creditCard.ToString();
                        creditCard = creditCard + (creditCardInterest - numericUpDown6.Value);

                        s1.Points.AddXY("Month" + months, checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown38.Value);
                        checking = checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value + numericUpDown38.Value;
                        textBox8.Text = checking.ToString();
                        textBox4.Text = carLoan.ToString();
                        textBox5.Text = homeLoan.ToString();

                    }
                    else if (carLoan < 1 && homeLoan >= 1 && studentLoan >= 1 && creditCard >= 1)
                    {
                        monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;


                        carLoan = 0;
                        s5.Points.AddXY("Month" + months, 0);

                        s6.Points.AddXY("Month" + months, homeLoan);
                        textBox5.Text = homeLoan.ToString();
                        homeLoan = homeLoan + (homeLoanInterest - numericUpDown38.Value);

                        s7.Points.AddXY("Month" + months, studentLoan);
                        textBox6.Text = studentLoan.ToString();
                        studentLoan = studentLoan + (studentLoanInterest - numericUpDown4.Value);

                        s8.Points.AddXY("Month" + months, creditCard);
                        textBox7.Text = creditCard.ToString();
                        creditCard = creditCard + (creditCardInterest - numericUpDown6.Value);

                        s1.Points.AddXY("Month" + months, checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value);
                        checking = checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments + numericUpDown1.Value;
                        textBox8.Text = checking.ToString();
                        textBox4.Text = carLoan.ToString();


                    }
                    else
                    {
                        monthlyBills = numericUpDown1.Value + numericUpDown2.Value + numericUpDown3.Value + numericUpDown4.Value + numericUpDown5.Value + numericUpDown6.Value + numericUpDown38.Value + dates + alcohol + drugs + cigarettes + coffee + weekendFunds + groceries + breakfast + lunch + dinner + otherFood;


                        s5.Points.AddXY("Month" + months, carLoan);
                        textBox4.Text = carLoan.ToString();
                        carLoan = carLoan + (carLoanInterest - numericUpDown1.Value);

                        s6.Points.AddXY("Month" + months, homeLoan);
                        textBox5.Text = homeLoan.ToString();
                        homeLoan = homeLoan + (homeLoanInterest - numericUpDown38.Value);

                        s7.Points.AddXY("Month" + months, studentLoan);
                        textBox6.Text = studentLoan.ToString();
                        studentLoan = studentLoan + (studentLoanInterest - numericUpDown4.Value);

                        s8.Points.AddXY("Month" + months, creditCard);
                        textBox7.Text = creditCard.ToString();
                        creditCard = creditCard + (creditCardInterest - numericUpDown6.Value);


                        s1.Points.AddXY("Month" + months, checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments);
                        checking = checking + payday + otherPay1 + otherPay2 + otherPay3 - monthlyBills - allotments;
                        textBox8.Text = checking.ToString();







                    }
                }

            } 

        }


        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Main();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox9.SelectedItem = "Monthly";
            comboBox8.SelectedItem = "Monthly";
            comboBox7.SelectedItem = "Monthly";
            comboBox6.SelectedItem = "Monthly";
            comboBox5.SelectedItem = "Monthly";
            comboBox15.SelectedItem = "Monthly";
            comboBox14.SelectedItem = "Monthly";
            comboBox13.SelectedItem = "Monthly";
            comboBox12.SelectedItem = "Monthly";
            comboBox11.SelectedItem = "Monthly";
            comboBox10.SelectedItem = "Monthly";
        }
    }

}
