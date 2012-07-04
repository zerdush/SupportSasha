﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SupportSasha.Donations.Helpers
{
    public static class HtmlHelpers
    {
        public static dynamic FormatDate(this HtmlHelper helper, DateTime date)
        {
            return string.Format(@"{0:dd MMM yyyy HH:mm}", date);
        }

        public static dynamic WrapWith(this HtmlHelper helper, string text, string tagName)
        {
            if(string.IsNullOrWhiteSpace(text))
                return string.Empty;

            var builder = new TagBuilder(tagName);
            builder.SetInnerText(text);
            return new MvcHtmlString(builder.ToString());
        }
    }
}