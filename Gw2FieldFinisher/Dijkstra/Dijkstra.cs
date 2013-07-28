using System.Collections.Generic;

namespace Gw2FieldFinisher.Dijkstra
{
    class Dijkstra
    {
        private readonly List<Node> _nodes;
        private readonly List<Edge> _edges;
        private readonly List<Node> _basis;
        private readonly Dictionary<string, double> _dist;
        private readonly Dictionary<string, Node> _previous;
 
        public Dijkstra(List<Edge> edges, List<Node> nodes)
        {
            _edges = edges;
            _nodes = nodes;
            _basis = new List<Node>();
            _dist = new Dictionary<string, double>();
            _previous = new Dictionary<string, Node>();
 
            // init
            foreach (var n in _nodes)
            {
                _previous.Add(n.Name, null);
                _basis.Add(n);
                _dist.Add(n.Name, double.MaxValue);
            }
        }
 
        public void CalculateDistance(Node start)
        {
            _dist[start.Name] = 0;
 
            while (_basis.Count > 0)
            {
                var u = GetNodeWithSmallestDistance();
                if (u == null)
                {
                    _basis.Clear();
                }
                else
                {
                    foreach (Node v in GetNeighbors(u))
                    {
                        double alt = _dist[u.Name] +
                                GetDistanceBetween(u, v);
                        if (alt < _dist[v.Name])
                        {
                            _dist[v.Name] = alt;
                            _previous[v.Name] = u;
                        }
                    }
                    _basis.Remove(u);
                }
            }
        }
 
        public List<Node> GetPathTo(Node d)
        {
            var path = new List<Node>();
 
            path.Insert(0, d);
 
            while (_previous[d.Name] != null)
            {
                d = _previous[d.Name];
                path.Insert(0, d);
            }
 
            return path;
        }

        public Node GetNodeWithSmallestDistance()
        {
            var distance = double.MaxValue;
            Node smallest = null;
 
            foreach (var n in _basis)
            {
                if (_dist[n.Name] < distance)
                {
                    distance = _dist[n.Name];
                    smallest = n;
                }
            }
 
            return smallest;
        }

        public List<Node> GetNeighbors(Node n)
        {
            var neighbors = new List<Node>();
 
            foreach (var e in _edges)
            {
                if (e.Origin.Equals(n) && _basis.Contains(n))
                {
                    neighbors.Add(e.Destination);
                }
            }
 
            return neighbors;
        }

        public double GetDistanceBetween(Node o, Node d)
        {
            foreach (var e in _edges)
            {
                if (e.Origin.Equals(o) && e.Destination.Equals(d))
                {
                    return e.Distance;
                }
            }
 
            return 0;
        }
    }
    }
