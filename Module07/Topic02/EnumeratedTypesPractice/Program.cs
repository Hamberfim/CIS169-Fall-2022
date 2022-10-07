using System;

namespace EnumeratedTypesPractice
{
    [Flags]  // required for bit flag use
    public enum Days
    {
        None = 0,  // 0
        Monday = 1,  // 1
        Tuesday = 2,  // 2
        Wednesday = 4,  // 4
        Thursday = 8,  // 8
        Friday = 16,  // 16
        Saturday = 32,  // 32
        Sunday = 64,  // 64
        Weekend = Saturday | Sunday
    }

    class Program
    {
        static void Main(string[] args)
        {
            Days meetingDays = Days.Monday | Days.Wednesday | Days.Friday;
            Console.WriteLine(meetingDays);


            Days workingFromHomeDays = Days.Thursday | Days.Friday;
            Console.WriteLine($"Join a meeting by phone on {meetingDays & workingFromHomeDays}");


            bool isMeetingOnTuesday = (meetingDays & Days.Tuesday) == Days.Tuesday;
            Console.WriteLine($"Is there a meeting on Tuesday: {isMeetingOnTuesday}");

            Days inOffice = Days.Monday | Days.Tuesday | Days.Wednesday;
            Console.WriteLine($"In office meeting on {meetingDays & inOffice}");

        }
    }
