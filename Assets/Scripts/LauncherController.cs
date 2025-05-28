using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class LauncherController : MonoBehaviour
{
    public Slider slide;

    void Update()
    {
        StartCoroutine(HandleInputs(slide.value, 1f, 0f));
    }

    void Handleinputs(float value, float maxValue, float minValue)
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) && value >= minValue)
        {
            value -= 0.1f;
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) && slide.value <= maxValue)
        {
            
        }
    }

    private IEnumerator HandleInputs(float value, float maxValue, float minValue)
    {
        if (Input.GetKey(KeyCode.DownArrow) && slide.value >= minValue)
        {
            yield return new WaitForSeconds(0.1f);
            slide.value -= 0.1f;
            yield return new WaitForSeconds(0.1f);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow) && !Input.GetKey(KeyCode.DownArrow) && slide.value <= maxValue)
        {
            while (slide.value <= slide.maxValue)
            {
                slide.value += 0.1f;

                if (Input.GetKey(KeyCode.DownArrow))
                {
                    break;
                }

                yield return new WaitForSeconds(0.002f);
            }
        }
    }
}
