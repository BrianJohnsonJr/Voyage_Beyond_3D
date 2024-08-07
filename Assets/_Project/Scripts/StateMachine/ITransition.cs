using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public interface ITransition
    {
        IState To { get; }
        IPredicate Condition { get; }
    }

    public class Transition : ITransition
    {
        public IState To { get; }

        public IPredicate Condition { get; }

        public Transition(IState to, IPredicate condition){
            To = to;
            Condition = condition;
        }
    }
}
