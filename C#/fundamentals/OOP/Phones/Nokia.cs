namespace Phones
{
    class Nokia : Phone, IRingable
    {
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring()
        {
            return $"......{_RingTone}......";
        }
        public string Unlock()
        {
            return $"Nokia {_VersionNumber} unlocked with password";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("###############");
            Console.WriteLine($"Nokia {_VersionNumber}");
            Console.WriteLine($"Battery Level: {_BatteryPercentage}");
            Console.WriteLine($"Carrier: {_Carrier}");
            Console.WriteLine($"Ring Tone: {_RingTone}");
            Console.WriteLine("###############");
        }
    }
}