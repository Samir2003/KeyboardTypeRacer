using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Name: Samir Ali
//Date: June 11, 2020
//Assignment: Final Assessment (CPT)
//Purpose: To improve the user's typing skills with multiple words that must be inputted.
namespace KeyboardTypeRacer
{
    public partial class KeyboardTyper : Form
    {
        public static int correct = 0;
        public static string[] fruits = new string[] {"Apple", "Apricot", "Avocado", "Banana", "Blackberry", "Blackcurrant", "Blueberry", "Boysenberry", "Cherry", "Coconut", "Fig", "Grape", "Grapefruit", "Kiwifruit", "Lemon", "Lime", "Lychee",
                                                      "Mandarin", "Mango","Melon", "Nectarine","Orange", "Papaya","Passionfruit", "Peach","Pear", "Pineapple","Plum", "Pomegranate","Quince", "Raspberry","Strawberry", "Watermelon"}; //string array containing all words that are fruits
        public static string[] vegetables = new string[] {"Asparagus", "Avocado", "Bean", "Beetroot", "Bok choy", "Broccoli", "Brussels sprouts", "Cabbage", "Capsicum", "Carrot", "Cauliflower", "Celery", "Corn", "Cucumber", "Eggplant", "Lettuce", "Mushroom" //string array containing all words that are vegetables
                                                          , "Onion", "Parsnip", "Peas", "Potato", "Pumpkin", "Radish", "Spinach", "Squash", "Turnip", "Zucchini "};
        public static Random random = new Random();
        public static int wordfruit;
        public static int wordveg;
        public static double time;
        public static double Wrong;
        public static double Right;
        public static double Attempt;
        public static double accuracy;
        public static double wpm;
        public static DateTime date = DateTime.Now; //assigns the variable date the date and time that the program is launched
        public static DirectoryInfo Result; //creates the variable Result with the data type DirectoryInfo to indicate the name of the directory
        public static int determine;
        public static List<int> listwordsfruit = new List<int>(); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
        public static List<int> listwordsvegetables = new List<int>(); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
        public KeyboardTyper()
        {
            InitializeComponent();
            txtInput.Visible = false; //makes the textbox and other controls invisible
            lblWord.Visible = false;
            btnNext.Visible = false;
            wordfruit = random.Next(0, 33); // randomizes the variable wordfruit between a number from 0-33
            listwordsfruit.Add(wordfruit);
            wordveg = random.Next(0, 23); // randomizes the variable wordveg between a number from 0-23
            listwordsvegetables.Add(wordveg);
            btnDone.Visible = false; 
            btnStore.Visible = false;
            lblWarning.Visible = false;
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //checks to see if the key enter is pressed
            {
                btnNext.PerformClick(); //a click on the next button is mimicked when the enter key is pressed
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnDone.Visible = true; //the done button becomes visible when the next button is clicked
            if (determine == 1) //if button fruits is clicked then the steps for fruits will be executed
            {


                if (txtInput.Text == fruits[wordfruit]) //If the word's spelling matches the user's input
                {
                    lblResult.Text = "Keep it up!";
                    if (listwordsfruit.Count <= 32)
                    {
                        do
                        {
                            wordfruit = random.Next(0, 33); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                        }
                        while (listwordsfruit.Contains(wordfruit));
                    } //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                    else if (listwordsfruit.Count >= 33)
                    {
                        wordfruit = random.Next(0, 33);
                    }
                    listwordsfruit.Add(wordfruit); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                    lblWord.Text = fruits[wordfruit]; //the label displays the new word
                    txtInput.Clear(); //the text box is cleared for the next word
                    Attempt += 1; //One is added to the attempt variable every time a word is attempted
                    Right += 1; //The variable right is added by 1 if the word matches user's input
                }
                else
                {
                    lblResult.Text = "Try Again!"; //letting the user know to try again
                    txtInput.Clear();
                    Wrong += 1; //adding one to the wrong variable if the answer is wrong
                    Attempt += 1;
                }
            }
            else if(determine == 2) //if the vegetables button is clicked then the following block of code will run
            {
                if (txtInput.Text == vegetables[wordveg])
                {
                    lblResult.Text = "Keep it up!";
                    if (listwordsvegetables.Count <= 21)
                    {
                        do
                        {
                            wordveg = random.Next(0, 23); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                        }
                        while (listwordsvegetables.Contains(wordveg));
                    } //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                    else if (listwordsvegetables.Count >= 22)
                    {
                        wordveg = random.Next(0, 23);
                    }
                        listwordsvegetables.Add(wordveg); //sourced from https://stackoverflow.com/questions/30014901/generating-random-numbers-without-repeating-c
                        lblWord.Text = vegetables[wordveg];
                        txtInput.Clear();
                        Attempt += 1;
                        Right += 1;
                    
                }
                else
                {
                    lblResult.Text = "Try Again!";
                    txtInput.Clear();
                    Wrong += 1;
                    Attempt += 1;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            time += 1; //the variable time is added by 1 every second
        }

        private void btnDone_Click(object sender, EventArgs e) 
        {
            accuracy = Right / Attempt * 100; //the accuracy percentage is calculated by dividing the right and the attempts times 100
            accuracy = Math.Round(accuracy, 1); //the variable accuracy is rounded to one decimal place
            double timeinMins = time / 60; //the variable timeinMins stores the value of the time elapsed in mins
            wpm = Right / timeinMins; //the variable wpm stores the value of the words per minute by dividing right and timeinmins
            wpm = Math.Round(wpm, 1);
            lblResult.Text = "Accuracy: " + accuracy.ToString() + "%" + "\n WPM = " + wpm.ToString(); //the user's results are outputted
            lblWord.Visible = false; //labels and other controls are hidden
            timer1.Enabled = false;
            btnStore.Visible = true;
            lblWarning.Visible = false;
        }

        private void timerResult_Tick(object sender, EventArgs e)
        {
            lblTime.Text = " Time in (s): " + time.ToString() + "\n Attempt:" + Attempt + "\n Correct:" + Right + "\n Incorrect:" + Wrong; // a timer is created to constantly show the results while the user is using the program
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            try
            {
                Result = Directory.CreateDirectory(@"C:\Users\computer\Downloads\Results"); //a folder is created with the name results
                if (File.Exists(@"C:\Users\computer\Downloads\Results\Results.txt")) //checks to see if a file with the name results exist
                {
                    using (StreamWriter sw = File.AppendText(@"C:\Users\computer\Downloads\Results\Results.txt")) //if a file does exist it will write to the file instead of creating a new one
                    {
                        sw.WriteLine("\n" + date.ToString() + "\nAccuracy: " + accuracy.ToString() + "%" + "\nWPM: " + wpm.ToString() + "\nTime Taken: " + time + " Seconds"); //stores results with date and time
                        MessageBox.Show("Check Results folder for results!");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(@"C:\Users\computer\Downloads\Results\Results.txt")) //if a file doesn't exist then one is created with the name results
                    {
                        sw.WriteLine("\n" + date.ToString() + "\nAccuracy: " + accuracy.ToString() + "%" + "\nWPM: " + wpm.ToString() + "\nTime Taken: " + time + " Seconds"); //stores results with date and time
                        MessageBox.Show("Check downloads folder for results!");
                    }
                }

                if (!Directory.Exists(@"C:\Users\computer\Downloads")) //checks to see if the path exists
                {
                    MessageBox.Show("Create downloads folder in path C:Users|computer|Downloads for storage"); //if the path doesn't exist, the user is asked to create one
                }
            }catch(Exception)
            {
                MessageBox.Show("Problem with storing file, Ensure Path C:|Users|computer|Downloads exists" );
            }
        }
        private void btnFruits_Click(object sender, EventArgs e)
        {
            //SETUP for the program is done by making certain controls visible and invisible 
            determine = 1;
            txtInput.Visible = true;
            btnFruits.Visible = false;
            btnVegetables.Visible = false;
            btnNext.Visible = true;
            lblWord.Text = fruits[wordfruit];
            lblWord.Visible = true;
            timer1.Enabled = true;
            timerResult.Enabled = true;
            BackgroundImage = Properties.Resources._500_F_78123835_NYa1r7I271AQWK8a5vncxlVxDcnaP0rc; //an image is loaded from resouces to become the background
            lblWarning.Visible = true;
        }

        private void btnVegetables_Click(object sender, EventArgs e)
        {
            //SETUP for the program is done by making certain controls visible and invisible 
            determine = 2;
            txtInput.Visible = true;
            btnFruits.Visible = false;
            btnVegetables.Visible = false;
            btnNext.Visible = true;
            lblWord.Text = vegetables[wordveg];
            lblWord.Visible = true;
            timer1.Enabled = true;
            timerResult.Enabled = true;
            BackgroundImage = Properties.Resources.images__1_;
            lblWarning.Visible = true;
        }
    }

}
