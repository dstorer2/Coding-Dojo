namespace Phones
{
    class Galaxy : Phone, IRingable
    {
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring()
        {
            return $"{_RingTone}";
        }
                public string Unlock()
        {
            return $"Galaxy {_VersionNumber} unlocked with fingerprint scanner";
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("###############");
            Console.WriteLine($"Galaxy {_VersionNumber}");
            Console.WriteLine($"Battery Level: {_BatteryPercentage}");
            Console.WriteLine($"Carrier: {_Carrier}");
            Console.WriteLine($"Ring Tone: {_RingTone}");
            Console.WriteLine("###############");
        }
    }
}