using UnityEngine;
using UnityEngine.UIElements;

public class main : MonoBehaviour
{
    UIDocument mainUI;
    Label temperatureValue;
    Label humidityValue;
    Label illuminanceValue;
    ProgressBar temperatureLevel;
    ProgressBar humidityLevel;
    ProgressBar illuminanceLevel;


    void Start()
    {
        mainUI = GetComponent<UIDocument>();
        temperatureValue = mainUI.rootVisualElement.Q<Label>("TemperatureValue");
        humidityValue = mainUI.rootVisualElement.Q<Label>("HumidityValue");
        illuminanceValue = mainUI.rootVisualElement.Q<Label>("IlluminanceValue");
        temperatureLevel = mainUI.rootVisualElement.Q<ProgressBar>("TemperatureLevel");
        humidityLevel = mainUI.rootVisualElement.Q<ProgressBar>("HumidityLevel");
        illuminanceLevel = mainUI.rootVisualElement.Q<ProgressBar>("IlluminanceLevel");

        temperatureLevel.lowValue = 0;
        temperatureLevel.highValue = 50;

        humidityLevel.lowValue = 0;
        humidityLevel.highValue = 100;

        illuminanceLevel.lowValue = 0;
        illuminanceLevel.highValue = 1023;
    }

    void Update()
    {
        if (Connect_Arduino.Instance == null)
        {
            return;
        }
        temperatureValue.text = Connect_Arduino.Instance.temperature.ToString();
        temperatureLevel.value = Connect_Arduino.Instance.temperature;
        humidityValue.text = Connect_Arduino.Instance.humidity.ToString();
        humidityLevel.value = Connect_Arduino.Instance.humidity;
        illuminanceValue.text = Connect_Arduino.Instance.illuminance.ToString();
        illuminanceLevel.value = Connect_Arduino.Instance.illuminance;

    }
}
