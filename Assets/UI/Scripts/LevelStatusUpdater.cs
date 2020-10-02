using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelStatusUpdater : MonoBehaviour
{
    [SerializeField] private Text levelNumberText;
    [SerializeField] private Image ProgressBar;
    [SerializeField] private SpriteRenderer currentPainting;

    /// <summary>
    ///  Загружает информацию об увроне во View
    /// </summary>
    /// <param name="levelNumber"> номер текущего уровня </param>
    /// <param name="progressPercentage">число от 0 до 100, прогресс </param>
    public void LoadLevelData(int levelNumber, int progressPercentage, Sprite currentPaintingSprite) 
    {
        try 
        {
            LoadProgressdata(progressPercentage);
            LoadCurrentLevelNumber(levelNumber);
            LoadCurrentPaintingSprite(currentPaintingSprite);
        }
        catch(Exception ex)
        {
            Debug.Log("Не доделана загрузка спрайта");
        }

    }

    private void LoadCurrentPaintingSprite(Sprite currentPaintingSprite)
    {
        currentPainting.sprite = currentPaintingSprite;
    }

    private void LoadCurrentLevelNumber(int v)
    {
        levelNumberText.text = v.ToString();
    }

    private void LoadProgressdata(int v)
    {
        ProgressBar.fillAmount = (v / 100.0f);
    }
}
