using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Launch
{
    [XmlRoot("Commands")]
    [XmlInclude(typeof(Command))]
    public class CommandList : List<Command>
    {
    }

    [XmlType("Command")]
    public class Command
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Application { get; set; }
        public string Arguments { get; set; }

        public Command()
        {
        }

        public override string ToString()
        {
            return Title;
            //return $"{Title}: \"{Application}\" \"{Arguments}\")";
        }
    }
}
