using System;
using Gw2FieldFinisher.Dijkstra;

namespace Gw2FieldFinisher.GuildWars2.Classes
{
    class Engineer : ComboFinderClass
    {

        public Engineer()
        {
            String name;

            // heal
            name = "Healing Turret";
            DictNodes.Add(name, new Node(name));
            name = "Cleansing Turret";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Water));

            // pistol + shield
            name = "Pistol";
            DictNodes.Add(name, new Node(name));
            name = "Explosive Shot";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Projectile));
            name = "Magnetic Shield";
            DictNodes.Add(name, new Node(name));
            name = "Magnetic Inversion";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Blast));
            name = "Static Shield";
            DictNodes.Add(name, new Node(name));
            name = "Throw Shield";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Projectile));

            // elixir gun
            name = "Elixir Gun";
            DictNodes.Add(name, new Node(name));
            name = "Tranquilizer Dart";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Projectile));
            name = "Acid Bomb";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Blast));
            name = "Super Elixir";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Light));

            // bomb kit
            name = "Bomb Kit";
            DictNodes.Add(name, new Node(name));
            name = "Fire Bomb";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Fire));
            name = "Smoke Bomb";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Smoke));


            // grenade kit
            name = "Grenade Kit";
            DictNodes.Add(name, new Node(name));
            name = "Poison Grenade";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Poison));

            // ultimate
            name = "Supply Crate";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Blast));

            // belt
            name = "Regenerating Mist";
            DictNodes.Add(name, new Node(name, FieldFinisher.Field.Water));
            name = "Big Oil Bomb";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Blast));
            name = "Detonate Healing Turret";
            DictNodes.Add(name, new Node(name, FieldFinisher.Finisher.Blast));

            // heal
            string from = "Healing Turret";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Cleansing Turret"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Detonate Healing Turret"]));

            // belt
            from = "Regenerating Mist";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Big Oil Bomb"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            from = "Big Oil Bomb";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Regenerating Mist"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            // pistol
            from = "Explosive Shot";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Magnetic Shield"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Static Shield"]));

            from = "Magnetic Shield";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Explosive Shot"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Magnetic Inversion"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Static Shield"]));

            from = "Static Shield";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Explosive Shot"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Throw Shield"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Magnetic Shield"]));

            // Elixir gun
            from = "Tranquilizer Dart";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Acid Bomb"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Super Elixir"]));

            from = "Acid Bomb";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Tranquilizer Dart"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Super Elixir"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes["Elixir Gun"], DictNodes["Acid Bomb"]));

            from = "Super Elixir";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Tranquilizer Dart"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Acid Bomb"]));

            // Bomb kit
            from = "Fire Bomb";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Smoke Bomb"]));

            from = "Smoke Bomb";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Fire Bomb"]));

            // Grenade kit
            from = "Poison Grenade";
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.AddEdge(new Edge(DictNodes[from], DictNodes["Smoke Bomb"]));

            // mezi zbranema muzu prepinat
            from = "Pistol";
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Regenerating Mist"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Big Oil Bomb"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            from = "Elixir Gun";
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Regenerating Mist"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Big Oil Bomb"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            from = "Bomb Kit";
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Grenade Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Regenerating Mist"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Big Oil Bomb"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            from = "Grenade Kit";
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Elixir Gun"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Bomb Kit"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Pistol"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Regenerating Mist"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Big Oil Bomb"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Supply Crate"]));
            BiDirectionalEdges.Add(new Edge(DictNodes[from], DictNodes["Healing Turret"]));

            RegisterFinishersAndFields();
        }
    }
}
