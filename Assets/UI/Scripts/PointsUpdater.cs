using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointsUpdater : MonoBehaviour
{
    [SerializeField] private Text pointsText;
    private void OnEnable()
    {
        pointsText.text = DataController.GetValue<int>(Constants.POINTS).ToString();
    }
}
