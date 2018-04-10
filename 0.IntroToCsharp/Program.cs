using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0.IntroToCsharp
{
    public abstract class Item //Abstract
    {
        protected string name;
        protected int Id;
    }
    public abstract class Weapon : Item //Abstract
    {
        public int power;
        public virtual void DoDamage(int amount)
        {
            
        }
    }
    public abstract class Potion : Item //Abstract
    {
        protected int Power;
        protected virtual void Consume()
        {

        } 
    }
    public class Elixir : Potion //Concrete
    {

    }
    public class Ether : Potion //Concrete
    {

    }
    public class BusterSword : Weapon //Concrete
    {
        public void Swing()
        {

        }
    }
    public class GatlingGun : Weapon //Concrete
    {
        public void Shoot()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
