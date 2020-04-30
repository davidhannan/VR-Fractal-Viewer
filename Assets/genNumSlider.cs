using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class genNumSlider : MonoBehaviour
{
    public Dropdown dropdown;
    public Generator Koch;
    public Generator Brain;
    public Generator Hilbert;
    public Generator Binary;

    public Fractal fracKoch;
    public Fractal fracBrain;
    public Fractal fracHilbert;
    public Fractal fracBinary;

    public Slider maxIter, width, noise;
    public Text iter, wid, nse;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void sliderChange(System.Single newVal)
    {
        int val = dropdown.value;

        if (val == 0)
        {
            changeGen(Koch, newVal);
            fracKoch.generator = Koch;
            fracKoch.change();
        }
        else if (val == 1)
        {
            changeGen(Brain, newVal);
            fracBrain.generator = Brain;
            fracBrain.change();
        }
        else if (val == 2)
        {
            changeGen(Hilbert, newVal);
            fracHilbert.generator = Hilbert;
            fracHilbert.change();
        }
        else if (val == 3)
        {
            changeGen(Binary, newVal);
            fracBinary.generator = Binary;
            fracBinary.change();
        }
       

    }

    public void iterChange(System.Single newVal)
    {
        int val = dropdown.value;
        iter.text = "Max Iter.: " + newVal.ToString("N2");
        if (val == 0)
        {
            Koch.maxIteration = (int)newVal;
            fracKoch.change();
        }
        else if (val == 1)
        {
            Brain.maxIteration = (int)newVal;
            fracBrain.change();
        }
        else if (val == 2)
        {
            Hilbert.maxIteration = (int)newVal;
            fracHilbert.change();
        }
        else if (val == 3)
        {
            Binary.maxIteration = (int)newVal;
            fracBinary.change();
        }
    }

    public void widthChange(System.Single newVal)
    {
        int val = dropdown.value;
        wid.text = "Width: " + newVal.ToString("N2");
        if (val == 0)
        {
            Koch.width = newVal;
            fracKoch.change();
        }
        else if (val == 1)
        {
            Brain.width = newVal;
            fracBrain.change();
        }
        else if (val == 2)
        {
            Hilbert.width = newVal;
            fracHilbert.change();
        }
        else if (val == 3)
        {
            Binary.width = newVal;
            fracBinary.change();
        }
    }

    public void noiseChange(System.Single newVal)
    {
        int val = dropdown.value;
        nse.text = "Noise: " + newVal.ToString("N2");
        if (val == 0)
        {
            Koch.noise = newVal;
            fracKoch.change();
        }
        else if (val == 1)
        {
            Brain.noise = newVal;
            fracBrain.change();
        }
        else if (val == 2)
        {
            Hilbert.noise = newVal;
            fracHilbert.change();
        }
        else if (val == 3)
        {
            Binary.noise = newVal;
            fracBinary.change();
        }
    }

    void changeGen(Generator gen, System.Single newVal)
    {
        gen.genSize = (int)newVal;
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
