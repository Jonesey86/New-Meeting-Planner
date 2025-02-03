using Meetingplanner.Models;
using Meetingplanner.View;
using Meetingplanner.Service;
using System.Linq;

namespace Meetingplanner.Controller;

public class MeetingController
{
    private List<Meeting> _meetings = new List<Meeting>();

    public void AddMeeting(Meeting meeting)
    {
        _meetings.Add(meeting);
        Console.WriteLine("Meeting added");
    }

    public List<Meeting> GetAllMeetings()
    {
        return _meetings;
    }

    public List<Meeting> GetListByParticipant(string Participants)
    {
        var MeetingsWithParticipant = _meetings
        .Where(m => m.Participants != null && m.Participants.Contains(Participants))
        .ToList();

        return MeetingsWithParticipant;
    }

    public List<Meeting> GetOverlappigMeetings(TimeOnly start, TimeOnly end)
    {
        var OverlappingMeetings = _meetings
        .Where(m => m.StartTime < end && m.EndTime > start)
        .ToList();

        return OverlappingMeetings;
    }
}