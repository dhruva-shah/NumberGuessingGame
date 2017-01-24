using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class WebPageSeparated : System.Web.UI.Page
{
    public static int trial, guess, r = 0;
    public static int[] guessedNo;
    public int[] score = {100, 99, 98, 97, 96 };
    public String[] names = {"a","b","c","d","e"};
    public String hs="";
    
    
    protected void Page_Load(object sender, EventArgs e)
    {
        scorewrite();
    }
    public void scorewrite()
    {
        for (int i = 0; i < score.Length; i++)
        {
            if (hs == "")
            {
                hs = names[i].ToString() + " - " + score[i].ToString();
            }
            else
            {
                hs += "<br/>"+names[i].ToString() + " - " + score[i].ToString();
            }
        }
    }

    
    protected void startGame_Click(object sender, EventArgs e)
    {
        if (nameLabel.Text.ToString() == "")
        {           
            nonameLabel.Text = "Please enter name";
            nonameLabel.Visible = true;
        }
        else
        {
            trial = 100;
            guess = 0;
            guessedNo = new int[100];

            hiLabel.Text = "Hi " + nameLabel.Text;
            Panel2.Visible = false;
            hiLabel.Visible = true;
            Panel1.Visible = true;
            trys.Text = "You have 100 trys remaining";
            trys.Visible = true;

            Random random = new Random();
            r = random.Next(1, 100);
        }
    }



    protected void numButton_Click(object sender, EventArgs e)
    {
               if (numBox.Text.ToString() == "")
                {
                    hllabel.Text = "Please enter a number";
                    hllabel.Visible = true;
                }
                else
                {
                    guess = Convert.ToInt32(numBox.Text.ToString());
                    if (guess > r) {
                        hllabel.Text = "Too high";
                        hllabel.Visible = true;
                        trial = trial - 1;
                        trys.Text = "You have "+trial+" trys remaining";

                }
                    else if (guess < r)
                    {
                        hllabel.Text = "Too low";
                        hllabel.Visible = true;
                        trial = trial - 1;
                        trys.Text = "You have " + trial + " trys remaining";
                        trys.Visible = true;
                }
                    else if (guess == r)
                    {
                        hllabel.Text = "Congratulations! You guessed it";
                        hllabel.Visible = true;
                        trys.Text = "Your score is " + trial;
                        trys.Visible = true;
                        again.Visible = true;
                hsLabel.Text = hs.ToString();
                hsLabel.Visible = true; 

                if (trial >= score[4])
                {
                    int temp = 0;
                    String tempname;
                    
                    score[4] = trial;
                    names[4] = nameLabel.Text;
                    for(int i = 0; i < (score.Length-1); i++) {
                       
                            if (score[i] > score[i + 1])
                            {
                                temp = score[i];
                                score[i] = score[i + 1];
                                score[i + 1] = temp;
                                tempname = names[i];
                                names[i] = names[i + 1];
                                names[i + 1] = tempname;
                            }
                       
                    }
                    hs = "";
                    scorewrite();
                    scorelabel.Text = "You made a highscore!";
                    scorelabel.Visible = true;
                    
                }
                

                     }
                 }
            }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel1.Visible = false;
        again.Visible = false;
        scorelabel.Visible = false;
        Panel2.Visible = true;
        hllabel.Text = "Please enter a number";
    }
    public void writeText()
    {
        string FilePath = HttpContext.Current.Request.PhysicalApplicationPath + "//Scores.txt";
        System.IO.StreamWriter file = new System.IO.StreamWriter(FilePath);
        file.WriteLine(hs.ToString());
        file.Close();
    }
    
}