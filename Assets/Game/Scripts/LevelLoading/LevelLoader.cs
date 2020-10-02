using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

[RequireComponent(typeof(LevelStatusUpdater))]
public class LevelLoader : MonoBehaviour
{
    [SerializeField] private SpriteAtlas Paintings;

    private LevelStatusUpdater statusUpdater;

    private int currentLevelNumber;

    private void Awake()
    {
        statusUpdater = GetComponent<LevelStatusUpdater>();
        if (statusUpdater == null)
            statusUpdater = gameObject.AddComponent<LevelStatusUpdater>();
    }

    // Возможно в будущем заменить логику на внешний вызов функции
    private void OnEnable()
    {
        currentLevelNumber = 1;
        LoadLevel();
    }

    private void LoadLevel()
    {
        // Загрузка компонентов уровня
        statusUpdater.LoadLevelData(currentLevelNumber, DataController.GetValue<int>(Constants.LEVEL_PROGRESS + currentLevelNumber), LoadLevelPaintinig());

        LoadLevelPaintinig();
    }

    private Sprite LoadLevelPaintinig()
    {
        return Paintings.GetSprite(Constants.PAINTING + currentLevelNumber);
    }
}
