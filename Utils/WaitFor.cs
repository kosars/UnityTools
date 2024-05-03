using UnityEngine;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
public static class WaitFor
{
    public static readonly WaitForEndOfFrame EndOfFrame = new();
    public static readonly WaitForFixedUpdate FixedUpdate = new();

    private static readonly Dictionary<float, WaitForSeconds> SecondsDictionary = new(100);

    public static WaitForSeconds Seconds(float seconds){
        if (!SecondsDictionary.ContainsKey(seconds))
            SecondsDictionary.Add(seconds, new WaitForSeconds(seconds));
        return SecondsDictionary[seconds];
    }
}