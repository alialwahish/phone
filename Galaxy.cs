using System;
namespace Phone
{

    public class Galaxy : Phone, IRingable
    {

        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;


        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
            : base(versionNumber, batteryPercentage, carrier, ringTone)
        {

            this._versionNumber = versionNumber;
            this._batteryPercentage = batteryPercentage;
            this._carrier = carrier;
            this._ringTone = ringTone;


        }
        public string Ring()
        {
            return _ringTone;
        }

        public string Unlock()
        {
            return "Unlock galaxy";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("#######################");
            Console.WriteLine("Galaxy "+_versionNumber+"\nBattery Percentage: "+_batteryPercentage+"\nCarrier: "+_carrier+"\nRingtone: "+_ringTone);
            Console.WriteLine("#######################\n");            
        }
    }

}