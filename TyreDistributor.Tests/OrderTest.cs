using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TyreDistributor.Tests
{
    [TestClass]
    public class OrderTest
    {
        // Brand Object set up
        private static readonly AlfaRomeo AlfaRomeo = new AlfaRomeo() { Brand = "Alfa Romeo", Model = Constants.Suv, Price = 100 };
        private static readonly BmwMini BmwMini = new BmwMini() { Brand = "BMW", Model = Constants.Mini, Price = 200 };
        private static readonly BmwEstate BmwEstate = new BmwEstate() { Brand = "BMW", Model = Constants.Estate, Price = 500 };

        [TestMethod]
        public void ReceiptOneAlfaRomeo()
        {
            var calculateTotoalAmout_For_AlfaRomio = new CalculateTotoalAmoutForAlfaRomio();
            var alfaRomioReceipt = new AlfaRomioReceipt(calculateTotoalAmout_For_AlfaRomio);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(AlfaRomeo, 1));
            var result = alfaRomioReceipt.Receipt(company, lines);
            Assert.AreEqual(ResultStatementOneAlfa, result);
        }

        private const string ResultStatementOneAlfa = @"Order Receipt for Anywhere Tyre Shop
	1 x Alfa Romeo Sports Utility Vehicle = $100.00
Sub-Total: $100.00
Tax: $7.25
Total: $107.25";

        [TestMethod]
        public void ReceiptOneBmw1()
        {
            var calculateTotoalAmoutForBmwMini = new CalculateTotoalAmoutForBmwMini();
            var bmwMiniReceipt = new BmwMiniReceipt(calculateTotoalAmoutForBmwMini);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(BmwMini, 1));
            Assert.AreEqual(ResultStatementOneBmw, bmwMiniReceipt.Receipt(company, lines));
        }

        private const string ResultStatementOneBmw = @"Order Receipt for Anywhere Tyre Shop
	1 x BMW Mini = $200.00
Sub-Total: $200.00
Tax: $14.50
Total: $214.50";

        [TestMethod]
        public void ReceiptOneBmwX()
        {
            var calculateTotoalAmoutForBmwEstate = new CalculateTotoalAmoutForBmwEstate();
            var bmwEstateReceipt = new BmwEstateReceipt(calculateTotoalAmoutForBmwEstate);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(BmwEstate, 1));
            Assert.AreEqual(ResultStatementOneBmwEstate, bmwEstateReceipt.Receipt(company,lines));
        }

        private const string ResultStatementOneBmwEstate = @"Order Receipt for Anywhere Tyre Shop
	1 x BMW Estate = $500.00
Sub-Total: $500.00
Tax: $36.25
Total: $536.25";
        [TestMethod]
        public void HtmlReceiptOneAlfaRomeoSportWagon()
        {
            var calculateTotoalAmout_For_AlfaRomio = new CalculateTotoalAmoutForAlfaRomio();
            var alfaRomioReceipt = new AlfaRomioReceipt(calculateTotoalAmout_For_AlfaRomio);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(AlfaRomeo, 1));
            var result = alfaRomioReceipt.HtmlReceipt(company, lines);
            Assert.AreEqual(HtmlResultStatementOneAlfaRomeoSportWagon, result);
        }

        private const string HtmlResultStatementOneAlfaRomeoSportWagon = @"<html><body><h1>Order Receipt for Anywhere Tyre Shop</h1><ul><li>1 x Alfa Romeo Sports Utility Vehicle = $100.00</li></ul><h3>Sub-Total: $100.00</h3><h3>Tax: $7.25</h3><h2>Total: $107.25</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneBmwMiniSeries()
        {
            var calculateTotoalAmoutForBmwMini = new CalculateTotoalAmoutForBmwMini();
            var bmwMiniReceipt = new BmwMiniReceipt(calculateTotoalAmoutForBmwMini);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(BmwMini, 1));
            Assert.AreEqual(HtmlResultStatementOneBmw1Series, bmwMiniReceipt.HtmlReceipt(company,lines));
        }

        private const string HtmlResultStatementOneBmw1Series = @"<html><body><h1>Order Receipt for Anywhere Tyre Shop</h1><ul><li>1 x BMW Mini = $200.00</li></ul><h3>Sub-Total: $200.00</h3><h3>Tax: $14.50</h3><h2>Total: $214.50</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneBmwEstate()
        {
            var calculateTotoalAmoutForBmwEstate = new CalculateTotoalAmoutForBmwEstate();
            var bmwEstateReceipt = new BmwEstateReceipt(calculateTotoalAmoutForBmwEstate);
            var company = new Company() { companyName = "Anywhere Tyre Shop" };
            var order = new Order();
            var lines = new List<Line>();
            lines.Add(order.AddLine(BmwEstate, 1));
            Assert.AreEqual(HtmlResultStatementOneBmwX5, bmwEstateReceipt.HtmlReceipt(company,lines));
        }

        private const string HtmlResultStatementOneBmwX5 = @"<html><body><h1>Order Receipt for Anywhere Tyre Shop</h1><ul><li>1 x BMW Estate = $500.00</li></ul><h3>Sub-Total: $500.00</h3><h3>Tax: $36.25</h3><h2>Total: $536.25</h2></body></html>";
    }
}


