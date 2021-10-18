using System.Collections.Generic;
using System.Linq;
using Exiled.API.Features;
using MEC;
using Mirror;
using PlayableScps.ScriptableObjects;
using UnityEngine;

namespace Smelly096.Helpers
{
    public static class Helper
    {
        public static void placeTantrum(Player ply)
        {
            GameObject gameObject = Object.Instantiate(ScpScriptableObjects.Instance.Scp173Data.TantrumPrefab);
            gameObject.transform.position = ply.Position;
            NetworkServer.Spawn(gameObject);

            if (Plugin.SharedConfig.removeAfterXSeconds > 0)
                Timing.RunCoroutine(_killTantrum(gameObject));
        }

        private static IEnumerator<float> _killTantrum(GameObject obj)
        {
            yield return Timing.WaitForSeconds(Plugin.SharedConfig.removeAfterXSeconds);
            NetworkServer.Destroy(obj);
        }
    }
}