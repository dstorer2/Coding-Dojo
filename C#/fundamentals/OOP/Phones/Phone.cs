namespace Phones
{
    public abstract class Phone
    {
        private string _versionNumber;
        private int _batteryPercentage;
        private string _carrier;
        private string _ringTone;
        public abstract void DisplayInfo();
        public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone)
        {
            _versionNumber = versionNumber;
            _batteryPercentage = batteryPercentage;
            _carrier = carrier;
            _ringTone = ringTone;
        }
        public string _VersionNumber{get{return _versionNumber;}}
        public int _BatteryPercentage{get{return _batteryPercentage;}}
        public string _Carrier{get{return _carrier;}}
        public string _RingTone{get{return _ringTone;}}

    }
}