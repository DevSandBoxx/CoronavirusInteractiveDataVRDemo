using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataPerContinent : MonoBehaviour
{
        public int totalCases { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }

        private List<DataPerCountryInContinent> dataPerCountries;
        public DataPerContinent(int totalCases, int deaths, int recovered, List<DataPerCountryInContinent> dataPerCountries)
        {
            this.totalCases = totalCases;
            this.deaths = deaths;
            this.recovered = recovered;
            this.dataPerCountries = dataPerCountries;
        }
}
