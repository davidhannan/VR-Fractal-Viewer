using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class genTuner : MonoBehaviour
{
    public Dropdown dropdown;
    public Generator Koch;
    public Generator Brain;
    public Generator Hilbert;
    public Generator Binary;

    public int genNum;
    public GameObject gen;

    public GameObject fractals;

    private Slider x, y, z;
    private Text textX, textY, textZ;
    private Fractal fracKoch, fracBrain, fracHilbert, fracBinary;
    // Start is called before the first frame update
    void Start()
    {
        gen = gen.transform.GetChild(1).gameObject;
        x = gen.transform.GetChild(0).gameObject.GetComponent<Slider>();
        y = gen.transform.GetChild(1).gameObject.GetComponent<Slider>();
        z = gen.transform.GetChild(2).gameObject.GetComponent<Slider>();

        textX = x.transform.GetChild(3).gameObject.GetComponent<Text>();
        textY = y.transform.GetChild(3).gameObject.GetComponent<Text>();
        textZ = z.transform.GetChild(3).gameObject.GetComponent<Text>();

        fractals = GameObject.Find("previewFractals");

        fracKoch = fractals.transform.GetChild(0).gameObject.GetComponent<Fractal>();
        fracBrain = fractals.transform.GetChild(1).gameObject.GetComponent<Fractal>();
        fracHilbert = fractals.transform.GetChild(2).gameObject.GetComponent<Fractal>();
        fracBinary = fractals.transform.GetChild(3).gameObject.GetComponent<Fractal>();
        getXYZ();
    }

    public void getXYZ()
    {
        int val = dropdown.value;

        if (val == 0)
        {
            x.value = Koch.generators[genNum][0];
            y.value = Koch.generators[genNum][1];
            z.value = Koch.generators[genNum][2];
        }
        else if (val == 1)
        {
            x.value = Brain.generators[genNum][0];
            y.value = Brain.generators[genNum][1];
            z.value = Brain.generators[genNum][2];
        }
        else if (val == 2)
        {
            x.value = Hilbert.generators[genNum][0];
            y.value = Hilbert.generators[genNum][1];
            z.value = Hilbert.generators[genNum][2];

        }
        else if (val == 3)
        {
            x.value = Binary.generators[genNum][0];
            y.value = Binary.generators[genNum][1];
            z.value = Binary.generators[genNum][2];
        }
    }

    public void setXYZ()
    {
        //getXYZ();

        textX.text = "X: " + x.value.ToString("N2");
        textY.text = "Y: " + y.value.ToString("N2");
        textZ.text = "Z: " + z.value.ToString("N2");

        int val = dropdown.value;

        if (val == 0)
        {
            Koch.generators[genNum][0] = x.value;
            Koch.generators[genNum][1] = y.value;
            Koch.generators[genNum][2] = z.value;
            fracKoch.change();
        }
        else if (val == 1)
        {
            Brain.generators[genNum][0] = x.value;
            Brain.generators[genNum][1] = y.value;
            Brain.generators[genNum][2] = z.value;
            fracBrain.change();
        }
        else if (val == 2)
        {
            Hilbert.generators[genNum][0] = x.value;
            Hilbert.generators[genNum][1] = y.value;
            Hilbert.generators[genNum][2] = z.value;
            fracHilbert.change();

        }
        else if (val == 3)
        {
            Binary.generators[genNum][0] = x.value;
            Binary.generators[genNum][1] = y.value;
            Binary.generators[genNum][2] = z.value;
            fracBinary.change();
        }
    }

    // Update is called once per frame
    void Update()
    {
        setXYZ();
        if (Input.GetButtonDown("Cancel")) SceneManager.LoadScene("menu");
    }
}
