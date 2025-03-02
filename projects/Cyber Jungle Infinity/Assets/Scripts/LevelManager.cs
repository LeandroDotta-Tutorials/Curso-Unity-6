using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private IEnumerator Start() 
    {
        foreach (Horde horde in transform.GetComponentsInChildren<Horde>(true))
        {
            horde.gameObject.SetActive(true);
            yield return new WaitForSeconds(horde.duration);
        }
    }
}
