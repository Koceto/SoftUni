using SecurityDoor.Models;
using System;

namespace SecurityDoor
{
    public class PinCodeCheck : SecurityCheck, IPinCodeUI, ISecurityUI
    {
        private ScannerUI scannerUi;

        public PinCodeCheck(ScannerUI scannerUi)
        {
            this.scannerUi = scannerUi;
        }

        public bool IsValid(int pin)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            int pin = this.RequestPinCode();
            if (this.IsValid(pin))
            {
                return true;
            }

            return false;
        }

        public int RequestPinCode()
        {
            Console.WriteLine("Enter your pin code:");
            return int.Parse(Console.ReadLine());
        }
    }
}