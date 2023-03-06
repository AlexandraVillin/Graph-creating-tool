using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokGraf
{
    public class GraphDFS
    {
        string s; 
        private int V; 

        private List<int>[] adj;

        public GraphDFS(int v) 
        {
            V = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
                adj[i] = new List<int>();
        }

        public void AddEdge(int v, int w)
        {
            adj[v].Add(w); 
        }

        public string DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            s += v + " ";

            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                    DFSUtil(n, visited);
            }
            return s;
        }

        public string  DFS(int v)
        {

            bool[] visited = new bool[V];

            DFSUtil(v, visited);
            return s;
        }
    }
}

