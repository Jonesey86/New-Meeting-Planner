﻿using Meetingplanner.Controller;
using Meetingplanner.View;

namespace Meetingplanner;

class Program
{
    static void Main(string[] args)
    {
        var controller = new MeetingController();
        var view = new MeetingView(controller);

        // text you will recieve whilst typing in terminal
        while (true)
        {
            Console.WriteLine("Meeting planner");
            Console.WriteLine("1.Display meeting's");
            Console.WriteLine("2.Add new meeting's");
            Console.WriteLine("3.Search for participant");
            Console.WriteLine("4.Exit");
            Console.WriteLine("Choose an option: ");
            string option = Console.ReadLine()?.Trim() ?? "1";

            switch (option)
            {
                case "1":
                    Console.Clear();
                    view.DisplayMeetings();
                    break;
                case "2":
                    Console.Clear();
                    view.AddMeeting();
                    break;
                case "3":
                    Console.Clear();
                    view.SearchMeetingsParticipant();
                    break;
                case "4":
                    Console.Clear();
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid. Please try again");
                    Console.ReadLine();
                    break;
            }
        }
    }
}