using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Ponte : MonoBehaviour
{
    public List<GameObject> Ponte;
    public Transform SpawnPonte;

    void Start()
    {
        InvokeRepeating("CriarPonte", 0f, 5f);
    }


    void CriarPonte()
    {
        int chance = Random.Range(0, Ponte.Count);
        Instantiate(Ponte[chance], SpawnPonte.position, Ponte[chance].transform.rotation);
        SpawnPonte.position += new Vector3(0, 0, 30);
    }
}
