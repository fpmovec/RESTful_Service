using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using RESTful_Service.Models;

namespace RESTful_Service.Services
{
    public class StringsRepository
    {
        private const string CacheKey = "StringsStore";

        public StringsRepository()
        {
            var ctx = HttpContext.Current;
            if (ctx != null)
            {
                if (ctx.Cache[CacheKey] == null)
                {
                    var strings = new Strings[]
                    {
                        new Strings{}
                    };
                    ctx.Cache[CacheKey] = strings;
                }
            }
        }

        public Strings[] GetAllStrings()
        {
            var ctx = HttpContext.Current;

            if (ctx != null) 
                return (Strings[])ctx.Cache[CacheKey];

            else throw new NullReferenceException();
        }

        public bool SaveStrings(Strings strings)
        {
            var ctx = HttpContext.Current;
            if (ctx != null)
            {
                try
                {
                    var currentData = ((Strings[])ctx.Cache[CacheKey]).ToList();
                    currentData.Add(strings);
                    ctx.Cache[CacheKey] = currentData.ToArray();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return false;
                }
            }
            return false;
        }
    }
}