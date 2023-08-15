using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadeinout : MonoBehaviour
{
    
    float time = 0f;
    float F_time = 2f;
    
    
    public Image Panel;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    public void Fade()
    {
        StartCoroutine(fadeinout());
    }

 
    public IEnumerator fadeinout()
    {

        Panel.gameObject.SetActive(true);
        Color alpha = Panel.color;
        while (alpha.a < 1f)
        {
           
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(0, 1, time);
            Panel.color = alpha;
            yield return null;
        }
        time = 0f;
        Debug.Log("fadein");
        yield return new WaitForSeconds(2f);
        Debug.Log("fadeout");
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            Panel.color = alpha;
            yield return null;
        }
        Panel.gameObject.SetActive(false);
        yield return null;
       
    }
}
