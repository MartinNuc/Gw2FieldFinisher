using System;

namespace Gw2FieldFinisher.GuildWars2
{
    class FieldFinisher
    {
        public enum Finisher
        {
            None, Blast, Leap, Projectile, Whirl
        }

        public enum Field
        {
            None, Dark, Ethereal, Fire, Ice, Light, Lightning, Poison, Smoke, Water
        }

        public static string GetEffect(Field field, Finisher finisher)
        {
            switch (field)
            {
                case Field.Dark:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area Blindness";
                        case Finisher.Leap:
                            return "Blindness";
                        case Finisher.Projectile:
                            return "Life stealing";
                        case Finisher.Whirl:
                            return "Leeching Bolts (life steal)";
                    }
                    throw new Exception("Not existing combination");
                case Field.Ethereal:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area chaos armor";
                        case Finisher.Leap:
                            return "Chaos armor";
                        case Finisher.Projectile:
                            return "Confusion (5s)";
                        case Finisher.Whirl:
                            return "Confusing Bolts (5s)";
                    }
                    throw new Exception("Not existing combination");
                case Field.Fire:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area might (3x, 20s)";
                        case Finisher.Leap:
                            return "Fire armor";
                        case Finisher.Projectile:
                            return "Burning (1s)";
                        case Finisher.Whirl:
                            return "Burning Bolts (5s)";
                    }
                    throw new Exception("Not existing combination");
                case Field.Ice:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area frost armor";
                        case Finisher.Leap:
                            return "Frost armor";
                        case Finisher.Projectile:
                            return "Chilled";
                        case Finisher.Whirl:
                            return "Chilling Bolts";
                    }
                    throw new Exception("Not existing combination");
                case Field.Light:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area retaliation (3s)";
                        case Finisher.Leap:
                            return "Retaliation (5s)";
                        case Finisher.Projectile:
                            return "Remove Condition";
                        case Finisher.Whirl:
                            return "Cleansing bolts";
                    }
                    throw new Exception("Not existing combination");
                case Field.Lightning:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area swiftness (10s)";
                        case Finisher.Leap:
                            return "Dazing strike";
                        case Finisher.Projectile:
                            return "Vulnerability";
                        case Finisher.Whirl:
                            return "Brutal bolts (vulnerability)";
                    }
                    throw new Exception("Not existing combination");
                case Field.Poison:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area weakness (5s)";
                        case Finisher.Leap:
                            return "Weakness (8s)";
                        case Finisher.Projectile:
                            return "Poison (2s)";
                        case Finisher.Whirl:
                            return "Poison bolts";
                    }
                    throw new Exception("Not existing combination");
                case Field.Smoke:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area stealth (5s)";
                        case Finisher.Leap:
                            return "Stealth (8s)";
                        case Finisher.Projectile:
                            return "Blindness";
                        case Finisher.Whirl:
                            return "Blinding bolts";
                    }
                    throw new Exception("Not existing combination");
                case Field.Water:
                    switch (finisher)
                    {
                        case Finisher.Blast:
                            return "Area healing";
                        case Finisher.Leap:
                            return "Healing";
                        case Finisher.Projectile:
                            return "Regeneration";
                        case Finisher.Whirl:
                            return "Healing bolts";
                    }
                    throw new Exception("Not existing combination");
            }
            throw new Exception("Not existing combination");
        }
    }
}
