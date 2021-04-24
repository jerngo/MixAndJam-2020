using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableButton : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject button1;
    public GameObject button2;

    public void enableTarget() {
        button1.SetActive(true);
        button2.SetActive(true);

    }
}
