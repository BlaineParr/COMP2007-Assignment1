using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_Assignment1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void SummaryButton_Click(object sender, EventArgs e)
        {
            //local variables
            bool error = false;
            RadioButtonList[] radioButtonLists = {ResultRadioButtonList1, ResultRadioButtonList2, ResultRadioButtonList3, ResultRadioButtonList4};
            int listNum = 0;
            TextBox[] textBoxes = { PointsScoredTextBox1, PointsAllowedTextBox1, SpectatorsTextBox1, PointsScoredTextBox2, PointsAllowedTextBox2, SpectatorsTextBox2, PointsScoredTextBox3, PointsAllowedTextBox3, SpectatorsTextBox3, PointsScoredTextBox4, PointsAllowedTextBox4, SpectatorsTextBox4};
            int gamesWon = 0, gamesLost = 0, totalPointsScored = 0, totalPointsAllowed = 0, totalSpectators = 0;

            //all checks nested in a try block, to prevent any errors from crashing the application
            try
            {
                //for loop to make sure each RadioButtonList has an option selected
                for (int i = 0; i < radioButtonLists.Length; i++)
                {
                    //if nothing has been selected set error to true
                    if (radioButtonLists[i].SelectedIndex == -1)
                    {
                        error = true;
                    } //if ends
                } //for ends

                //for loop to ensure each textbox is not empty
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    //if any of the textboxes are empty set error to true
                    if (textBoxes[i].Text == "")
                    {
                        error = true;
                    } //if ends

                    //if any of the textboxes are negative set error to true
                    if (int.Parse(textBoxes[i].Text) < 0)
                    {
                        error = true;
                    } //if ends
                } //for ends

                //for loop to check the points scored and allowed text boxes with their respective
                //result
                for (int i = 0; i < textBoxes.Length; i += 3)
                {
                    //if the user has selected win...
                    if (radioButtonLists[listNum].SelectedIndex == 0)
                    {
                        //if the points scored is less than points allowed set error to true
                        if (int.Parse(textBoxes[i].Text) < int.Parse(textBoxes[i + 1].Text))
                        {
                            error = true;
                        } //if ends
                    } //if ends
                    //if the user has selected lose...
                    else if (radioButtonLists[listNum].SelectedIndex == 1)
                    {
                        //if the points scored is more than points allowed set error to true
                        if (int.Parse(textBoxes[i].Text) > int.Parse(textBoxes[i + 1].Text))
                        {
                            error = true;
                        } //if ends
                    } //else if ends

                    //ensure the points scored and points allowed are not the same
                    if (textBoxes[i].Text == textBoxes[i + 1].Text)
                    {
                        error = true;
                    } //if ends

                    listNum++;
                } //for ends
            } //try ends

            //catch any format exceptions, overflow exceptions and general exceptions
            catch(FormatException)
            {
                error = true;
            } //catch ends
            catch(OverflowException)
            {
                error = true;
            } //catch ends
            catch(Exception)
            {
                error = true;
            } //catch ends

            //if there were no errors perform the calculations
            if(!error)
            {
                //for loop to count how many games were won and lost
                for (int i = 0; i < radioButtonLists.Length; i++)
                {
                    if(radioButtonLists[i].SelectedIndex == 0)
                    {
                        gamesWon++;
                    } //if ends
                    else
                    {
                        gamesLost++;
                    } //else ends
                } //for ends

                //print out games won, games lost and win percentage
                GamesWonOutputLabel.Text = "Games Won: " + gamesWon.ToString();
                GamesLostOutputLabel.Text = "Games Lost: " + gamesLost.ToString();
                WinPercentageOutputLabel.Text = "Win Percentage: " + ((float)gamesWon / 4).ToString();

                //count total points scored and allowed
                totalPointsScored = int.Parse(textBoxes[0].Text) + int.Parse(textBoxes[3].Text) + int.Parse(textBoxes[6].Text) + int.Parse(textBoxes[9].Text);
                totalPointsAllowed = int.Parse(textBoxes[1].Text) + int.Parse(textBoxes[4].Text) + int.Parse(textBoxes[7].Text) + int.Parse(textBoxes[10].Text);

                //print out total points scored, allowed and the point differential
                TotalPointsScoredOutputLabel.Text = "Total Points Scored: " + totalPointsAllowed.ToString();
                TotalPointsAllowedOutputLabel.Text = "Total Points Allowed: " + totalPointsAllowed.ToString();
                PointDifferentialOutputLabel.Text = "Point Differential: " + (totalPointsScored - totalPointsAllowed).ToString();

                //count total spectators
                totalSpectators = int.Parse(textBoxes[2].Text) + int.Parse(textBoxes[5].Text) + int.Parse(textBoxes[8].Text) + int.Parse(textBoxes[11].Text);

                //print out total and average spectators
                TotalSpectatorsOutputLabel.Text = "Total Spectators: " + totalSpectators.ToString();
                AverageSpectatorsLabel.Text = "Average Spectators: " + ((float)totalSpectators / 4).ToString();
            } //if ends
        } //method SummaryButton_Click ends

        protected void Button1_Click(object sender, EventArgs e)
        {
            RadioButtonList[] radioButtonLists = { ResultRadioButtonList1, ResultRadioButtonList2, ResultRadioButtonList3, ResultRadioButtonList4 };
            TextBox[] textBoxes = { PointsScoredTextBox1, PointsAllowedTextBox1, SpectatorsTextBox1, PointsScoredTextBox2, PointsAllowedTextBox2, SpectatorsTextBox2, PointsScoredTextBox3, PointsAllowedTextBox3, SpectatorsTextBox3, PointsScoredTextBox4, PointsAllowedTextBox4, SpectatorsTextBox4 };
            bool odd = true;
            for (int i = 0; i < radioButtonLists.Length; i++)
            {
                if (odd)
                {
                    radioButtonLists[i].SelectedIndex = 0;
                    odd = false;
                }
                else
                {
                    radioButtonLists[i].SelectedIndex = 1;
                    odd = true;
                }
            }
            for (int i = 0; i < textBoxes.Length; i++)
            {
                if (odd)
                {
                    textBoxes[i].Text = "9";
                    odd = false;
                }
                else
                {
                    textBoxes[i].Text = "8";
                    odd = true;
                }
            }
        } //method Button1_Click ends
    } //class default ends
} //namespace COMP2007_Assignment1 ends