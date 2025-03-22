using System;

namespace Silkworm.API
{
    public static class SettingsMenuHook
    {
        /// <summary>
        /// Hook to execute when the settings menu is opened.
        /// </summary>
        public static Action OnSettingsMenuOpened;

        /// <summary>
        /// Hook to execute when the settings menu language is changed.
        /// </summary>
        public static Action<string> OnSettingsMenuLanguageChanged;

    }
}
