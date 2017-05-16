using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web.UI;

namespace TestCode.Html
{
    public class TagsGenerator
    {
        public Dictionary<HtmlTextWriterTag, Dictionary<HtmlTextWriterAttribute, string>> MyProperty { get; set; }

        public string Generate(string text)
        {
            Dictionary<HtmlTextWriterTag, Dictionary<HtmlTextWriterAttribute, string>> property = new Dictionary<HtmlTextWriterTag, Dictionary<HtmlTextWriterAttribute, string>>();
            Dictionary<HtmlTextWriterAttribute, string> attr = new Dictionary<HtmlTextWriterAttribute, string>();
            attr.Add(HtmlTextWriterAttribute.Src, "value");
            attr.Add(HtmlTextWriterAttribute.Style, "style");
            attr.Add(HtmlTextWriterAttribute.Height, "60");
            attr.Add(HtmlTextWriterAttribute.Width, "60");

            Dictionary<HtmlTextWriterAttribute, string> attr2 = new Dictionary<HtmlTextWriterAttribute, string>();
            attr2.Add(HtmlTextWriterAttribute.Src, "value");
            attr2.Add(HtmlTextWriterAttribute.Style, "style");


            property.Add(HtmlTextWriterTag.Img, attr);
            property.Add(HtmlTextWriterTag.Table, attr2);

            StringWriter writer = new StringWriter();
            using (HtmlTextWriter html = new HtmlTextWriter(writer))
            {
                html.RenderBeginTag(HtmlTextWriterTag.Div);
                foreach (var d in property)
                {
                    foreach(var a in d.Value)
                    {
                        html.AddAttribute(a.Key, a.Value);
                    }
                    html.RenderBeginTag(d.Key);
                    html.RenderEndTag();
                }
                html.RenderEndTag();

            }

           

            return writer.ToString();
        }
    }
}
