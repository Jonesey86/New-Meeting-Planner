using MeetingPlanner.Controller;

namespace MeetingPlanner.Models

public class Meeting 
{
    public string? Title { get; set; }
    public string? Day { get; set; }
    public List<string>? Participants { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

}
