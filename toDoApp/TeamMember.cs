using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDoApp
{
    public class TeamMember
    {
        private Dictionary<int, string> team = new Dictionary<int, string>()
        {
            {1,"seyfettin"},
            {2,"burhan"},
            {3,"ahmet"},
            {4,"gokturk"},
            {5,"bora"},
            {6,"halit"}
        };

        public TeamMember(){}
        public Dictionary<int, string> Team {get => team;}
        public void addTeamMember(int id,string name)
        {
            team.Add(id, name);
        }

        
    }
}
