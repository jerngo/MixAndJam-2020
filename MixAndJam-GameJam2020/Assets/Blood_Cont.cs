using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood_Cont : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Update()
    {
        if (this.GetComponent<ParticleSystem>().IsAlive() == false)
        {
            Destroy(this.gameObject);
        }
    }
}
