using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPulse : MonoBehaviour
{
    private float pulse_speed = 2.5f;
    private float index = 0f;
    private float base_scale;
    // Start is called before the first frame update
    void Start()
    {
        base_scale = this.transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        index += Time.deltaTime;
        this.transform.localScale = new Vector3(base_scale + 0.07f * Mathf.Abs(Mathf.Sin(pulse_speed * index)), base_scale + 0.07f * Mathf.Abs(Mathf.Sin(pulse_speed * index)), 1f);
    }
}
