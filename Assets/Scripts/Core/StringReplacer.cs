using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class StringReplacer
{
    [SerializeField, TextArea(1, 10)] private string original;
    [SerializeField] private string[] varCodes = new string[0];


    public StringReplacer(string original)
    {
        this.original = original;
    }

    public string GetReplacedText(object[] replacingValues)
    {
        if (replacingValues.Length != varCodes.Length)
        {
            Debug.LogError($"{original} - Var codes length of {varCodes.Length} does not match replacing values length of {replacingValues.Length}.");
            return null;
        }
        string updated;
        updated = original;
        for (int i = 0; i < replacingValues.Length; i++)
            updated = updated.Replace(varCodes[i], replacingValues[i].ToString());
        return updated;
    }

    public string GetReplacedText(object replacingValue) => GetReplacedText(new object[1] { replacingValue });

}
