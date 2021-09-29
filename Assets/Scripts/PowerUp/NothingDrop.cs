using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NothingDrop : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject);
    }
}
