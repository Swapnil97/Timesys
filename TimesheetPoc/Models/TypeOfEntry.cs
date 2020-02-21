using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TimesheetPoc.Models
{
    using System;
    using System.Collections.Generic;
  

    public class Applications 
    {
        public int ApplicationId { get; set; }
        public string ApplicationName { get; set; }

        public Teams Team { get; set; }   //foreign key rel 
    }

    public class Teams  //one team can work on many applications //have many TeamMembers
    {
        public int TeamId { get; set; }
        public string TeamName { get; set; }
    }

    public class Shift  //One shift can have many team members 
    {
        public int ShiftId { get; set; }
        public string ShiftName { get; set; }
    }

    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public string TeamMemberName { get; set; }

        public Shift Shift { get; set; }  //foreign key rel

        public Teams Team { get; set; } //foreign key rel
    }

    public class Category   // One Category can have many activities
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class Activity
    {
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }

        public Category Category { get; set; }  //foreign key rel
    }


 
    public class Entry
    {
        public DateTime WeekStart { get; set; }
        public TeamTypes? Team { get; set; }
        public ShiftTypes? Shift { get; set; }
        public NameType? Name { get; set; }
        public ApplicationType? Application { get; set; }
        public TaskType? Task { get; set; }
        public ActivityType? Activity { get; set; }
        public ReleaseType? Release { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public float HoursSpent { get; set; }
        public short Id { get; set; }
        public string Reference { get; set; }
    }
}