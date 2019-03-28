using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Step
    {
        public string Name { get; set; }
        public bool ConnectedToStart { get; set; }
        public bool ConnectedToEnd { get; set; }
        public List<Step> Precessors { get; set; } = new List<Step>();
        public List<Step> Succesors { get; set; } = new List<Step>();

        public void PropagateStartConnection()
        {
            if (ConnectedToStart || Precessors.Any(s => s.ConnectedToStart))
            {
                Console.WriteLine($"Propagating start in {Name}");
                ConnectedToStart = true;
                foreach (var step in Succesors.Where(s => !s.ConnectedToStart))
                {
                    step.ConnectedToStart = true;
                    step.PropagateStartConnection();
                }
            }
        }

        public void PropagateEndConnection()
        {
            if (ConnectedToEnd || Succesors.Any(s => s.ConnectedToEnd))
            {
                Console.WriteLine($"Propagating end in {Name}");
                ConnectedToEnd = true;
                foreach (var step in Precessors.Where(s => !s.ConnectedToEnd))
                {
                    step.ConnectedToEnd = true;
                    step.PropagateEndConnection();
                }
            }
        }
    }
}
