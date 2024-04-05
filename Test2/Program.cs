using System;
using System.Threading.Channels;

namespace Test 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HeroAction heroAction = new HeroAction();
            heroAction.Move();

            ((IAction)heroAction).Move();

            IAction heroAction2 = new HeroAction();
            heroAction2.Move();
        }
        
        interface IAction
        {
            void Move();
        }

        class BaseAction : IAction
        {
            public virtual void Move() => Console.WriteLine("Move in BaseAction");
            
        }

        class HeroAction: BaseAction, IAction
        {
            public override void Move() => Console.WriteLine("Move in HeroAction");
        }

    }

    

   
}