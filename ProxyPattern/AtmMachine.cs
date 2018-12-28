using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class AtmMachine : GetAtmData 
    {
        ATMState hasCard;
        ATMState noCard;
        ATMState hasCorrectPin;
        ATMState atmOutOfMoney;

        ATMState atmState;

        public int cashInMachine = 2000;

        public bool correctPinEntered = false;

        public AtmMachine()
        {
            hasCard = new HasCard(this);
            noCard = new NoCard(this);
            hasCorrectPin = new HasPin(this);
            atmOutOfMoney = new NoCash(this);

            atmState = noCard;

            if (cashInMachine < 0)
            {
                atmState = atmOutOfMoney;
            }

        }

        public void setATMState(ATMState newAtmState)
        {
            atmState = newAtmState;
        }

        public void setCashInMachine(int newCashInMachine)
        {
            cashInMachine = newCashInMachine;
        }

        public void InsertCard()
        {
            atmState.InsertCard();
        }

        public void EjectCard()
        {
            atmState.EjectCard();
        }

        public void RequestCash(int cashToWithdraw)
        {
            atmState.RequestCash(cashToWithdraw);
        }

        public void InsertPin(int pinEntered)
        {
            atmState.InsertPin(pinEntered);
        }

        public ATMState GetYesCardState()
        {
            return hasCard;
        }

        public ATMState GetNoCardState()
        {
            return noCard;
        }

        public ATMState GetHasPinState()
        {
            return hasCorrectPin;
        }

        public ATMState GetNoCashState()
        {
            return atmOutOfMoney;
        }

        public ATMState GetAtmData()
        {
            return atmState;
        }

        public int GetCashInMachine()
        {
            return cashInMachine;
        }
    }
}
