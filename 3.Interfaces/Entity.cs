using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace _3.Interfaces
{
    public interface IDamagable
    {
        bool TakeTamage(int dodamage);
        int ArmorClass { get; set; }

    }

    public interface IDamage : IDamagable
    {
        int HitModifier { get; set; }
        void DoDamage(IDamagable other);
    }
    public class Entity : IDamagable
    {
        private int health; //Field
        private string name; //Field
        string Name; // Property
        int Health; //Property

        public int ArmorClass { get; set; }

        public bool TakeTamage(int dodamage)
        {
            throw new NotImplementedException();
        }
    }
    public class Assassin : Entity
    {
        
    }

    public class Ninja : Entity
    {
    }

    public class Nord : Entity
    {

    }

    public class Soldier : Entity
    {

    }

    public class Robot : Entity
    {
        public int HitModifier
        {
            get { return ArmorClass; }

            set { ArmorClass = value; }
        }

        public void DoDamage(IDamagable other)
        {

        }
    }

    public class Witcher : Entity, IDamage
    {
        public int HitModifier
        {
            get { return ArmorClass; }

            set { ArmorClass = value; }
        }

        public void DoDamage(IDamagable other)
        {
            throw new NotImplementedException();
        }
    }

    public class Spartan : Entity, IDamage
    {
        public int HitModifier
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void DoDamage(IDamagable other)
        {
            throw new NotImplementedException();
        }
    }
}
