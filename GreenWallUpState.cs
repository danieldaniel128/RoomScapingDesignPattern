using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assembly_CSharp
{
    public class GreenWallUpState : State
    {
        public GreenWallUpState(Transform camTransform, Transform left, Transform right) : base(camTransform, left, right)
        {
        }
    }
}
