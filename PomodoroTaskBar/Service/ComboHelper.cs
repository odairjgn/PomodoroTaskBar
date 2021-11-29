using System;
using System.Collections.Generic;

namespace PomodoroTaskBar.Service
{
    public static class ComboHelper
    {
        public class ComboItem<T> where T : Enum
        {
            public ComboItem(string name, T value)
            {
                Name = name;
                Value = value;
            }

            public string Name { get; set; }
            public T Value { get; set; }
        }

        public static IEnumerable<ComboItem<T>> CriarDataSource<T>() where T : Enum
        {
            foreach (T item in Enum.GetValues(typeof(T)))
                yield return new ComboItem<T>(item.ToString(), item);
        }
    }
}
