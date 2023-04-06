using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class CreditCard
    {
        private string _cardNumber { get; set; }
        private string _cardholderName { get; set; }
        private string _cvc { get; set; }
        private string _expirationDate { get; set; }

        public CreditCard(string cardNumber, string cardholderName, string cvc, string expirationDate)
        {
            _cardNumber = cardNumber;
            _cardholderName = cardholderName;
            _cvc = cvc;
            _expirationDate = expirationDate;
        }

        public void SetCardNumber()
        {
            this._cardNumber = _cardNumber;
        }
        public string GetCardNumber(string _cardNumber)
        {
            return this._cardNumber;
        }
        public void SetCardholderName()
        {
            
            this._cardholderName = _cardholderName;
        }
        public string GetCardHolderName(string _cardholdername)
        {
            return this._cardholderName;
        }
        public void SetCVC()
        {
            this._cvc = _cvc;
        }
        public string GetCVC(string _cvc)
        {
            return this._cvc;
        }

        public void SetExpirationDate()
        {
            this._expirationDate = _expirationDate;
        }
        public string GetExpirationDate(string _expirationDate)
        {
            return this._expirationDate;
        }

    }

    internal class cs4
    {

    }
}
