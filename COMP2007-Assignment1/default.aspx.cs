using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/*
 * Title: COMP2007 Assignment 1: Game Calculator
 * Author: Blaine Parr
 * Date: June 19, 2015
 * Purpose: This application takes the user's input from a form and calculates statistics about four games that were played.
 * The application then outputs the information for the user to see.
 */
namespace COMP2007_Assignment1
{
    public partial class _default : System.Web.UI.Page
    {
        //Protected Methods//////////////////////////////////////////////////////////////////////////////////////////////////

        /*
         * This method hides the output div when the page is loaded.
         */
        protected void Page_Load(object sender, EventArgs e)
        {
            //hide the output div until we need it
            output.Visible = false;
        } //method Page_Load ends

        /*
         * This method verifies the user's input about the games and then, if the information is valid, calculates statistics
         * about the game when the summary button is clicked.
         */
        protected void SummaryButton_Click(object sender, EventArgs e)
        {
            //local variables
            bool error = false, winTriggered = false, loseTriggered=false;
            RadioButtonList[] radioButtonLists = {ResultRadioButtonList1, ResultRadioButtonList2, ResultRadioButtonList3, ResultRadioButtonList4};
            int listNum = 0;
            TextBox[] textBoxes = { PointsScoredTextBox1, PointsAllowedTextBox1, SpectatorsTextBox1, PointsScoredTextBox2, PointsAllowedTextBox2, SpectatorsTextBox2, PointsScoredTextBox3, PointsAllowedTextBox3, SpectatorsTextBox3, PointsScoredTextBox4, PointsAllowedTextBox4, SpectatorsTextBox4};
            int gamesWon = 0, gamesLost = 0, totalPointsScored = 0, totalPointsAllowed = 0, totalSpectators = 0;
            string errorMessage = "alert('";

            //all checks nested in a try block, to prevent any errors from crashing the application
            try
            {
                //for loop to make sure each RadioButtonList has an option selected
                for (int i = 0; i < radioButtonLists.Length; i++)
                {
                    //if nothing has been selected set error to true and display a message
                    if (radioButtonLists[i].SelectedIndex == -1)
                    {
                        errorMessage += "A radio button was left unselected\\n";
                        error = true;
                        break;
                    } //if ends
                } //for ends

                //for loop to ensure each textbox is not empty
                for (int i = 0; i < textBoxes.Length; i++)
                {
                    //if any of the textboxes are empty set error to true and display a message
                    if (textBoxes[i].Text == "")
                    {
                        errorMessage += "A text box was left empty\\n";
                        error = true;
                        break;
                    } //if ends

                    //if any of the textboxes are negative set error to true and display a message
                    if (int.Parse(textBoxes[i].Text) < 0)
                    {
                        errorMessage += "A negative value was entered in a text box\\n";
                        error = true;
                        break;
                    } //if ends
                } //for ends

                //for loop to check the points scored and allowed text boxes with their respective
                //result
                for (int i = 0; i < textBoxes.Length; i += 3)
                {
                    //if the user has selected win...
                    if (radioButtonLists[listNum].SelectedIndex == 0)
                    {
                        //if the points scored is less than points allowed set error to true and 
                        //display a message
                        if (int.Parse(textBoxes[i].Text) < int.Parse(textBoxes[i + 1].Text))
                        {
                            //check if winTriggered is false so we don't display the same message
                            //twice
                            if (!winTriggered)
                            {
                                errorMessage += "Win was selected for a game that was lost\\n";
                                error = true;
                                winTriggered = true; //set winTriggered to true
                            } //if ends
                        } //if ends
                    } //if ends
                    //if the user has selected lose...
                    else if (radioButtonLists[listNum].SelectedIndex == 1)
                    {
                        //if the points scored is more than points allowed set error to true and 
                        //display a message
                        if (int.Parse(textBoxes[i].Text) > int.Parse(textBoxes[i + 1].Text))
                        {
                            //check if loseTriggered is false so we don't display the same message
                            //twice
                            if (!loseTriggered)
                            {
                                errorMessage += "Lose was selected for a game that was won\\n";
                                error = true;
                                loseTriggered = true; //set loseTriggered to true
                            } //if ends
                        } //if ends
                    } //else if ends

                    //if points scored and points allowed are the same set errot to true and 
                    //display a message
                    if (int.Parse(textBoxes[i].Text) == int.Parse(textBoxes[i + 1].Text))
                    {
                        errorMessage += "Points scored and points allowed cannot be the same\\n";
                        error = true;
                    } //if ends

                    //increment listNum
                    listNum++;
                } //for ends
            } //try ends

            //catch any format exceptions, overflow exceptions and general exceptions setting error
            //error to true and displaying a message if any occur
            catch (FormatException)
            {
                errorMessage += "A non-integer value was entered in a text box\\n";
                error = true;
            } //catch ends
            catch (OverflowException)
            {
                errorMessage += "Too many digits were entered in a text box\\n";
                error = true;
            } //catch ends
            catch (Exception)
            {
                errorMessage += "An error occured\\n";
                error = true;
            } //catch ends

            //close errorMessage's bracket
            errorMessage += "');";

            //if there were no errors perform the calculations
            if(!error)
            {
                //set the output div to be visible
                output.Visible = true;

                //add the styling for the outputdiv
                output.Attributes["class"] = "output";

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
                TotalPointsScoredOutputLabel.Text = "Total Points Scored: " + totalPointsScored.ToString();
                TotalPointsAllowedOutputLabel.Text = "Total Points Allowed: " + totalPointsAllowed.ToString();
                PointDifferentialOutputLabel.Text = "Point Differential: " + (totalPointsScored - totalPointsAllowed).ToString();

                //count total spectators
                totalSpectators = int.Parse(textBoxes[2].Text) + int.Parse(textBoxes[5].Text) + int.Parse(textBoxes[8].Text) + int.Parse(textBoxes[11].Text);

                //print out total and average spectators
                TotalSpectatorsOutputLabel.Text = "Total Spectators: " + totalSpectators.ToString();
                AverageSpectatorsLabel.Text = "Average Spectators: " + ((float)totalSpectators / 4).ToString();
            } //if ends
            //else if there were errors, display all error messages and clear the output
            else
            {
                clearOutput();
                ClientScript.RegisterStartupScript(GetType(), "hwa", errorMessage, true);
            } //else ends
        } //method SummaryButton_Click ends

        /*
         * This method clears the form when the clear button is clicked.
         */
        protected void ClearButton_Click(object sender, EventArgs e)
        {
            //local variables
            RadioButtonList[] radioButtonLists = { ResultRadioButtonList1, ResultRadioButtonList2, ResultRadioButtonList3, ResultRadioButtonList4 };
            TextBox[] textBoxes = { PointsScoredTextBox1, PointsAllowedTextBox1, SpectatorsTextBox1, PointsScoredTextBox2, PointsAllowedTextBox2, SpectatorsTextBox2, PointsScoredTextBox3, PointsAllowedTextBox3, SpectatorsTextBox3, PointsScoredTextBox4, PointsAllowedTextBox4, SpectatorsTextBox4 };

            //for loop to reset all of the radioButtons
            for(int i = 0; i < radioButtonLists.Length; i++)
            {
                radioButtonLists[i].SelectedIndex = -1;
            } //for ends

            //for loop to reset all of the textBoxes
            for(int i = 0; i < textBoxes.Length; i++)
            {
                textBoxes[i].Text = "";
            } //for ends

            //call clearOuput
            clearOutput();
        } //method ClearButton_Click ends

        /*
         * This method clears the output section of the form and hides the output div.
         */
        protected void clearOutput()
        {
            //hide the output div
            output.Visible = false;

            //set all of the output labels to be blank
            GamesWonOutputLabel.Text = "";
            GamesLostOutputLabel.Text = "";
            WinPercentageOutputLabel.Text = "";
            TotalPointsScoredOutputLabel.Text = "";
            TotalPointsAllowedOutputLabel.Text = "";
            PointDifferentialOutputLabel.Text = "";
            TotalSpectatorsOutputLabel.Text = "";
            AverageSpectatorsLabel.Text = "";
        } //method clearOutput ends
    } //class default ends
} //namespace COMP2007_Assignment1 ends