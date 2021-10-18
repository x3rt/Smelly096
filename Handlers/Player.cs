using Exiled.Events.EventArgs;
using Smelly096.Helpers;

namespace Smelly096.Handlers
{
    public class Player
    {
        public static void OnCalmingDownEvent(CalmingDownEventArgs ev)
        {
            Helper.placeTantrum(ev.Player);
        }
        
    }
}