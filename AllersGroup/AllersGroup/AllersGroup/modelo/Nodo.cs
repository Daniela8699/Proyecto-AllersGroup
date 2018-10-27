using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public  class Nodo
    {
        private int count;
        private bool visited;
        public Dictionary<string, Nodo> item = new Dictionary<string, Nodo>();

        public Nodo()
        {
            count = 0;
            visited = false;
        }

        public int Count { get; set; }
        public bool Visited { get; set; }
}

