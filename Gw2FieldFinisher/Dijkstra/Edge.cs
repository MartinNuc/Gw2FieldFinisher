namespace Gw2FieldFinisher.Dijkstra
{
    class Edge
    {
        public Node Origin;
        public Node Destination;
        public double Distance;

        public Edge(Node origin, Node destination, double distance)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Distance = distance;
        }

        public Edge(Node origin, Node destination)
        {
            this.Origin = origin;
            this.Destination = destination;
            this.Distance = 1;
        }
    }
}
