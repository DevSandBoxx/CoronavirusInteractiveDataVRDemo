using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetrieveData : MonoBehaviour
{
    private static Dictionary<string, DataPerContinent> allData;
    private string[] continents = { "North America", "South America", "Africa", "Antarctica", "Europe", "Asia", "Oceania" };
    void Start()
    {
        allData = new Dictionary<string, DataPerContinent>()
        {
            {"North America", null},
            {"South America", null},
            {"Antarctica", null},
            {"Europe", null},
            {"Asia", null},
            {"Oceania", null},
        };
    }
    void Update()
    {
        foreach(KeyValuePair<string, DataPerContinent> data in allData)
        {
            //do something
        }
    }

    public static Dictionary<string, DataPerContinent> getAllData()
    {
        return allData;
    }
}
