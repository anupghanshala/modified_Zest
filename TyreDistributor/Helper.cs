using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TyreDistributor
{
    public interface ICalculateTotoalAmout
    {
        double GetTotalAmount(double totalAmount, ref double thisAmount, Line line);
    }

    /// <summary>
    /// Calculating the Total Amount for AlfaRomio 
    /// </summary>
    public class CalculateTotoalAmoutForAlfaRomio : ICalculateTotoalAmout
    {
        /// <summary>
        /// GetTotalAmount --> This calss can be refector for  line.Tyre.Model and get rid of if condition
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <param name="thisAmount"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public double GetTotalAmount(double totalAmount, ref double thisAmount, Line line)
        {
            if (line.Tyre.Model == Constants.Suv)
            {
                if (line.Quantity >= 20)
                { thisAmount += line.Quantity * line.Tyre.Price * .9d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Mini)
            {
                if (line.Quantity >= 10)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Estate)
            {
                if (line.Quantity >= 5)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            totalAmount += thisAmount;
            return totalAmount;
        }
    }


    /// <summary>
    /// Calculating the Total Amount for BmwMini 
    /// </summary>
    public class CalculateTotoalAmoutForBmwMini : ICalculateTotoalAmout
    {
        /// <summary>
        /// GetTotalAmount --> This calss can be refector for  line.Tyre.Model and get rid of if condition
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <param name="thisAmount"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public double GetTotalAmount(double totalAmount, ref double thisAmount, Line line)
        {
            if (line.Tyre.Model == Constants.Suv)
            {
                if (line.Quantity >= 20)
                { thisAmount += line.Quantity * line.Tyre.Price * .9d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Mini)
            {
                if (line.Quantity >= 10)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Estate)
            {
                if (line.Quantity >= 5)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            totalAmount += thisAmount;
            return totalAmount;
        }
    }


    /// <summary>
    /// Calculating the Total Amount for BmwEstate 
    /// </summary>
    public class CalculateTotoalAmoutForBmwEstate : ICalculateTotoalAmout
    {
        /// <summary>
        /// GetTotalAmount --> This calss can be refector for  line.Tyre.Model and get rid of if condition
        /// </summary>
        /// <param name="totalAmount"></param>
        /// <param name="thisAmount"></param>
        /// <param name="line"></param>
        /// <returns></returns>
        public double GetTotalAmount(double totalAmount, ref double thisAmount, Line line)
        {
            if (line.Tyre.Model == Constants.Suv)
            {
                if (line.Quantity >= 20)
                { thisAmount += line.Quantity * line.Tyre.Price * .9d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Mini)
            {
                if (line.Quantity >= 10)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            if (line.Tyre.Model == Constants.Estate)
            {
                if (line.Quantity >= 5)
                { thisAmount += line.Quantity * line.Tyre.Price * .8d; }
                else
                { thisAmount += line.Quantity * line.Tyre.Price; }
            }
            totalAmount += thisAmount;
            return totalAmount;
        }
    }
}
