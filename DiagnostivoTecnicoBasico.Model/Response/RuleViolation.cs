using System;
using System.Collections.Generic;
using System.Text;

namespace DiagnostivoTecnicoBasico.Model.Response
{
    public class RuleViolation
    {
        public string conformanceComparatorLower { get; set; }
        public string conformanceComparatorUpper { get; set; }
        public string conformanceTargetLower { get; set; }
        public string conformanceTargetUpper { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public int numberOfAllowedCrossing { get; set; }
        public string thresholdRuleSeverity { get; set; }
        public List<AppliedConsequence> appliedConsequence { get; set; }
        public TolerancePeriod tolerancePeriod { get; set; }
        public string baseType { get; set; }
        public string schemaLocation { get; set; }
        public string type { get; set; }
    }
}
