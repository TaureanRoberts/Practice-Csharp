using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.StatePattern
{
    public interface IContext
    {
        IState CurrentState { get; set; }
        void UpdateContent();
        void ChangeState();
    }

    public interface IState
    {
        void OnEnter(IContext other);
        void UpdateState(IContext other);
        void OnExit(IContext other);
    }

    public class GameStartState : IState, IContext
    {
        public void OnEnter(IContext other)
        {

        }

        public void UpdateState(IContext other)
        {
            throw new NotImplementedException();
        }

        public void OnExit(IContext other)
        {
            throw new NotImplementedException();
        }

        public IState CurrentState { get; set; }
        public void UpdateContent()
        {
            throw new NotImplementedException();
        }

        public void ChangeState()
        {
            throw new NotImplementedException();
        }
    }

    public class GameRunningState : IState, IContext
    {
        public void OnEnter(IContext other)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(IContext other)
        {
            throw new NotImplementedException();
        }

        public void OnExit(IContext other)
        {
            throw new NotImplementedException();
        }

        public IState CurrentState { get; set; }
        public void UpdateContent()
        {
            throw new NotImplementedException();
        }

        public void ChangeState()
        {
            throw new NotImplementedException();
        }
    }

    public class GameExitState : IState, IContext
    {
        public void OnEnter(IContext other)
        {
            throw new NotImplementedException();
        }

        public void UpdateState(IContext other)
        {
            throw new NotImplementedException();
        }

        public void OnExit(IContext other)
        {
            throw new NotImplementedException();
        }

        public IState CurrentState { get; set; }
        public void UpdateContent()
        {
            throw new NotImplementedException();
        }

        public void ChangeState()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
