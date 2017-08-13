using SecurityDoor.Models;
using System;

namespace SecurityDoor
{
    public class KeyCardCheck : SecurityCheck, IKeyCardUI, ISecurityUI
    {
        private ScannerUI scannerUi;

        public KeyCardCheck(ScannerUI scannerUi)
        {
            this.scannerUi = scannerUi;
        }

        public bool IsValid(string code)
        {
            return true;
        }

        public override bool ValidateUser()
        {
            string pin = this.RequestKeyCard();
            if (this.IsValid(pin))
            {
                return true;
            }

            return false;
        }

        public string RequestKeyCard()
        {
            Console.WriteLine("Slide your key card");
            return Console.ReadLine();
        }
    }
}