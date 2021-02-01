using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CameraMoving : MonoBehaviour
{
    float clipingX;
    float clipingY;
    Vector3 clipingVec;

    float movingGap = 0.01f;

    float vecX;
    float vecY;
    Vector3 vecToMove;
    Vector3 unitVec;

    private void Start()
    {
        clipingVec = new Vector3(5f, 1f, 0f);
        vecToMove = new Vector3(0f, 0f, 0f);
        VecInit();
    }

    private void Update()
    {
        if (Mathf.Abs(vecToMove.magnitude) >= movingGap)
        {
            transform.Translate(unitVec);
            adjustVecToMove();
        }
    }

    private void VecInit()
    {
        adjustVecToMove();
        unitVec = vecToMove / 100;
    }

    private void adjustVecToMove()
    {
        vecToMove = clipingVec - transform.position;
        vecToMove.z = 0f;
    }
}
