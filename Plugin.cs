using System;
using Exiled.API.Enums;
using Exiled.API.Features;
using ExEvents = Exiled.Events.Handlers;
using Player = Smelly096.Handlers.Player;

namespace Smelly096
{
    internal class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Smelly096";
        public override string Author { get; } = "x3rt";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        
        internal static Config SharedConfig { get; set; }
        public override PluginPriority Priority => PluginPriority.Last;
        private Player _player;

        public override void OnEnabled()
        {
            if (!Config.IsEnabled) return;
            if (SharedConfig is null)
                SharedConfig = Config;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnregisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            _player = new Player();
            ExEvents.Scp096.CalmingDown += Player.OnCalmingDownEvent;
            
        }
        
        private void UnregisterEvents()
        {
            
            ExEvents.Scp096.CalmingDown -= Player.OnCalmingDownEvent;
            _player = null;
        }
    }
}