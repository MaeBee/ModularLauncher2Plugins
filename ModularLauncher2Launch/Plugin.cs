using System;
using System.Collections;
using ModularLauncherUtil;

namespace ModularLauncher2Launch
{
    public class Plugin : IPlugin
    {
        IPluginHost Host = null;

        string Name = "Launch";
        int ID = 0;
        string Description = "Plugin for mod management.";
        string Author = "Jannik \"gobbo\" Balkau";
        string Version = "0.1";

        System.Windows.Forms.UserControl MainInterface = new MainInterface();
        System.Windows.Forms.UserControl SettingsPanel = new SettingsPanel();

        event EventHandler SendNotification;
        event EventHandler LaunchGame;

        void Initialize();
        void Dispose();
    }
}