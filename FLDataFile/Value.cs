﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace FLDataFile
{
    public class Setting
    {

        public string Name { get; set; }

        private static readonly string[] Delimiters = { ", ","," };

        public List<String> Values;

        /// <summary>
        /// Creates an empty setting.
        /// </summary>
        /// <param name="name"></param>
        public Setting(string name)
        {
            Name = name;
            Values = new List<string>();
        }

        /// <summary>
        /// Creates a setting parsed from the list of values.
        /// </summary>
        /// <param name="text">Values to parse.</param>
        /// <param name="name">Setting's name.</param>
        public Setting(string text,string name)
        {
            Name = name.Trim();
            //get the values, split em and trim em.
            Values = (List<String>)(new List<string>(text.Split(Delimiters, StringSplitOptions.RemoveEmptyEntries))).Select(s => s.Trim());
        }




    }
}
