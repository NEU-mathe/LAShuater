namespace xxdswinform.Entity
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Xml;

    internal class GapfillingEntity
    {
        public GapfillingEntity()
        {
            this.Content = new List<XmlNode>();
        }

        public List<XmlNode> Content { get; set; }

        public string Num { get; set; }
    }
}

