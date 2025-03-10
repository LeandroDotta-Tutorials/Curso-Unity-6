using System.Collections;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public float endDelay = 15f;
    
    private IEnumerator Start()
    {
        foreach (Horde horde in transform.GetComponentsInChildren<Horde>(true))
        {
            horde.gameObject.SetActive(true);
            yield return new WaitForSeconds(horde.duration);
        }

        yield return new WaitForSeconds(endDelay);
        SendMessage("OnLevelEnd", SendMessageOptions.RequireReceiver);
    }

    private void OnDisable()
    {
        StopAllCoroutines();    
    }
}
