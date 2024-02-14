using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class ControlPanelLocalSelection : MonoBehaviour
{

    public void ChangesLocale(int _localeID)
    {
        StartCoroutine(SetLocale(_localeID));
    }

    IEnumerator SetLocale(int _localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_localeID];
    }
}
