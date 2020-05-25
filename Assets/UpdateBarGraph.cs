using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateBarGraph : MonoBehaviour
{
    public GameObject[] bars;
    public const float barIncrememnt = 0.1f;
    void Update()
    {
        foreach (KeyValuePair<string, DataPerContinent> data in RetrieveData.getAllData())
        {
            foreach(GameObject bar in bars){
                if (bar.name == data.Key)
                {
                    bar.transform.localScale = new Vector3(bar.transform.localScale.x, bar.transform.localScale.y + barIncrememnt, bar.transform.localScale.z);
                }
            }
        }
    }
    
}
