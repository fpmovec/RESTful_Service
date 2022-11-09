using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RESTful_Service.Models
{
    public class Strings
    {
        public int _replaysCount { get; set; }
        public string _stringOne { get; set; }
        public string _stringTwo { get; set; }
        public string _stringConcat { get; set; }
        public string _stringReplay { get; set; }

        public override string ToString() =>
            new StringBuilder()
                .Append(_stringConcat + "\n")
                .Append(_stringReplay)
                .ToString();

        public string StringsConcat() => string.Concat(_stringOne, _stringTwo);
        public string StringsReplay()
        {
            if (_stringOne == null) throw new ArgumentNullException();
            string result = "";
            for (int j = 0; j < _replaysCount; j++)
            {
                result += _stringOne;
            }
            return result;
        }
    }
}