using UnityEngine;
using UnityEngine.Events;

public class DeliveryPoint : MonoBehaviour
{
    [SerializeField] private LoadType loadType;
    [SerializeField] private Transform loadSlot;

    public bool IsEmpty => loadSlot.childCount == 0;

    public event UnityAction OnLoadDelivered;

    public bool PutLoad(Load load)
    {
        if (!IsEmpty) return false;
        if (load.type != loadType) return false;

        load.transform.SetParent(loadSlot);
        load.transform.localPosition = Vector3.zero;

        OnLoadDelivered?.Invoke();

        return true;
    }
}
