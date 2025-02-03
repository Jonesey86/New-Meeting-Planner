using Meetingplanner.Controller;

namespace Meetingplanner.Models;
public class Meeting
{
    public string? Title { get; set; }
    public string? Day {get; set;}
    public List<string>? Participants { get; set; } 
    public TimeOnly StartTime { get; set; } 
    public TimeOnly EndTime { get; set; }
};