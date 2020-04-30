using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class viewSwitch : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject VRCam;
    // Start is called before the first frame update
    private bool enabled = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Submit"))
        {
            enabled = !enabled;
            if (!enabled)
            {
                Canvas.SetActive(false);
                VRCam.SetActive(true);
                Cursor.visible = false;
            }
            if (enabled)
            {
                Canvas.SetActive(true);
                VRCam.SetActive(false);
                Cursor.visible = true;
            }
        }
    }
}
