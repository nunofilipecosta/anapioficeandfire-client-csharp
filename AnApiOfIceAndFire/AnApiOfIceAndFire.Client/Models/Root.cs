using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnApiOfIceAndFire.Client.Models
{
    public class Root
    {
        public List<Book> Books { get; set; }

        public List<Character> Characters { get; set; }

        public List<House> Houses { get; set; }
    }
}
