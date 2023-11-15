using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace discussion
{
    // [SECTION] Partial Classes
    // Each source file contains a section of the type or method definition, and all parts are combined when the application is compiled.
    // There are several situations when splitting a class definition is desirable:
    // 1. When working on large projects, spreading a class over separate files enables multiple programmers to work on it at the same time.
    // 2. WHen working with automatically generated source, code can be add to the class without having to create the source file.
    // 3. When using source generators to generate additional functionality in class.
    internal partial class Laptop
    {
        private string graphicsCard;

        public Laptop() { }
        public Laptop(string graphicsCard, string memory)
        {
            this.graphicsCard = graphicsCard;
            this.memory = memory;
        }

        public string GraphicsCard { get => graphicsCard; set => graphicsCard = value; }
    }
}
