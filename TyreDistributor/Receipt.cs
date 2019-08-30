using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyreDistributor
{
    public interface IReceipt
    {
        string Receipt(Company company, List<Line> _lines);
    }

    public interface IHtmlReceipt
    {
        string HtmlReceipt(Company company, List<Line> _lines);
    }

    /// <summary>
    /// Genereate the Receipt fro AlfaRomio
    /// </summary>
    public class AlfaRomioReceipt : IReceipt, IHtmlReceipt
    {
        private readonly ICalculateTotoalAmout _calculateTotoalAmout;
        public AlfaRomioReceipt(ICalculateTotoalAmout calculateTotoalAmout)
        {
            this._calculateTotoalAmout = calculateTotoalAmout;
        }
        /// <summary>
        /// Generate the Receipt , This can be further refecotred to get rid of string.Format;
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string Receipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("Order Receipt for {0}{1}", company.companyName, Environment.NewLine));
            foreach (var line in _lines)
            {
                var thisAmount = 0d;
                totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                result.AppendLine(string.Format("\t{0} x {1} {2} = {3}", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
            }
            result.AppendLine(string.Format("Sub-Total: {0}", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.AppendLine(string.Format("Tax: {0}", tax.ToString("C")));
            result.Append(string.Format("Total: {0}", (totalAmount + tax).ToString("C")));
            return result.ToString();

        }
        /// <summary>
        /// Generat html Receipt 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string HtmlReceipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("<html><body><h1>Order Receipt for {0}</h1>", company.companyName));
            if (_lines.Any())
            {
                result.Append("<ul>");
                foreach (var line in _lines)
                {
                    var thisAmount = 0d;
                    totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                    result.Append(string.Format("<li>{0} x {1} {2} = {3}</li>", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
                }
                result.Append("</ul>");
            }
            result.Append(string.Format("<h3>Sub-Total: {0}</h3>", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.Append(string.Format("<h3>Tax: {0}</h3>", tax.ToString("C")));
            result.Append(string.Format("<h2>Total: {0}</h2>", (totalAmount + tax).ToString("C")));
            result.Append("</body></html>");
            return result.ToString();
        }
    }

    /// <summary>
    /// Genereate the Receipt fro BMW MINI
    /// </summary>
    public class BmwMiniReceipt : IReceipt, IHtmlReceipt
    {
        private readonly ICalculateTotoalAmout _calculateTotoalAmout;
        public BmwMiniReceipt(ICalculateTotoalAmout calculateTotoalAmout)
        {
            this._calculateTotoalAmout = calculateTotoalAmout;
        }
        /// <summary>
        /// Generate the Receipt , This can be further refecotred to get rid of string.Format;
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string Receipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("Order Receipt for {0}{1}", company.companyName, Environment.NewLine));
            foreach (var line in _lines)
            {
                var thisAmount = 0d;
                totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                result.AppendLine(string.Format("\t{0} x {1} {2} = {3}", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
            }
            result.AppendLine(string.Format("Sub-Total: {0}", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.AppendLine(string.Format("Tax: {0}", tax.ToString("C")));
            result.Append(string.Format("Total: {0}", (totalAmount + tax).ToString("C")));
            return result.ToString();

        }
        /// <summary>
        /// Generat html Receipt 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string HtmlReceipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("<html><body><h1>Order Receipt for {0}</h1>", company.companyName));
            if (_lines.Any())
            {
                result.Append("<ul>");
                foreach (var line in _lines)
                {
                    var thisAmount = 0d;
                    totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                    result.Append(string.Format("<li>{0} x {1} {2} = {3}</li>", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
                }
                result.Append("</ul>");
            }
            result.Append(string.Format("<h3>Sub-Total: {0}</h3>", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.Append(string.Format("<h3>Tax: {0}</h3>", tax.ToString("C")));
            result.Append(string.Format("<h2>Total: {0}</h2>", (totalAmount + tax).ToString("C")));
            result.Append("</body></html>");
            return result.ToString();
        }
    }

    /// <summary>
    /// Genereate the Receipt fro BmwEstate
    /// </summary>
    public class BmwEstateReceipt : IReceipt, IHtmlReceipt
    {
        private readonly ICalculateTotoalAmout _calculateTotoalAmout;
        public BmwEstateReceipt(ICalculateTotoalAmout calculateTotoalAmout)
        {
            this._calculateTotoalAmout = calculateTotoalAmout;
        }
        /// <summary>
        /// Generate the Receipt , This can be further refecotred to get rid of string.Format;
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string Receipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("Order Receipt for {0}{1}", company.companyName, Environment.NewLine));
            foreach (var line in _lines)
            {
                var thisAmount = 0d;
                totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                result.AppendLine(string.Format("\t{0} x {1} {2} = {3}", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
            }
            result.AppendLine(string.Format("Sub-Total: {0}", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.AppendLine(string.Format("Tax: {0}", tax.ToString("C")));
            result.Append(string.Format("Total: {0}", (totalAmount + tax).ToString("C")));
            return result.ToString();

        }
        /// <summary>
        /// Generat html Receipt 
        /// </summary>
        /// <param name="company"></param>
        /// <param name="_lines"></param>
        /// <returns></returns>
        public string HtmlReceipt(Company company, List<Line> _lines)
        {
            var totalAmount = 0d;
            var result = new StringBuilder(string.Format("<html><body><h1>Order Receipt for {0}</h1>", company.companyName));
            if (_lines.Any())
            {
                result.Append("<ul>");
                foreach (var line in _lines)
                {
                    var thisAmount = 0d;
                    totalAmount = _calculateTotoalAmout.GetTotalAmount(totalAmount, ref thisAmount, line);
                    result.Append(string.Format("<li>{0} x {1} {2} = {3}</li>", line.Quantity, line.Tyre.Brand, line.Tyre.Model, thisAmount.ToString("C")));
                }
                result.Append("</ul>");
            }
            result.Append(string.Format("<h3>Sub-Total: {0}</h3>", totalAmount.ToString("C")));
            var tax = totalAmount * Constants.TaxRate;
            result.Append(string.Format("<h3>Tax: {0}</h3>", tax.ToString("C")));
            result.Append(string.Format("<h2>Total: {0}</h2>", (totalAmount + tax).ToString("C")));
            result.Append("</body></html>");
            return result.ToString();
        }
    }
}
