using System;
namespace Phone
{

    public class Nokia : Phone, IRingable
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;

        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone)
        {
            this._versionNumber=versionNumber;
            this._batteryPercentage=batteryPercentage;
            this._carrier=carrier;
            this._ringTone=ringTone;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("#######################");
            Console.WriteLine("Nokia "+_versionNumber+"\nBattery Percentage: "+_batteryPercentage+"\nCarrier: "+_carrier+"\nRingtone: "+_ringTone);
            Console.WriteLine("#######################\n");

        }

        public string Ring()
        {
            return _ringTone;
        }

        public string Unlock()
        {
            return "Nokia Unlock";
        }
    }
}