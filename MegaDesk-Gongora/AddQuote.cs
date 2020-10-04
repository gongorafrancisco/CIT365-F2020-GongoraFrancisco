using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Gongora
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }
        public static string customerName;
        public static int deskWidth;
        public static int deskDepth;
        public static int noOfDrawers;
        public static string deskMaterial;
        public static int productionDays;

        private void ExitAddQuoteFormBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenuForm = (MainMenu)Tag;
            viewMainMenuForm.Show();
            Close();
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!ValidIntegerWidth(WidthInput.Text, out errorMessage))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                WidthInput.Select(0, WidthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(WidthInput, errorMessage);
            }
        }

        private void WidthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider1.SetError(WidthInput, "");
        }

        public bool ValidIntegerWidth(string userInput, out string errorMessage)
        {
            int result;
            // Check that the input string is not empty
            if (userInput.Length == 0)
            {
                errorMessage = "Width size is needed";
            }
            try
            {
                result = int.Parse(userInput);
                if (result < Desk.MIN_WIDTH || result > Desk.MAX_WIDTH)
                {
                    errorMessage = $"Width size must be a valid integer between {Desk.MIN_WIDTH}, and {Desk.MAX_WIDTH}";
                    return false;
                } 
                else
                {
                    errorMessage = "";
                    return true;
                }
            }
            catch (FormatException)
            {
                errorMessage = $"Width size must be a valid integer between {Desk.MIN_WIDTH}, and {Desk.MAX_WIDTH}";
                return false;
            }
           
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            string errorMessage;
            if (!ValidIntegerDepth(DepthInput.Text, out errorMessage))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                DepthInput.Select(0, DepthInput.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider2.SetError(DepthInput, errorMessage);
            }
        }

        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ((char)(Keys.Enter)) && (e.KeyChar != (char)(Keys.Delete) || e.KeyChar == Char.Parse(".")) && e.KeyChar != (char)(Keys.Back))
            {
                e.Handled = true;
            }
            else
            {

            }

        }

        private void DepthInput_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            errorProvider2.SetError(DepthInput, "");
        }

        public bool ValidIntegerDepth(string userInput, out string errorMessage)
        {
            int result;
            // Check that the input string is not empty
            if (userInput.Length == 0)
            {
                errorMessage = "Depth size is needed";
            }
            try
            {
                result = int.Parse(userInput);
                if (result < Desk.MIN_DEPTH || result > Desk.MAX_DEPTH)
                {
                    errorMessage = $"Depth size must be a valid integer between {Desk.MIN_DEPTH}, and {Desk.MAX_DEPTH}";
                    return false;
                }
                else
                {
                    errorMessage = "";
                    return true;
                }
            }
            catch (FormatException)
            {
                errorMessage = $"Depth size must be a valid integer between {Desk.MIN_DEPTH}, and {Desk.MAX_DEPTH}";
                return false;
            }

        }

        private void DisplayQuoteBtn_Click(object sender, EventArgs e)
        {
            customerName = NameInput.Text;
            deskWidth = int.Parse(WidthInput.Text);
            deskDepth = int.Parse(DepthInput.Text);
            noOfDrawers = int.Parse((string)NoOfDrawersInput.SelectedItem);
            productionDays = int.Parse((string)ProductionDaysInput.SelectedItem);
            deskMaterial = (string)MaterialSelectionInput.SelectedItem;

            DisplayQuote viewDisplayQuoteForm = new DisplayQuote();
            viewDisplayQuoteForm.Tag = this;
            viewDisplayQuoteForm.Show(this);
        }
    }
}
