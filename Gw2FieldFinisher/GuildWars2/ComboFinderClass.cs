using System.Collections.Generic;
using Gw2FieldFinisher.Dijkstra;
using Gw2FieldFinisher.Utils;

namespace Gw2FieldFinisher.GuildWars2
{
    abstract class ComboFinderClass
    {
        internal Dictionary<string, Node> DictNodes =
                    new Dictionary<string, Node>();

        internal List<Node> Fields = new List<Node>();
        internal List<Node> Finishers = new List<Node>();

        internal List<Node> Nodes = new List<Node>();
        internal BiDirectionalEdgesList BiDirectionalEdges = new BiDirectionalEdgesList();

        internal List<Node> Path;

        public void RegisterFinishersAndFields()
        {
            foreach (var n in DictNodes.Values)
            {
                if (n.Field != FieldFinisher.Field.None)
                {
                    Fields.Add(n);
                }
                else if (n.Finisher != FieldFinisher.Finisher.None)
                {
                    Finishers.Add(n);
                }
                Nodes.Add(n);
            }
        }

        public List<Node> CalculateDistance(Node field, Node finisher)
        {
            var d = new Dijkstra.Dijkstra(BiDirectionalEdges, Nodes);
            d.CalculateDistance(DictNodes[field.Name]);
            return d.GetPathTo(DictNodes[finisher.Name]);
        }

        public BiDirectionalEdgesList GetEdges()
        {
            return BiDirectionalEdges;
        }

        public List<Node> GetNodes()
        {
            return Nodes;
        }

        public List<Node> GetFields()
        {
            return Fields;
        }

        public List<Node> GetFinishers()
        {
            return Finishers;
        }
    }
}
