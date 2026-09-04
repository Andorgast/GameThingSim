using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class NavigationCode : MonoBehaviour
{
    [SerializeField] private GameObject currentArea;
    public void ChangeArea(GameObject areaToSwapTo)
    {
        currentArea.SetActive(false);
        areaToSwapTo.SetActive(true);
    }
}
