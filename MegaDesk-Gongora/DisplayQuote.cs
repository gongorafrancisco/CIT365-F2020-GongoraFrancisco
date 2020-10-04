using System;
using System.Globalization;
using System.Windows.Forms;

namespace MegaDesk_Gongora
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void ExitDisplayQuoteBtn_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuoteForm = (AddQuote)Tag;
            viewAddQuoteForm.Show();
            Close();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            String today = DateTime.UtcNow.ToShortDateString();
            string specifier =  "F";
            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
            DeskQuote quoteSummary = new DeskQuote(AddQuote.deskWidth,
                                                   AddQuote.deskDepth,
                                                   AddQuote.noOfDrawers,
                                                   AddQuote.deskMaterial,
                                                   AddQuote.productionDays,
                                                   AddQuote.customerName,
                                                   today);
            QuoteDateOutput.Text = quoteSummary.quoteDate;
            CustomerNameOutput.Text = quoteSummary.customerName;
            MaterialOutput.Text = quoteSummary.getSurfaceMaterial();
            SurfaceAreaOutput.Text = quoteSummary.getSurfaceArea().ToString(specifier, culture);
            NumberOfDrawersOutput.Text = quoteSummary.getNoOfDrawers().ToString();
            ProductionDaysOutput.Text = quoteSummary.getProductionDays().ToString();
            TotalCostOutput.Text = quoteSummary.calcTotalCost().ToString(specifier, culture);
        }
    }
}
