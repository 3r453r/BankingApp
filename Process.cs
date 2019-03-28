using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp2
{
    public class Process
    {
        public Step Start { get; set; }
        public Step End { get; set; }
        public List<Step> Connectors { get; set; } = new List<Step>();

        public ProcessValidationResult Validate()
        {
            var result = ProcessValidationResult.None;
            if (Start == null)
                result = result == ProcessValidationResult.None ? ProcessValidationResult.NoStart : result | ProcessValidationResult.NoStart;

            if (End == null)
                result = result == ProcessValidationResult.None ? ProcessValidationResult.NoEnd : result | ProcessValidationResult.NoEnd;

            if(!Start.Succesors.Any() || !End.Precessors.Any() || Connectors.Any(s => !s.Precessors.Any() || !s.Succesors.Any()))
                result = result == ProcessValidationResult.None ? ProcessValidationResult.MissingConnections : result | ProcessValidationResult.MissingConnections;

            //if (result != ProcessValidationResult.None)
            //    return result;

            Start.PropagateStartConnection();
            End.PropagateEndConnection();
            return result == ProcessValidationResult.None ? ProcessValidationResult.Ok : result;
        }
       
    }

    [Flags]
    public enum ProcessValidationResult
    {
        None = 0,
        Ok = 1,
        NoStart = 2,
        NoEnd = 4,
        MissingConnections = 8,
        StepsDisconnectedFromStart = 16,
        StepsDisconnectedFromEnd = 32
    }
}
