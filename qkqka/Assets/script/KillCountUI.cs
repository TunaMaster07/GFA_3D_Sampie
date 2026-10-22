using UnityEngine;
using TMPro;

public class KillCountUI : MonoBehaviour
{
    private const int V = 0;
    public TMP_Text label;
    void Start()
    {
        Health.KillCount = 0;   // Play 마다 0 부터
    }

    void Update()
    {
        label.text = "KILL " + Health.KillCount;
    }
}
