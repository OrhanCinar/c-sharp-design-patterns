using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    public interface ATMState
    {
        void InsertCard();

        void EjectCard();

        void InsertPin(int pinEntered);

        void RequestCash(int cashToWithdraw);
    }
}
