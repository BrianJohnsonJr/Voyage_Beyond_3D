using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Voyage_Beyond_3D
{
    public interface IState
    {
        void OnEnter();
        void update();
        void FixedUpdate();
        void OnExit();
        void Update();
    }

}
