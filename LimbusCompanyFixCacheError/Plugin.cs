using BepInEx;
using BepInEx.Unity.IL2CPP;
using Il2CppSystem.Threading;

namespace LimbusCompany.FixCacheError;

[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class Plugin : BasePlugin
{
    public override void Load()
    {
        // Plugin startup logic
        Log.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");

        // for some reason LC trying to use caching very early in loading of the menu. We are blocking the main thread to get Unity initialize the caching.
        // 
        while (!UnityEngine.Caching.ready)
        {
            Thread.Sleep(500);
        }
        Log.LogInfo("Caching is ready for use!");
    }
}
