using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Sessions
    {
        public DateTime DateAndTime { get; set; }

        public int RoomNum { get; set; }

        public string Topic { get; set; }

        public string GroupMembers { get; set; }

        public string AssignmentQs { get; set; }

        public string Agenda { get; set; }

        public string GoalsAndOjectives { get; set; }

        public string StudyMaterials { get; set; }


        public Sessions(DateTime dateTime, int RoomNr, string SesTopic, string GrpMem, string AssQs, string SesAgenda, string Goals, string SesStyMats) 
        {
            this.DateAndTime = dateTime;
            this.RoomNum = RoomNr;
            this.Topic = SesTopic;
            this.GroupMembers = GrpMem;
            this.AssignmentQs = AssQs;
            this.Agenda = SesAgenda;
            this.GoalsAndOjectives = Goals;
            this.StudyMaterials = SesStyMats;
            
        }

    }
}
