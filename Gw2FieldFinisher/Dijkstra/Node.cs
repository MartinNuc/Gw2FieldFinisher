using Gw2FieldFinisher.GuildWars2;

namespace Gw2FieldFinisher.Dijkstra
{
    class Node
    {
        public string Name;
        public FieldFinisher.Field Field;
        public FieldFinisher.Finisher Finisher;

        public Node(string name)
        {
            this.Name = name;
        }

        public Node(string name, FieldFinisher.Field field)
        {
            this.Name = name;
            this.Field = field;
        }

        public Node(string name, FieldFinisher.Finisher finisher)
        {
            this.Name = name;
            this.Finisher = finisher;

        }

    }
}
