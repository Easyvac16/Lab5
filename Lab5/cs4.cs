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
        private string _cvv { get; set; }
        private string _expirationDate { get; set; }
        private decimal _balance { get; set; }


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
        public void SetCVV()
        {
            this._cvv = _cvv;
        }
        public string GetCVV(string _cvc)
        {
            return this._cvv;
        }

        public void SetExpirationDate()
        {
            this._expirationDate = _expirationDate;
        }
        public string GetExpirationDate(string _expirationDate)
        {
            return this._expirationDate;
        }
        public decimal GetBalance(decimal _balance)
        {
            return this._balance;
        }
        public void SetBalance()
        {
            this._balance = _balance;
        }
        public void DecreaseBalance(decimal amount)
        {
            this._balance -= amount;
        }

        public void InputCardInfo()
        {
            Console.WriteLine("Write card number:");
            _cardNumber = Console.ReadLine();

            Console.WriteLine("Write card holder name:");
            _cardholderName = Console.ReadLine();

            Console.WriteLine("Write Expiration Date of your card (MM/YY):");
            _expirationDate = Console.ReadLine();

            Console.WriteLine("Write your CVV");
            _cvv = Console.ReadLine();

            Console.WriteLine("Write your balance:");
            _balance = Convert.ToInt16(Console.ReadLine());
        }

        public void OutputInfo()
        {
            Console.WriteLine("Card information:");
            Console.WriteLine("Card Number: " + _cardNumber);
            Console.WriteLine("Cardholder Name: " +_cardholderName);
            Console.WriteLine("Expiration Date: " + _expirationDate);
            Console.WriteLine("CVV: " + _cvv);
            Console.WriteLine("Balance: " + _balance);
        }
        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            card._balance += amount;
            return card;
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            card._balance -= amount;
            return card;
        }

        public static bool operator ==(CreditCard card1, CreditCard card2)
        {
            return (card1._cvv == card2._cvv);
        }

        public static bool operator !=(CreditCard card1, CreditCard card2)
        {
            return !(card1 == card2);
        }

        public static bool operator >(CreditCard card1, CreditCard card2)
        {
            return (card1._balance > card2._balance);
        }

        public static bool operator <(CreditCard card1, CreditCard card2)
        {
            return (card1._balance < card2._balance);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            CreditCard otherCard = (CreditCard)obj;
            return (this._cvv == otherCard._cvv);
        }

        public override int GetHashCode()
        {
            return this._cvv.GetHashCode();
        }

    }

    internal class cs4
    {
        public static void task_4()
        {
            CreditCard card = new CreditCard();
            card.InputCardInfo();
            card.OutputInfo();
            // збільшуємо баланс на 500
            card += 500;
            
            // зменшуємо баланс на 200
            card -= 200;
            string cvv = card.GetCVV($"{card.GetCVV}").ToString();
            Console.WriteLine(cvv);
            // перевіряємо рівність CVV коду
            if (cvv != "123")
            {
                Console.WriteLine("CVV codes are not equal.");
            }
            else
            {
                Console.WriteLine("CVV codes are equal.");
            }

            CreditCard card2 = new CreditCard();
            card2.InputCardInfo();
            card2.OutputInfo();



            // перевіряємо, який баланс більший
            if (card > card2)
            {
                Console.WriteLine("Balance is greater than 1000.");
            }
            else
            {
                Console.WriteLine("Balance is less than or equal to 1000.");
            }

            // перевіряємо, який баланс менший
            if (card < card2)
            {
                Console.WriteLine("Balance is less than 1500.");
            }
            else
            {
                Console.WriteLine("Balance is greater than or equal to 1500.");
            }

            // перевіряємо нерівність
            if (card != card2)
            {
                Console.WriteLine("CVV codes are not equal.");
            }
            else
            {
                Console.WriteLine("CVV codes are equal.");
            }

            
            
            

            if (card.Equals(card2))
            {
                Console.WriteLine("Cards are equal.");
            }
            else
            {
                Console.WriteLine("Cards are not equal.");
            }
        }
    }
}
