using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

namespace Leaning
{
    public class RotateCube : MonoBehaviour
    {

        void Start()
        {

            transform.DORotate(new Vector3(0f, 0f, -360f), 1.0f, RotateMode.FastBeyond360).SetLoops(-1)
                .SetEase(Ease.Linear);

        }

        // Update is called once per frame
        void Update()
        {
            transform.RotateAround(Vector3.zero, Vector3.up, 0.5f);
        
        }
    }
    
}
