﻿namespace Account.Application.Library.Models.Controls
{
    public class KeyValue<T>
    {
        public string Key { get; set; }
        public T Value { get; set; }

        public override string ToString()
        {
            return Key;
        }
    }
}