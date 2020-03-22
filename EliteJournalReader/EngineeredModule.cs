﻿using System.Collections.Generic;

namespace EliteJournalReader
{
    public class EngineeredModule
    {
        public string Engineer { get; set; }
        public long EngineerID { get; set; }
        public long BlueprintID { get; set; }
        public string BlueprintName { get; set; }
        public int Level { get; set; }
        public double Quality { get; set; }
        public string ExperimentalEffect { get; set; }
        public EngineeringModifiers[] Modifiers { get; set; }

        public EngineeredModule Clone() => (EngineeredModule)MemberwiseClone();
    }
}
