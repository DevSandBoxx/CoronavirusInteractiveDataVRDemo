using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPerCountryInContinent : MonoBehaviour
{
    public int totalCases { get; set; }
    public DataPerCountryInContinent(int totalCases)
    {
         this.totalCases = totalCases;
    }
}
