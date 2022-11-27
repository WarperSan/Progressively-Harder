using Assets.Scripts.Models.Towers;
using BTD_Mod_Helper;
using BTD_Mod_Helper.Api.Towers;
using BTD_Mod_Helper.Extensions;
using MelonLoader;

namespace ProgressivelyHarder
{
    [assembly: MelonInfo(typeof(ProgressivelyHarder), ModHelperData.Name, ModHelperData.Version, ModHelperData.RepoOwner)]
    public static class ModHelperData
    {
        public const string Version = "1.0.0";
        public const string Name = "Progressively Harder";
        public const string Description =
            "Make the game progressively harder by removing most used upgrades";

        public const string RepoOwner = "WarperSan";
        public const string RepoName = "Progressively-Harder";
        public const string Icon = "up_arrow.png";
    }
}
