using System.Collections.Generic;
using Gw2FieldFinisher.Dijkstra;

namespace Gw2FieldFinisher.Utils
{
    class BiDirectionalEdgesList : List<Edge>
    {
        public void AddEdge(Edge edge)
        {
            Add(edge);
            Add(new Edge(edge.Destination, edge.Origin, edge.Distance));
        }
    }
}
