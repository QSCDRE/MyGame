using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zat : MonoBehaviour
{
    public float fade_speed = 1f;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        Image fade_image = GetComponent<Image>();
        Color color = fade_image.color;

        while(color.a < 1f)
        {
            color.a += fade_speed * Time.deltaTime;
            fade_image.color = color;
            yield return null;
        }
    }
}
