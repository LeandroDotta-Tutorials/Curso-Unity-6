using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class CheatCodes : MonoBehaviour
{
    private Dictionary<Key[], Action> ActionMap;

    private void Start()
    {
        ActionMap = new()
        {
            { new Key[] {Key.LeftCtrl, Key.R } , RestartScene },

        };
    }

    private void Update()
    {
        foreach(var combination in ActionMap)
        {
            if (IsKeyCombinationPressed(combination.Key))
            {
                combination.Value.Invoke();
            }
        }
    }

    private bool IsKeyCombinationPressed(params Key[] keys)
    {
        if (!KeyDown(keys.Last())) return false;

        if (keys.Length == 1) return true;

        return keys
            .Take(keys.Length - 1)
            .All(key => KeyHeld(key));
    }

    private bool KeyDown(Key key) => Keyboard.current[key].wasPressedThisFrame;
    private bool KeyHeld(Key key) => Keyboard.current[key].isPressed;

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
