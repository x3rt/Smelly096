using System.ComponentModel;
using Exiled.API.Interfaces;

namespace Smelly096
{
    public sealed class Config : IConfig
    {
        [Description("If plugin is enabled")]
        public bool IsEnabled { get; set; } = true;
        
        [Description("After how many seconds should the puddle be removed? 0 or lower to disable")]
        public float removeAfterXSeconds { get; set; } = 60f;
    }
}