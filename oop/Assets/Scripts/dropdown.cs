using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class dropdown : MonoBehaviour
{
    private TMP_Dropdown dropdowwn;
    private List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>(); 

    public void GetDropdawnValue()
    {
        int pickedEntryIndex = dropdowwn.value;
        string selectedOption = dropdowwn.options[pickedEntryIndex].text;
        Debug.Log(pickedEntryIndex);
    }
    private void AddNewPlayer()
    {
        dropdowwn.options.Add(new TMP_Dropdown.OptionData("soldado", null));
        dropdowwn.AddOptions(options);
        dropdowwn.RefreshShownValue();
    }
    
}
