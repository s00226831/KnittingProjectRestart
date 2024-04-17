using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KnittingProjectRestart
{
    public class Project
    {
        public string ProjectName { get; set; }    
        public string ProjectDescription { get; set; }
        public ProjectStatus Status { get; set; }

        public Project(string name, string description)
        {
            ProjectName = name;
            ProjectDescription = description;
            Status = ProjectStatus.InProgress;
        }


    }

    // status to allow you to mark the projects you have finished/ are working on atm
    public enum ProjectStatus
    {
        Complete,
        InProgress,
        Dropped
    }


}
