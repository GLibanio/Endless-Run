using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruir_Ponte : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
