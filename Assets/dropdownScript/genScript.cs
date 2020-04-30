using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class genScript : MonoBehaviour
{
    public Dropdown dropdown;
    public Fractal Koch;
    public Fractal Brain;
    public Fractal Hilbert;
    public Fractal Binary;

    public Tracer KochTracer;
    public Tracer BrainTracer;
    public Tracer HilbertTracer;
    public Tracer BinaryTracer;

    public TraceReplicator KochTraceRepl;
    public TraceReplicator BrainTraceRepl;
    public TraceReplicator HilbertTraceRepl;
    public TraceReplicator BinaryTraceRepl;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void startChange()
    {
        
            int val = dropdown.value;
            
            if (val == 0)
            {
                changeFractal(Koch, KochTracer, KochTraceRepl);
            }else if(val == 1)
            {
                changeFractal(Brain, BrainTracer, BrainTraceRepl);
            }else if(val == 2)
            {
                changeFractal(Hilbert, HilbertTracer, HilbertTraceRepl);
            }else if (val == 3)
            {
                changeFractal(Binary, HilbertTracer, HilbertTraceRepl);
            }
        


    }

    public void changeFractal(Fractal name, Tracer trace, TraceReplicator repl)
    {
        Koch.transform.gameObject.SetActive(false);
        Brain.transform.gameObject.SetActive(false);
        Hilbert.transform.gameObject.SetActive(false);
        Binary.transform.gameObject.SetActive(false);

        KochTracer.transform.gameObject.SetActive(false);
        BrainTracer.transform.gameObject.SetActive(false);
        HilbertTracer.transform.gameObject.SetActive(false);
        BinaryTracer.transform.gameObject.SetActive(false);

        KochTraceRepl.transform.gameObject.SetActive(false);
        BrainTraceRepl.transform.gameObject.SetActive(false);
        HilbertTraceRepl.transform.gameObject.SetActive(false);
        BinaryTraceRepl.transform.gameObject.SetActive(false);

        name.transform.gameObject.SetActive(true);
        trace.transform.gameObject.SetActive(true);
        repl.transform.gameObject.SetActive(true);

        //Instantiate(fractal);
        //SceneManager.LoadScene("customizeFractal");
        //fractal.Start();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
