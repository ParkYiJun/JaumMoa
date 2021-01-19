using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingPlayer : MonoBehaviour
{
    private void OnEnable()
    {
        transform.DetachChildren();
    }
}
