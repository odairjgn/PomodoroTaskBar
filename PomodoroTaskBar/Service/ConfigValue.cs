using Microsoft.Win32;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomodoroTaskBar.Service
{
    public class ConfigValue<T>
    {
        public ConfigValue(string key, T defaultValue = default)
        {
            Key = key;
            _defaultValue = defaultValue;
        }

        public T Value
        {
            get => GetValue();

            set => SetValue(value);
        }

        private void SetValue(T value)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\PomodoroTaskBar", true) ?? Registry.CurrentUser.CreateSubKey(@"SOFTWARE\PomodoroTaskBar", true);
            key.SetValue(Key, JsonConvert.SerializeObject(value));
            key.Close();
            key.Dispose();
        }

        private T GetValue()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\PomodoroTaskBar");
            if (key == null)
                return _defaultValue;

            var vl = key.GetValue(Key)?.ToString();
            key.Close();
            key.Dispose();
            return vl == null ? _defaultValue : JsonConvert.DeserializeObject<T>(vl);
        }

        public string Key { get; }

        private T _defaultValue;

        public static implicit operator T(ConfigValue<T> config)
        {
            return config.Value;
        }

    }
}
