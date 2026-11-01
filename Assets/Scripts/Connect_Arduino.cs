using UnityEngine;
using System.IO.Ports;

public class Connect_Arduino : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM6", 9600);

    public static Connect_Arduino Instance;

    [Header("Sensor Data")]
    public string rawData = "";
    public float temperature = 0;
    public float humidity = 0;
    public float illuminance = 0;

    void OnEnable()
    {
        Instance = this;
    }
    
    void Start()
    {
        try
        {
            sp.Open();
            sp.ReadTimeout = 50;
            Debug.Log("Serial Open");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Serial Open Fail: " + e.Message);
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (sp != null && sp.IsOpen)
        {
            try
            {
                if (sp.BytesToRead > 0)
                {
                    rawData = sp.ReadLine();
                    Debug.Log(rawData);

                    // Parse data
                    string cleanData = rawData.Trim();
                    string[] splitData = cleanData.Split(',');


                    float.TryParse(splitData[0], out temperature);
                    float.TryParse(splitData[1], out humidity);
                    float.TryParse(splitData[2], out illuminance);

                    Debug.Log($"온도: {temperature}, 습도: {humidity}, 조도: {illuminance}");

                }
            }
            catch (System.TimeoutException)
            {

            }
            catch(System.Exception e)
            {
                Debug.LogWarning("Connection Exception: " + e.Message);
            }
        }
    }

    void OnApplicationQuit()
    {
        sp.Close();
    }
}
