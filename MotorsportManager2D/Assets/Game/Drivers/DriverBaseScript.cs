using UnityEngine;

[CreateAssetMenu(fileName = "NewDriver", menuName = "Motorsport Manager/Driver")]
public class DriverBaseScript : ScriptableObject
{
    [Header("Basic Information")]
    public string driverName;
    public string nationality;
    public string raceClass;

    [Header("Ratings")]
    [Range(1, 100)] public int rating = 50;
    [Range(16, 60)] public int age = 20;
    [Range(1, 100)] public int potential = 50;
    [Range(0f, 2f)] public float developmentRate = 1f;

    [Header("Driving Skills")]
    [Range(1, 100)] public int speed = 50;
    [Range(1, 100)] public int consistency = 50;
    [Range(1, 100)] public int racecraft = 50;

    [Header("Contract")]
    public int salary;

    //[Header("Visuals")]
    //public Sprite portrait;
}