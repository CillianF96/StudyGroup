using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject
{
    public class Subject
    {

        public string SubjectName { get; set; }

        public string SubjectDescription { get; set; }

        public string LearningOutcome { get; set; }

        public int YearOfStudy { get; set; }

        public string Prerequisites { get; set; }

        public string Projects { get; set; }

        public string StudyMaterial { get; set; }

        public string RolesAndResponsibilities { get; set; }

        public Subject(string SubName, string SubDesc, string Loutcomes, int StudyYr, string PreReq, string SubProjects, string StudyMat, string Roles )
        {
            this.SubjectName = SubName;
            this.SubjectDescription = SubDesc;
            this.LearningOutcome = Loutcomes;
            this.YearOfStudy = StudyYr;
            this.Prerequisites = PreReq;
            this.Projects = SubProjects;
            this.StudyMaterial = StudyMat;
            this.RolesAndResponsibilities = Roles;
        }


    }
}
