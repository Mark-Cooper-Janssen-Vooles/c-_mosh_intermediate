using System;
namespace _18_InheritanceDEMO
{
    public class Text : PresentationObject
    {
        public string FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }
}
