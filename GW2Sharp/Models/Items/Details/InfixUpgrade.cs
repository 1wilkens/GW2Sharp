using System.Collections.Generic;

namespace MrFloya.GW2Sharp.Models.Items.Details
{
    public class InfixUpgrade
    {
        /// <summary>
        /// The buff the Infix provides
        /// </summary>
        public InfixBuff Buff { get; set; }
        /// <summary>
        /// The AttributeModifiers the Infix provides
        /// </summary>
        public List<AttributeModifier> Attributes { get; set; }
    }

    public class InfixBuff
    {
        public string Skill_ID { get; set; }
        public string Description { get; set; }
    }
}